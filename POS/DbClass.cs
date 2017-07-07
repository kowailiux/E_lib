using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace POS
{
    class DbClass
    {
       public static String strConn = "Data Source=.;Initial Catalog=pos;Integrated Security=True";
        public static SqlConnection cn = new SqlConnection(strConn);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter da = new SqlDataAdapter();
        //public SqlDataReader dr = new SqlDataReader();

        public object GetCheck(String sql, SqlParameter para)
        {

            dynamic intCount = null;
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.Add(para);
            intCount = cmd.ExecuteScalar();
            cn.Close();

            return intCount;
        }
        public void CreateDelete(String sql, SqlParameter parar)
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.Parameters.Add(parar);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public  DataTable LoadAndReturnMultiRow(string[] ColumnList, string TableName, string Filter, string Order)
        {

            string str = "Select ";
            for (int i = 0; i < ColumnList.Length; i++)
            {
                str += ColumnList[i] + ",";
            }
            str = str.Substring(0, str.Length - 1);
            str += " From " + TableName;
            if (Filter != "") str += " Where " + Filter;
            if (Order != "") str += " Order by " + Order;
           // cn = new SqlConnection(strconn);
            cn = new SqlConnection(strConn);
            da = new SqlDataAdapter(str, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Tbl");

            return ds.Tables["Tbl"];
        }

        public  void CREATE(string[] ColumnList, string[] DataList, string TableName)
        {
            string str = "Insert Into " + TableName + " (";
            for (int i = 0; i < ColumnList.Length; i++)
            {
                str += ColumnList[i] + ",";
            }
            str = str.Substring(0, str.Length - 1);
            str += ") Values (";

            for (int i = 0; i < ColumnList.Length; i++)
            {
                str += "@" + ColumnList[i] + ",";
            }

            str = str.Substring(0, str.Length - 1);
            str += ")";

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            cmd = new SqlCommand(str, cn);

            for (int i = 0; i < ColumnList.Length; i++)
            {

                cmd.Parameters.AddWithValue("@" + ColumnList[i], DataList[i]);
            }

            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void CREATE(string[] ColumnList, string[] DataList, string TableName, string ImageColumn, byte[] Photo)
        {
            int ColumnCount = ColumnList.Length;
            string str = "Insert Into " + TableName + " (";
            for (int i = 0; i < ColumnCount; i++)
            {
                str += ColumnList[i] + ",";
            }
            if (ImageColumn != "" && Photo != null)
            {
                str += ImageColumn + ",";
            }
            str = str.Substring(0, str.Length - 1);
            str += ") Values (";

            for (int i = 0; i < ColumnCount; i++)
            {
                str += "@" + ColumnList[i] + ",";
            }
            if (ImageColumn != "" && Photo != null)
            {
                str += "@" + ImageColumn + ",";
            }
            str = str.Substring(0, str.Length - 1);
            str += ")";
            cn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(str, cn);

            for (int i = 0; i < ColumnCount; i++)
            {

                cmd.Parameters.AddWithValue("@" + ColumnList[i], DataList[i]);
            }
            if (ImageColumn != "" && Photo != null)
            {

                cmd.Parameters.AddWithValue("@" + ImageColumn, Photo);

            }
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();


        }

        public  void UPDATE(string[] ColumnList, string[] DataList, string TableName, string filter)
        {
            string str = "UPDATE " + TableName + " SET ";
            for (int i = 0; i < ColumnList.Length; i++)
            {
                str += ColumnList[i] + "=@" + ColumnList[i] + ",";
            }
            str = str.Substring(0, str.Length - 1);
            str += " WHERE " + filter;

            cn = new SqlConnection(strConn);
            cmd = new SqlCommand(str, cn);
 
            for (int i = 0; i < ColumnList.Length; i++)
            {
                cmd.Parameters.AddWithValue("@" + ColumnList[i], DataList[i]);
            }

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public  void DELETE(string TableName, string Filter)
        {
            string str = "Delete From " + TableName;
            if (Filter != "") str += " Where " + Filter;

            cn = new SqlConnection(strConn);
            cmd = new SqlCommand(str, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

//---------------
    }
}
