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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void отделыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.отделыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);

        }

        private void Form21_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "supermarketBaseDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделыTableAdapter.Fill(this.supermarketBaseDataSet.Отделы);

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
                case 6:
                    column = dataGridViewTextBoxColumn8;
                    break;
                case 7:
                    column = dataGridViewTextBoxColumn9;
                    break;
                default:
                    break;
            }
            if (this.radioButton1.Checked)
            {
                отделыDataGridView.Sort(column, ListSortDirection.Ascending);
            }
            else
            {
                отделыDataGridView.Sort(column, ListSortDirection.Descending);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            отделыBindingSource.Filter = "DatePostuplenya= ' " + comboBox1.Text + " ' ";
            this.button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            отделыBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                //перебирает все ячейки таблицы и
                //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
                //отменяет результаты предыдущего поиска
                for (int i = 0; i < отделыDataGridView.ColumnCount - 1; i++)
                {
                    for (int j = 0; j < отделыDataGridView.RowCount - 1; j++)
                    {
                        отделыDataGridView[i, j].Style.BackColor = Color.White;
                        отделыDataGridView[i, j].Style.ForeColor = Color.Black;
                    }
                }
                //перебирает все ячейки таблицы и если они
                //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
                //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
                for (int i = 0; i < отделыDataGridView.ColumnCount - 1; i++)
                {
                    for (int j = 0; j < отделыDataGridView.RowCount - 1; j++)
                    {
                        if (отделыDataGridView[i,
                       j].Value.ToString().IndexOf(textBox1.Text) != -1)
                        {
                            отделыDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                            отделыDataGridView[i, j].Style.ForeColor = Color.Blue;

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
