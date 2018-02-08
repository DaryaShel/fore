namespace WindowsFormsApplication4
{
    partial class Form6
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
            this.sFUDataSet5 = new WindowsFormsApplication4.SFUDataSet5();
            this.wvIndicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wvIndicationsTableAdapter = new WindowsFormsApplication4.SFUDataSet5TableAdapters.wvIndicationsTableAdapter();
            this.кодсчетчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.месяцигодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.показаниядоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.показанияпослеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зданиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ресурсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvIndicationsBindingSource)).BeginInit();
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
            this.зданиеDataGridViewTextBoxColumn,
            this.ресурсDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wvIndicationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // sFUDataSet5
            // 
            this.sFUDataSet5.DataSetName = "SFUDataSet5";
            this.sFUDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wvIndicationsBindingSource
            // 
            this.wvIndicationsBindingSource.DataMember = "wvIndications";
            this.wvIndicationsBindingSource.DataSource = this.sFUDataSet5;
            // 
            // wvIndicationsTableAdapter
            // 
            this.wvIndicationsTableAdapter.ClearBeforeFill = true;
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
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvIndicationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SFUDataSet5 sFUDataSet5;
        private System.Windows.Forms.BindingSource wvIndicationsBindingSource;
        private SFUDataSet5TableAdapters.wvIndicationsTableAdapter wvIndicationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодсчетчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn месяцигодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn показаниядоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn показанияпослеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зданиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ресурсDataGridViewTextBoxColumn;
    }
}