
namespace supermarketBase
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label opisanieLabel;
            System.Windows.Forms.Label osobennostiLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.supermarketBaseDataSet = new supermarketBase.SupermarketBaseDataSet();
            this.типы_товаровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типы_товаровTableAdapter = new supermarketBase.SupermarketBaseDataSetTableAdapters.Типы_товаровTableAdapter();
            this.tableAdapterManager = new supermarketBase.SupermarketBaseDataSetTableAdapters.TableAdapterManager();
            this.типы_товаровBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.типы_товаровBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.opisanieTextBox = new System.Windows.Forms.TextBox();
            this.osobennostiTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            opisanieLabel = new System.Windows.Forms.Label();
            osobennostiLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типы_товаровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типы_товаровBindingNavigator)).BeginInit();
            this.типы_товаровBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(osobennostiLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.osobennostiTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(opisanieLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.opisanieTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(176, 127);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(458, 241);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(206, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отчет таблицы \"Типы товаров\"";
            // 
            // supermarketBaseDataSet
            // 
            this.supermarketBaseDataSet.DataSetName = "SupermarketBaseDataSet";
            this.supermarketBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // типы_товаровBindingSource
            // 
            this.типы_товаровBindingSource.DataMember = "Типы товаров";
            this.типы_товаровBindingSource.DataSource = this.supermarketBaseDataSet;
            // 
            // типы_товаровTableAdapter
            // 
            this.типы_товаровTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Типы_товаровTableAdapter = this.типы_товаровTableAdapter;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // типы_товаровBindingNavigator
            // 
            this.типы_товаровBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.типы_товаровBindingNavigator.BindingSource = this.типы_товаровBindingSource;
            this.типы_товаровBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.типы_товаровBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.типы_товаровBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.типы_товаровBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.типы_товаровBindingNavigatorSaveItem});
            this.типы_товаровBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.типы_товаровBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.типы_товаровBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.типы_товаровBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.типы_товаровBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.типы_товаровBindingNavigator.Name = "типы_товаровBindingNavigator";
            this.типы_товаровBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.типы_товаровBindingNavigator.Size = new System.Drawing.Size(827, 27);
            this.типы_товаровBindingNavigator.TabIndex = 2;
            this.типы_товаровBindingNavigator.Text = "bindingNavigator1";
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
            // типы_товаровBindingNavigatorSaveItem
            // 
            this.типы_товаровBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.типы_товаровBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("типы_товаровBindingNavigatorSaveItem.Image")));
            this.типы_товаровBindingNavigatorSaveItem.Name = "типы_товаровBindingNavigatorSaveItem";
            this.типы_товаровBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.типы_товаровBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.типы_товаровBindingNavigatorSaveItem.Click += new System.EventHandler(this.типы_товаровBindingNavigatorSaveItem_Click);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(3, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типы_товаровBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(232, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(223, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // opisanieLabel
            // 
            opisanieLabel.AutoSize = true;
            opisanieLabel.Location = new System.Drawing.Point(3, 86);
            opisanieLabel.Name = "opisanieLabel";
            opisanieLabel.Size = new System.Drawing.Size(68, 17);
            opisanieLabel.TabIndex = 2;
            opisanieLabel.Text = "Opisanie:";
            // 
            // opisanieTextBox
            // 
            this.opisanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типы_товаровBindingSource, "Opisanie", true));
            this.opisanieTextBox.Location = new System.Drawing.Point(232, 89);
            this.opisanieTextBox.Name = "opisanieTextBox";
            this.opisanieTextBox.Size = new System.Drawing.Size(223, 22);
            this.opisanieTextBox.TabIndex = 3;
            // 
            // osobennostiLabel
            // 
            osobennostiLabel.AutoSize = true;
            osobennostiLabel.Location = new System.Drawing.Point(3, 172);
            osobennostiLabel.Name = "osobennostiLabel";
            osobennostiLabel.Size = new System.Drawing.Size(92, 17);
            osobennostiLabel.TabIndex = 4;
            osobennostiLabel.Text = "Osobennosti:";
            // 
            // osobennostiTextBox
            // 
            this.osobennostiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типы_товаровBindingSource, "Osobennosti", true));
            this.osobennostiTextBox.Location = new System.Drawing.Point(232, 175);
            this.osobennostiTextBox.Name = "osobennostiTextBox";
            this.osobennostiTextBox.Size = new System.Drawing.Size(223, 22);
            this.osobennostiTextBox.TabIndex = 5;
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 497);
            this.Controls.Add(this.типы_товаровBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form16";
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типы_товаровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типы_товаровBindingNavigator)).EndInit();
            this.типы_товаровBindingNavigator.ResumeLayout(false);
            this.типы_товаровBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private SupermarketBaseDataSet supermarketBaseDataSet;
        private System.Windows.Forms.BindingSource типы_товаровBindingSource;
        private SupermarketBaseDataSetTableAdapters.Типы_товаровTableAdapter типы_товаровTableAdapter;
        private SupermarketBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator типы_товаровBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton типы_товаровBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox osobennostiTextBox;
        private System.Windows.Forms.TextBox opisanieTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}