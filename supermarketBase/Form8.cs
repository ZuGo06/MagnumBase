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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "supermarketBaseDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.supermarketBaseDataSet.Клиенты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.клиентыBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new Form9();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new Form10();
            frm.Show();
        }
    }
}
