namespace WindowsFormsApplication4
{
    partial class FormUpdateCounter
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sFUDataSet32 = new WindowsFormsApplication4.SFUDataSet32();
            this.counterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.counterTableAdapter = new WindowsFormsApplication4.SFUDataSet32TableAdapters.CounterTableAdapter();
            this.counternumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countercodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourcecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(405, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(405, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Новое значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Номер счетчика";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 65);
            this.label1.TabIndex = 7;
            this.label1.Text = "Изменить данные в таблице \"Счетчик\"\r\nКод счетчика - 1\r\nКод ресурса - 2\r\nДата тест" +
    "ирования - 3\r\nДата поломки - 4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ввод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(684, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.counternumberDataGridViewTextBoxColumn,
            this.countercodeDataGridViewTextBoxColumn,
            this.resourcecodeDataGridViewTextBoxColumn,
            this.installationdateDataGridViewTextBoxColumn,
            this.testdateDataGridViewTextBoxColumn,
            this.breakingdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.counterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // sFUDataSet32
            // 
            this.sFUDataSet32.DataSetName = "SFUDataSet32";
            this.sFUDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // counterBindingSource
            // 
            this.counterBindingSource.DataMember = "Counter";
            this.counterBindingSource.DataSource = this.sFUDataSet32;
            // 
            // counterTableAdapter
            // 
            this.counterTableAdapter.ClearBeforeFill = true;
            // 
            // counternumberDataGridViewTextBoxColumn
            // 
            this.counternumberDataGridViewTextBoxColumn.DataPropertyName = "Counter_number";
            this.counternumberDataGridViewTextBoxColumn.HeaderText = "Counter_number";
            this.counternumberDataGridViewTextBoxColumn.Name = "counternumberDataGridViewTextBoxColumn";
            this.counternumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countercodeDataGridViewTextBoxColumn
            // 
            this.countercodeDataGridViewTextBoxColumn.DataPropertyName = "Counter_code";
            this.countercodeDataGridViewTextBoxColumn.HeaderText = "Counter_code";
            this.countercodeDataGridViewTextBoxColumn.Name = "countercodeDataGridViewTextBoxColumn";
            // 
            // resourcecodeDataGridViewTextBoxColumn
            // 
            this.resourcecodeDataGridViewTextBoxColumn.DataPropertyName = "Resource_code";
            this.resourcecodeDataGridViewTextBoxColumn.HeaderText = "Resource_code";
            this.resourcecodeDataGridViewTextBoxColumn.Name = "resourcecodeDataGridViewTextBoxColumn";
            // 
            // installationdateDataGridViewTextBoxColumn
            // 
            this.installationdateDataGridViewTextBoxColumn.DataPropertyName = "Installation_date";
            this.installationdateDataGridViewTextBoxColumn.HeaderText = "Installation_date";
            this.installationdateDataGridViewTextBoxColumn.Name = "installationdateDataGridViewTextBoxColumn";
            // 
            // testdateDataGridViewTextBoxColumn
            // 
            this.testdateDataGridViewTextBoxColumn.DataPropertyName = "Test_date";
            this.testdateDataGridViewTextBoxColumn.HeaderText = "Test_date";
            this.testdateDataGridViewTextBoxColumn.Name = "testdateDataGridViewTextBoxColumn";
            // 
            // breakingdateDataGridViewTextBoxColumn
            // 
            this.breakingdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.breakingdateDataGridViewTextBoxColumn.DataPropertyName = "Breaking_date";
            this.breakingdateDataGridViewTextBoxColumn.HeaderText = "Breaking_date";
            this.breakingdateDataGridViewTextBoxColumn.Name = "breakingdateDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(581, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Ввод";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormUpdateCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 311);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateCounter";
            this.Text = "FormUpdateCounter";
            this.Load += new System.EventHandler(this.FormUpdateCounter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SFUDataSet32 sFUDataSet32;
        private System.Windows.Forms.BindingSource counterBindingSource;
        private SFUDataSet32TableAdapters.CounterTableAdapter counterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn counternumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countercodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourcecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}