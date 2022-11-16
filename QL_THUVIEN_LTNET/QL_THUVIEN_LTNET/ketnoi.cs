using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_THUVIEN_LTNET
{
    internal class ketnoi
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H79AQE2\NGUYENPHUOC;Initial Catalog=QL_THUVIEN;Integrated Security=True");
        public void moketnoi()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
       }
        public void dongketnoi()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public Boolean thucthidulieu(string cmd) //hàm thực thi dữ liệu có tham số cmd
        {
            moketnoi();//mở kết nối dữ liệu
            Boolean check = false;// gán check = sai
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            dongketnoi();
            return check;//nếu thực thi câu lệnh sql được thì hảm trả về check= đúng ngược lại check=sai.
        }
        public DataTable docdulieu(string cmd)//hàm đọc dữ liệu đỗ dữ liệu vào lướisử dụng sqldatadapter để chuyển đổi dữ liệu từ lệnh cmd trả về. Sau đó thì dùng Fill để đổ dữ liệu từ adapter vào datatable và cuối cùng là trả về một bảng chứa dữ liệu đã truy vấn.
        {
            moketnoi();
            DataTable da = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(da);
            }
            catch (Exception)
            {
                da = null;
            }
            dongketnoi();
            return da;
        }
    }
}
