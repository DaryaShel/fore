﻿namespace WindowsFormsApplication4
{
    partial class FormGas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодсчетчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.месяцигодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.показаниядоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.показанияпослеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зданиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wvGasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sFUDataSet20 = new WindowsFormsApplication4.SFUDataSet20();
            this.wvGasTableAdapter = new WindowsFormsApplication4.SFUDataSet20TableAdapters.wvGasTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvGasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet20)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодсчетчикаDataGridViewTextBoxColumn,
            this.месяцигодDataGridViewTextBoxColumn,
            this.показаниядоDataGridViewTextBoxColumn,
            this.показанияпослеDataGridViewTextBoxColumn,
            this.зданиеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wvGasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(238, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 170);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодсчетчикаDataGridViewTextBoxColumn
            // 
            this.кодсчетчикаDataGridViewTextBoxColumn.DataPropertyName = "Код_счетчика";
            this.кодсчетчикаDataGridViewTextBoxColumn.HeaderText = "Код_счетчика";
            this.кодсчетчикаDataGridViewTextBoxColumn.Name = "кодсчетчикаDataGridViewTextBoxColumn";
            // 
            // месяцигодDataGridViewTextBoxColumn
            // 
            this.месяцигодDataGridViewTextBoxColumn.DataPropertyName = "Месяц_и_год";
            this.месяцигодDataGridViewTextBoxColumn.HeaderText = "Месяц_и_год";
            this.месяцигодDataGridViewTextBoxColumn.Name = "месяцигодDataGridViewTextBoxColumn";
            // 
            // показаниядоDataGridViewTextBoxColumn
            // 
            this.показаниядоDataGridViewTextBoxColumn.DataPropertyName = "Показания_до";
            this.показаниядоDataGridViewTextBoxColumn.HeaderText = "Показания_до";
            this.показаниядоDataGridViewTextBoxColumn.Name = "показаниядоDataGridViewTextBoxColumn";
            // 
            // показанияпослеDataGridViewTextBoxColumn
            // 
            this.показанияпослеDataGridViewTextBoxColumn.DataPropertyName = "Показания_после";
            this.показанияпослеDataGridViewTextBoxColumn.HeaderText = "Показания_после";
            this.показанияпослеDataGridViewTextBoxColumn.Name = "показанияпослеDataGridViewTextBoxColumn";
            // 
            // зданиеDataGridViewTextBoxColumn
            // 
            this.зданиеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.зданиеDataGridViewTextBoxColumn.DataPropertyName = "Здание";
            this.зданиеDataGridViewTextBoxColumn.HeaderText = "Здание";
            this.зданиеDataGridViewTextBoxColumn.Name = "зданиеDataGridViewTextBoxColumn";
            // 
            // wvGasBindingSource
            // 
            this.wvGasBindingSource.DataMember = "wvGas";
            this.wvGasBindingSource.DataSource = this.sFUDataSet20;
            // 
            // sFUDataSet20
            // 
            this.sFUDataSet20.DataSetName = "SFUDataSet20";
            this.sFUDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wvGasTableAdapter
            // 
            this.wvGasTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Код счетчика";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Код счетчика";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(108, 177);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(103, 20);
            this.textBox5.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(108, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(103, 20);
            this.textBox4.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Код счетчика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Код счетчика";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Код счетчика";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(108, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(103, 20);
            this.textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 20);
            this.textBox1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(788, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Печать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FormGas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 252);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormGas";
            this.Text = "Газ";
            this.Load += new System.EventHandler(this.FormGas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvGasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SFUDataSet20 sFUDataSet20;
        private System.Windows.Forms.BindingSource wvGasBindingSource;
        private SFUDataSet20TableAdapters.wvGasTableAdapter wvGasTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодсчетчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn месяцигодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn показаниядоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn показанияпослеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зданиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}