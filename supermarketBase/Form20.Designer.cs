
namespace supermarketBase
{
    partial class Form20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form20));
            System.Windows.Forms.Label kodPostavchikaLabel;
            System.Windows.Forms.Label kodKlientaLabel;
            System.Windows.Forms.Label kodSotrudnikaLabel;
            System.Windows.Forms.Label datePostuplenyaLabel;
            System.Windows.Forms.Label sposobDostavkiLabel;
            System.Windows.Forms.Label obemLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label nameOtdelaLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделыBindingNavigator)).BeginInit();
            this.отделыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(305, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Таблица \"Отделы\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(744, 498);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(113, 40);
            this.button9.TabIndex = 35;
            this.button9.Text = "Отчет";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(610, 500);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 38);
            this.button8.TabIndex = 34;
            this.button8.Text = "Таблица";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(480, 500);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 38);
            this.button7.TabIndex = 33;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(744, 453);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 35);
            this.button6.TabIndex = 32;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(610, 455);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 33);
            this.button5.TabIndex = 31;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(480, 453);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 35);
            this.button4.TabIndex = 30;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(744, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 33);
            this.button3.TabIndex = 29;
            this.button3.Text = "Следующая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 28;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 27;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.отделыBindingNavigator.Size = new System.Drawing.Size(909, 27);
            this.отделыBindingNavigator.TabIndex = 36;
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
            kodPostavchikaLabel.Location = new System.Drawing.Point(44, 103);
            kodPostavchikaLabel.Name = "kodPostavchikaLabel";
            kodPostavchikaLabel.Size = new System.Drawing.Size(117, 17);
            kodPostavchikaLabel.TabIndex = 36;
            kodPostavchikaLabel.Text = "Kod Postavchika:";
            // 
            // kodPostavchikaTextBox
            // 
            this.kodPostavchikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделыBindingSource, "KodPostavchika", true));
            this.kodPostavchikaTextBox.Location = new System.Drawing.Point(167, 100);
            this.kodPostavchikaTextBox.Name = "kodPostavchikaTextBox";
            this.kodPostavchikaTextBox.Size = new System.Drawing.Size(100, 22);
            this.kodPostavchikaTextBox.TabIndex = 37;
            // 
            // kodKlientaLabel
            // 
            kodKlientaLabel.AutoSize = true;
            kodKlientaLabel.Location = new System.Drawing.Point(46, 155);
            kodKlientaLabel.Name = "kodKlientaLabel";
            kodKlientaLabel.Size = new System.Drawing.Size(84, 17);
            kodKlientaLabel.TabIndex = 37;
            kodKlientaLabel.Text = "Kod Klienta:";
            // 
            // kodKlientaTextBox
            // 
            this.kodKlientaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделыBindingSource, "KodKlienta", true));
            this.kodKlientaTextBox.Location = new System.Drawing.Point(136, 152);
            this.kodKlientaTextBox.Name = "kodKlientaTextBox";
            this.kodKlientaTextBox.Size = new System.Drawing.Size(100, 22);
            this.kodKlientaTextBox.TabIndex = 38;
            // 
            // kodSotrudnikaLabel
            // 
            kodSotrudnikaLabel.AutoSize = true;
            kodSotrudnikaLabel.Location = new System.Drawing.Point(47, 215);
            kodSotrudnikaLabel.Name = "kodSotrudnikaLabel";
            kodSotrudnikaLabel.Size = new System.Drawing.Size(109, 17);
            kodSotrudnikaLabel.TabIndex = 38;
            kodSotrudnikaLabel.Text = "Kod Sotrudnika:";
            // 
            // kodSotrudnikaTextBox
            // 
            this.kodSotrudnikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделыBindingSource, "KodSotrudnika", true));
            this.kodSotrudnikaTextBox.Location = new System.Drawing.Point(162, 212);
            this.kodSotrudnikaTextBox.Name = "kodSotrudnikaTextBox";
            this.kodSotrudnikaTextBox.Size = new System.Drawing.Size(100, 22);
            this.kodSotrudnikaTextBox.TabIndex = 39;
            // 
            // datePostuplenyaLabel
            // 
            datePostuplenyaLabel.AutoSize = true;
            datePostuplenyaLabel.Location = new System.Drawing.Point(47, 285);
            datePostuplenyaLabel.Name = "datePostuplenyaLabel";
            datePostuplenyaLabel.Size = new System.Drawing.Size(124, 17);
            datePostuplenyaLabel.TabIndex = 39;
            datePostuplenyaLabel.Text = "Date Postuplenya:";
            // 
            // datePostuplenyaDateTimePicker
            // 
            this.datePostuplenyaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.отделыBindingSource, "DatePostuplenya", true));
            this.datePostuplenyaDateTimePicker.Location = new System.Drawing.Point(177, 281);
            this.datePostuplenyaDateTimePicker.Name = "datePostuplenyaDateTimePicker";
            this.datePostuplenyaDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.datePostuplenyaDateTimePicker.TabIndex = 40;
            // 
            // sposobDostavkiLabel
            // 
            sposobDostavkiLabel.AutoSize = true;
            sposobDostavkiLabel.Location = new System.Drawing.Point(64, 365);
            sposobDostavkiLabel.Name = "sposobDostavkiLabel";
            sposobDostavkiLabel.Size = new System.Drawing.Size(118, 17);
            sposobDostavkiLabel.TabIndex = 40;
            sposobDostavkiLabel.Text = "Sposob Dostavki:";
            // 
            // sposobDostavkiTextBox
            // 
            this.sposobDostavkiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделыBindingSource, "SposobDostavki", true));
            this.sposobDostavkiTextBox.Location = new System.Drawing.Point(188, 362);
            this.sposobDostavkiTextBox.Name = "sposobDostavkiTextBox";
            this.sposobDostavkiTextBox.Size = new System.Drawing.Size(167, 22);
            this.sposobDostavkiTextBox.TabIndex = 41;
            // 
            // obemLabel
            // 
            obemLabel.AutoSize = true;
            obemLabel.Location = new System.Drawing.Point(482, 104);
            obemLabel.Name = "obemLabel";
            obemLabel.Size = new System.Drawing.Size(50, 17);
            obemLabel.TabIndex = 41;
            obemLabel.Text = "Obem:";
            // 
            // obemTextBox
            // 
            this.obemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделыBindingSource, "Obem", true));
            this.obemTextBox.Location = new System.Drawing.Point(538, 101);
            this.obemTextBox.Name = "obemTextBox";
            this.obemTextBox.Size = new System.Drawing.Size(204, 22);
            this.obemTextBox.TabIndex = 42;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(480, 172);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(44, 17);
            priceLabel.TabIndex = 42;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделыBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(530, 169);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(204, 22);
            this.priceTextBox.TabIndex = 43;
            // 
            // nameOtdelaLabel
            // 
            nameOtdelaLabel.AutoSize = true;
            nameOtdelaLabel.Location = new System.Drawing.Point(483, 242);
            nameOtdelaLabel.Name = "nameOtdelaLabel";
            nameOtdelaLabel.Size = new System.Drawing.Size(95, 17);
            nameOtdelaLabel.TabIndex = 43;
            nameOtdelaLabel.Text = "Name Otdela:";
            // 
            // nameOtdelaTextBox
            // 
            this.nameOtdelaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделыBindingSource, "NameOtdela", true));
            this.nameOtdelaTextBox.Location = new System.Drawing.Point(584, 239);
            this.nameOtdelaTextBox.Name = "nameOtdelaTextBox";
            this.nameOtdelaTextBox.Size = new System.Drawing.Size(189, 22);
            this.nameOtdelaTextBox.TabIndex = 44;
            // 
            // Form20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 623);
            this.Controls.Add(nameOtdelaLabel);
            this.Controls.Add(this.nameOtdelaTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(obemLabel);
            this.Controls.Add(this.obemTextBox);
            this.Controls.Add(sposobDostavkiLabel);
            this.Controls.Add(this.sposobDostavkiTextBox);
            this.Controls.Add(datePostuplenyaLabel);
            this.Controls.Add(this.datePostuplenyaDateTimePicker);
            this.Controls.Add(kodSotrudnikaLabel);
            this.Controls.Add(this.kodSotrudnikaTextBox);
            this.Controls.Add(kodKlientaLabel);
            this.Controls.Add(this.kodKlientaTextBox);
            this.Controls.Add(kodPostavchikaLabel);
            this.Controls.Add(this.kodPostavchikaTextBox);
            this.Controls.Add(this.отделыBindingNavigator);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form20";
            this.Text = "Form20";
            this.Load += new System.EventHandler(this.Form20_Load);
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
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.TextBox kodPostavchikaTextBox;
        private System.Windows.Forms.TextBox kodKlientaTextBox;
        private System.Windows.Forms.TextBox kodSotrudnikaTextBox;
        private System.Windows.Forms.DateTimePicker datePostuplenyaDateTimePicker;
        private System.Windows.Forms.TextBox sposobDostavkiTextBox;
        private System.Windows.Forms.TextBox obemTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox nameOtdelaTextBox;
    }
}