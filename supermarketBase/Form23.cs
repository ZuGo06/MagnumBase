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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void Form23_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "SupermarketBaseDataSet.Отдел_кадров". При необходимости она может быть перемещена или удалена.
            this.Отдел_кадровTableAdapter.Fill(this.SupermarketBaseDataSet.Отдел_кадров);

            this.reportViewer1.RefreshReport();
        }
    }
}
