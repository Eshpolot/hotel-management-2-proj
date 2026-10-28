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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // проверка полей гостя и номера
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введите ФИО гостя и номер комнаты");
                return;
            }

            // подсчёт количества ночей
            int nights = (dateTimePicker2.Value - dateTimePicker1.Value).Days;

            if (nights <= 0)
            {
                MessageBox.Show("Дата выезда должна быть позже даты заезда");
                return;
            }

            // добавление брони в таблицу
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text,
                dateTimePicker1.Value.ToShortDateString(),
                dateTimePicker2.Value.ToShortDateString(),
                nights);

            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // удаление выбранной брони
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
