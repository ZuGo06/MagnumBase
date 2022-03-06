
namespace supermarketBase
{
    partial class Form22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form22));
            System.Windows.Forms.Label kodPostavchikaLabel;
            System.Windows.Forms.Label kodKlientaLabel;
            System.Windows.Forms.Label kodSotrudnikaLabel;
            System.Windows.Forms.Label datePostuplenyaLabel;
            System.Windows.Forms.Label sposobDostavkiLabel;
            System.Windows.Forms.Label obemLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label nameOtdelaLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.supermarketBaseDataSet = new supermarketBase.SupermarketBaseDataSet();
            this.отделыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отделыTableAdapter = new supermarketBase.SupermarketBaseDataSetTableAdapters.ОтделыTableAdapter();
            this.tableAdapterManager = new supermarketBase.SupermarketBaseDataSetTableAdapters.TableAdapterManager();
            this.отделыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.отделыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kodPostavchikaTextBox = new System.Windows.Forms.TextBox();
            this.kodKlientaTextBox = new System.Windows.Forms.TextBox();
            this.kodSotrudnikaTextBox = new System.Windows.Forms.TextBox();
            this.datePostuplenyaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sposobDostavkiTextBox = new System.Windows.Forms.TextBox();
            this.obemTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.nameOtdelaTextBox = new System.Windows.Forms.TextBox();
            kodPostavchikaLabel = new System.Windows.Forms.Label();
            kodKlientaLabel = new System.Windows.Forms.Label();
            kodSotrudnikaLabel = new System.Windows.Forms.Label();
            datePostuplenyaLabel = new System.Windows.Forms.Label();
            sposobDostavkiLabel = new System.Windows.Forms.Label();
            obemLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            nameOtdelaLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделыBindingNavigator)).BeginInit();
            this.отделыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(285, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отчет таблицы \"Отделы\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(nameOtdelaLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.nameOtdelaTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(priceLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.priceTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(obemLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.obemTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(sposobDostavkiLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.sposobDostavkiTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(datePostuplenyaLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.datePostuplenyaDateTimePicker, 1, 3);
            this.tableLayoutPanel1.Controls.Add(kodSotrudnikaLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.kodSotrudnikaTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(kodKlientaLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.kodKlientaTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(kodPostavchikaLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kodPostavchikaTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(253, 107);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.19231F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.80769F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(481, 421);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // supermarketBaseDataSet
            // 
            this.supermarketBaseDataSet.DataSetName = "SupermarketBaseDataSet";
            this.supermarketBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отделыBindingSource
            // 
            this.отделыBindingSource.DataMember = "Отделы";
            this.отделыBindingSource.DataSource = this.supermarketBaseDataSet;
            // 
            // отделыTableAdapter
            // 
            this.отделыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = supermarketBase.SupermarketBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.ОтделыTableAdapter = this.отделыTableAdapter;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Типы_товаровTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // отделыBindingNavigator
            // 
            this.отделыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.отделыBindingNavigator.BindingSource = this.отделыBindingSource;
            this.отделыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.отделыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.отделыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.отделыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.отделыBindingNavigatorSaveItem});
            this.отделыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.отделыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.отделыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.отделыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.отделыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.отделыBindingNavigator.Name = "отделыBindingNavigator";
            this.отделыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.отделыBindingNavigator.Size = new System.Drawing.Size(965, 31);
            this.отделыBindingNavigator.TabIndex = 3;
            this.отделыBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
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
            // отделыBindingNavigatorSaveItem
            // 
            this.отделыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.отделыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("отделыBindingNavigatorSaveItem.Image")));
            this.отделыBindingNavigatorSaveItem.Name = "отделыBindingNavigatorSaveItem";
            this.отделыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.отделыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.отделыBindingNavigatorSaveItem.Click += new System.EventHandler(this.отделыBindingNavigatorSaveItem_Click);
            // 
            // kodPostavchikaLabel
            // 
            kodPostavchikaLabel.AutoSize = true;
            kodPostavchikaLabel.Location = new System.Drawing.Point(3, 0);
            kodPostavchikaLabel.Name = "kodPostavchikaLabel";
            kodPostavchikaLabel.Size = new System.Drawing.Size(117, 17);
            kodPostavchikaLabel.TabIndex = 0;
            kodPostavchikaLabel.Text = "Kod Postavchika:";
            // 
            // kodPostavchikaTextBox
            // 
            this.kodPostavchikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделыBindingSource, "KodPostavchika", true));
            this.kodPostavchikaTextBox.Location = new System.Drawing.Point(243, 3);
            this.kodPostavchikaTextBox.Name = "kodPostavchikaTextBox";
            this.kodPostavchikaTextBox.Size = new System.Drawing.Size(186, 22);
            this.kodPostavchikaTextBox.TabIndex = 1;
            // 
            // kodKlientaLabel
            // 
            kodKlientaLabel.AutoSize = true;
            kodKlientaLabel.Location = new System.Drawing.Point(3, 56);
            kodKlientaLabel.Name = "kodKlientaLabel";
            kodKlientaLabel.Size = new System.Drawing.Size(84, 17);
            kodKlientaLabel.TabIndex = 2;
            kodKlientaLabel.Text = "Kod Klienta:";
            // 
            // kodKlientaTextBox
            // 
            this.kodKlientaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделыBindingSource, "KodKlienta", true));
            this.kodKlientaTextBox.Location = new System.Drawing.Point(243, 59);
            this.kodKlientaTextBox.Name = "kodKlientaTextBox";
            this.kodKlientaTextBox.Size = new System.Drawing.Size(200, 22);
            this.kodKlientaTextBox.TabIndex = 3;
            // 
            // kodSotrudnikaLabel
            // 
            kodSotrudnikaLabel.AutoSize = true;
            kodSotrudnikaLabel.Location = new System.Drawing.Point(3, 125);
            kodSotrudnikaLabel.Name = "kodSotrudnikaLabel";
            kodSotrudnikaLabel.Size = new System.Drawing.Size(109, 17);
            kodSotrudnikaLabel.TabIndex = 4;
            kodSotrudnikaLabel.Text = "Kod Sotrudnika:";
            // 
            // kodSotrudnikaTextBox
            // 
            this.kodSotrudnikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделыBindingSource, "KodSotrudnika", true));
            this.kodSotrudnikaTextBox.Location = new System.Drawing.Point(243, 128);
            this.kodSotrudnikaTextBox.Name = "kodSotrudnikaTextBox";
            this.kodSotrudnikaTextBox.Size = new System.Drawing.Size(200, 22);
            this.kodSotrudnikaTextBox.TabIndex = 5;
            // 
            // datePostuplenyaLabel
            // 
            datePostuplenyaLabel.AutoSize = true;
            datePostuplenyaLabel.Location = new System.Drawing.Point(3, 199);
            datePostuplenyaLabel.Name = "datePostuplenyaLabel";
            datePostuplenyaLabel.Size = new System.Drawing.Size(124, 17);
            datePostuplenyaLabel.TabIndex = 6;
            datePostuplenyaLabel.Text = "Date Postuplenya:";
            // 
            // datePostuplenyaDateTimePicker
            // 
            this.datePostuplenyaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.отделыBindingSource, "DatePostuplenya", true));
            this.datePostuplenyaDateTimePicker.Location = new System.Drawing.Point(243, 202);
            this.datePostuplenyaDateTimePicker.Name = "datePostuplenyaDateTimePicker";
            this.datePostuplenyaDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.datePostuplenyaDateTimePicker.TabIndex = 7;
            // 
            // sposobDostavkiLabel
            // 
            sposobDostavkiLabel.AutoSize = true;
            sposobDostavkiLabel.Location = new System.Drawing.Point(3, 253);
            sposobDostavkiLabel.Name = "sposobDostavkiLabel";
            sposobDostavkiLabel.Size = new System.Drawing.Size(118, 17);
            sposobDostavkiLabel.TabIndex = 8;
            sposobDostavkiLabel.Text = "Sposob Dostavki:";
            // 
            // sposobDostavkiTextBox
            // 
            this.sposobDostavkiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделыBindingSource, "SposobDostavki", true));
            this.sposobDostavkiTextBox.Location = new System.Drawing.Point(243, 256);
            this.sposobDostavkiTextBox.Name = "sposobDostavkiTextBox";
            this.sposobDostavkiTextBox.Size = new System.Drawing.Size(200, 22);
            this.sposobDostavkiTextBox.TabIndex = 9;
            // 
            // obemLabel
            // 
            obemLabel.AutoSize = true;
            obemLabel.Location = new System.Drawing.Point(3, 310);
            obemLabel.Name = "obemLabel";
            obemLabel.Size = new System.Drawing.Size(50, 17);
            obemLabel.TabIndex = 10;
            obemLabel.Text = "Obem:";
            // 
            // obemTextBox
            // 
            this.obemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделыBindingSource, "Obem", true));
            this.obemTextBox.Location = new System.Drawing.Point(243, 313);
            this.obemTextBox.Name = "obemTextBox";
            this.obemTextBox.Size = new System.Drawing.Size(204, 22);
            this.obemTextBox.TabIndex = 11;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(3, 352);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(44, 17);
            priceLabel.TabIndex = 12;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделыBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(243, 355);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(204, 22);
            this.priceTextBox.TabIndex = 13;
            // 
            // nameOtdelaLabel
            // 
            nameOtdelaLabel.AutoSize = true;
            nameOtdelaLabel.Location = new System.Drawing.Point(3, 389);
            nameOtdelaLabel.Name = "nameOtdelaLabel";
            nameOtdelaLabel.Size = new System.Drawing.Size(95, 17);
            nameOtdelaLabel.TabIndex = 14;
            nameOtdelaLabel.Text = "Name Otdela:";
            // 
            // nameOtdelaTextBox
            // 
            this.nameOtdelaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделыBindingSource, "NameOtdela", true));
            this.nameOtdelaTextBox.Location = new System.Drawing.Point(243, 392);
            this.nameOtdelaTextBox.Name = "nameOtdelaTextBox";
            this.nameOtdelaTextBox.Size = new System.Drawing.Size(213, 22);
            this.nameOtdelaTextBox.TabIndex = 15;
            // 
            // Form22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 593);
            this.Controls.Add(this.отделыBindingNavigator);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form22";
            this.Text = "Form22";
            this.Load += new System.EventHandler(this.Form22_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделыBindingNavigator)).EndInit();
            this.отделыBindingNavigator.ResumeLayout(false);
            this.отделыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SupermarketBaseDataSet supermarketBaseDataSet;
        private System.Windows.Forms.BindingSource отделыBindingSource;
        private SupermarketBaseDataSetTableAdapters.ОтделыTableAdapter отделыTableAdapter;
        private SupermarketBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator отделыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton отделыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameOtdelaTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox obemTextBox;
        private System.Windows.Forms.TextBox sposobDostavkiTextBox;
        private System.Windows.Forms.DateTimePicker datePostuplenyaDateTimePicker;
        private System.Windows.Forms.TextBox kodSotrudnikaTextBox;
        private System.Windows.Forms.TextBox kodKlientaTextBox;
        private System.Windows.Forms.TextBox kodPostavchikaTextBox;
    }
}