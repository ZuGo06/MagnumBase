
namespace supermarketBase
{
    partial class Form19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form19));
            System.Windows.Forms.Label kodTovaraLabel;
            System.Windows.Forms.Label namePostavchikaLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label vidTransportaLabel;
            System.Windows.Forms.Label vidOplatyLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.supermarketBaseDataSet = new supermarketBase.SupermarketBaseDataSet();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикиTableAdapter = new supermarketBase.SupermarketBaseDataSetTableAdapters.ПоставщикиTableAdapter();
            this.tableAdapterManager = new supermarketBase.SupermarketBaseDataSetTableAdapters.TableAdapterManager();
            this.поставщикиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.поставщикиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kodTovaraTextBox = new System.Windows.Forms.TextBox();
            this.namePostavchikaTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.vidTransportaTextBox = new System.Windows.Forms.TextBox();
            this.vidOplatyTextBox = new System.Windows.Forms.TextBox();
            kodTovaraLabel = new System.Windows.Forms.Label();
            namePostavchikaLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            vidTransportaLabel = new System.Windows.Forms.Label();
            vidOplatyLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingNavigator)).BeginInit();
            this.поставщикиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(vidOplatyLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.vidOplatyTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(vidTransportaLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.vidTransportaTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(adressLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.adressTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(countryLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.countryTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(namePostavchikaLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.namePostavchikaTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(kodTovaraLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kodTovaraTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(205, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.51852F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.48148F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 293);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(257, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отчет таблицы \"Поставщики\"";
            // 
            // supermarketBaseDataSet
            // 
            this.supermarketBaseDataSet.DataSetName = "SupermarketBaseDataSet";
            this.supermarketBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.supermarketBaseDataSet;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = supermarketBase.SupermarketBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.ОтделыTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = this.поставщикиTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Типы_товаровTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // поставщикиBindingNavigator
            // 
            this.поставщикиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.поставщикиBindingNavigator.BindingSource = this.поставщикиBindingSource;
            this.поставщикиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.поставщикиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.поставщикиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.поставщикиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.поставщикиBindingNavigatorSaveItem});
            this.поставщикиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.поставщикиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.поставщикиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.поставщикиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.поставщикиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.поставщикиBindingNavigator.Name = "поставщикиBindingNavigator";
            this.поставщикиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.поставщикиBindingNavigator.Size = new System.Drawing.Size(868, 27);
            this.поставщикиBindingNavigator.TabIndex = 2;
            this.поставщикиBindingNavigator.Text = "bindingNavigator1";
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
            // поставщикиBindingNavigatorSaveItem
            // 
            this.поставщикиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.поставщикиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("поставщикиBindingNavigatorSaveItem.Image")));
            this.поставщикиBindingNavigatorSaveItem.Name = "поставщикиBindingNavigatorSaveItem";
            this.поставщикиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.поставщикиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.поставщикиBindingNavigatorSaveItem.Click += new System.EventHandler(this.поставщикиBindingNavigatorSaveItem_Click);
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
            this.kodTovaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "KodTovara", true));
            this.kodTovaraTextBox.Location = new System.Drawing.Point(232, 3);
            this.kodTovaraTextBox.Name = "kodTovaraTextBox";
            this.kodTovaraTextBox.Size = new System.Drawing.Size(205, 22);
            this.kodTovaraTextBox.TabIndex = 1;
            // 
            // namePostavchikaLabel
            // 
            namePostavchikaLabel.AutoSize = true;
            namePostavchikaLabel.Location = new System.Drawing.Point(3, 33);
            namePostavchikaLabel.Name = "namePostavchikaLabel";
            namePostavchikaLabel.Size = new System.Drawing.Size(129, 17);
            namePostavchikaLabel.TabIndex = 2;
            namePostavchikaLabel.Text = "Name Postavchika:";
            // 
            // namePostavchikaTextBox
            // 
            this.namePostavchikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "NamePostavchika", true));
            this.namePostavchikaTextBox.Location = new System.Drawing.Point(232, 36);
            this.namePostavchikaTextBox.Name = "namePostavchikaTextBox";
            this.namePostavchikaTextBox.Size = new System.Drawing.Size(205, 22);
            this.namePostavchikaTextBox.TabIndex = 3;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(3, 77);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(61, 17);
            countryLabel.TabIndex = 4;
            countryLabel.Text = "Country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(232, 80);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(205, 22);
            this.countryTextBox.TabIndex = 5;
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(3, 141);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(56, 17);
            adressLabel.TabIndex = 6;
            adressLabel.Text = "Adress:";
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(232, 144);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(205, 22);
            this.adressTextBox.TabIndex = 7;
            // 
            // vidTransportaLabel
            // 
            vidTransportaLabel.AutoSize = true;
            vidTransportaLabel.Location = new System.Drawing.Point(3, 190);
            vidTransportaLabel.Name = "vidTransportaLabel";
            vidTransportaLabel.Size = new System.Drawing.Size(106, 17);
            vidTransportaLabel.TabIndex = 8;
            vidTransportaLabel.Text = "Vid Transporta:";
            // 
            // vidTransportaTextBox
            // 
            this.vidTransportaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "VidTransporta", true));
            this.vidTransportaTextBox.Location = new System.Drawing.Point(232, 193);
            this.vidTransportaTextBox.Name = "vidTransportaTextBox";
            this.vidTransportaTextBox.Size = new System.Drawing.Size(205, 22);
            this.vidTransportaTextBox.TabIndex = 9;
            // 
            // vidOplatyLabel
            // 
            vidOplatyLabel.AutoSize = true;
            vidOplatyLabel.Location = new System.Drawing.Point(3, 249);
            vidOplatyLabel.Name = "vidOplatyLabel";
            vidOplatyLabel.Size = new System.Drawing.Size(77, 17);
            vidOplatyLabel.TabIndex = 10;
            vidOplatyLabel.Text = "Vid Oplaty:";
            // 
            // vidOplatyTextBox
            // 
            this.vidOplatyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "VidOplaty", true));
            this.vidOplatyTextBox.Location = new System.Drawing.Point(232, 252);
            this.vidOplatyTextBox.Name = "vidOplatyTextBox";
            this.vidOplatyTextBox.Size = new System.Drawing.Size(205, 22);
            this.vidOplatyTextBox.TabIndex = 11;
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 509);
            this.Controls.Add(this.поставщикиBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form19";
            this.Text = "Form19";
            this.Load += new System.EventHandler(this.Form19_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingNavigator)).EndInit();
            this.поставщикиBindingNavigator.ResumeLayout(false);
            this.поставщикиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private SupermarketBaseDataSet supermarketBaseDataSet;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private SupermarketBaseDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private SupermarketBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator поставщикиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton поставщикиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox vidOplatyTextBox;
        private System.Windows.Forms.TextBox vidTransportaTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox namePostavchikaTextBox;
        private System.Windows.Forms.TextBox kodTovaraTextBox;
    }
}