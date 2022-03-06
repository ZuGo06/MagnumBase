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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void должностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.должностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "supermarketBaseDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.supermarketBaseDataSet.Должности);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            должностиBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            должностиBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            должностиBindingSource.MoveLast();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            должностиBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            должностиBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.должностиBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new Form6();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new Form7();
            frm.Show();
        }
    }
}
