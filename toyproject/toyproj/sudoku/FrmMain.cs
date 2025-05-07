using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace sudoku
{
    public partial class FrmMain : Form
    {
        Button[,] buttons = new Button[9, 9];
        Button[,] answerButtons = new Button[9, 9];
        int[,] board = new int[9, 9];   // 정답 보드
        int[,] puzzle = new int[9, 9];  // 퍼즐 보드
        int[,] hintMap = new int[9, 9]; // 0: 사용자 입력 가능, 1: 힌트로 고정
        Random rand = new Random();
        bool isAnswerShown = false;
        int checkAnswerCount = 0;
        int newGameCount = 0;
        int clearedGameCount = 0;
        string saveFilePath = "save.txt";
        Timer hintTimer = new Timer();
        Timer gameTimer = new Timer();
        int elapsedSeconds = 0;

        public FrmMain()
        {
            InitializeComponent();
            CreateGrid();
            StartNewGame();

            // 힌트 타이머 설정
            hintTimer.Interval = 3000; // 3초
            hintTimer.Tick += HintTimer_Tick;

            // 진행시간 타이머 설정
            gameTimer.Interval = 1000; // 1초
            gameTimer.Tick += GameTimer_Tick;
        }

        void CreateGrid()
        {
            int size = 40;
            int spacing = 40;

            int totalWidth = size * 9 * 2 + spacing;
            int startX = (this.ClientSize.Width - totalWidth) / 2;
            int startY = (this.ClientSize.Height - size * 9) / 2 - 50;

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    Button btnPuzzle = new Button();
                    btnPuzzle.Width = size;
                    btnPuzzle.Height = size;
                    btnPuzzle.Left = startX + col * size;
                    btnPuzzle.Top = startY + row * size;
                    btnPuzzle.Font = new Font("Arial", 14);
                    btnPuzzle.Tag = (row, col);
                    btnPuzzle.Click += Btn_Click;
                    btnPuzzle.MouseDown += Btn_MouseDown;
                    this.Controls.Add(btnPuzzle);
                    buttons[row, col] = btnPuzzle;

                    Button btnAnswer = new Button();
                    btnAnswer.Width = size;
                    btnAnswer.Height = size;
                    btnAnswer.Left = startX + size * 9 + spacing + col * size;
                    btnAnswer.Top = startY + row * size;
                    btnAnswer.Font = new Font("Arial", 14);
                    btnAnswer.Enabled = false;
                    btnAnswer.BackColor = Color.LightGray;
                    btnAnswer.FlatStyle = FlatStyle.Flat;
                    btnAnswer.FlatAppearance.BorderSize = 1;
                    btnAnswer.FlatAppearance.BorderColor = Color.DarkGray;
                    this.Controls.Add(btnAnswer);
                    answerButtons[row, col] = btnAnswer;
                }
            }
        }

        void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            var (row, col) = ((int, int))btn.Tag;

            if (puzzle[row, col] == 0 || hintMap[row, col] == 0)
            {
                int current = string.IsNullOrEmpty(btn.Text) ? 0 : int.Parse(btn.Text);
                int next = (current % 9) + 1;
                btn.Text = next.ToString();
            }
        }

        void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button btn = sender as Button;
                var (row, col) = ((int, int))btn.Tag;

                if (puzzle[row, col] == 0 || hintMap[row, col] == 0)
                {
                    int current = string.IsNullOrEmpty(btn.Text) ? 10 : int.Parse(btn.Text);
                    int next = (current == 1) ? 9 : (current - 1);
                    btn.Text = next.ToString();
                    puzzle[row, col] = next;
                    hintMap[row, col] = 0;
                }
            }
        }


        void StartNewGame()
        {
            Array.Clear(board, 0, board.Length);
            Array.Clear(hintMap, 0, hintMap.Length);
            FillBoard(board);
            Array.Copy(board, puzzle, board.Length);
            RemoveNumbers(puzzle, 40);
            UpdateHintMap();
            UpdateGrid();
            elapsedSeconds = 0; // ⬅️ 시간 초기화
            gameTimer.Start();
        }

        void UpdateHintMap()
        {
            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    hintMap[r, c] = puzzle[r, c] == 0 ? 0 : 1;
                }
            }
        }

        void UpdateGrid()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    int val = puzzle[row, col];
                    buttons[row, col].Text = val == 0 ? "" : val.ToString();

                    if (hintMap[row, col] == 0)
                    {
                        buttons[row, col].Enabled = true;
                        buttons[row, col].BackColor = Color.White;
                        buttons[row, col].ForeColor = Color.Black;
                    }
                    else
                    {
                        buttons[row, col].Enabled = false;
                        buttons[row, col].BackColor = Color.LightGray;
                        buttons[row, col].ForeColor = Color.DarkBlue;
                    }
                }
            }
        }

        bool FillBoard(int[,] board, int row = 0, int col = 0)
        {
            if (row == 9) return true;
            if (col == 9) return FillBoard(board, row + 1, 0);

            var numbers = Enumerable.Range(1, 9).OrderBy(n => rand.Next()).ToList();
            foreach (int num in numbers)
            {
                if (IsValid(board, row, col, num))
                {
                    board[row, col] = num;
                    if (FillBoard(board, row, col + 1))
                        return true;
                    board[row, col] = 0;
                }
            }
            return false;
        }

        bool IsValid(int[,] board, int row, int col, int num)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[row, i] == num || board[i, col] == num)
                    return false;
            }

            int startRow = row / 3 * 3;
            int startCol = col / 3 * 3;
            for (int i = startRow; i < startRow + 3; i++)
                for (int j = startCol; j < startCol + 3; j++)
                    if (board[i, j] == num)
                        return false;

            return true;
        }

        void RemoveNumbers(int[,] puzzle, int removeCount)
        {
            int removed = 0;
            while (removed < removeCount)
            {
                int row = rand.Next(9);
                int col = rand.Next(9);
                if (puzzle[row, col] != 0)
                {
                    puzzle[row, col] = 0;
                    removed++;
                }
            }
        }

        void ShowAnswer()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    answerButtons[row, col].Text = board[row, col].ToString();

                    if (hintMap[row, col] == 0)  // 사용자가 입력할 수 있는 칸
                    {
                        answerButtons[row, col].BackColor = Color.LightBlue;
                        answerButtons[row, col].ForeColor = Color.Black;
                    }
                    else
                    {
                        answerButtons[row, col].BackColor = Color.LightGray;
                        answerButtons[row, col].ForeColor = Color.DarkBlue;
                    }
                }
            }
        }


        void HideAnswer()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    answerButtons[row, col].Text = "";
                    answerButtons[row, col].Enabled = false;
                    answerButtons[row, col].BackColor = Color.LightGray;
                    answerButtons[row, col].ForeColor = Color.DarkGray;
                }
            }
        }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            if (!isAnswerShown)
            {
                ShowAnswer();
                isAnswerShown = true;
                ((Button)sender).Text = "힌트 숨기기";
            }
            else
            {
                HideAnswer();
                isAnswerShown = false;
                ((Button)sender).Text = "힌트 확인";
            }
        }

        bool IsCorrect()
        {
            for (int row = 0; row < 9; row++)
                for (int col = 0; col < 9; col++)
                {
                    int input = string.IsNullOrEmpty(buttons[row, col].Text) ? 0 : int.Parse(buttons[row, col].Text);
                    if (input != board[row, col])
                        return false;
                }
            return true;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (IsCorrect())
            {
                MessageBox.Show("정답입니다!", "정답 확인!");
                lblClearedGames.Text = $"완료게임 수 : {clearedGameCount}";
            }
            else
            {
                MessageBox.Show("틀렸습니다. 다시 풀어보세요~", "정답 확인!");
            }
            checkAnswerCount++;
            lblCheckCount.Text = $"정답확인 수 : {checkAnswerCount}";
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 새로 시작하시겠습니까?", "새 게임 시작", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                StartNewGame();
                HideAnswer();
                isAnswerShown = false;
                BtnAnswer.Text = "힌트 확인";
                newGameCount++;
                lblNewGame.Text = $"게임시작 수 : {newGameCount}";
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("저장하시겠습니까?", "게임 저장", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (StreamWriter sw = new StreamWriter(saveFilePath))
                {
                    for (int r = 0; r < 9; r++)
                        sw.WriteLine(string.Join(",", Enumerable.Range(0, 9).Select(c => string.IsNullOrEmpty(buttons[r, c].Text) ? "0" : buttons[r, c].Text)));

                    for (int r = 0; r < 9; r++)
                        sw.WriteLine(string.Join(",", Enumerable.Range(0, 9).Select(c => hintMap[r, c])));

                    for (int r = 0; r < 9; r++)
                        sw.WriteLine(string.Join(",", Enumerable.Range(0, 9).Select(c => board[r, c])));

                    sw.WriteLine(checkAnswerCount);
                    sw.WriteLine(newGameCount);
                    sw.WriteLine(elapsedSeconds); // 시간 저장
                }

                MessageBox.Show("저장 완료!", "게임 저장");
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("불러오시겠습니까?", "게임 불러오기", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!File.Exists(saveFilePath))
                {
                    MessageBox.Show("저장된 파일이 없습니다.");
                    return;
                }

                using (StreamReader sr = new StreamReader(saveFilePath))
                {
                    for (int r = 0; r < 9; r++)
                    {
                        var vals = sr.ReadLine().Split(',').Select(int.Parse).ToArray();
                        for (int c = 0; c < 9; c++)
                        {
                            puzzle[r, c] = vals[c];
                            buttons[r, c].Text = vals[c] == 0 ? "" : vals[c].ToString();
                        }
                    }

                    for (int r = 0; r < 9; r++)
                    {
                        var hints = sr.ReadLine().Split(',').Select(int.Parse).ToArray();
                        for (int c = 0; c < 9; c++) hintMap[r, c] = hints[c];
                    }

                    for (int r = 0; r < 9; r++)
                    {
                        var ans = sr.ReadLine().Split(',').Select(int.Parse).ToArray();
                        for (int c = 0; c < 9; c++) board[r, c] = ans[c];
                    }

                    checkAnswerCount = int.Parse(sr.ReadLine());
                    newGameCount = int.Parse(sr.ReadLine());

                    lblCheckCount.Text = $"정답확인 수 : {checkAnswerCount}";
                    lblNewGame.Text = $"게임시작 수 : {newGameCount}";
                    UpdateGrid();
                    elapsedSeconds = int.Parse(sr.ReadLine());
                    TimeSpan time = TimeSpan.FromSeconds(elapsedSeconds);
                    lblTimer.Text = $"진행시간: {time:hh\\:mm\\:ss}";
                }

                MessageBox.Show("불러오기 완료!", "게임 불러오기");
            }
        }
        private void HintTimer_Tick(object sender, EventArgs e)
        {
            HideAnswer();
            isAnswerShown = false;
            BtnAnswer.Text = "힌트 확인";
            hintTimer.Stop(); // 타이머 종료
        }
        private void btnHintSec_Click(object sender, EventArgs e)
        {
            if (!isAnswerShown)
            {
                ShowAnswer();
                hintTimer.Start(); // 3초 후 자동 숨김 시작
            }
    
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            TimeSpan time = TimeSpan.FromSeconds(elapsedSeconds);
            lblTimer.Text = $"진행시간 : {time:hh\\:mm\\:ss}";
        }
        private void FrmMain_Load(object sender, EventArgs e) { }

    }
}
