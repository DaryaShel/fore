﻿namespace WindowsFormsApplication4
{
    partial class Form3
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
            this.sFUDataSet4 = new WindowsFormsApplication4.SFUDataSet4();
            this.wvСounterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wvСounterTableAdapter = new WindowsFormsApplication4.SFUDataSet4TableAdapters.wvСounterTableAdapter();
            this.кодсчетчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зданиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ресурсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаустановкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапроверкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvСounterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодсчетчикаDataGridViewTextBoxColumn,
            this.зданиеDataGridViewTextBoxColumn,
            this.ресурсDataGridViewTextBoxColumn,
            this.датаустановкиDataGridViewTextBoxColumn,
            this.датапроверкиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wvСounterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // sFUDataSet4
            // 
            this.sFUDataSet4.DataSetName = "SFUDataSet4";
            this.sFUDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wvСounterBindingSource
            // 
            this.wvСounterBindingSource.DataMember = "wvСounter";
            this.wvСounterBindingSource.DataSource = this.sFUDataSet4;
            // 
            // wvСounterTableAdapter
            // 
            this.wvСounterTableAdapter.ClearBeforeFill = true;
            // 
            // кодсчетчикаDataGridViewTextBoxColumn
            // 
            this.кодсчетчикаDataGridViewTextBoxColumn.DataPropertyName = "Код_счетчика";
            this.кодсчетчикаDataGridViewTextBoxColumn.HeaderText = "Код_счетчика";
            this.кодсчетчикаDataGridViewTextBoxColumn.Name = "кодсчетчикаDataGridViewTextBoxColumn";
            // 
            // зданиеDataGridViewTextBoxColumn
            // 
            this.зданиеDataGridViewTextBoxColumn.DataPropertyName = "Здание";
            this.зданиеDataGridViewTextBoxColumn.HeaderText = "Здание";
            this.зданиеDataGridViewTextBoxColumn.Name = "зданиеDataGridViewTextBoxColumn";
            // 
            // ресурсDataGridViewTextBoxColumn
            // 
            this.ресурсDataGridViewTextBoxColumn.DataPropertyName = "Ресурс";
            this.ресурсDataGridViewTextBoxColumn.HeaderText = "Ресурс";
            this.ресурсDataGridViewTextBoxColumn.Name = "ресурсDataGridViewTextBoxColumn";
            // 
            // датаустановкиDataGridViewTextBoxColumn
            // 
            this.датаустановкиDataGridViewTextBoxColumn.DataPropertyName = "Дата_установки";
            this.датаустановкиDataGridViewTextBoxColumn.HeaderText = "Дата_установки";
            this.датаустановкиDataGridViewTextBoxColumn.Name = "датаустановкиDataGridViewTextBoxColumn";
            // 
            // датапроверкиDataGridViewTextBoxColumn
            // 
            this.датапроверкиDataGridViewTextBoxColumn.DataPropertyName = "Дата_проверки";
            this.датапроверкиDataGridViewTextBoxColumn.HeaderText = "Дата_проверки";
            this.датапроверкиDataGridViewTextBoxColumn.Name = "датапроверкиDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 236);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Счетчики, установленные на общижития и корпуса ИТА ЮФУ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvСounterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SFUDataSet4 sFUDataSet4;
        private System.Windows.Forms.BindingSource wvСounterBindingSource;
        private SFUDataSet4TableAdapters.wvСounterTableAdapter wvСounterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодсчетчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зданиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ресурсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаустановкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапроверкиDataGridViewTextBoxColumn;
    }
}