
namespace supermarketBase
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            System.Windows.Forms.Label nameOfTovaraLabel;
            System.Windows.Forms.Label otdelLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label usloviyaHranenyaLabel;
            System.Windows.Forms.Label srokiHranenyaLabel;
            System.Windows.Forms.Label kodTipaLabel;
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.supermarketBaseDataSet = new supermarketBase.SupermarketBaseDataSet();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарыTableAdapter = new supermarketBase.SupermarketBaseDataSetTableAdapters.ТоварыTableAdapter();
            this.tableAdapterManager = new supermarketBase.SupermarketBaseDataSetTableAdapters.TableAdapterManager();
            this.товарыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.товарыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameOfTovaraTextBox = new System.Windows.Forms.TextBox();
            this.otdelTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.usloviyaHranenyaTextBox = new System.Windows.Forms.TextBox();
            this.srokiHranenyaTextBox = new System.Windows.Forms.TextBox();
            this.kodTipaTextBox = new System.Windows.Forms.TextBox();
            nameOfTovaraLabel = new System.Windows.Forms.Label();
            otdelLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            usloviyaHranenyaLabel = new System.Windows.Forms.Label();
            srokiHranenyaLabel = new System.Windows.Forms.Label();
            kodTipaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingNavigator)).BeginInit();
            this.товарыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(779, 404);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(113, 40);
            this.button9.TabIndex = 35;
            this.button9.Text = "Отчет";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(645, 406);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 38);
            this.button8.TabIndex = 34;
            this.button8.Text = "Таблица";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(515, 406);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 38);
            this.button7.TabIndex = 33;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(779, 359);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 35);
            this.button6.TabIndex = 32;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(645, 361);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 33);
            this.button5.TabIndex = 31;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(515, 359);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 35);
            this.button4.TabIndex = 30;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(779, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 33);
            this.button3.TabIndex = 29;
            this.button3.Text = "Следующая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 28;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 27;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(342, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Таблица \"Товары\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // supermarketBaseDataSet
            // 
            this.supermarketBaseDataSet.DataSetName = "SupermarketBaseDataSet";
            this.supermarketBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.supermarketBaseDataSet;
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
            this.товарыBindingNavigator.Size = new System.Drawing.Size(963, 31);
            this.товарыBindingNavigator.TabIndex = 37;
            this.товарыBindingNavigator.Text = "bindingNavigator1";
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
            // товарыBindingNavigatorSaveItem
            // 
            this.товарыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.товарыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("товарыBindingNavigatorSaveItem.Image")));
            this.товарыBindingNavigatorSaveItem.Name = "товарыBindingNavigatorSaveItem";
            this.товарыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.товарыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.товарыBindingNavigatorSaveItem.Click += new System.EventHandler(this.товарыBindingNavigatorSaveItem_Click);
            // 
            // nameOfTovaraLabel
            // 
            nameOfTovaraLabel.AutoSize = true;
            nameOfTovaraLabel.Location = new System.Drawing.Point(105, 142);
            nameOfTovaraLabel.Name = "nameOfTovaraLabel";
            nameOfTovaraLabel.Size = new System.Drawing.Size(117, 17);
            nameOfTovaraLabel.TabIndex = 37;
            nameOfTovaraLabel.Text = "Name Of Tovara:";
            // 
            // nameOfTovaraTextBox
            // 
            this.nameOfTovaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "NameOfTovara", true));
            this.nameOfTovaraTextBox.Location = new System.Drawing.Point(228, 139);
            this.nameOfTovaraTextBox.Name = "nameOfTovaraTextBox";
            this.nameOfTovaraTextBox.Size = new System.Drawing.Size(164, 22);
            this.nameOfTovaraTextBox.TabIndex = 38;
            // 
            // otdelLabel
            // 
            otdelLabel.AutoSize = true;
            otdelLabel.Location = new System.Drawing.Point(107, 209);
            otdelLabel.Name = "otdelLabel";
            otdelLabel.Size = new System.Drawing.Size(46, 17);
            otdelLabel.TabIndex = 38;
            otdelLabel.Text = "Otdel:";
            // 
            // otdelTextBox
            // 
            this.otdelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "Otdel", true));
            this.otdelTextBox.Location = new System.Drawing.Point(159, 206);
            this.otdelTextBox.Name = "otdelTextBox";
            this.otdelTextBox.Size = new System.Drawing.Size(208, 22);
            this.otdelTextBox.TabIndex = 39;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(107, 296);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(61, 17);
            countryLabel.TabIndex = 39;
            countryLabel.Text = "Country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(174, 293);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 22);
            this.countryTextBox.TabIndex = 40;
            // 
            // usloviyaHranenyaLabel
            // 
            usloviyaHranenyaLabel.AutoSize = true;
            usloviyaHranenyaLabel.Location = new System.Drawing.Point(108, 395);
            usloviyaHranenyaLabel.Name = "usloviyaHranenyaLabel";
            usloviyaHranenyaLabel.Size = new System.Drawing.Size(131, 17);
            usloviyaHranenyaLabel.TabIndex = 40;
            usloviyaHranenyaLabel.Text = "Usloviya Hranenya:";
            // 
            // usloviyaHranenyaTextBox
            // 
            this.usloviyaHranenyaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "UsloviyaHranenya", true));
            this.usloviyaHranenyaTextBox.Location = new System.Drawing.Point(245, 392);
            this.usloviyaHranenyaTextBox.Name = "usloviyaHranenyaTextBox";
            this.usloviyaHranenyaTextBox.Size = new System.Drawing.Size(163, 22);
            this.usloviyaHranenyaTextBox.TabIndex = 41;
            // 
            // srokiHranenyaLabel
            // 
            srokiHranenyaLabel.AutoSize = true;
            srokiHranenyaLabel.Location = new System.Drawing.Point(526, 132);
            srokiHranenyaLabel.Name = "srokiHranenyaLabel";
            srokiHranenyaLabel.Size = new System.Drawing.Size(110, 17);
            srokiHranenyaLabel.TabIndex = 41;
            srokiHranenyaLabel.Text = "Sroki Hranenya:";
            // 
            // srokiHranenyaTextBox
            // 
            this.srokiHranenyaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "SrokiHranenya", true));
            this.srokiHranenyaTextBox.Location = new System.Drawing.Point(642, 129);
            this.srokiHranenyaTextBox.Name = "srokiHranenyaTextBox";
            this.srokiHranenyaTextBox.Size = new System.Drawing.Size(182, 22);
            this.srokiHranenyaTextBox.TabIndex = 42;
            // 
            // kodTipaLabel
            // 
            kodTipaLabel.AutoSize = true;
            kodTipaLabel.Location = new System.Drawing.Point(536, 197);
            kodTipaLabel.Name = "kodTipaLabel";
            kodTipaLabel.Size = new System.Drawing.Size(69, 17);
            kodTipaLabel.TabIndex = 42;
            kodTipaLabel.Text = "Kod Tipa:";
            // 
            // kodTipaTextBox
            // 
            this.kodTipaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "KodTipa", true));
            this.kodTipaTextBox.Location = new System.Drawing.Point(611, 194);
            this.kodTipaTextBox.Name = "kodTipaTextBox";
            this.kodTipaTextBox.Size = new System.Drawing.Size(152, 22);
            this.kodTipaTextBox.TabIndex = 43;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 521);
            this.Controls.Add(kodTipaLabel);
            this.Controls.Add(this.kodTipaTextBox);
            this.Controls.Add(srokiHranenyaLabel);
            this.Controls.Add(this.srokiHranenyaTextBox);
            this.Controls.Add(usloviyaHranenyaLabel);
            this.Controls.Add(this.usloviyaHranenyaTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(otdelLabel);
            this.Controls.Add(this.otdelTextBox);
            this.Controls.Add(nameOfTovaraLabel);
            this.Controls.Add(this.nameOfTovaraTextBox);
            this.Controls.Add(this.товарыBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingNavigator)).EndInit();
            this.товарыBindingNavigator.ResumeLayout(false);
            this.товарыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.TextBox nameOfTovaraTextBox;
        private System.Windows.Forms.TextBox otdelTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox usloviyaHranenyaTextBox;
        private System.Windows.Forms.TextBox srokiHranenyaTextBox;
        private System.Windows.Forms.TextBox kodTipaTextBox;
    }
}