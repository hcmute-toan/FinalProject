using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public class DBConnection
    {
        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.ConnStr);
        public DBConnection() { }

        //public DataTable Load(string table)
        //{
        //    DataTable datatable = new DataTable();
        //    try
        //    {
        //        conn.Open();
        //        string sqlStr = string.Format($"SELECT *FROM {table} ");

        //        SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);

        //        adapter.Fill(datatable);

        //        return datatable;
        //    }
        //    catch (Exception exc)
        //    {
        //        MessageBox.Show(exc.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return datatable;
        //}
        public void Excude(string SQL)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Successful!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail!!!" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
