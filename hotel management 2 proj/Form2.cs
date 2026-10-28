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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // тестовые гости, добавил для проверки работы таблицы
            dataGridView1.Rows.Add("Асанов Асан Асанович", "+996 555 12 34 56", "AN1234567");
            dataGridView1.Rows.Add("Петрова", "+996 700 98 76 54", "AN7654321");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // проверка, что поле ФИО не пустое
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите ФИО гостя");
                return;
            }

            // добавление гостя в таблицу
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);

            // очистка полей после добавления
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // удаление выбранной строки
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
            // кнопка очистки полей
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // вернуться на главную форму
            Close();
        }
    }
}
