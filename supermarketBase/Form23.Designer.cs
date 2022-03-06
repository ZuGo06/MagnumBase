
namespace supermarketBase
{
    partial class Form23
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SupermarketBaseDataSet = new supermarketBase.SupermarketBaseDataSet();
            this.Отдел_кадровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Отдел_кадровTableAdapter = new supermarketBase.SupermarketBaseDataSetTableAdapters.Отдел_кадровTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SupermarketBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отдел_кадровBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Отдел_кадровBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "supermarketBase.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(933, 571);
            this.reportViewer1.TabIndex = 0;
            // 
            // SupermarketBaseDataSet
            // 
            this.SupermarketBaseDataSet.DataSetName = "SupermarketBaseDataSet";
            this.SupermarketBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Отдел_кадровBindingSource
            // 
            this.Отдел_кадровBindingSource.DataMember = "Отдел кадров";
            this.Отдел_кадровBindingSource.DataSource = this.SupermarketBaseDataSet;
            // 
            // Отдел_кадровTableAdapter
            // 
            this.Отдел_кадровTableAdapter.ClearBeforeFill = true;
            // 
            // Form23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 571);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form23";
            this.Text = "Form23";
            this.Load += new System.EventHandler(this.Form23_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SupermarketBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отдел_кадровBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Отдел_кадровBindingSource;
        private SupermarketBaseDataSet SupermarketBaseDataSet;
        private SupermarketBaseDataSetTableAdapters.Отдел_кадровTableAdapter Отдел_кадровTableAdapter;
    }
}