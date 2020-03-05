namespace MedDataBase
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label name1Label;
            System.Windows.Forms.Label name2Label;
            System.Windows.Forms.Label name3Label;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label sNILSLabel;
            this.database1DataSet = new MedDataBase.Database1DataSet();
            this.tPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPersonTableAdapter = new MedDataBase.Database1DataSetTableAdapters.TPersonTableAdapter();
            this.tableAdapterManager = new MedDataBase.Database1DataSetTableAdapters.TableAdapterManager();
            this.tPersonBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tPersonBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tPersonDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.name1TextBox = new System.Windows.Forms.TextBox();
            this.name2TextBox = new System.Windows.Forms.TextBox();
            this.name3TextBox = new System.Windows.Forms.TextBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sNILSTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            name1Label = new System.Windows.Forms.Label();
            name2Label = new System.Windows.Forms.Label();
            name3Label = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            sNILSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPersonBindingNavigator)).BeginInit();
            this.tPersonBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tPersonDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tPersonBindingSource
            // 
            this.tPersonBindingSource.DataMember = "TPerson";
            this.tPersonBindingSource.DataSource = this.database1DataSet;
            // 
            // tPersonTableAdapter
            // 
            this.tPersonTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TPersonTableAdapter = this.tPersonTableAdapter;
            this.tableAdapterManager.UpdateOrder = MedDataBase.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tPersonBindingNavigator
            // 
            this.tPersonBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tPersonBindingNavigator.BindingSource = this.tPersonBindingSource;
            this.tPersonBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tPersonBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tPersonBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tPersonBindingNavigatorSaveItem});
            this.tPersonBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tPersonBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tPersonBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tPersonBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tPersonBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tPersonBindingNavigator.Name = "tPersonBindingNavigator";
            this.tPersonBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tPersonBindingNavigator.Size = new System.Drawing.Size(960, 25);
            this.tPersonBindingNavigator.TabIndex = 0;
            this.tPersonBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // tPersonBindingNavigatorSaveItem
            // 
            this.tPersonBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tPersonBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tPersonBindingNavigatorSaveItem.Image")));
            this.tPersonBindingNavigatorSaveItem.Name = "tPersonBindingNavigatorSaveItem";
            this.tPersonBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tPersonBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tPersonBindingNavigatorSaveItem.Click += new System.EventHandler(this.tPersonBindingNavigatorSaveItem_Click);
            // 
            // tPersonDataGridView
            // 
            this.tPersonDataGridView.AutoGenerateColumns = false;
            this.tPersonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tPersonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tPersonDataGridView.DataSource = this.tPersonBindingSource;
            this.tPersonDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.tPersonDataGridView.Location = new System.Drawing.Point(0, 25);
            this.tPersonDataGridView.Name = "tPersonDataGridView";
            this.tPersonDataGridView.Size = new System.Drawing.Size(665, 425);
            this.tPersonDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name2";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name2";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name3";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name3";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BirthDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "BirthDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SNILS";
            this.dataGridViewTextBoxColumn6.HeaderText = "SNILS";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(name1Label);
            this.panel1.Controls.Add(this.name1TextBox);
            this.panel1.Controls.Add(name2Label);
            this.panel1.Controls.Add(this.name2TextBox);
            this.panel1.Controls.Add(name3Label);
            this.panel1.Controls.Add(this.name3TextBox);
            this.panel1.Controls.Add(birthDateLabel);
            this.panel1.Controls.Add(this.birthDateDateTimePicker);
            this.panel1.Controls.Add(sNILSLabel);
            this.panel1.Controls.Add(this.sNILSTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(665, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 425);
            this.panel1.TabIndex = 2;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(15, 14);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tPersonBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(78, 11);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // name1Label
            // 
            name1Label.AutoSize = true;
            name1Label.Location = new System.Drawing.Point(15, 40);
            name1Label.Name = "name1Label";
            name1Label.Size = new System.Drawing.Size(44, 13);
            name1Label.TabIndex = 2;
            name1Label.Text = "Name1:";
            // 
            // name1TextBox
            // 
            this.name1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tPersonBindingSource, "Name1", true));
            this.name1TextBox.Location = new System.Drawing.Point(78, 37);
            this.name1TextBox.Name = "name1TextBox";
            this.name1TextBox.Size = new System.Drawing.Size(200, 20);
            this.name1TextBox.TabIndex = 3;
            // 
            // name2Label
            // 
            name2Label.AutoSize = true;
            name2Label.Location = new System.Drawing.Point(15, 66);
            name2Label.Name = "name2Label";
            name2Label.Size = new System.Drawing.Size(44, 13);
            name2Label.TabIndex = 4;
            name2Label.Text = "Name2:";
            // 
            // name2TextBox
            // 
            this.name2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tPersonBindingSource, "Name2", true));
            this.name2TextBox.Location = new System.Drawing.Point(78, 63);
            this.name2TextBox.Name = "name2TextBox";
            this.name2TextBox.Size = new System.Drawing.Size(200, 20);
            this.name2TextBox.TabIndex = 5;
            // 
            // name3Label
            // 
            name3Label.AutoSize = true;
            name3Label.Location = new System.Drawing.Point(15, 92);
            name3Label.Name = "name3Label";
            name3Label.Size = new System.Drawing.Size(44, 13);
            name3Label.TabIndex = 6;
            name3Label.Text = "Name3:";
            // 
            // name3TextBox
            // 
            this.name3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tPersonBindingSource, "Name3", true));
            this.name3TextBox.Location = new System.Drawing.Point(78, 89);
            this.name3TextBox.Name = "name3TextBox";
            this.name3TextBox.Size = new System.Drawing.Size(200, 20);
            this.name3TextBox.TabIndex = 7;
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(15, 119);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(57, 13);
            birthDateLabel.TabIndex = 8;
            birthDateLabel.Text = "Birth Date:";
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tPersonBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(78, 115);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthDateDateTimePicker.TabIndex = 9;
            // 
            // sNILSLabel
            // 
            sNILSLabel.AutoSize = true;
            sNILSLabel.Location = new System.Drawing.Point(15, 144);
            sNILSLabel.Name = "sNILSLabel";
            sNILSLabel.Size = new System.Drawing.Size(41, 13);
            sNILSLabel.TabIndex = 10;
            sNILSLabel.Text = "SNILS:";
            // 
            // sNILSTextBox
            // 
            this.sNILSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tPersonBindingSource, "SNILS", true));
            this.sNILSTextBox.Location = new System.Drawing.Point(78, 141);
            this.sNILSTextBox.Name = "sNILSTextBox";
            this.sNILSTextBox.Size = new System.Drawing.Size(200, 20);
            this.sNILSTextBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tPersonDataGridView);
            this.Controls.Add(this.tPersonBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPersonBindingNavigator)).EndInit();
            this.tPersonBindingNavigator.ResumeLayout(false);
            this.tPersonBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tPersonDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tPersonBindingSource;
        private Database1DataSetTableAdapters.TPersonTableAdapter tPersonTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tPersonBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tPersonBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tPersonDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox name1TextBox;
        private System.Windows.Forms.TextBox name2TextBox;
        private System.Windows.Forms.TextBox name3TextBox;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox sNILSTextBox;
    }
}

