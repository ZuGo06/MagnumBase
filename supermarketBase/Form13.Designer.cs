
namespace supermarketBase
{
    partial class Form13
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
            System.Windows.Forms.Label nameOfTovaraLabel;
            System.Windows.Forms.Label otdelLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label usloviyaHranenyaLabel;
            System.Windows.Forms.Label srokiHranenyaLabel;
            System.Windows.Forms.Label kodTipaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kodTipaTextBox = new System.Windows.Forms.TextBox();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supermarketBaseDataSet = new supermarketBase.SupermarketBaseDataSet();
            this.srokiHranenyaTextBox = new System.Windows.Forms.TextBox();
            this.usloviyaHranenyaTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.otdelTextBox = new System.Windows.Forms.TextBox();
            this.nameOfTovaraTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.товарыTableAdapter = new supermarketBase.SupermarketBaseDataSetTableAdapters.ТоварыTableAdapter();
            this.tableAdapterManager = new supermarketBase.SupermarketBaseDataSetTableAdapters.TableAdapterManager();
            this.товарыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.товарыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            nameOfTovaraLabel = new System.Windows.Forms.Label();
            otdelLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            usloviyaHranenyaLabel = new System.Windows.Forms.Label();
            srokiHranenyaLabel = new System.Windows.Forms.Label();
            kodTipaLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingNavigator)).BeginInit();
            this.товарыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameOfTovaraLabel
            // 
            nameOfTovaraLabel.AutoSize = true;
            nameOfTovaraLabel.Location = new System.Drawing.Point(3, 0);
            nameOfTovaraLabel.Name = "nameOfTovaraLabel";
            nameOfTovaraLabel.Size = new System.Drawing.Size(117, 17);
            nameOfTovaraLabel.TabIndex = 0;
            nameOfTovaraLabel.Text = "Name Of Tovara:";
            // 
            // otdelLabel
            // 
            otdelLabel.AutoSize = true;
            otdelLabel.Location = new System.Drawing.Point(3, 27);
            otdelLabel.Name = "otdelLabel";
            otdelLabel.Size = new System.Drawing.Size(46, 17);
            otdelLabel.TabIndex = 2;
            otdelLabel.Text = "Otdel:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(3, 70);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(61, 17);
            countryLabel.TabIndex = 4;
            countryLabel.Text = "Country:";
            // 
            // usloviyaHranenyaLabel
            // 
            usloviyaHranenyaLabel.AutoSize = true;
            usloviyaHranenyaLabel.Location = new System.Drawing.Point(3, 137);
            usloviyaHranenyaLabel.Name = "usloviyaHranenyaLabel";
            usloviyaHranenyaLabel.Size = new System.Drawing.Size(131, 17);
            usloviyaHranenyaLabel.TabIndex = 6;
            usloviyaHranenyaLabel.Text = "Usloviya Hranenya:";
            // 
            // srokiHranenyaLabel
            // 
            srokiHranenyaLabel.AutoSize = true;
            srokiHranenyaLabel.Location = new System.Drawing.Point(3, 184);
            srokiHranenyaLabel.Name = "srokiHranenyaLabel";
            srokiHranenyaLabel.Size = new System.Drawing.Size(110, 17);
            srokiHranenyaLabel.TabIndex = 8;
            srokiHranenyaLabel.Text = "Sroki Hranenya:";
            // 
            // kodTipaLabel
            // 
            kodTipaLabel.AutoSize = true;
            kodTipaLabel.Location = new System.Drawing.Point(3, 221);
            kodTipaLabel.Name = "kodTipaLabel";
            kodTipaLabel.Size = new System.Drawing.Size(69, 17);
            kodTipaLabel.TabIndex = 10;
            kodTipaLabel.Text = "Kod Tipa:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(kodTipaLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.kodTipaTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(srokiHranenyaLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.srokiHranenyaTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(usloviyaHranenyaLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.usloviyaHranenyaTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(countryLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.countryTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(otdelLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.otdelTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(nameOfTovaraLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameOfTovaraTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(196, 137);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.24051F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.75949F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(436, 281);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // kodTipaTextBox
            // 
            this.kodTipaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "KodTipa", true));
            this.kodTipaTextBox.Location = new System.Drawing.Point(221, 224);
            this.kodTipaTextBox.Name = "kodTipaTextBox";
            this.kodTipaTextBox.Size = new System.Drawing.Size(199, 22);
            this.kodTipaTextBox.TabIndex = 11;
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.supermarketBaseDataSet;
            // 
            // supermarketBaseDataSet
            // 
            this.supermarketBaseDataSet.DataSetName = "SupermarketBaseDataSet";
            this.supermarketBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // srokiHranenyaTextBox
            // 
            this.srokiHranenyaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "SrokiHranenya", true));
            this.srokiHranenyaTextBox.Location = new System.Drawing.Point(221, 187);
            this.srokiHranenyaTextBox.Name = "srokiHranenyaTextBox";
            this.srokiHranenyaTextBox.Size = new System.Drawing.Size(199, 22);
            this.srokiHranenyaTextBox.TabIndex = 9;
            // 
            // usloviyaHranenyaTextBox
            // 
            this.usloviyaHranenyaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "UsloviyaHranenya", true));
            this.usloviyaHranenyaTextBox.Location = new System.Drawing.Point(221, 140);
            this.usloviyaHranenyaTextBox.Name = "usloviyaHranenyaTextBox";
            this.usloviyaHranenyaTextBox.Size = new System.Drawing.Size(199, 22);
            this.usloviyaHranenyaTextBox.TabIndex = 7;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(221, 73);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(199, 22);
            this.countryTextBox.TabIndex = 5;
            // 
            // otdelTextBox
            // 
            this.otdelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "Otdel", true));
            this.otdelTextBox.Location = new System.Drawing.Point(221, 30);
            this.otdelTextBox.Name = "otdelTextBox";
            this.otdelTextBox.Size = new System.Drawing.Size(199, 22);
            this.otdelTextBox.TabIndex = 3;
            // 
            // nameOfTovaraTextBox
            // 
            this.nameOfTovaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "NameOfTovara", true));
            this.nameOfTovaraTextBox.Location = new System.Drawing.Point(221, 3);
            this.nameOfTovaraTextBox.Name = "nameOfTovaraTextBox";
            this.nameOfTovaraTextBox.Size = new System.Drawing.Size(199, 22);
            this.nameOfTovaraTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(315, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отчет таблицы \"Товары\"";
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = supermarketBase.SupermarketBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.ОтделыTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Типы_товаровTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = this.товарыTableAdapter;
            // 
            // товарыBindingNavigator
            // 
            this.товарыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.товарыBindingNavigator.BindingSource = this.товарыBindingSource;
            this.товарыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.товарыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.товарыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.товарыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.товарыBindingNavigatorSaveItem});
            this.товарыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.товарыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.товарыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.товарыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.товарыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.товарыBindingNavigator.Name = "товарыBindingNavigator";
            this.товарыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.товарыBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.товарыBindingNavigator.TabIndex = 2;
            this.товарыBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // товарыBindingNavigatorSaveItem
            // 
            this.товарыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.товарыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("товарыBindingNavigatorSaveItem.Image")));
            this.товарыBindingNavigatorSaveItem.Name = "товарыBindingNavigatorSaveItem";
            this.товарыBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.товарыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.товарыBindingNavigatorSaveItem.Click += new System.EventHandler(this.товарыBindingNavigatorSaveItem_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.товарыBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form13";
            this.Text = "Form13";
            this.Load += new System.EventHandler(this.Form13_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingNavigator)).EndInit();
            this.товарыBindingNavigator.ResumeLayout(false);
            this.товарыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private SupermarketBaseDataSet supermarketBaseDataSet;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private SupermarketBaseDataSetTableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private SupermarketBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator товарыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton товарыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox kodTipaTextBox;
        private System.Windows.Forms.TextBox srokiHranenyaTextBox;
        private System.Windows.Forms.TextBox usloviyaHranenyaTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox otdelTextBox;
        private System.Windows.Forms.TextBox nameOfTovaraTextBox;
    }
}