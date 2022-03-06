
namespace supermarketBase
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            System.Windows.Forms.Label kodTovaraLabel;
            System.Windows.Forms.Label nameKlientaLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label vidOplatyLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.supermarketBaseDataSet = new supermarketBase.SupermarketBaseDataSet();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new supermarketBase.SupermarketBaseDataSetTableAdapters.КлиентыTableAdapter();
            this.tableAdapterManager = new supermarketBase.SupermarketBaseDataSetTableAdapters.TableAdapterManager();
            this.клиентыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.клиентыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kodTovaraTextBox = new System.Windows.Forms.TextBox();
            this.nameKlientaTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.vidOplatyTextBox = new System.Windows.Forms.TextBox();
            kodTovaraLabel = new System.Windows.Forms.Label();
            nameKlientaLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            vidOplatyLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingNavigator)).BeginInit();
            this.клиентыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(vidOplatyLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.vidOplatyTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(telephoneLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.telephoneTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(nameKlientaLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameKlientaTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(kodTovaraLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kodTovaraTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(200, 112);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.41322F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.58678F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 301);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(233, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = " Отчет таблицы \"Клиенты\"";
            // 
            // supermarketBaseDataSet
            // 
            this.supermarketBaseDataSet.DataSetName = "SupermarketBaseDataSet";
            this.supermarketBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.supermarketBaseDataSet;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = supermarketBase.SupermarketBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = this.клиентыTableAdapter;
            this.tableAdapterManager.ОтделыTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Типы_товаровTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // клиентыBindingNavigator
            // 
            this.клиентыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.клиентыBindingNavigator.BindingSource = this.клиентыBindingSource;
            this.клиентыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.клиентыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.клиентыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.клиентыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.клиентыBindingNavigatorSaveItem});
            this.клиентыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.клиентыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.клиентыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.клиентыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.клиентыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.клиентыBindingNavigator.Name = "клиентыBindingNavigator";
            this.клиентыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.клиентыBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.клиентыBindingNavigator.TabIndex = 2;
            this.клиентыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // клиентыBindingNavigatorSaveItem
            // 
            this.клиентыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.клиентыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("клиентыBindingNavigatorSaveItem.Image")));
            this.клиентыBindingNavigatorSaveItem.Name = "клиентыBindingNavigatorSaveItem";
            this.клиентыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.клиентыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.клиентыBindingNavigatorSaveItem.Click += new System.EventHandler(this.клиентыBindingNavigatorSaveItem_Click);
            // 
            // kodTovaraLabel
            // 
            kodTovaraLabel.AutoSize = true;
            kodTovaraLabel.Location = new System.Drawing.Point(3, 0);
            kodTovaraLabel.Name = "kodTovaraLabel";
            kodTovaraLabel.Size = new System.Drawing.Size(86, 17);
            kodTovaraLabel.TabIndex = 0;
            kodTovaraLabel.Text = "Kod Tovara:";
            // 
            // kodTovaraTextBox
            // 
            this.kodTovaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "KodTovara", true));
            this.kodTovaraTextBox.Location = new System.Drawing.Point(200, 3);
            this.kodTovaraTextBox.Name = "kodTovaraTextBox";
            this.kodTovaraTextBox.Size = new System.Drawing.Size(191, 22);
            this.kodTovaraTextBox.TabIndex = 1;
            // 
            // nameKlientaLabel
            // 
            nameKlientaLabel.AutoSize = true;
            nameKlientaLabel.Location = new System.Drawing.Point(3, 78);
            nameKlientaLabel.Name = "nameKlientaLabel";
            nameKlientaLabel.Size = new System.Drawing.Size(96, 17);
            nameKlientaLabel.TabIndex = 2;
            nameKlientaLabel.Text = "Name Klienta:";
            // 
            // nameKlientaTextBox
            // 
            this.nameKlientaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "NameKlienta", true));
            this.nameKlientaTextBox.Location = new System.Drawing.Point(200, 81);
            this.nameKlientaTextBox.Name = "nameKlientaTextBox";
            this.nameKlientaTextBox.Size = new System.Drawing.Size(191, 22);
            this.nameKlientaTextBox.TabIndex = 3;
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(3, 155);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(80, 17);
            telephoneLabel.TabIndex = 4;
            telephoneLabel.Text = "Telephone:";
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(200, 158);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(191, 22);
            this.telephoneTextBox.TabIndex = 5;
            // 
            // vidOplatyLabel
            // 
            vidOplatyLabel.AutoSize = true;
            vidOplatyLabel.Location = new System.Drawing.Point(3, 218);
            vidOplatyLabel.Name = "vidOplatyLabel";
            vidOplatyLabel.Size = new System.Drawing.Size(77, 17);
            vidOplatyLabel.TabIndex = 6;
            vidOplatyLabel.Text = "Vid Oplaty:";
            // 
            // vidOplatyTextBox
            // 
            this.vidOplatyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "VidOplaty", true));
            this.vidOplatyTextBox.Location = new System.Drawing.Point(200, 221);
            this.vidOplatyTextBox.Name = "vidOplatyTextBox";
            this.vidOplatyTextBox.Size = new System.Drawing.Size(191, 22);
            this.vidOplatyTextBox.TabIndex = 7;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.клиентыBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingNavigator)).EndInit();
            this.клиентыBindingNavigator.ResumeLayout(false);
            this.клиентыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private SupermarketBaseDataSet supermarketBaseDataSet;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private SupermarketBaseDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private SupermarketBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator клиентыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton клиентыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox vidOplatyTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox nameKlientaTextBox;
        private System.Windows.Forms.TextBox kodTovaraTextBox;
    }
}