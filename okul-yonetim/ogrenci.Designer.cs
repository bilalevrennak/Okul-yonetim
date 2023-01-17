namespace okul_yonetim
{
    partial class ogrenci
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adsoyadtxt1 = new System.Windows.Forms.TextBox();
            this.ogrnumtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrkaydet = new System.Windows.Forms.Button();
            this.kayittarihi = new System.Windows.Forms.DateTimePicker();
            this.dogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.bolumcombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD SOYAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "KAYIT TARİHİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ÖĞRENCİ NUMARASI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DOĞUM TARİHİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "BÖLÜM";
            // 
            // adsoyadtxt1
            // 
            this.adsoyadtxt1.Location = new System.Drawing.Point(150, 33);
            this.adsoyadtxt1.Name = "adsoyadtxt1";
            this.adsoyadtxt1.Size = new System.Drawing.Size(100, 20);
            this.adsoyadtxt1.TabIndex = 7;
            // 
            // ogrnumtxt
            // 
            this.ogrnumtxt.Location = new System.Drawing.Point(150, 85);
            this.ogrnumtxt.Name = "ogrnumtxt";
            this.ogrnumtxt.Size = new System.Drawing.Size(100, 20);
            this.ogrnumtxt.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(291, 211);
            this.dataGridView1.TabIndex = 12;
            // 
            // ogrkaydet
            // 
            this.ogrkaydet.Location = new System.Drawing.Point(88, 185);
            this.ogrkaydet.Name = "ogrkaydet";
            this.ogrkaydet.Size = new System.Drawing.Size(124, 40);
            this.ogrkaydet.TabIndex = 13;
            this.ogrkaydet.Text = "KAYDET";
            this.ogrkaydet.UseVisualStyleBackColor = true;
            // 
            // kayittarihi
            // 
            this.kayittarihi.Location = new System.Drawing.Point(150, 60);
            this.kayittarihi.Name = "kayittarihi";
            this.kayittarihi.Size = new System.Drawing.Size(152, 20);
            this.kayittarihi.TabIndex = 14;
            // 
            // dogumtarihi
            // 
            this.dogumtarihi.Location = new System.Drawing.Point(150, 112);
            this.dogumtarihi.Name = "dogumtarihi";
            this.dogumtarihi.Size = new System.Drawing.Size(152, 20);
            this.dogumtarihi.TabIndex = 15;
            // 
            // bolumcombo
            // 
            this.bolumcombo.FormattingEnabled = true;
            this.bolumcombo.Items.AddRange(new object[] {
            "BILGISAYAR PROGRAMCILIGI",
            "DENIZ LIMAN ISLETMECILIGI",
            "BROKER",
            "YONETIM BILISIM SISTEMLERI"});
            this.bolumcombo.Location = new System.Drawing.Point(150, 144);
            this.bolumcombo.Name = "bolumcombo";
            this.bolumcombo.Size = new System.Drawing.Size(121, 21);
            this.bolumcombo.TabIndex = 16;
            // 
            // ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 290);
            this.Controls.Add(this.bolumcombo);
            this.Controls.Add(this.dogumtarihi);
            this.Controls.Add(this.kayittarihi);
            this.Controls.Add(this.ogrkaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ogrnumtxt);
            this.Controls.Add(this.adsoyadtxt1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ogrenci";
            this.Text = "ogrenci";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adsoyadtxt1;
        private System.Windows.Forms.TextBox ogrnumtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ogrkaydet;
        private System.Windows.Forms.DateTimePicker kayittarihi;
        private System.Windows.Forms.DateTimePicker dogumtarihi;
        private System.Windows.Forms.ComboBox bolumcombo;
    }
}