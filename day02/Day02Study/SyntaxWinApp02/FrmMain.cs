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
            // ������ : =, +, 0, *, /, %, ^,
            // &&, ||, &, |, ^, !
            //int val = 2 ^ 10;

            //int result = 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2;

            //MessageBox.Show(result.ToString(), "�˸�", MessageBoxButtons.OKCancel);
            //MessageBox.Show(val.ToString(), "�˸�", MessageBoxButtons.OKCancel);

            // �б⹮
            // if else ��
            if (TxtPain.Text == "�ƴϿ�")
            {
                MessageBox.Show("������ �� �Ծ�. ������!");
            }
            else if (TxtPain.Text == "��" || TxtPain.Text == "��")
            {
                string PainPoint = CboPainPoint.SelectedItem.ToString();
                // switch��
                switch (PainPoint)
                {
                    case "�Ӹ�":
                        MessageBox.Show("�Ű���� ���ϴ�", "���������");
                        break;
                    case "��":
                        MessageBox.Show("�Ȱ��� ���ϴ�", "���������");
                        break;
                    case "��":
                        MessageBox.Show("�̺����İ��� ���ϴ�", "���������");
                        break;
                    case "����":
                    //MessageBox.Show("������ ���ϴ�", "���������");
                    //break;
                    case "��":
                        MessageBox.Show("������ ���ϴ�", "���������");
                        break;
                    case "�ո�":
                        MessageBox.Show("�����ܰ��� ���ϴ�", "���������");
                        break;
                }
            }
            else
            {
                MessageBox.Show("�������θ� �Է��ϼ���!!");
                TxtPain.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtPain_KeyPress(object sender, KeyPressEventArgs e)
        {
            // KeyPress���� Enter�� �Է��ϸ� 
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show(TxtPain.Text, "�Է°� ");
            }
        }

        private void CboPainPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            // var ��������
            //var selectedPointItem = CboPainPoint.SelectedItem;
            //var selectedPointIndex = CboPainPoint.SelectedIndex;
            //MessageBox.Show(selectedPointItem.ToString() + '\n' + selectedPointIndex.ToString(), "��������");

        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            // for��
            for (int x = 2; x < 10; x++)
            {
                for (int y = 1; y < 10; y++)
                {
                    var result = x + "x" + y + "=" + (x * y);
                    TxtResult.Text += result + " ";
                }
                TxtResult.Text += "\r\n"; // ���� ������� \r\n ���� �����
            }
        }

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            
        int clickNum = 0;
            // ���� �ݺ�
            while (true)
            {
                MessageBox.Show("5���� ��� : " + clickNum);
                clickNum++;

                if(clickNum >= 5)
                {
                    break;
                    // �ݺ��� Ż�� for, foreach, while���� ��밡��
                    // continue; �� �ľ��� ��
                    // goto; �� �����ϸ� ���� ����
                }
            }
        }
    }
}
