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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void отделыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.отделыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);

        }

        private void Form20_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "supermarketBaseDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделыTableAdapter.Fill(this.supermarketBaseDataSet.Отделы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            отделыBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            отделыBindingSource.MovePrevious();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            отделыBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            отделыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            отделыBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            отделыBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.отделыBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new Form21();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new Form22();
            frm.Show();
        }
    }
}
