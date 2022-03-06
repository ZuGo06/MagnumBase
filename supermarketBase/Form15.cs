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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void типы_товаровBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.типы_товаровBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "supermarketBaseDataSet.Типы_товаров". При необходимости она может быть перемещена или удалена.
            this.типы_товаровTableAdapter.Fill(this.supermarketBaseDataSet.Типы_товаров);

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
                default:
                    break;
            }
            if (this.radioButton1.Checked)
            {
                типы_товаровDataGridView.Sort(column, ListSortDirection.Ascending);
            }
            else
            {
                типы_товаровDataGridView.Sort(column, ListSortDirection.Descending);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            типы_товаровBindingSource.Filter = "NameKlienta= ' " + comboBox1.Text + " ' ";
            this.button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            типы_товаровBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                //перебирает все ячейки таблицы и
                //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
                //отменяет результаты предыдущего поиска
                for (int i = 0; i < типы_товаровDataGridView.ColumnCount - 1; i++)
                {
                    for (int j = 0; j < типы_товаровDataGridView.RowCount - 1; j++)
                    {
                        типы_товаровDataGridView[i, j].Style.BackColor = Color.White;
                        типы_товаровDataGridView[i, j].Style.ForeColor = Color.Black;
                    }
                }
                //перебирает все ячейки таблицы и если они
                //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
                //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
                for (int i = 0; i < типы_товаровDataGridView.ColumnCount - 1; i++)
                {
                    for (int j = 0; j < типы_товаровDataGridView.RowCount - 1; j++)
                    {
                        if (типы_товаровDataGridView[i,
                       j].Value.ToString().IndexOf(textBox1.Text) != -1)
                        {
                            типы_товаровDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                            типы_товаровDataGridView[i, j].Style.ForeColor = Color.Blue;

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

