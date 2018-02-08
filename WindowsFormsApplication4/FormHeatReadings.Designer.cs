namespace WindowsFormsApplication4
{
    partial class FormHeatReadings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHeatReadings));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодбойлераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.показаниядоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.показанияпослеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тарифDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаустановкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапроверкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wvHeatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sFUDataSet16 = new WindowsFormsApplication4.SFUDataSet16();
            this.wvHeatTableAdapter = new WindowsFormsApplication4.SFUDataSet16TableAdapters.wvHeatTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvHeatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодбойлераDataGridViewTextBoxColumn,
            this.показаниядоDataGridViewTextBoxColumn,
            this.показанияпослеDataGridViewTextBoxColumn,
            this.тарифDataGridViewTextBoxColumn,
            this.датаустановкиDataGridViewTextBoxColumn,
            this.датапроверкиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wvHeatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодбойлераDataGridViewTextBoxColumn
            // 
            this.кодбойлераDataGridViewTextBoxColumn.DataPropertyName = "Код_бойлера";
            this.кодбойлераDataGridViewTextBoxColumn.HeaderText = "Код_бойлера";
            this.кодбойлераDataGridViewTextBoxColumn.Name = "кодбойлераDataGridViewTextBoxColumn";
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
            // тарифDataGridViewTextBoxColumn
            // 
            this.тарифDataGridViewTextBoxColumn.DataPropertyName = "Тариф";
            this.тарифDataGridViewTextBoxColumn.HeaderText = "Тариф";
            this.тарифDataGridViewTextBoxColumn.Name = "тарифDataGridViewTextBoxColumn";
            // 
            // датаустановкиDataGridViewTextBoxColumn
            // 
            this.датаустановкиDataGridViewTextBoxColumn.DataPropertyName = "Дата_установки";
            this.датаустановкиDataGridViewTextBoxColumn.HeaderText = "Дата_установки";
            this.датаустановкиDataGridViewTextBoxColumn.Name = "датаустановкиDataGridViewTextBoxColumn";
            // 
            // датапроверкиDataGridViewTextBoxColumn
            // 
            this.датапроверкиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датапроверкиDataGridViewTextBoxColumn.DataPropertyName = "Дата_проверки";
            this.датапроверкиDataGridViewTextBoxColumn.HeaderText = "Дата_проверки";
            this.датапроверкиDataGridViewTextBoxColumn.Name = "датапроверкиDataGridViewTextBoxColumn";
            // 
            // wvHeatBindingSource
            // 
            this.wvHeatBindingSource.DataMember = "wvHeat";
            this.wvHeatBindingSource.DataSource = this.sFUDataSet16;
            // 
            // sFUDataSet16
            // 
            this.sFUDataSet16.DataSetName = "SFUDataSet16";
            this.sFUDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wvHeatTableAdapter
            // 
            this.wvHeatTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(678, 21);
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
            // FormHeatReadings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 259);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormHeatReadings";
            this.Text = "Показания";
            this.Load += new System.EventHandler(this.FormHeatReadings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvHeatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet16)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SFUDataSet16 sFUDataSet16;
        private System.Windows.Forms.BindingSource wvHeatBindingSource;
        private SFUDataSet16TableAdapters.wvHeatTableAdapter wvHeatTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодбойлераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn показаниядоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn показанияпослеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тарифDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаустановкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапроверкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}