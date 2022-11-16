namespace QL_THUVIEN_LTNET
{
    partial class frm_tguser
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
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.rdb_tentg = new System.Windows.Forms.RadioButton();
            this.rdb_matg = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_tguser = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tguser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 49);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN TÁC GIẢ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_thoat);
            this.panel2.Controls.Add(this.btn_tim);
            this.panel2.Controls.Add(this.txt_timkiem);
            this.panel2.Controls.Add(this.rdb_tentg);
            this.panel2.Controls.Add(this.rdb_matg);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(2, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 124);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(623, 82);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(165, 26);
            this.btn_thoat.TabIndex = 12;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(623, 36);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(165, 26);
            this.btn_tim.TabIndex = 11;
            this.btn_tim.Text = "Tìm kiếm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(225, 59);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(364, 25);
            this.txt_timkiem.TabIndex = 10;
            // 
            // rdb_tentg
            // 
            this.rdb_tentg.AutoSize = true;
            this.rdb_tentg.Location = new System.Drawing.Point(50, 36);
            this.rdb_tentg.Name = "rdb_tentg";
            this.rdb_tentg.Size = new System.Drawing.Size(158, 23);
            this.rdb_tentg.TabIndex = 9;
            this.rdb_tentg.TabStop = true;
            this.rdb_tentg.Text = "Tìm theo ma tác giả";
            this.rdb_tentg.UseVisualStyleBackColor = true;
            // 
            // rdb_matg
            // 
            this.rdb_matg.AutoSize = true;
            this.rdb_matg.Location = new System.Drawing.Point(50, 82);
            this.rdb_matg.Name = "rdb_matg";
            this.rdb_matg.Size = new System.Drawing.Size(159, 23);
            this.rdb_matg.TabIndex = 8;
            this.rdb_matg.TabStop = true;
            this.rdb_matg.Text = "Tìm theo tên tác giả";
            this.rdb_matg.UseVisualStyleBackColor = true;
            this.rdb_matg.CheckedChanged += new System.EventHandler(this.rdb_matg_CheckedChanged);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_tguser);
            this.panel4.Location = new System.Drawing.Point(2, 186);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(799, 293);
            this.panel4.TabIndex = 13;
            // 
            // dgv_tguser
            // 
            this.dgv_tguser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tguser.Location = new System.Drawing.Point(3, 3);
            this.dgv_tguser.Name = "dgv_tguser";
            this.dgv_tguser.Size = new System.Drawing.Size(796, 284);
            this.dgv_tguser.TabIndex = 0;
            // 
            // frm_tguser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 494);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_tguser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_tguser";
            this.Load += new System.EventHandler(this.frm_tguser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tguser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.RadioButton rdb_tentg;
        private System.Windows.Forms.RadioButton rdb_matg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_tguser;
    }
}