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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "supermarketBaseDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.supermarketBaseDataSet.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.MoveNext();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.MoveLast();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.RemoveCurrent();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.сотрудникиBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new Form3();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new Form4();
            frm.Show();
        }
    }
}
