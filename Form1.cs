namespace практика
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        // Удалить неиспользуемый обработчик событий, если label1 не используется
        // private void label1_Click(object sender, EventArgs e)
        // {
        // }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 klientForm = new Form4();//клиент
            klientForm.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 registrationForm = new Form2();
            registrationForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //админ
            Form4 klientForm = new Form4();
            klientForm.ShowDialog();
        }
    }
}
