
namespace supermarketBase
{
    partial class Form4
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
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label god_RozhdenyaLabel;
            System.Windows.Forms.Label god_Postuplenya_Na_RabotuLabel;
            System.Windows.Forms.Label stazhLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supermarketBaseDataSet = new supermarketBase.SupermarketBaseDataSet();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.stazhTextBox = new System.Windows.Forms.TextBox();
            this.god_Postuplenya_Na_RabotuDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.god_RozhdenyaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
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
            fIOLabel = new System.Windows.Forms.Label();
            god_RozhdenyaLabel = new System.Windows.Forms.Label();
            god_Postuplenya_Na_RabotuLabel = new System.Windows.Forms.Label();
            stazhLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingNavigator)).BeginInit();
            this.сотрудникиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(3, 0);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(34, 17);
            fIOLabel.TabIndex = 0;
            fIOLabel.Text = "FIO:";
            // 
            // god_RozhdenyaLabel
            // 
            god_RozhdenyaLabel.AutoSize = true;
            god_RozhdenyaLabel.Location = new System.Drawing.Point(3, 28);
            god_RozhdenyaLabel.Name = "god_RozhdenyaLabel";
            god_RozhdenyaLabel.Size = new System.Drawing.Size(115, 17);
            god_RozhdenyaLabel.TabIndex = 2;
            god_RozhdenyaLabel.Text = "God Rozhdenya:";
            // 
            // god_Postuplenya_Na_RabotuLabel
            // 
            god_Postuplenya_Na_RabotuLabel.AutoSize = true;
            god_Postuplenya_Na_RabotuLabel.Location = new System.Drawing.Point(3, 63);
            god_Postuplenya_Na_RabotuLabel.Name = "god_Postuplenya_Na_RabotuLabel";
            god_Postuplenya_Na_RabotuLabel.Size = new System.Drawing.Size(193, 17);
            god_Postuplenya_Na_RabotuLabel.TabIndex = 4;
            god_Postuplenya_Na_RabotuLabel.Text = "God Postuplenya Na Rabotu:";
            // 
            // stazhLabel
            // 
            stazhLabel.AutoSize = true;
            stazhLabel.Location = new System.Drawing.Point(3, 122);
            stazhLabel.Name = "stazhLabel";
            stazhLabel.Size = new System.Drawing.Size(48, 17);
            stazhLabel.TabIndex = 6;
            stazhLabel.Text = "Stazh:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(3, 175);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(60, 17);
            genderLabel.TabIndex = 8;
            genderLabel.Text = "Gender:";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(3, 226);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(56, 17);
            adressLabel.TabIndex = 10;
            adressLabel.Text = "Adress:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(3, 268);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(80, 17);
            telephoneLabel.TabIndex = 12;
            telephoneLabel.Text = "Telephone:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(341, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отчет таблицы \"Сотрудники\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(telephoneLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.telephoneTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(adressLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.adressTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(genderLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.genderTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(stazhLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.stazhTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(god_Postuplenya_Na_RabotuLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.god_Postuplenya_Na_RabotuDateTimePicker, 1, 2);
            this.tableLayoutPanel1.Controls.Add(god_RozhdenyaLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.god_RozhdenyaDateTimePicker, 1, 1);
            this.tableLayoutPanel1.Controls.Add(fIOLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fIOTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(346, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.85965F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.14035F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 314);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(203, 271);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(194, 22);
            this.telephoneTextBox.TabIndex = 13;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.supermarketBaseDataSet;
            // 
            // supermarketBaseDataSet
            // 
            this.supermarketBaseDataSet.DataSetName = "SupermarketBaseDataSet";
            this.supermarketBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(203, 229);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(194, 22);
            this.adressTextBox.TabIndex = 11;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(203, 178);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(194, 22);
            this.genderTextBox.TabIndex = 9;
            // 
            // stazhTextBox
            // 
            this.stazhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Stazh", true));
            this.stazhTextBox.Location = new System.Drawing.Point(203, 125);
            this.stazhTextBox.Name = "stazhTextBox";
            this.stazhTextBox.Size = new System.Drawing.Size(194, 22);
            this.stazhTextBox.TabIndex = 7;
            // 
            // god_Postuplenya_Na_RabotuDateTimePicker
            // 
            this.god_Postuplenya_Na_RabotuDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.сотрудникиBindingSource, "God_Postuplenya_Na_Rabotu", true));
            this.god_Postuplenya_Na_RabotuDateTimePicker.Location = new System.Drawing.Point(203, 66);
            this.god_Postuplenya_Na_RabotuDateTimePicker.Name = "god_Postuplenya_Na_RabotuDateTimePicker";
            this.god_Postuplenya_Na_RabotuDateTimePicker.Size = new System.Drawing.Size(194, 22);
            this.god_Postuplenya_Na_RabotuDateTimePicker.TabIndex = 5;
            // 
            // god_RozhdenyaDateTimePicker
            // 
            this.god_RozhdenyaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.сотрудникиBindingSource, "God_Rozhdenya", true));
            this.god_RozhdenyaDateTimePicker.Location = new System.Drawing.Point(203, 31);
            this.god_RozhdenyaDateTimePicker.Name = "god_RozhdenyaDateTimePicker";
            this.god_RozhdenyaDateTimePicker.Size = new System.Drawing.Size(194, 22);
            this.god_RozhdenyaDateTimePicker.TabIndex = 3;
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "FIO", true));
            this.fIOTextBox.Location = new System.Drawing.Point(203, 3);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(194, 22);
            this.fIOTextBox.TabIndex = 1;
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
            this.сотрудникиBindingNavigator.Size = new System.Drawing.Size(999, 31);
            this.сотрудникиBindingNavigator.TabIndex = 2;
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 487);
            this.Controls.Add(this.сотрудникиBindingNavigator);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingNavigator)).EndInit();
            this.сотрудникиBindingNavigator.ResumeLayout(false);
            this.сотрудникиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox stazhTextBox;
        private System.Windows.Forms.DateTimePicker god_Postuplenya_Na_RabotuDateTimePicker;
        private System.Windows.Forms.DateTimePicker god_RozhdenyaDateTimePicker;
        private System.Windows.Forms.TextBox fIOTextBox;
    }
}