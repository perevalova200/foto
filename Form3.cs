using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
 // Определяется обработчик события нажатия на кнопку button1.
        private void button1_Click(object sender, EventArgs e)
        {
        // Создается экземпляр формы Form6 и отображается модальное диалоговое окно.
            Form6 servicesForm = new Form6();
            servicesForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        // Определяется обработчик события нажатия на кнопку button2.
            Form7 timeForm = new Form7();
            timeForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 timeForm = new Form8();
            timeForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        // Определяется обработчик события нажатия на кнопку button4.
            Form9 timeForm = new Form9();
            timeForm.ShowDialog();
        }
    }
}
