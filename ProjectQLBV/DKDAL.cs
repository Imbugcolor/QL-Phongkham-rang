using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProjectQLBV
{
    class DKDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public DKDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllDK()
        {
            string sql = "SELECT * FROM [Dangky]";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertDK(tblDangkykb dk)
        {
            string sql = "INSERT INTO [Dangky](Madk,hotendk,thoigiandk,thoigianhen,buoihen,sdtdk,ghichudk) VALUES(@Madk,@hotendk,@thoigiandk,@thoigianhen,@buoihen,@sdtdk,@ghichudk)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Madk", SqlDbType.NChar).Value = dk.Madk;
                cmd.Parameters.Add("@hotendk", SqlDbType.NVarChar).Value = dk.hotendk;
                cmd.Parameters.Add("@thoigiandk", SqlDbType.NVarChar).Value = dk.thoigiandk;
                cmd.Parameters.Add("@thoigianhen", SqlDbType.NVarChar).Value = dk.thoigianhen;
                cmd.Parameters.Add("@buoihen", SqlDbType.NVarChar).Value = dk.buoihen;
                cmd.Parameters.Add("@sdtdk", SqlDbType.NVarChar).Value = dk.sdtdk;
                cmd.Parameters.Add("@ghichudk", SqlDbType.NVarChar).Value = dk.ghichudk;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateDK(tblDangkykb dk)
        {
            string sql = "UPDATE [Dangky] SET Madk = @Madk, hotendk = @hotendk,thoigiandk = @thoigiandk,thoigianhen = @thoigianhen,buoihen=@buoihen,sdtdk = @sdtdk,ghichudk = @ghichudk WHERE Madk=@Madk";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Madk", SqlDbType.NChar).Value = dk.Madk;
                cmd.Parameters.Add("@hotendk", SqlDbType.NVarChar).Value = dk.hotendk;
                cmd.Parameters.Add("@thoigiandk", SqlDbType.NVarChar).Value = dk.thoigiandk;
                cmd.Parameters.Add("@thoigianhen", SqlDbType.NVarChar).Value = dk.thoigianhen;
                cmd.Parameters.Add("@buoihen", SqlDbType.NVarChar).Value = dk.buoihen;
                cmd.Parameters.Add("@sdtdk", SqlDbType.NVarChar).Value = dk.sdtdk;
                cmd.Parameters.Add("@ghichudk", SqlDbType.NVarChar).Value = dk.ghichudk;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteDK(tblDangkykb dk)
        {
            string sql = "DELETE FROM [Dangky] WHERE Madk = '" + dk.Madk + "'";
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
        //public DataTable SearchBS(string bs)
        //{
        //    string sql = "SELECT * FROM [BÁC SĨ] WHERE hotenbs like N'%" + bs + "%' OR MS like N'%" + bs + "%'";
        //    SqlConnection con = dc.getConnect();
        //    da = new SqlDataAdapter(sql, con);
        //    con.Open();
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    con.Close();
        //    return dt;
        //}
    }
}
