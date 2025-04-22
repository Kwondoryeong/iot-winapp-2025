namespace SyntaxWinApp04
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtAge.Text == "")
            {
                MessageBox.Show("???? ????????.");
                return; // �޼��� Ż��
            }
            else
            {
                // ���� ������ ���� �� ����...
                LblResult.Text = "ó����� : ";
                TxtResult.Text = "�հ� ó���� ����";
                string name = TxtName.Text.Trim(); // �յ� ������ ����
                // �Ľ� -> �м��ؼ� �� ��ȯ
                DateTime birthday = DateTime.Parse(TxtAge.Text.Trim());
                int age = DateTime.Now.Year - birthday.Year;
                // 3�׽� �б�
                string gender = RdoMale.Checked ? "��" : "��";

                TxtResult.Text = "���� " + name + "�̰�, " + birthday + "�� �¾ " + age + "�� " + gender + "�� �Դϴ�.";
                
            }
                
        }
    }
}
