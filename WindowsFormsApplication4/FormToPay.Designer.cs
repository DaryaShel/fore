namespace WindowsFormsApplication4
{
    partial class FormToPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormToPay));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.зданиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодсчетчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рескрсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.коплатеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sFUDataSet24 = new WindowsFormsApplication4.SFUDataSet24();
            this.button1 = new System.Windows.Forms.Button();
            this.to_payTableAdapter = new WindowsFormsApplication4.SFUDataSet24TableAdapters.To_payTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet24)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.зданиеDataGridViewTextBoxColumn,
            this.кодсчетчикаDataGridViewTextBoxColumn,
            this.рескрсDataGridViewTextBoxColumn,
            this.коплатеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.topayBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // зданиеDataGridViewTextBoxColumn
            // 
            this.зданиеDataGridViewTextBoxColumn.DataPropertyName = "Здание";
            this.зданиеDataGridViewTextBoxColumn.HeaderText = "Здание";
            this.зданиеDataGridViewTextBoxColumn.Name = "зданиеDataGridViewTextBoxColumn";
            // 
            // кодсчетчикаDataGridViewTextBoxColumn
            // 
            this.кодсчетчикаDataGridViewTextBoxColumn.DataPropertyName = "Код_счетчика";
            this.кодсчетчикаDataGridViewTextBoxColumn.HeaderText = "Код_счетчика";
            this.кодсчетчикаDataGridViewTextBoxColumn.Name = "кодсчетчикаDataGridViewTextBoxColumn";
            // 
            // рескрсDataGridViewTextBoxColumn
            // 
            this.рескрсDataGridViewTextBoxColumn.DataPropertyName = "Рескрс";
            this.рескрсDataGridViewTextBoxColumn.HeaderText = "Рескрс";
            this.рескрсDataGridViewTextBoxColumn.Name = "рескрсDataGridViewTextBoxColumn";
            // 
            // коплатеDataGridViewTextBoxColumn
            // 
            this.коплатеDataGridViewTextBoxColumn.DataPropertyName = "К_оплате";
            this.коплатеDataGridViewTextBoxColumn.HeaderText = "К_оплате";
            this.коплатеDataGridViewTextBoxColumn.Name = "коплатеDataGridViewTextBoxColumn";
            // 
            // topayBindingSource
            // 
            this.topayBindingSource.DataMember = "To_pay";
            this.topayBindingSource.DataSource = this.sFUDataSet24;
            // 
            // sFUDataSet24
            // 
            this.sFUDataSet24.DataSetName = "SFUDataSet24";
            this.sFUDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // to_payTableAdapter
            // 
            this.to_payTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Печать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormToPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 233);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormToPay";
            this.Text = "Начисления по показаниям";
            this.Load += new System.EventHandler(this.FormToPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet24)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private SFUDataSet24 sFUDataSet24;
        private System.Windows.Forms.BindingSource topayBindingSource;
        private SFUDataSet24TableAdapters.To_payTableAdapter to_payTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn зданиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодсчетчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рескрсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn коплатеDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}