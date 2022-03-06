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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void поставщикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);

        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "supermarketBaseDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.supermarketBaseDataSet.Поставщики);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            поставщикиBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            поставщикиBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            поставщикиBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            поставщикиBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            поставщикиBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            поставщикиBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.поставщикиBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new Form18();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new Form19();
            frm.Show();
        }
    }
}
