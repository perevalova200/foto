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

namespace практика
{
    public partial class Form7 : Form
    {
        private string connectionString = "server=localhost;database=foto;Uid=root;Pwd=vekzIc-gyxqi1-syjjiw;";
        public Form7()
        {
            InitializeComponent();
            LoadFreeTimeData();
        }
        private void LoadFreeTimeData()
        {
            using (var context = new fotoContext(connectionString))
            {
                var svobodnoetimes = context.svobodnoeTime.ToList();
                // Создаем DataTable для DataGridView
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Дата", typeof(DateTime));
                dataTable.Columns.Add("Начало", typeof(TimeSpan));
                dataTable.Columns.Add("Окончание", typeof(TimeSpan));
                dataTable.Columns.Add("Статус", typeof(string));

                // Заполняем DataTable данными
                foreach (var svobodnoeTime in svobodnoetimes)
                {
                    DataRow row = dataTable.NewRow();
                    row["Id"] = svobodnoeTime.Id;
                    row["Дата"] = svobodnoeTime.Date;
                    row["Начало"] = svobodnoeTime.StartTime;
                    row["Окончание"] = svobodnoeTime.EndTime;
                    row["Статус"] = svobodnoeTime.IsFree ? "Свободно" : "Занято";
                    dataTable.Rows.Add(row);
                }
                // Устанавливаем источник данных для DataGridView
                dataGridView1.DataSource = dataTable;
            }
            // Настройка DataGridView
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Дата"].HeaderText = "Дата";
            dataGridView1.Columns["Начало"].HeaderText = "Начало";
            dataGridView1.Columns["Окончание"].HeaderText = "Окончание";
            dataGridView1.Columns["Статус"].HeaderText = "Статус";

            // Настройка стиля для столбца "Статус"
            dataGridView1.Columns["Статус"].DefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView1.Columns["Статус"].DefaultCellStyle.ForeColor = Color.Black;

            // Делаем столбец "Статус" не редактируемым
            dataGridView1.Columns["Статус"].ReadOnly = true;
            // Добавляем обработчик события CellClick для DataGridView
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, была ли щелкнута ячейка в столбце "Статус"
            if (e.ColumnIndex == dataGridView1.Columns["Статус"].Index)
            {
                // Получаем ID записи из выбранной строки
                int selectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                using (var context = new fotoContext(connectionString))
                {
                    // Находим запись по ID
                    var svobodnoetimes = context.svobodnoeTime.Find(selectedId);
                    if (svobodnoetimes != null)
                    {
                        // Меняем статус записи
                        svobodnoetimes.IsFree = !svobodnoetimes.IsFree;

                        // Сохраняем изменения в базе данных
                        context.SaveChanges();

                        // Обновляем данные в DataGridView
                        LoadFreeTimeData();
                    }
                }
            }
        }

        // Модель сущности FreeTime
        public class svobodnoeTime
        {
            public int Id { get; set; }
            public DateTime Date { get; set; }
            public TimeSpan StartTime { get; set; }
            public TimeSpan EndTime { get; set; }
            public bool IsFree { get; set; }
        }

        // Контекст базы данных
        public class fotoContext : DbContext
        {
            private readonly string connectionString;

            public fotoContext(string connectionString) : base()
            {
                this.connectionString = connectionString;
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseMySql(this.connectionString, ServerVersion.AutoDetect(connectionString));
            }

            public DbSet<svobodnoeTime> svobodnoeTime { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

