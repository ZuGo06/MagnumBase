
namespace supermarketBase
{
    partial class Form17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form17));
            System.Windows.Forms.Label kodTovaraLabel;
            System.Windows.Forms.Label namePostavchikaLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label vidTransportaLabel;
            System.Windows.Forms.Label vidOplatyLabel;
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
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingNavigator)).BeginInit();
            this.поставщикиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(274, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Таблица \"Поставщики\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(632, 372);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 39);
            this.button9.TabIndex = 35;
            this.button9.Text = "Отчет";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(498, 374);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 37);
            this.button8.TabIndex = 34;
            this.button8.Text = "Таблица";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(368, 374);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 37);
            this.button7.TabIndex = 33;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(632, 327);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 34);
            this.button6.TabIndex = 32;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(498, 329);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 32);
            this.button5.TabIndex = 31;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(368, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 34);
            this.button4.TabIndex = 30;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(632, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 32);
            this.button3.TabIndex = 29;
            this.button3.Text = "Следующая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 33);
            this.button2.TabIndex = 28;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
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
            this.поставщикиBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.поставщикиBindingNavigator.TabIndex = 36;
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
            kodTovaraLabel.Location = new System.Drawing.Point(63, 137);
            kodTovaraLabel.Name = "kodTovaraLabel";
            kodTovaraLabel.Size = new System.Drawing.Size(86, 17);
            kodTovaraLabel.TabIndex = 36;
            kodTovaraLabel.Text = "Kod Tovara:";
            // 
            // kodTovaraTextBox
            // 
            this.kodTovaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "KodTovara", true));
            this.kodTovaraTextBox.Location = new System.Drawing.Point(155, 134);
            this.kodTovaraTextBox.Name = "kodTovaraTextBox";
            this.kodTovaraTextBox.Size = new System.Drawing.Size(162, 22);
            this.kodTovaraTextBox.TabIndex = 37;
            // 
            // namePostavchikaLabel
            // 
            namePostavchikaLabel.AutoSize = true;
            namePostavchikaLabel.Location = new System.Drawing.Point(69, 193);
            namePostavchikaLabel.Name = "namePostavchikaLabel";
            namePostavchikaLabel.Size = new System.Drawing.Size(129, 17);
            namePostavchikaLabel.TabIndex = 37;
            namePostavchikaLabel.Text = "Name Postavchika:";
            // 
            // namePostavchikaTextBox
            // 
            this.namePostavchikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "NamePostavchika", true));
            this.namePostavchikaTextBox.Location = new System.Drawing.Point(204, 190);
            this.namePostavchikaTextBox.Name = "namePostavchikaTextBox";
            this.namePostavchikaTextBox.Size = new System.Drawing.Size(154, 22);
            this.namePostavchikaTextBox.TabIndex = 38;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(78, 262);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(61, 17);
            countryLabel.TabIndex = 38;
            countryLabel.Text = "Country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(145, 259);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(145, 22);
            this.countryTextBox.TabIndex = 39;
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(74, 331);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(56, 17);
            adressLabel.TabIndex = 39;
            adressLabel.Text = "Adress:";
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(136, 328);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(168, 22);
            this.adressTextBox.TabIndex = 40;
            // 
            // vidTransportaLabel
            // 
            vidTransportaLabel.AutoSize = true;
            vidTransportaLabel.Location = new System.Drawing.Point(470, 133);
            vidTransportaLabel.Name = "vidTransportaLabel";
            vidTransportaLabel.Size = new System.Drawing.Size(106, 17);
            vidTransportaLabel.TabIndex = 40;
            vidTransportaLabel.Text = "Vid Transporta:";
            // 
            // vidTransportaTextBox
            // 
            this.vidTransportaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "VidTransporta", true));
            this.vidTransportaTextBox.Location = new System.Drawing.Point(582, 130);
            this.vidTransportaTextBox.Name = "vidTransportaTextBox";
            this.vidTransportaTextBox.Size = new System.Drawing.Size(181, 22);
            this.vidTransportaTextBox.TabIndex = 41;
            // 
            // vidOplatyLabel
            // 
            vidOplatyLabel.AutoSize = true;
            vidOplatyLabel.Location = new System.Drawing.Point(471, 187);
            vidOplatyLabel.Name = "vidOplatyLabel";
            vidOplatyLabel.Size = new System.Drawing.Size(77, 17);
            vidOplatyLabel.TabIndex = 41;
            vidOplatyLabel.Text = "Vid Oplaty:";
            // 
            // vidOplatyTextBox
            // 
            this.vidOplatyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "VidOplaty", true));
            this.vidOplatyTextBox.Location = new System.Drawing.Point(554, 184);
            this.vidOplatyTextBox.Name = "vidOplatyTextBox";
            this.vidOplatyTextBox.Size = new System.Drawing.Size(170, 22);
            this.vidOplatyTextBox.TabIndex = 42;
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(vidOplatyLabel);
            this.Controls.Add(this.vidOplatyTextBox);
            this.Controls.Add(vidTransportaLabel);
            this.Controls.Add(this.vidTransportaTextBox);
            this.Controls.Add(adressLabel);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(namePostavchikaLabel);
            this.Controls.Add(this.namePostavchikaTextBox);
            this.Controls.Add(kodTovaraLabel);
            this.Controls.Add(this.kodTovaraTextBox);
            this.Controls.Add(this.поставщикиBindingNavigator);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form17";
            this.Text = "Form17";
            this.Load += new System.EventHandler(this.Form17_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingNavigator)).EndInit();
            this.поставщикиBindingNavigator.ResumeLayout(false);
            this.поставщикиBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox kodTovaraTextBox;
        private System.Windows.Forms.TextBox namePostavchikaTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox vidTransportaTextBox;
        private System.Windows.Forms.TextBox vidOplatyTextBox;
    }
}