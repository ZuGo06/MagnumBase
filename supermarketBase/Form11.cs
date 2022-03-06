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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void товарыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "supermarketBaseDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.supermarketBaseDataSet.Товары);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            товарыBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            товарыBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            товарыBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            товарыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            товарыBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            товарыBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.товарыBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new Form12();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new Form13();
            frm.Show();
        }
    }
}
