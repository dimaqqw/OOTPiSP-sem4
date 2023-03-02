namespace Lab2
{
    public partial class Form1 : Form
    {
        public static List<Discipline> disciplines = new List<Discipline>();

        public static List<Lector> Lectors = new List<Lector> {
            new Lector("Барковсий", "Евгений", "Валерьевич","311-1","ИСиТ"),
            new Lector("Смелов", "Владимир", "Владимирович","306-1","ИСиТ"),
            new Lector("Сазонова", "Дарья", "Владимировна","311-1","ИСиТ"),
            new Lector("Пацей", "Наталья", "Владимировна","327-1","ПОИТ"),
            new Lector("Пахолко", "Алёна", "Степанова","408-1","ПОИТ"),
            new Lector("Чистякова", "Юлия", "Александровна","226-1","ПОИТ")
            };
           
    public Form1()
        {
            InitializeComponent();

            foreach (var item in Lectors)
            {
                comboBox2.Items.Add(item.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Учебный отдел";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar1.Value.ToString();
        }
        private string checkRadio()
        {
            if (radioButton1.Checked)
            {
                return String.Format(radioButton1.Text);
            }
            else if (radioButton2.Checked)
            {
                return String.Format(radioButton2.Text);
            }
            else if (radioButton3.Checked)
            {
                return String.Format(radioButton3.Text);
            }
            else if(radioButton4.Checked)
            {
                return String.Format(radioButton4.Text);
            }
            else
            {
                return "";
            }
        }
        private bool checkExam()
        {
            if (listBox1.SelectedIndex == 0)
            {
                return true;
            }
            else if (listBox1.SelectedIndex == 1)
            {
                return false;
            }
            else
            {
                return false;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(comboBox1.SelectedText) &&
                !String.IsNullOrEmpty(checkedListBox1.Text) &&
                !String.IsNullOrEmpty(checkRadio()) &&
                !String.IsNullOrEmpty(Convert.ToString(numericUpDown1.Value)) &&
                !String.IsNullOrEmpty(Convert.ToString(trackBar1.Value)) &&
                !String.IsNullOrEmpty(Convert.ToString(checkExam())) &&
                comboBox2.SelectedIndex!=null )
            {
                disciplines.Add(new Discipline(
                textBox1.Text.ToString(),  // name
                comboBox1.SelectedText,  // semestr
                Convert.ToInt32(checkedListBox1.Text),// course 
                checkRadio(), // spec
                Convert.ToInt32(numericUpDown1.Value), // lect
                trackBar1.Value, // labs
                checkExam(),// ex
                Lectors[comboBox2.SelectedIndex]) // lector
            );
                var discip = disciplines;
                XmlSerializeWrapper.Serialize(discip, "disciplines.xml");
                richTextBox1.Text = $"Discipline name: {textBox1.Text.ToString()}\n" +
                    $"Semester: {comboBox1.SelectedText}\n" +
                    $"Course: {Convert.ToInt32(checkedListBox1.Text)}\n" +
                    $"Specialization: {checkRadio()}\n" +
                    $"Lections: {Convert.ToInt32(numericUpDown1.Value)} \n" +
                    $"Labs: {trackBar1.Value}\n" +
                    $"Exam: {checkExam()} \n" +
                    $"Lector: {Lectors[comboBox2.SelectedIndex]}";
                var des = XmlSerializeWrapper.Deserialize<List<Discipline>>("disciplines.xml");
            }
            else
            {
                MessageBox.Show("Некоректные данные");
            }
        }
    }
}