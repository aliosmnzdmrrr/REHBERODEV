namespace ödevimverim
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.box3 = new System.Windows.Forms.TextBox();
            this.box2 = new System.Windows.Forms.TextBox();
            this.box1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rehberkisilerDataSet = new ödevimverim.rehberkisilerDataSet();
            this.kisilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kisilerTableAdapter = new ödevimverim.rehberkisilerDataSetTableAdapters.kisilerTableAdapter();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMARADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehberkisilerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "NUMARA";
            // 
            // box3
            // 
            this.box3.Location = new System.Drawing.Point(103, 151);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(155, 22);
            this.box3.TabIndex = 3;
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(103, 100);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(155, 22);
            this.box2.TabIndex = 4;
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(103, 52);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(155, 22);
            this.box1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 82);
            this.button1.TabIndex = 6;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aDDataGridViewTextBoxColumn,
            this.sOYADDataGridViewTextBoxColumn,
            this.nUMARADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kisilerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(316, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 238);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rehberkisilerDataSet
            // 
            this.rehberkisilerDataSet.DataSetName = "rehberkisilerDataSet";
            this.rehberkisilerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kisilerBindingSource
            // 
            this.kisilerBindingSource.DataMember = "kisiler";
            this.kisilerBindingSource.DataSource = this.rehberkisilerDataSet;
            // 
            // kisilerTableAdapter
            // 
            this.kisilerTableAdapter.ClearBeforeFill = true;
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            this.aDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sOYADDataGridViewTextBoxColumn
            // 
            this.sOYADDataGridViewTextBoxColumn.DataPropertyName = "SOYAD";
            this.sOYADDataGridViewTextBoxColumn.HeaderText = "SOYAD";
            this.sOYADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sOYADDataGridViewTextBoxColumn.Name = "sOYADDataGridViewTextBoxColumn";
            this.sOYADDataGridViewTextBoxColumn.Width = 125;
            // 
            // nUMARADataGridViewTextBoxColumn
            // 
            this.nUMARADataGridViewTextBoxColumn.DataPropertyName = "NUMARA";
            this.nUMARADataGridViewTextBoxColumn.HeaderText = "NUMARA";
            this.nUMARADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nUMARADataGridViewTextBoxColumn.Name = "nUMARADataGridViewTextBoxColumn";
            this.nUMARADataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehberkisilerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box3;
        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private rehberkisilerDataSet rehberkisilerDataSet;
        private System.Windows.Forms.BindingSource kisilerBindingSource;
        private rehberkisilerDataSetTableAdapters.kisilerTableAdapter kisilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMARADataGridViewTextBoxColumn;
    }
}

