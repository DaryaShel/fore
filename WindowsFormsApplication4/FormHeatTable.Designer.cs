namespace WindowsFormsApplication4
{
    partial class FormHeatTable
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sFUDataSet29 = new WindowsFormsApplication4.SFUDataSet29();
            this.heatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heatTableAdapter = new WindowsFormsApplication4.SFUDataSet29TableAdapters.HeatTableAdapter();
            this.numheatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boilernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indicationsbeforeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indicationsafterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numtariffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numheatDataGridViewTextBoxColumn,
            this.boilernumberDataGridViewTextBoxColumn,
            this.indicationsbeforeDataGridViewTextBoxColumn,
            this.indicationsafterDataGridViewTextBoxColumn,
            this.numtariffDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.heatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 208);
            this.dataGridView1.TabIndex = 1;
            // 
            // sFUDataSet29
            // 
            this.sFUDataSet29.DataSetName = "SFUDataSet29";
            this.sFUDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // heatBindingSource
            // 
            this.heatBindingSource.DataMember = "Heat";
            this.heatBindingSource.DataSource = this.sFUDataSet29;
            // 
            // heatTableAdapter
            // 
            this.heatTableAdapter.ClearBeforeFill = true;
            // 
            // numheatDataGridViewTextBoxColumn
            // 
            this.numheatDataGridViewTextBoxColumn.DataPropertyName = "Num_heat";
            this.numheatDataGridViewTextBoxColumn.HeaderText = "Num_heat";
            this.numheatDataGridViewTextBoxColumn.Name = "numheatDataGridViewTextBoxColumn";
            // 
            // boilernumberDataGridViewTextBoxColumn
            // 
            this.boilernumberDataGridViewTextBoxColumn.DataPropertyName = "Boiler_number";
            this.boilernumberDataGridViewTextBoxColumn.HeaderText = "Boiler_number";
            this.boilernumberDataGridViewTextBoxColumn.Name = "boilernumberDataGridViewTextBoxColumn";
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
            // numtariffDataGridViewTextBoxColumn
            // 
            this.numtariffDataGridViewTextBoxColumn.DataPropertyName = "Num_tariff";
            this.numtariffDataGridViewTextBoxColumn.HeaderText = "Num_tariff";
            this.numtariffDataGridViewTextBoxColumn.Name = "numtariffDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер тепла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер бойлера";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Показания до";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Показания после ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Тариф";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(676, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(676, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(676, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(676, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(676, 142);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(701, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ввод";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormHeatTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 333);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "FormHeatTable";
            this.Text = "Тепло";
            this.Load += new System.EventHandler(this.FormHeatTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SFUDataSet29 sFUDataSet29;
        private System.Windows.Forms.BindingSource heatBindingSource;
        private SFUDataSet29TableAdapters.HeatTableAdapter heatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numheatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boilernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indicationsbeforeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indicationsafterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numtariffDataGridViewTextBoxColumn;
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