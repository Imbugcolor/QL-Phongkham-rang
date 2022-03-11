using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProjectQLBV
{
    class BenhnhanDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public BenhnhanDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllBenhnhan()
        {
            string sql = "SELECT * FROM [BỆNH NHÂN]";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertBenhnhan(tblBenhnhan bn)
        {
            string sql = "INSERT INTO [BỆNH NHÂN](MBN,hotenbn,ngaysinh,gioitinh,sdt,diachi,ghichu,ngaykham) VALUES(@MBN,@hotenbn,@ngaysinh,@gioitinh,@sdt,@diachi,@ghichu,@ngaykham)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MBN", SqlDbType.NChar).Value = bn.MBN;
                cmd.Parameters.Add("@hotenbn", SqlDbType.NVarChar).Value = bn.hotenbn;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar).Value = bn.ngaysinh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NChar).Value = bn.gioitinh;
                cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = bn.sdt;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = bn.diachi;
                cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = bn.ghichu;
                cmd.Parameters.Add("@ngaykham", SqlDbType.NVarChar).Value = bn.ngaykham;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateBenhnhan(tblBenhnhan bn)
        {
            string sql = "UPDATE [BỆNH NHÂN] SET MBN = @MBN, hotenbn = @hotenbn,ngaysinh = @ngaysinh,gioitinh = @gioitinh,sdt = @sdt,diachi = @diachi,ghichu = @ghichu,ngaykham = @ngaykham WHERE MBN=@MBN";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MBN", SqlDbType.NChar).Value = bn.MBN;
                cmd.Parameters.Add("@hotenbn", SqlDbType.NVarChar).Value = bn.hotenbn;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar).Value = bn.ngaysinh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NChar).Value = bn.gioitinh;
                cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = bn.sdt;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = bn.diachi;
                cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = bn.ghichu;
                cmd.Parameters.Add("@ngaykham", SqlDbType.NVarChar).Value = bn.ngaykham;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteBenhnhan(tblBenhnhan bn)
        {
            string sql = "DELETE FROM [BỆNH NHÂN] WHERE MBN = '" + bn.MBN + "'";
            SqlConnection con = dc.getConnect();
            try
            {

                cmd = new SqlCommand(sql, con);
                con.Open();
                //cmd.Parameters.Add("@MBN", SqlDbType.NChar).Value = bn.MBN;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable SearchBN(string bn)
        {
            string sql = "SELECT * FROM [BỆNH NHÂN] WHERE hotenbn like N'%" + bn + "%' OR MBN like N'%" + bn + "%'";
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

