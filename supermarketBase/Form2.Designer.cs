
namespace supermarketBase
{
    partial class Form2
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
            System.Windows.Forms.Label kodDolzhnostiLabel;
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label god_RozhdenyaLabel;
            System.Windows.Forms.Label god_Postuplenya_Na_RabotuLabel;
            System.Windows.Forms.Label stazhLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.supermarketBaseDataSet = new supermarketBase.SupermarketBaseDataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new supermarketBase.SupermarketBaseDataSetTableAdapters.СотрудникиTableAdapter();
            this.tableAdapterManager = new supermarketBase.SupermarketBaseDataSetTableAdapters.TableAdapterManager();
            this.сотрудникиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.сотрудникиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kodDolzhnostiTextBox = new System.Windows.Forms.TextBox();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.god_RozhdenyaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.god_Postuplenya_Na_RabotuDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stazhTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            kodDolzhnostiLabel = new System.Windows.Forms.Label();
            fIOLabel = new System.Windows.Forms.Label();
            god_RozhdenyaLabel = new System.Windows.Forms.Label();
            god_Postuplenya_Na_RabotuLabel = new System.Windows.Forms.Label();
            stazhLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingNavigator)).BeginInit();
            this.сотрудникиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // kodDolzhnostiLabel
            // 
            kodDolzhnostiLabel.AutoSize = true;
            kodDolzhnostiLabel.Location = new System.Drawing.Point(97, 165);
            kodDolzhnostiLabel.Name = "kodDolzhnostiLabel";
            kodDolzhnostiLabel.Size = new System.Drawing.Size(107, 17);
            kodDolzhnostiLabel.TabIndex = 1;
            kodDolzhnostiLabel.Text = "Kod Dolzhnosti:";
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(170, 214);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(34, 17);
            fIOLabel.TabIndex = 3;
            fIOLabel.Text = "FIO:";
            // 
            // god_RozhdenyaLabel
            // 
            god_RozhdenyaLabel.AutoSize = true;
            god_RozhdenyaLabel.Location = new System.Drawing.Point(89, 265);
            god_RozhdenyaLabel.Name = "god_RozhdenyaLabel";
            god_RozhdenyaLabel.Size = new System.Drawing.Size(115, 17);
            god_RozhdenyaLabel.TabIndex = 5;
            god_RozhdenyaLabel.Text = "God Rozhdenya:";
            // 
            // god_Postuplenya_Na_RabotuLabel
            // 
            god_Postuplenya_Na_RabotuLabel.AutoSize = true;
            god_Postuplenya_Na_RabotuLabel.Location = new System.Drawing.Point(12, 327);
            god_Postuplenya_Na_RabotuLabel.Name = "god_Postuplenya_Na_RabotuLabel";
            god_Postuplenya_Na_RabotuLabel.Size = new System.Drawing.Size(193, 17);
            god_Postuplenya_Na_RabotuLabel.TabIndex = 7;
            god_Postuplenya_Na_RabotuLabel.Text = "God Postuplenya Na Rabotu:";
            // 
            // stazhLabel
            // 
            stazhLabel.AutoSize = true;
            stazhLabel.Location = new System.Drawing.Point(156, 377);
            stazhLabel.Name = "stazhLabel";
            stazhLabel.Size = new System.Drawing.Size(48, 17);
            stazhLabel.TabIndex = 9;
            stazhLabel.Text = "Stazh:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(145, 422);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(60, 17);
            genderLabel.TabIndex = 11;
            genderLabel.Text = "Gender:";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(459, 165);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(56, 17);
            adressLabel.TabIndex = 13;
            adressLabel.Text = "Adress:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(459, 217);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(80, 17);
            telephoneLabel.TabIndex = 15;
            telephoneLabel.Text = "Telephone:";
            // 
            // supermarketBaseDataSet
            // 
            this.supermarketBaseDataSet.DataSetName = "SupermarketBaseDataSet";
            this.supermarketBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.supermarketBaseDataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = supermarketBase.SupermarketBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.ОтделыTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            this.tableAdapterManager.Типы_товаровTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // сотрудникиBindingNavigator
            // 
            this.сотрудникиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.сотрудникиBindingNavigator.BindingSource = this.сотрудникиBindingSource;
            this.сотрудникиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.сотрудникиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.сотрудникиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.сотрудникиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.сотрудникиBindingNavigatorSaveItem});
            this.сотрудникиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.сотрудникиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.сотрудникиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.сотрудникиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.сотрудникиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.сотрудникиBindingNavigator.Name = "сотрудникиBindingNavigator";
            this.сотрудникиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.сотрудникиBindingNavigator.Size = new System.Drawing.Size(1022, 31);
            this.сотрудникиBindingNavigator.TabIndex = 0;
            this.сотрудникиBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // сотрудникиBindingNavigatorSaveItem
            // 
            this.сотрудникиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сотрудникиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("сотрудникиBindingNavigatorSaveItem.Image")));
            this.сотрудникиBindingNavigatorSaveItem.Name = "сотрудникиBindingNavigatorSaveItem";
            this.сотрудникиBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.сотрудникиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.сотрудникиBindingNavigatorSaveItem.Click += new System.EventHandler(this.сотрудникиBindingNavigatorSaveItem_Click);
            // 
            // kodDolzhnostiTextBox
            // 
            this.kodDolzhnostiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "KodDolzhnosti", true));
            this.kodDolzhnostiTextBox.Location = new System.Drawing.Point(232, 165);
            this.kodDolzhnostiTextBox.Name = "kodDolzhnostiTextBox";
            this.kodDolzhnostiTextBox.Size = new System.Drawing.Size(100, 22);
            this.kodDolzhnostiTextBox.TabIndex = 2;
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "FIO", true));
            this.fIOTextBox.Location = new System.Drawing.Point(232, 214);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(100, 22);
            this.fIOTextBox.TabIndex = 4;
            // 
            // god_RozhdenyaDateTimePicker
            // 
            this.god_RozhdenyaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.сотрудникиBindingSource, "God_Rozhdenya", true));
            this.god_RozhdenyaDateTimePicker.Location = new System.Drawing.Point(232, 265);
            this.god_RozhdenyaDateTimePicker.Name = "god_RozhdenyaDateTimePicker";
            this.god_RozhdenyaDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.god_RozhdenyaDateTimePicker.TabIndex = 6;
            // 
            // god_Postuplenya_Na_RabotuDateTimePicker
            // 
            this.god_Postuplenya_Na_RabotuDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.сотрудникиBindingSource, "God_Postuplenya_Na_Rabotu", true));
            this.god_Postuplenya_Na_RabotuDateTimePicker.Location = new System.Drawing.Point(232, 327);
            this.god_Postuplenya_Na_RabotuDateTimePicker.Name = "god_Postuplenya_Na_RabotuDateTimePicker";
            this.god_Postuplenya_Na_RabotuDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.god_Postuplenya_Na_RabotuDateTimePicker.TabIndex = 8;
            // 
            // stazhTextBox
            // 
            this.stazhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Stazh", true));
            this.stazhTextBox.Location = new System.Drawing.Point(232, 377);
            this.stazhTextBox.Name = "stazhTextBox";
            this.stazhTextBox.Size = new System.Drawing.Size(100, 22);
            this.stazhTextBox.TabIndex = 10;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(232, 422);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(100, 22);
            this.genderTextBox.TabIndex = 12;
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(547, 165);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(139, 22);
            this.adressTextBox.TabIndex = 14;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(547, 214);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(140, 22);
            this.telephoneTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(372, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Таблица \"Сотрудники\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(662, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(796, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 33);
            this.button3.TabIndex = 20;
            this.button3.Text = "Следующая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(532, 375);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 35);
            this.button4.TabIndex = 21;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(662, 377);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 33);
            this.button5.TabIndex = 22;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(796, 375);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 35);
            this.button6.TabIndex = 23;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(532, 422);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 38);
            this.button7.TabIndex = 24;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(662, 422);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 38);
            this.button8.TabIndex = 25;
            this.button8.Text = "Таблица";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(796, 420);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(113, 40);
            this.button9.TabIndex = 26;
            this.button9.Text = "Отчет";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 483);
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
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(adressLabel);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(stazhLabel);
            this.Controls.Add(this.stazhTextBox);
            this.Controls.Add(god_Postuplenya_Na_RabotuLabel);
            this.Controls.Add(this.god_Postuplenya_Na_RabotuDateTimePicker);
            this.Controls.Add(god_RozhdenyaLabel);
            this.Controls.Add(this.god_RozhdenyaDateTimePicker);
            this.Controls.Add(fIOLabel);
            this.Controls.Add(this.fIOTextBox);
            this.Controls.Add(kodDolzhnostiLabel);
            this.Controls.Add(this.kodDolzhnostiTextBox);
            this.Controls.Add(this.сотрудникиBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingNavigator)).EndInit();
            this.сотрудникиBindingNavigator.ResumeLayout(false);
            this.сотрудникиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SupermarketBaseDataSet supermarketBaseDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private SupermarketBaseDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private SupermarketBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator сотрудникиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton сотрудникиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox kodDolzhnostiTextBox;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.DateTimePicker god_RozhdenyaDateTimePicker;
        private System.Windows.Forms.DateTimePicker god_Postuplenya_Na_RabotuDateTimePicker;
        private System.Windows.Forms.TextBox stazhTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}