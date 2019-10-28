using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLogMonitor.BLL;
using MetroFramework.Forms;

namespace DataLogMonitor.DAL
{
    class LoginDAL
    {
        #region login fuction for database

        public bool login(LoginBLL u)
        {
            bool issuccess = false;
            ConnClass c = new ConnClass();
            SqlConnection conn = new SqlConnection(c.Appconnection);
            try
            {
                string query = "select * from tbl_user where username=@username AND password=@password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    issuccess = true;
                }
                else
                {
                    issuccess = false;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return issuccess;
        }


        #endregion
    }
}
