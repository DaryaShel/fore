namespace WindowsFormsApplication4
{
    partial class FormIndicationsE
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
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sFUDataSet31 = new WindowsFormsApplication4.SFUDataSet31();
            this.indicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.indicationsTableAdapter = new WindowsFormsApplication4.SFUDataSet31TableAdapters.IndicationsTableAdapter();
            this.numIndicationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counternumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofindicationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indicationsbeforeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indicationsafterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthandyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(704, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Дата показания";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(802, 205);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(702, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Номер показания";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(802, 162);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 50;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(535, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "Вставить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(704, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Показания после";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(802, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(718, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Показания до";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Месяц и год";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Номер счетчика";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(802, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 43;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(802, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(802, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 41;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numIndicationsDataGridViewTextBoxColumn,
            this.counternumberDataGridViewTextBoxColumn,
            this.dateofindicationsDataGridViewTextBoxColumn,
            this.indicationsbeforeDataGridViewTextBoxColumn,
            this.indicationsafterDataGridViewTextBoxColumn,
            this.monthandyearDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.indicationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 150);
            this.dataGridView1.TabIndex = 40;
            // 
            // sFUDataSet31
            // 
            this.sFUDataSet31.DataSetName = "SFUDataSet31";
            this.sFUDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // indicationsBindingSource
            // 
            this.indicationsBindingSource.DataMember = "Indications";
            this.indicationsBindingSource.DataSource = this.sFUDataSet31;
            // 
            // indicationsTableAdapter
            // 
            this.indicationsTableAdapter.ClearBeforeFill = true;
            // 
            // numIndicationsDataGridViewTextBoxColumn
            // 
            this.numIndicationsDataGridViewTextBoxColumn.DataPropertyName = "Num_Indications";
            this.numIndicationsDataGridViewTextBoxColumn.HeaderText = "Num_Indications";
            this.numIndicationsDataGridViewTextBoxColumn.Name = "numIndicationsDataGridViewTextBoxColumn";
            // 
            // counternumberDataGridViewTextBoxColumn
            // 
            this.counternumberDataGridViewTextBoxColumn.DataPropertyName = "Counter_number";
            this.counternumberDataGridViewTextBoxColumn.HeaderText = "Counter_number";
            this.counternumberDataGridViewTextBoxColumn.Name = "counternumberDataGridViewTextBoxColumn";
            // 
            // dateofindicationsDataGridViewTextBoxColumn
            // 
            this.dateofindicationsDataGridViewTextBoxColumn.DataPropertyName = "Date_of_indications";
            this.dateofindicationsDataGridViewTextBoxColumn.HeaderText = "Date_of_indications";
            this.dateofindicationsDataGridViewTextBoxColumn.Name = "dateofindicationsDataGridViewTextBoxColumn";
            // 
            // indicationsbeforeDataGridViewTextBoxColumn
            // 
            this.indicationsbeforeDataGridViewTextBoxColumn.DataPropertyName = "Indications_before";
            this.indicationsbeforeDataGridViewTextBoxColumn.HeaderText = "Indications_before";
            this.indicationsbeforeDataGridViewTextBoxColumn.Name = "indicationsbeforeDataGridViewTextBoxColumn";
            // 
            // indicationsafterDataGridViewTextBoxColumn
            // 
            this.indicationsafterDataGridViewTextBoxColumn.DataPropertyName = "Indications_after";
            this.indicationsafterDataGridViewTextBoxColumn.HeaderText = "Indications_after";
            this.indicationsafterDataGridViewTextBoxColumn.Name = "indicationsafterDataGridViewTextBoxColumn";
            // 
            // monthandyearDataGridViewTextBoxColumn
            // 
            this.monthandyearDataGridViewTextBoxColumn.DataPropertyName = "Month_and_year";
            this.monthandyearDataGridViewTextBoxColumn.HeaderText = "Month_and_year";
            this.monthandyearDataGridViewTextBoxColumn.Name = "monthandyearDataGridViewTextBoxColumn";
            // 
            // FormIndicationsE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormIndicationsE";
            this.Text = "FormIndicationsE";
            this.Load += new System.EventHandler(this.FormIndicationsE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SFUDataSet31 sFUDataSet31;
        private System.Windows.Forms.BindingSource indicationsBindingSource;
        private SFUDataSet31TableAdapters.IndicationsTableAdapter indicationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numIndicationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn counternumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofindicationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indicationsbeforeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indicationsafterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthandyearDataGridViewTextBoxColumn;
    }
}