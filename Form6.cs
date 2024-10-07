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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace практика
{
    public partial class Form6 : Form
    {
        private string connectionString = "server=localhost;database=foto;Uid=root;Pwd=vekzIc-gyxqi1-syjjiw;";
        public Form6()
        {
            InitializeComponent();
        }
        public class Service
        {
            public int Id { get; set; }
            public string service_type { get; set; }

            public decimal Price { get; set; }
        }


        public class HairContext : DbContext
        {
            private readonly string connectionString = "server=localhost;database=foto;Uid=root;Pwd=vekzIc-gyxqi1-syjjiw;";

            public DbSet<Service> Services { get; set; }

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
            using (var context = new HairContext())
            {
                var services = context.Services.ToList();

                // Фильтруем данные
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    services = services.Where(s => s.service_type.Contains(searchQuery)).ToList();
                }

                // Отображаем данные в DataGridView
                dataGridView1.DataSource = services;

            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           //лучше удалить
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
