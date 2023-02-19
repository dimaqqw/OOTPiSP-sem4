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
                    throw new Exception("Нет такого индекса");
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
                if (textBox1.Text[i] == 'е' || textBox1.Text[i] == 'ы' ||
                    textBox1.Text[i] == 'а' || textBox1.Text[i] == 'у' ||
                    textBox1.Text[i] == 'о' || textBox1.Text[i] == 'э' ||
                    textBox1.Text[i] == 'я' || textBox1.Text[i] == 'ю' ||
                    textBox1.Text[i] == 'ё')
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
                if (textBox1.Text[i] == 'й' || 
                    textBox1.Text[i] == 'ц' ||
                    textBox1.Text[i] == 'к' ||
                    textBox1.Text[i] == 'н' ||
                    textBox1.Text[i] == 'ш' ||
                    textBox1.Text[i] == 'щ' ||
                    textBox1.Text[i] == 'з' ||
                    textBox1.Text[i] == 'х' ||
                    textBox1.Text[i] == 'ъ' ||
                    textBox1.Text[i] == 'ф' ||
                    textBox1.Text[i] == 'в' ||
                    textBox1.Text[i] == 'р' ||
                    textBox1.Text[i] == 'л' ||
                    textBox1.Text[i] == 'д' ||
                    textBox1.Text[i] == 'ж' ||
                    textBox1.Text[i] == 'ч' ||
                    textBox1.Text[i] == 'с' ||
                    textBox1.Text[i] == 'м' ||
                    textBox1.Text[i] == 'т' ||
                    textBox1.Text[i] == 'б' ||
                    textBox1.Text[i] == 'п' ||
                    textBox1.Text[i] == 'г' )
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