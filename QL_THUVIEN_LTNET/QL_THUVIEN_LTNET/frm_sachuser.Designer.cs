namespace QL_THUVIEN_LTNET
{
    partial class frm_sachuser
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_sachuser = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.rdb_tensach = new System.Windows.Forms.RadioButton();
            this.rdb_tg = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sachuser)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 49);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN SÁCH";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_sachuser);
            this.panel4.Location = new System.Drawing.Point(1, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(799, 293);
            this.panel4.TabIndex = 4;
            // 
            // dgv_sachuser
            // 
            this.dgv_sachuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sachuser.Location = new System.Drawing.Point(3, 3);
            this.dgv_sachuser.Name = "dgv_sachuser";
            this.dgv_sachuser.Size = new System.Drawing.Size(796, 284);
            this.dgv_sachuser.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_thoat);
            this.panel2.Controls.Add(this.btn_tim);
            this.panel2.Controls.Add(this.txt_timkiem);
            this.panel2.Controls.Add(this.rdb_tensach);
            this.panel2.Controls.Add(this.rdb_tg);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 124);
            this.panel2.TabIndex = 9;
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
            // rdb_tensach
            // 
            this.rdb_tensach.AutoSize = true;
            this.rdb_tensach.Location = new System.Drawing.Point(51, 36);
            this.rdb_tensach.Name = "rdb_tensach";
            this.rdb_tensach.Size = new System.Drawing.Size(145, 23);
            this.rdb_tensach.TabIndex = 9;
            this.rdb_tensach.TabStop = true;
            this.rdb_tensach.Text = "Tìm theo tên sách";
            this.rdb_tensach.UseVisualStyleBackColor = true;
            // 
            // rdb_tg
            // 
            this.rdb_tg.AutoSize = true;
            this.rdb_tg.Location = new System.Drawing.Point(51, 82);
            this.rdb_tg.Name = "rdb_tg";
            this.rdb_tg.Size = new System.Drawing.Size(159, 23);
            this.rdb_tg.TabIndex = 8;
            this.rdb_tg.TabStop = true;
            this.rdb_tg.Text = "Tìm theo tên tác giả";
            this.rdb_tg.UseVisualStyleBackColor = true;
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
            // frm_sachuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 494);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "frm_sachuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_sachuser";
            this.Load += new System.EventHandler(this.frm_sachuser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sachuser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_sachuser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.RadioButton rdb_tensach;
        private System.Windows.Forms.RadioButton rdb_tg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}