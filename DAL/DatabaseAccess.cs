using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SqlconnectionData
    {
        // tao chuoi ket noi csdl
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=DESKTOP-F55VHGS;Initial Catalog=QLSHOPAOQUAN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon); // khoi tao connect
            return conn;
        }
    }
    public class DatabaseAccess
    {
        public static string CheckLogicDTO(TaiKhoan taikhoan)
        {
            string user = null;
            // Ham connect toi csdl
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            /*SqlCommand command = new(" proc_logic", conn);*/
            SqlCommand command = new("proc_logic", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taikhoan.sTaiKhoan);
            command.Parameters.AddWithValue("@pass", taikhoan.sMatKhau);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows )
            {
                    while( reader.Read())
                {
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                conn.Close();
            }else
            {
                return "Tai khoan hoac mat khau khong chinh xac!";
            }
            return user;

        }

    }

}
