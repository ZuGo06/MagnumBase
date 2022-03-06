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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void отделыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.отделыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);

        }

        private void Form22_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "supermarketBaseDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделыTableAdapter.Fill(this.supermarketBaseDataSet.Отделы);

        }
    }
}
