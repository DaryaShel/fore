namespace WindowsFormsApplication4
{
    partial class Form5
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
            this.sFUDataSet3 = new WindowsFormsApplication4.SFUDataSet3();
            this.wvBoilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wvBoilerTableAdapter = new WindowsFormsApplication4.SFUDataSet3TableAdapters.wvBoilerTableAdapter();
            this.кодбойлераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зданиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тарифНормаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тврифВышенормыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvBoilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодбойлераDataGridViewTextBoxColumn,
            this.зданиеDataGridViewTextBoxColumn,
            this.тарифНормаDataGridViewTextBoxColumn,
            this.тврифВышенормыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wvBoilerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // sFUDataSet3
            // 
            this.sFUDataSet3.DataSetName = "SFUDataSet3";
            this.sFUDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wvBoilerBindingSource
            // 
            this.wvBoilerBindingSource.DataMember = "wvBoiler";
            this.wvBoilerBindingSource.DataSource = this.sFUDataSet3;
            // 
            // wvBoilerTableAdapter
            // 
            this.wvBoilerTableAdapter.ClearBeforeFill = true;
            // 
            // кодбойлераDataGridViewTextBoxColumn
            // 
            this.кодбойлераDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.кодбойлераDataGridViewTextBoxColumn.DataPropertyName = "Код_бойлера";
            this.кодбойлераDataGridViewTextBoxColumn.HeaderText = "Код_бойлера";
            this.кодбойлераDataGridViewTextBoxColumn.Name = "кодбойлераDataGridViewTextBoxColumn";
            // 
            // зданиеDataGridViewTextBoxColumn
            // 
            this.зданиеDataGridViewTextBoxColumn.DataPropertyName = "Здание";
            this.зданиеDataGridViewTextBoxColumn.HeaderText = "Здание";
            this.зданиеDataGridViewTextBoxColumn.Name = "зданиеDataGridViewTextBoxColumn";
            // 
            // тарифНормаDataGridViewTextBoxColumn
            // 
            this.тарифНормаDataGridViewTextBoxColumn.DataPropertyName = "Тариф_Норма";
            this.тарифНормаDataGridViewTextBoxColumn.HeaderText = "Тариф_Норма";
            this.тарифНормаDataGridViewTextBoxColumn.Name = "тарифНормаDataGridViewTextBoxColumn";
            // 
            // тврифВышенормыDataGridViewTextBoxColumn
            // 
            this.тврифВышенормыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.тврифВышенормыDataGridViewTextBoxColumn.DataPropertyName = "Твриф_Выше_нормы";
            this.тврифВышенормыDataGridViewTextBoxColumn.HeaderText = "Твриф_Выше_нормы";
            this.тврифВышенормыDataGridViewTextBoxColumn.Name = "тврифВышенормыDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Реестр бойлеров";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvBoilerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SFUDataSet3 sFUDataSet3;
        private System.Windows.Forms.BindingSource wvBoilerBindingSource;
        private SFUDataSet3TableAdapters.wvBoilerTableAdapter wvBoilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодбойлераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зданиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тарифНормаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тврифВышенормыDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}