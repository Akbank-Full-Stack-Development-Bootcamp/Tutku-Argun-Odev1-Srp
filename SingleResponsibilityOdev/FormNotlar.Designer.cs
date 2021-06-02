
namespace SingleResponsibilityOdev
{
    partial class FormNotlar
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
            this.buttonCreateTxt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateTxt
            // 
            this.buttonCreateTxt.Location = new System.Drawing.Point(25, 263);
            this.buttonCreateTxt.Name = "buttonCreateTxt";
            this.buttonCreateTxt.Size = new System.Drawing.Size(129, 31);
            this.buttonCreateTxt.TabIndex = 3;
            this.buttonCreateTxt.Text = "Text Dosyası Oluştur";
            this.buttonCreateTxt.UseVisualStyleBackColor = true;
            this.buttonCreateTxt.Click += new System.EventHandler(this.buttonCreateTxt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vize,
            this.final,
            this.ortalama,
            this.durum});
            this.dataGridView1.Location = new System.Drawing.Point(25, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(437, 217);
            this.dataGridView1.TabIndex = 2;
            // 
            // vize
            // 
            this.vize.DataPropertyName = "vize";
            this.vize.HeaderText = "Vize Notu";
            this.vize.Name = "vize";
            // 
            // final
            // 
            this.final.DataPropertyName = "final";
            this.final.HeaderText = "Final Notu";
            this.final.Name = "final";
            // 
            // ortalama
            // 
            this.ortalama.DataPropertyName = "ortalama";
            this.ortalama.HeaderText = "Ortalama";
            this.ortalama.Name = "ortalama";
            // 
            // durum
            // 
            this.durum.DataPropertyName = "durum";
            this.durum.HeaderText = "Durum";
            this.durum.Name = "durum";
            // 
            // FormNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 336);
            this.Controls.Add(this.buttonCreateTxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormNotlar";
            this.Text = "FormNotlar";
            this.Load += new System.EventHandler(this.FormNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vize;
        private System.Windows.Forms.DataGridViewTextBoxColumn final;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalama;
        private System.Windows.Forms.DataGridViewTextBoxColumn durum;
    }
}