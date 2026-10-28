using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management_2_proj
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // несколько номеров для примера
            dataGridView1.Rows.Add("101", "Стандарт", "2500", "Свободен");
            dataGridView1.Rows.Add("102", "Стандарт", "2500", "Занят");
            dataGridView1.Rows.Add("201", "Люкс", "6000", "Свободен");
            dataGridView1.Rows.Add("202", "Семейный", "4500", "На уборке");

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // проверка заполнения полей
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните номер и цену");
                return;
            }

            // добавление номера в таблицу
            dataGridView1.Rows.Add(textBox1.Text, comboBox1.Text, textBox2.Text, comboBox2.Text);

            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // удаление выбранного номера
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
