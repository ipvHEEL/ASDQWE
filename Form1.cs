using System.Text;

namespace txtredactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //��������� ��� �� ������ ����
            {
                richTextBox1.Clear(); //������� richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //��������� ��� ��� ����������
                                                                     //������ ��������� �����
                string fileName = openFileDialog1.FileName; //�������� ������������ ���� � ���� �
                //����.
                richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //��������
                //���������� ����� � richTextBox
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//������ ��������� ����������
            saveFileDialog1.DefaultExt = ".txt"; //������ ���������� �� ���������
                                                 //3
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //��������� �������������
                                                                 // ���������� ����������.
            {
                var name = saveFileDialog1.FileName; //������ ��� �����
                File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251)); //����������
                                                                                        //� ���� ���������� textBox � ���������� 1251
            }
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ��������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello World!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void �����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void �����������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void ����������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = richTextBox1.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = MyDialog.Color;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = richTextBox1.Font;
            fontDialog1.Color = richTextBox1.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}