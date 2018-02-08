namespace WindowsFormsApplication4
{
    partial class FormBoilers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoilers));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодбойлераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зданиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тарифНормаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тарифВышенормыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wvBoilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sFUDataSet8 = new WindowsFormsApplication4.SFUDataSet8();
            this.wvBoilerTableAdapter = new WindowsFormsApplication4.SFUDataSet8TableAdapters.wvBoilerTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvBoilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 186);
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
            this.кодбойлераDataGridViewTextBoxColumn,
            this.зданиеDataGridViewTextBoxColumn,
            this.тарифНормаDataGridViewTextBoxColumn,
            this.тарифВышенормыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wvBoilerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // кодбойлераDataGridViewTextBoxColumn
            // 
            this.кодбойлераDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.кодбойлераDataGridViewTextBoxColumn.DataPropertyName = "Код_бойлера";
            this.кодбойлераDataGridViewTextBoxColumn.HeaderText = "Код_бойлера";
            this.кодбойлераDataGridViewTextBoxColumn.Name = "кодбойлераDataGridViewTextBoxColumn";
            this.кодбойлераDataGridViewTextBoxColumn.Width = 87;
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
            // тарифВышенормыDataGridViewTextBoxColumn
            // 
            this.тарифВышенормыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.тарифВышенормыDataGridViewTextBoxColumn.DataPropertyName = "Тариф_Выше_нормы";
            this.тарифВышенормыDataGridViewTextBoxColumn.HeaderText = "Тариф_Выше_нормы";
            this.тарифВышенормыDataGridViewTextBoxColumn.Name = "тарифВышенормыDataGridViewTextBoxColumn";
            // 
            // wvBoilerBindingSource
            // 
            this.wvBoilerBindingSource.DataMember = "wvBoiler";
            this.wvBoilerBindingSource.DataSource = this.sFUDataSet8;
            // 
            // sFUDataSet8
            // 
            this.sFUDataSet8.DataSetName = "SFUDataSet8";
            this.sFUDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wvBoilerTableAdapter
            // 
            this.wvBoilerTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 26);
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
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // FormBoilers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 233);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "FormBoilers";
            this.Text = "Реестр бойлеров";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvBoilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SFUDataSet8 sFUDataSet8;
        private System.Windows.Forms.BindingSource wvBoilerBindingSource;
        private SFUDataSet8TableAdapters.wvBoilerTableAdapter wvBoilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодбойлераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зданиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тарифНормаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тарифВышенормыDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}