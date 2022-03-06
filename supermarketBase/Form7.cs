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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void должностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.должностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supermarketBaseDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "supermarketBaseDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.supermarketBaseDataSet.Должности);

        }
    }
}
