namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // async - await ���� ����ؾ���!
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            LblCurrState.Text = "������� : ����";    // UI ó��
            BtnStart.Text = "������";  // UIó��
            BtnStart.Enabled = false; // ������ ��, ��ư ��Ȱ��ȭ

            long MaxVal = 100;
            long total = 0;

            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = 100;
            LblCurrState.Text = "������� : ����";

            long cnt = 0;
            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = 100;

            // -- ������� ���� ���� �ڵ� --
            //for (int i = 0; i < MaxVal + 1; i++)
            //{
            //    PrgProcess.Value = i;
            //    TxtLog.Text = i.ToString();
            //    // UI�� ������ �ʵ��� await ���
            //    await Task.Delay(10);
            //}

            //BtnStart.Text = "����";
            //BtnStart.Enabled = true; // ��ư ��Ȱ��
            //LblCurrState.Text = "������� : ����";
            // --

            await Task.Run(() =>
            {
                for (int i = 0; i < MaxVal + 1; i++)
                {
                    // 1% ������ ������Ʈ
                    // UI������ ���� �ִ� ��� �ϵ��� ó���ϴ� �޼���
                    this.Invoke(new Action(() =>
                    {
                        PrgProcess.Value = i;
                        TxtLog.Text = i.ToString() + "\r\n";
                    }));
                    Thread.Sleep(20);
                }
            });
            BtnStart.Text = "����";
            BtnStart.Enabled = true; // ��ư ��Ȱ��
            LblCurrState.Text = "������� : ����";

            // -- ������� �����ִ� �ڵ� --
            // * : UI�����尡 ����
            LblCurrState.Text = "������� : ����"; // *
            BtnStart.Text = "������";
            BtnStart.Enabled = false;

            long MaxVal2 = 100;
            long total2 = 0;
            PrgProcess2.Minimum = 0;
            PrgProcess2.Maximum = 100;

            // awiat�� �񵿱� ���
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
                BtnStart.Text = "����";
                BtnStart.Enabled = true; // ��ư ��Ȱ��
                LblCurrState.Text = "������� : ����";
            });
        }

    }
}
