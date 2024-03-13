using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace _1055_LeXuanTruc
{
    class LOPDUNGCHUNG
    {
        string chuoiKN = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\lesson\.NET\Do an ca nhan\1055_LeXuanTruc\1055_LeXuanTruc\1055_LeXuanTruc.mdf"";Integrated Security=True";
        SqlConnection con;
        public LOPDUNGCHUNG()
        {
            con = new SqlConnection(chuoiKN);
        }
        public DataTable LoadDL(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int ThemXoaSua(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, con);
            con.Open();
            int kq =comm.ExecuteNonQuery();
            con.Close();
            return kq;
        }
        public object LayDL(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, con);
            con.Open();
            object kq = comm.ExecuteScalar();
            con.Close();
            return kq;
        }
    }
}
