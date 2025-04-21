namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            // 연산자 : =, +, 0, *, /, %, ^,
            // &&, ||, &, |, ^, !
            //int val = 2 ^ 10;

            //int result = 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2;

            //MessageBox.Show(result.ToString(), "알림", MessageBoxButtons.OKCancel);
            //MessageBox.Show(val.ToString(), "알림", MessageBoxButtons.OKCancel);

            // 분기문
            // if else 문
            if (TxtPain.Text == "아니오")
            {
                MessageBox.Show("병원을 왜 왔어. 집에가!");
            }
            else if (TxtPain.Text == "네" || TxtPain.Text == "예")
            {
                string PainPoint = CboPainPoint.SelectedItem.ToString();
                // switch문
                switch (PainPoint)
                {
                    case "머리":
                        MessageBox.Show("신경과로 갑니다", "진료과선택");
                        break;
                    case "눈":
                        MessageBox.Show("안과로 갑니다", "진료과선택");
                        break;
                    case "코":
                        MessageBox.Show("이비인후과로 갑니다", "진료과선택");
                        break;
                    case "가슴":
                    //MessageBox.Show("내과로 갑니다", "진료과선택");
                    //break;
                    case "배":
                        MessageBox.Show("내과로 갑니다", "진료과선택");
                        break;
                    case "손목":
                        MessageBox.Show("정형외과로 갑니다", "진료과선택");
                        break;
                }
            }
            else
            {
                MessageBox.Show("통증여부를 입력하세요!!");
                TxtPain.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtPain_KeyPress(object sender, KeyPressEventArgs e)
        {
            // KeyPress에서 Enter를 입력하면 
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show(TxtPain.Text, "입력값 ");
            }
        }

        private void CboPainPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            // var 동적변수
            //var selectedPointItem = CboPainPoint.SelectedItem;
            //var selectedPointIndex = CboPainPoint.SelectedIndex;
            //MessageBox.Show(selectedPointItem.ToString() + '\n' + selectedPointIndex.ToString(), "통증부위");

        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            // for문
            for (int x = 2; x < 10; x++)
            {
                for (int y = 1; y < 10; y++)
                {
                    var result = x + "x" + y + "=" + (x * y);
                    TxtResult.Text += result + " ";
                }
                TxtResult.Text += "\r\n"; // 원래 윈도우는 \r\n 같이 써야함
            }
        }

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            
        int clickNum = 0;
            // 무한 반복
            while (true)
            {
                MessageBox.Show("5까지 계속 : " + clickNum);
                clickNum++;

                if(clickNum >= 5)
                {
                    break;
                    // 반복문 탈출 for, foreach, while문에 사용가능
                    // continue; 도 파악할 것
                    // goto; 는 웬만하면 쓰지 말것
                }
            }
        }
    }
}
