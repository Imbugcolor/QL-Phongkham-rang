using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProjectQLBV
{
    class BacsiDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public BacsiDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllBacsi()
        {
            string sql = "SELECT * FROM [BÁC SĨ]";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertBacsi(tblBacsi bs)
        {
            string sql = "INSERT INTO [BÁC SĨ](MS,hotenbs,Ngaysinh,Gioitinh,sdt,diachi) VALUES(@MS,@hotenbs,@Ngaysinh,@Gioitinh,@sdt,@diachi)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MS", SqlDbType.NChar).Value = bs.MS;
                cmd.Parameters.Add("@hotenbs", SqlDbType.NVarChar).Value = bs.hotenbs;
                cmd.Parameters.Add("@Ngaysinh", SqlDbType.NVarChar).Value = bs.Ngaysinh;
                cmd.Parameters.Add("@Gioitinh", SqlDbType.NChar).Value = bs.Gioitinh;
                cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = bs.sdt;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = bs.diachi;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateBacsi(tblBacsi bs)
        {
            string sql = "UPDATE [BÁC SĨ] SET MS = @MS, hotenbs = @hotenbs,Ngaysinh = @Ngaysinh,Gioitinh = @Gioitinh,sdt = @sdt,diachi = @diachi WHERE MS=@MS";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MS", SqlDbType.NChar).Value = bs.MS;
                cmd.Parameters.Add("@hotenbs", SqlDbType.NVarChar).Value = bs.hotenbs;
                cmd.Parameters.Add("@Ngaysinh", SqlDbType.NVarChar).Value = bs.Ngaysinh;
                cmd.Parameters.Add("@Gioitinh", SqlDbType.NChar).Value = bs.Gioitinh;
                cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = bs.sdt;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = bs.diachi;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteBacsi(tblBacsi bs)
        {
            string sql = "DELETE FROM [BÁC SĨ] WHERE MS = '" + bs.MS + "'";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                //cmd.Parameters.Add("@MS", SqlDbType.NChar).Value = bs.MS;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable SearchBS(string bs)
        {
            string sql = "SELECT * FROM [BÁC SĨ] WHERE hotenbs like N'%" + bs + "%' OR MS like N'%" + bs + "%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
