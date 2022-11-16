using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_THUVIEN_LTNET
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
            pn_dangky.Visible= false;
          
        }
        ketnoi kn = new ketnoi();
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           
            


            kn.moketnoi();
            if(txt_pass.Text == "" || txt_user.Text == "" )
            {
                MessageBox.Show("Vui long nhap đầy đủ thông tin tài khoản và mật khẩu ");
            }
            else
            {
               
                String sql = "Select * from DocGia where Username = '" +txt_user.Text +"' and Pass = '"+txt_pass.Text +"' ";
                DataTable dt = new DataTable();
                

                dt = kn.docdulieu(sql);
               
                    //Lấy giá trị ở cột quyền gán vào biến  quyền
                    if(dt.Rows.Count > 0)
                    {
                        for(int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (dt.Rows[i]["Quyen"].ToString()=="1")
                            {
                                MessageBox.Show("Bạn đang đăng nhập với quyền Admin!");
                                frm_Admin admin = new frm_Admin();
                                admin.Show();
                                this.Hide();
                            }
                            else if(dt.Rows[i]["Quyen"].ToString()=="0")
                            {
                                MessageBox.Show("Đăng nhập thành công !");
                                frm_user user = new frm_user(txt_user.Text);
                                user.Show();
                                this.Hide();
                            }   
                        }    
                    }   
                    else
                {
                    MessageBox.Show("Thong tin tài khoản hoặc mật khẩu không đúng !");
                }    

                   
                   
                   
            }    
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pn_dangky_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            btn_Signup.Enabled = false;
            pn_dangky.Visible = true;
            
         
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_thoat2_Click(object sender, EventArgs e)
        {
            pn_dangky.Visible = false;
            panel1.Visible = true;
        }

        private void btn_dangky_Click(object sender, EventArgs e)

        {
           
            if (txt_nhaplaipass.Text == "" || txt_passdk.Text ==""||txt_userdk.Text ==""||txt_madg.Text=="")
            {
                MessageBox.Show("Vui long nhập đầy đủ thông tin đăng ký");
            }
            else if(txt_nhaplaipass.Text != txt_passdk.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp !");

            }
            else
            {
                bool check = false;
                String sql1 = "Select * from DocGia where Username = '" +txt_userdk.Text +"' or MaDG = '"+txt_madg.Text +"' ";
                DataTable dt1 = new DataTable();
               dt1 =  kn.docdulieu(sql1);
                if (dt1.Rows.Count > 0)
                {
                    MessageBox.Show("Mã hoặc tên độc giả đã tồn tại !", "Thông báo");

                }
               else
                {
                    String sql2 = "INSERT INTO DocGia(MaDG,Username,Pass,Quyen) VALUES (N'" + txt_madg.Text + "', '" + txt_userdk.Text+ "','" + txt_passdk.Text +"',0)";
                    if (kn.thucthidulieu(sql2) == true)
                    {
                        MessageBox.Show("Đăng ký thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi !!");
                    }
                }    
                
                 
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
