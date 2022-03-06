using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarketBase
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void товарыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "supermarketBaseDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.supermarketBaseDataSet.Товары);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            int index = this.listBox1.SelectedIndex;
            switch (index)
            {
                case 0:
                    column = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    column = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    column = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    column = dataGridViewTextBoxColumn5;
                    break;
                case 4:
                    column = dataGridViewTextBoxColumn6;
                    break;
                case 5:
                    column = dataGridViewTextBoxColumn7;
                    break;
                default:
                    break;
            }
            if (this.radioButton1.Checked)
            {
                товарыDataGridView.Sort(column, ListSortDirection.Ascending);
            }
            else
            {
                товарыDataGridView.Sort(column, ListSortDirection.Descending);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            товарыBindingSource.Filter = "NameOfTovara= ' " + comboBox1.Text + " ' ";
            this.button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            товарыBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                //перебирает все ячейки таблицы и
                //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
                //отменяет результаты предыдущего поиска
                for (int i = 0; i < товарыDataGridView.ColumnCount - 1; i++)
                {
                    for (int j = 0; j < товарыDataGridView.RowCount - 1; j++)
                    {
                        товарыDataGridView[i, j].Style.BackColor = Color.White;
                        товарыDataGridView[i, j].Style.ForeColor = Color.Black;
                    }
                }
                //перебирает все ячейки таблицы и если они
                //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
                //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
                for (int i = 0; i < товарыDataGridView.ColumnCount - 1; i++)
                {
                    for (int j = 0; j < товарыDataGridView.RowCount - 1; j++)
                    {
                        if (товарыDataGridView[i,
                       j].Value.ToString().IndexOf(textBox1.Text) != -1)
                        {
                            товарыDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                            товарыDataGridView[i, j].Style.ForeColor = Color.Blue;

                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

