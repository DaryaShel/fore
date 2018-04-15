namespace WindowsFormsApplication4
{
    partial class FormBoilerTable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boilernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boilercodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sFUDataSet28 = new WindowsFormsApplication4.SFUDataSet28();
            this.boilerTableAdapter = new WindowsFormsApplication4.SFUDataSet28TableAdapters.BoilerTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet28)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boilernumberDataGridViewTextBoxColumn,
            this.boilercodeDataGridViewTextBoxColumn,
            this.installationdateDataGridViewTextBoxColumn,
            this.testdateDataGridViewTextBoxColumn,
            this.breakingdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.boilerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // boilernumberDataGridViewTextBoxColumn
            // 
            this.boilernumberDataGridViewTextBoxColumn.DataPropertyName = "Boiler_number";
            this.boilernumberDataGridViewTextBoxColumn.HeaderText = "Boiler_number";
            this.boilernumberDataGridViewTextBoxColumn.Name = "boilernumberDataGridViewTextBoxColumn";
            // 
            // boilercodeDataGridViewTextBoxColumn
            // 
            this.boilercodeDataGridViewTextBoxColumn.DataPropertyName = "Boiler_code";
            this.boilercodeDataGridViewTextBoxColumn.HeaderText = "Boiler_code";
            this.boilercodeDataGridViewTextBoxColumn.Name = "boilercodeDataGridViewTextBoxColumn";
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
            this.breakingdateDataGridViewTextBoxColumn.DataPropertyName = "Breaking_date";
            this.breakingdateDataGridViewTextBoxColumn.HeaderText = "Breaking_date";
            this.breakingdateDataGridViewTextBoxColumn.Name = "breakingdateDataGridViewTextBoxColumn";
            // 
            // boilerBindingSource
            // 
            this.boilerBindingSource.DataMember = "Boiler";
            this.boilerBindingSource.DataSource = this.sFUDataSet28;
            // 
            // sFUDataSet28
            // 
            this.sFUDataSet28.DataSetName = "SFUDataSet28";
            this.sFUDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boilerTableAdapter
            // 
            this.boilerTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер бойлера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Код бойлера";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата установки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дата проверки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Дата  поломки";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(667, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(667, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(667, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(667, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(667, 157);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(692, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ввод";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormBoilerTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 307);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormBoilerTable";
            this.Text = "Бойлер";
            this.Load += new System.EventHandler(this.FormBoilerTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet28)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SFUDataSet28 sFUDataSet28;
        private System.Windows.Forms.BindingSource boilerBindingSource;
        private SFUDataSet28TableAdapters.BoilerTableAdapter boilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn boilernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boilercodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
    }
}