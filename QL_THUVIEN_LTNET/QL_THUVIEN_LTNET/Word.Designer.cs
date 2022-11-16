namespace QL_THUVIEN_LTNET
{
    partial class Word
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
            this.rtfdata = new System.Windows.Forms.RichTextBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtfdata
            // 
            this.rtfdata.Location = new System.Drawing.Point(11, 11);
            this.rtfdata.Margin = new System.Windows.Forms.Padding(2);
            this.rtfdata.Name = "rtfdata";
            this.rtfdata.Size = new System.Drawing.Size(778, 350);
            this.rtfdata.TabIndex = 1;
            this.rtfdata.Text = "";
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnopen.Location = new System.Drawing.Point(581, 388);
            this.btnopen.Margin = new System.Windows.Forms.Padding(2);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(89, 32);
            this.btnopen.TabIndex = 3;
            this.btnopen.Text = " Mở";
            this.btnopen.UseVisualStyleBackColor = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnthoat.Location = new System.Drawing.Point(700, 388);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(89, 32);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = " Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 494);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.rtfdata);
            this.Name = "Word";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfdata;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnthoat;
    }
}