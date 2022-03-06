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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void типы_товаровBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.типы_товаровBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "supermarketBaseDataSet.Типы_товаров". При необходимости она может быть перемещена или удалена.
            this.типы_товаровTableAdapter.Fill(this.supermarketBaseDataSet.Типы_товаров);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            типы_товаровBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            типы_товаровBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            типы_товаровBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            типы_товаровBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            типы_товаровBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            типы_товаровBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.типы_товаровBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new Form15();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new Form16();
            frm.Show();
        }
    }
}
