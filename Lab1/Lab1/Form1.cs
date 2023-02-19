namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(textBox2.Text, textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(textBox4.Text, "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox5.Text) >= textBox1.Text.Length ||
                Convert.ToInt32(textBox5.Text) <= 0)
                {
                    throw new Exception("��� ������ �������");
                }
                else
                {
                    textBox1.Text = textBox1.Text[Convert.ToInt32(textBox5.Text) - 1].ToString();
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Length.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == '�' || textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' || textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' || textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' || textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�')
                {
                    count++;
                }
            }
            textBox1.Text = count.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == '�' || 
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' ||
                    textBox1.Text[i] == '�' )
                {
                    count++;
                }
            }
            textBox1.Text = count.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == '.')
                {
                    count++;
                }
            }
            count++;
            textBox1.Text = count.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == ' ')
                {
                    count++;
                }
            }
            count++;
            textBox1.Text = count.ToString();
        }
    }
}