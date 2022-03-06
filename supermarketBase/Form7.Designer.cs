
namespace supermarketBase
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            System.Windows.Forms.Label nameOfDolzhonstiLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label obyazannostiLabel;
            System.Windows.Forms.Label trebovaniyaLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.supermarketBaseDataSet = new supermarketBase.SupermarketBaseDataSet();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностиTableAdapter = new supermarketBase.SupermarketBaseDataSetTableAdapters.ДолжностиTableAdapter();
            this.tableAdapterManager = new supermarketBase.SupermarketBaseDataSetTableAdapters.TableAdapterManager();
            this.должностиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.должностиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameOfDolzhonstiTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.obyazannostiTextBox = new System.Windows.Forms.TextBox();
            this.trebovaniyaTextBox = new System.Windows.Forms.TextBox();
            nameOfDolzhonstiLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            obyazannostiLabel = new System.Windows.Forms.Label();
            trebovaniyaLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingNavigator)).BeginInit();
            this.должностиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(364, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отчет таблицы \"Должности\"";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(trebovaniyaLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.trebovaniyaTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(obyazannostiLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.obyazannostiTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(salaryLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.salaryTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(nameOfDolzhonstiLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameOfDolzhonstiTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(351, 133);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.93827F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.06173F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(392, 341);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // supermarketBaseDataSet
            // 
            this.supermarketBaseDataSet.DataSetName = "SupermarketBaseDataSet";
            this.supermarketBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.supermarketBaseDataSet;
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = supermarketBase.SupermarketBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = this.должностиTableAdapter;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.ОтделыTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Типы_товаровTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // должностиBindingNavigator
            // 
            this.должностиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.должностиBindingNavigator.BindingSource = this.должностиBindingSource;
            this.должностиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.должностиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.должностиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.должностиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.должностиBindingNavigatorSaveItem});
            this.должностиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.должностиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.должностиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.должностиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.должностиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.должностиBindingNavigator.Name = "должностиBindingNavigator";
            this.должностиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.должностиBindingNavigator.Size = new System.Drawing.Size(1015, 27);
            this.должностиBindingNavigator.TabIndex = 2;
            this.должностиBindingNavigator.Text = "bindingNavigator1";
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
            // должностиBindingNavigatorSaveItem
            // 
            this.должностиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.должностиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("должностиBindingNavigatorSaveItem.Image")));
            this.должностиBindingNavigatorSaveItem.Name = "должностиBindingNavigatorSaveItem";
            this.должностиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.должностиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.должностиBindingNavigatorSaveItem.Click += new System.EventHandler(this.должностиBindingNavigatorSaveItem_Click);
            // 
            // nameOfDolzhonstiLabel
            // 
            nameOfDolzhonstiLabel.AutoSize = true;
            nameOfDolzhonstiLabel.Location = new System.Drawing.Point(3, 0);
            nameOfDolzhonstiLabel.Name = "nameOfDolzhonstiLabel";
            nameOfDolzhonstiLabel.Size = new System.Drawing.Size(138, 17);
            nameOfDolzhonstiLabel.TabIndex = 0;
            nameOfDolzhonstiLabel.Text = "Name Of Dolzhonsti:";
            // 
            // nameOfDolzhonstiTextBox
            // 
            this.nameOfDolzhonstiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "NameOfDolzhonsti", true));
            this.nameOfDolzhonstiTextBox.Location = new System.Drawing.Point(199, 3);
            this.nameOfDolzhonstiTextBox.Name = "nameOfDolzhonstiTextBox";
            this.nameOfDolzhonstiTextBox.Size = new System.Drawing.Size(181, 22);
            this.nameOfDolzhonstiTextBox.TabIndex = 1;
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(3, 112);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(52, 17);
            salaryLabel.TabIndex = 2;
            salaryLabel.Text = "Salary:";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "Salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(199, 115);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(170, 22);
            this.salaryTextBox.TabIndex = 3;
            // 
            // obyazannostiLabel
            // 
            obyazannostiLabel.AutoSize = true;
            obyazannostiLabel.Location = new System.Drawing.Point(3, 203);
            obyazannostiLabel.Name = "obyazannostiLabel";
            obyazannostiLabel.Size = new System.Drawing.Size(99, 17);
            obyazannostiLabel.TabIndex = 4;
            obyazannostiLabel.Text = "Obyazannosti:";
            // 
            // obyazannostiTextBox
            // 
            this.obyazannostiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "Obyazannosti", true));
            this.obyazannostiTextBox.Location = new System.Drawing.Point(199, 206);
            this.obyazannostiTextBox.Name = "obyazannostiTextBox";
            this.obyazannostiTextBox.Size = new System.Drawing.Size(181, 22);
            this.obyazannostiTextBox.TabIndex = 5;
            // 
            // trebovaniyaLabel
            // 
            trebovaniyaLabel.AutoSize = true;
            trebovaniyaLabel.Location = new System.Drawing.Point(3, 273);
            trebovaniyaLabel.Name = "trebovaniyaLabel";
            trebovaniyaLabel.Size = new System.Drawing.Size(91, 17);
            trebovaniyaLabel.TabIndex = 6;
            trebovaniyaLabel.Text = "Trebovaniya:";
            // 
            // trebovaniyaTextBox
            // 
            this.trebovaniyaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "Trebovaniya", true));
            this.trebovaniyaTextBox.Location = new System.Drawing.Point(199, 276);
            this.trebovaniyaTextBox.Name = "trebovaniyaTextBox";
            this.trebovaniyaTextBox.Size = new System.Drawing.Size(190, 22);
            this.trebovaniyaTextBox.TabIndex = 7;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 546);
            this.Controls.Add(this.должностиBindingNavigator);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingNavigator)).EndInit();
            this.должностиBindingNavigator.ResumeLayout(false);
            this.должностиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SupermarketBaseDataSet supermarketBaseDataSet;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private SupermarketBaseDataSetTableAdapters.ДолжностиTableAdapter должностиTableAdapter;
        private SupermarketBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator должностиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton должностиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox trebovaniyaTextBox;
        private System.Windows.Forms.TextBox obyazannostiTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox nameOfDolzhonstiTextBox;
    }
}