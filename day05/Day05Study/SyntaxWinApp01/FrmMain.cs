using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole(); // �ܼ� â ���� ���� ����

        // �븮��(delegate) ����
        delegate void MyDelegate(string msg);

        // �̺�Ʈ �ڵ鷯 �븮�� ����
        delegate void MyEventHandler(object sender, EventArgs e);
        // �̺�Ʈ ����
        public event EventHandler SomethingHappend;

        // �븮�ڿ��� ȣ���� �޼��� - �븮�ڿ� �Ķ���Ͱ� ��ġ
        void SayHello(string msg)
        {
            MessageBox.Show($"�ȳ�, {msg}", "�޽���",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void SayGoodbye(string msg)
        {
            MessageBox.Show($"���Ϻ�~, {msg}", "�޽���",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public FrmMain()
        {
            InitializeComponent();
            AllocConsole();
            Console.WriteLine("1. �� ������ ����");
            TxtLog.Text += ("1. �� ������ ����\r\n");
        }
        private void FrmMain_Load(object sender, EventArgs e) {
            Console.WriteLine("2. ���ε� �̺�Ʈ ����");
            TxtLog.Text += ("2. ���ε� �̺�Ʈ ����\r\n");
        }
        private void FrmMain_Activated(object sender, EventArgs e) {
            Console.WriteLine("3. ����Ƽ����Ƽ�� �̺�Ʈ ����");
            TxtLog.Text += ("3. ����Ƽ����Ƽ�� �̺�Ʈ ����\r\n");
        }
        private void FrmMain_Shown(object sender, EventArgs e) {
            Console.WriteLine("4. ���� �̺�Ʈ ����");
            TxtLog.Text += ("4. ���� �̺�Ʈ ����\r\n");

        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) {
            Console.WriteLine("5. ��Ŭ��¡ �̺�Ʈ ����");
            TxtLog.Text += ("5. ��Ŭ��¡ �̺�Ʈ ����\r\n");
        }

       private void FrmMain_FormClosed(object sender, FormClosedEventArgs e){
            Console.WriteLine("6. ��Ŭ����� �̺�Ʈ ����");
            TxtLog.Text += ("6. ��Ŭ����� �̺�Ʈ ����\r\n");
       }





        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // 1. ���� ȣ��
            SayHello("DoHyeong");
            SayGoodbye("DoHyeong");

            // 2. �븮��(delegate) ȣ��(���� ���� �ٽ�!!)
            MyDelegate del = SayHello; // �븮�ڿ� ȣ���� �޼��带 ������
            del += SayGoodbye;          // �߰��� ���� (�븮�� ü��(�Լ�) �߰�)
            del -= SayHello;            // �븮�� ü��(�Լ�) ����
            del("TaeHyeong");           // ��ϵ� �Լ� ���

            // 3. ��ȯ�� ���� �븮�� - Action
            Action<string> act = SayHello;
            act("Chris");

            // 4. ��ȯ�� �ִ� �븮�� - Func
            Func<int, int, int> add = (a, b) => a + b;
            int result = add(7, 8);
            Console.Write(result);

            // �̺�Ʈ ����
            if (SomethingHappend != null)
            {
                SomethingHappend(this, new EventArgs()); // �̺�Ʈ ����
            }

        }



    }
}
