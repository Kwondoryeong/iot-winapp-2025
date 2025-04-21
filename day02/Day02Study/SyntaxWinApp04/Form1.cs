namespace SyntaxWinApp04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtAge.Text == "")
            {
                MessageBox.Show("값을 채워주세요.");
                return; // 메서드 탈출
            }
            else
            {
                if (RdoMale.Checked)
                {
                    TxtResult.Text = "이름 : " + TxtAge.Text + ", 나이 : " + TxtName.Text + ", 성별 : " + RdoMale.Text;
                }
                else
                {
                    TxtResult.Text = "이름 : " + TxtAge.Text + ", 나이 : " + TxtName.Text + ", 성별 : " + RdoFemale.Text;
                }
            }
                
        }
    }
}
