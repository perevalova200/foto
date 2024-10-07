using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static практика.Form6;
using static практика.Form8;

namespace практика
{
    public partial class Form8 : Form
    {
        private string connectionString = "server=localhost;database=foto;Uid=root;Pwd=vekzIc-gyxqi1-syjjiw;";
        public Form8()
        {
            InitializeComponent();
        }
        public class Fotograf
        {
            public int Id { get; set; }
            public string first_name { get; set; }

            public string last_name { get; set; }
            public string genre { get; set; }
            public string contact_info { get; set; }
        }
        public class fotoContext : DbContext
        {
            private readonly string connectionString = "server=localhost;database=foto;Uid=root;Pwd=vekzIc-gyxqi1-syjjiw;";

            public DbSet<Fotograf> fotograf { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем поисковый запрос
            string searchQuery = textBox1.Text;

            // Получаем данные из БД
            using (var context = new fotoContext())
            {
                var fotograf = context.fotograf.ToList();

                // Фильтруем данные
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    fotograf = fotograf.Where(s => s.first_name.Contains(searchQuery)).ToList();
                }

                // Отображаем данные в DataGridView
                dataGridView1.DataSource = fotograf;

            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
//лучше удалить
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
//лучше удалить
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

    
