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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void типы_товаровBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.типы_товаровBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);

        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "supermarketBaseDataSet.Типы_товаров". При необходимости она может быть перемещена или удалена.
            this.типы_товаровTableAdapter.Fill(this.supermarketBaseDataSet.Типы_товаров);

        }
    }
}
