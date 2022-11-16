namespace QL_THUVIEN_LTNET
{
    partial class frm_phieumuon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_sl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_sl = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_nv = new System.Windows.Forms.ComboBox();
            this.cb_dg = new System.Windows.Forms.ComboBox();
            this.cb_sach = new System.Windows.Forms.ComboBox();
            this.dtpngaytra = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_mapm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_giahan = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_trasach = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_pm = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_tuychon = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 49);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ PHIẾU MƯỢN TRẢ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb_tuychon);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lb_sl);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cb_sl);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cb_nv);
            this.panel2.Controls.Add(this.cb_dg);
            this.panel2.Controls.Add(this.cb_sach);
            this.panel2.Controls.Add(this.dtpngaytra);
            this.panel2.Controls.Add(this.dtp_ngaymuon);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_mapm);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 199);
            this.panel2.TabIndex = 7;
            // 
            // lb_sl
            // 
            this.lb_sl.AutoSize = true;
            this.lb_sl.ForeColor = System.Drawing.Color.Red;
            this.lb_sl.Location = new System.Drawing.Point(536, 174);
            this.lb_sl.Name = "lb_sl";
            this.lb_sl.Size = new System.Drawing.Size(49, 13);
            this.lb_sl.TabIndex = 31;
            this.lb_sl.Text = "Số lượng";
            this.lb_sl.Click += new System.EventHandler(this.lb_sl_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(353, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Tổng số sách đã cho mượn là :";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // cb_sl
            // 
            this.cb_sl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sl.FormattingEnabled = true;
            this.cb_sl.Location = new System.Drawing.Point(420, 92);
            this.cb_sl.Name = "cb_sl";
            this.cb_sl.Size = new System.Drawing.Size(166, 25);
            this.cb_sl.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(311, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "So luong sach";
            // 
            // cb_nv
            // 
            this.cb_nv.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nv.FormattingEnabled = true;
            this.cb_nv.Location = new System.Drawing.Point(102, 138);
            this.cb_nv.Name = "cb_nv";
            this.cb_nv.Size = new System.Drawing.Size(166, 25);
            this.cb_nv.TabIndex = 27;
            // 
            // cb_dg
            // 
            this.cb_dg.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dg.FormattingEnabled = true;
            this.cb_dg.Location = new System.Drawing.Point(102, 92);
            this.cb_dg.Name = "cb_dg";
            this.cb_dg.Size = new System.Drawing.Size(166, 25);
            this.cb_dg.TabIndex = 26;
            // 
            // cb_sach
            // 
            this.cb_sach.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sach.FormattingEnabled = true;
            this.cb_sach.Location = new System.Drawing.Point(102, 54);
            this.cb_sach.Name = "cb_sach";
            this.cb_sach.Size = new System.Drawing.Size(166, 25);
            this.cb_sach.TabIndex = 25;
            this.cb_sach.SelectedIndexChanged += new System.EventHandler(this.cb_sach_SelectedIndexChanged);
            // 
            // dtpngaytra
            // 
            this.dtpngaytra.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaytra.Location = new System.Drawing.Point(420, 54);
            this.dtpngaytra.Name = "dtpngaytra";
            this.dtpngaytra.Size = new System.Drawing.Size(166, 25);
            this.dtpngaytra.TabIndex = 24;
            // 
            // dtp_ngaymuon
            // 
            this.dtp_ngaymuon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaymuon.Location = new System.Drawing.Point(420, 17);
            this.dtp_ngaymuon.Name = "dtp_ngaymuon";
            this.dtp_ngaymuon.Size = new System.Drawing.Size(166, 25);
            this.dtp_ngaymuon.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(311, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ngày mượn";
            // 
            // txt_mapm
            // 
            this.txt_mapm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mapm.Location = new System.Drawing.Point(102, 16);
            this.txt_mapm.Name = "txt_mapm";
            this.txt_mapm.Size = new System.Drawing.Size(166, 25);
            this.txt_mapm.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(311, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 19);
            this.label9.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(311, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Độc gia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã PM";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_giahan);
            this.panel3.Controls.Add(this.btn_thoat);
            this.panel3.Controls.Add(this.btn_trasach);
            this.panel3.Controls.Add(this.btn_sua);
            this.panel3.Controls.Add(this.btn_them);
            this.panel3.Location = new System.Drawing.Point(605, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 199);
            this.panel3.TabIndex = 30;
            // 
            // btn_giahan
            // 
            this.btn_giahan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giahan.Location = new System.Drawing.Point(17, 82);
            this.btn_giahan.Name = "btn_giahan";
            this.btn_giahan.Size = new System.Drawing.Size(169, 25);
            this.btn_giahan.TabIndex = 4;
            this.btn_giahan.Text = "Gia hạn";
            this.btn_giahan.UseVisualStyleBackColor = true;
            this.btn_giahan.Click += new System.EventHandler(this.btn_giahan_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(16, 162);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(169, 25);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_trasach
            // 
            this.btn_trasach.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trasach.Location = new System.Drawing.Point(16, 122);
            this.btn_trasach.Name = "btn_trasach";
            this.btn_trasach.Size = new System.Drawing.Size(169, 25);
            this.btn_trasach.TabIndex = 2;
            this.btn_trasach.Text = "Trả sách";
            this.btn_trasach.UseVisualStyleBackColor = true;
            this.btn_trasach.Click += new System.EventHandler(this.btn_trasach_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(17, 48);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(169, 25);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(16, 14);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(169, 25);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Tạo phiếu mượn";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_pm);
            this.panel4.Location = new System.Drawing.Point(1, 262);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(799, 220);
            this.panel4.TabIndex = 31;
            // 
            // dgv_pm
            // 
            this.dgv_pm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pm.Location = new System.Drawing.Point(3, 3);
            this.dgv_pm.Name = "dgv_pm";
            this.dgv_pm.Size = new System.Drawing.Size(796, 225);
            this.dgv_pm.TabIndex = 0;
            this.dgv_pm.SelectionChanged += new System.EventHandler(this.dgv_pm_SelectionChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(317, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 19);
            this.label13.TabIndex = 32;
            this.label13.Text = "Tùy chọn";
            // 
            // cb_tuychon
            // 
            this.cb_tuychon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tuychon.FormattingEnabled = true;
            this.cb_tuychon.Items.AddRange(new object[] {
            "Tất cả phiếu mượn",
            "Phiếu mượn quá hạn"});
            this.cb_tuychon.Location = new System.Drawing.Point(420, 138);
            this.cb_tuychon.Name = "cb_tuychon";
            this.cb_tuychon.Size = new System.Drawing.Size(166, 25);
            this.cb_tuychon.TabIndex = 33;
            this.cb_tuychon.SelectedIndexChanged += new System.EventHandler(this.cb_tuychon_SelectedIndexChanged);
            // 
            // frm_phieumuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 494);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_phieumuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_phieumuon";
            this.Load += new System.EventHandler(this.frm_phieumuon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtp_ngaymuon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_mapm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpngaytra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_giahan;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_trasach;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox cb_nv;
        private System.Windows.Forms.ComboBox cb_dg;
        private System.Windows.Forms.ComboBox cb_sach;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_pm;
        private System.Windows.Forms.ComboBox cb_sl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_sl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_tuychon;
    }
}