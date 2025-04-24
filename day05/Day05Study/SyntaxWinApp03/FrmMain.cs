namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // async - await 같이 사용해야함!
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            LblCurrState.Text = "현재상태 : 진행";    // UI 처리
            BtnStart.Text = "진행중";  // UI처리
            BtnStart.Enabled = false; // 못쓰게 함, 버튼 비활성화

            long MaxVal = 100;
            long total = 0;

            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = 100;
            LblCurrState.Text = "현재상태 : 진행";

            long cnt = 0;
            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = 100;

            // -- 응답없음 문제 없는 코드 --
            //for (int i = 0; i < MaxVal + 1; i++)
            //{
            //    PrgProcess.Value = i;
            //    TxtLog.Text = i.ToString();
            //    // UI가 멈추지 않도록 await 사용
            //    await Task.Delay(10);
            //}

            //BtnStart.Text = "시작";
            //BtnStart.Enabled = true; // 버튼 비활성
            //LblCurrState.Text = "현재상태 : 중지";
            // --

            await Task.Run(() =>
            {
                for (int i = 0; i < MaxVal + 1; i++)
                {
                    // 1% 단위로 업데이트
                    // UI스레드 내에 있는 제어를 하도록 처리하는 메서드
                    this.Invoke(new Action(() =>
                    {
                        PrgProcess.Value = i;
                        TxtLog.Text = i.ToString() + "\r\n";
                    }));
                    Thread.Sleep(20);
                }
            });
            BtnStart.Text = "시작";
            BtnStart.Enabled = true; // 버튼 비활성
            LblCurrState.Text = "현재상태 : 중지";

            // -- 응답없음 문제있는 코드 --
            // * : UI스레드가 관리
            LblCurrState.Text = "현재상태 : 진행"; // *
            BtnStart.Text = "진행중";
            BtnStart.Enabled = false;

            long MaxVal2 = 100;
            long total2 = 0;
            PrgProcess2.Minimum = 0;
            PrgProcess2.Maximum = 100;

            // awiat로 비동기 대기
            await Task.Run(() =>
            {
                for (int i = 0; i < MaxVal + 1; i++)
                {
                    TxtLog.Text += i.ToString() + "\r\n";
                    TxtLog.SelectionStart = TxtLog.Text.Length;
                    TxtLog.ScrollToCaret();
                    PrgProcess2.Value = i;
                    Thread.Sleep(20);
                }
                BtnStart.Text = "시작";
                BtnStart.Enabled = true; // 버튼 비활성
                LblCurrState.Text = "현재상태 : 중지";
            });
        }

    }
}
