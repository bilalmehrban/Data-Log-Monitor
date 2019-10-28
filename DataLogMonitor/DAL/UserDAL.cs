using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataLogMonitor.BLL;
using MetroFramework;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
namespace DataLogMonitor.DAL
{
    class UserDAL
    {
        DataSet dataSet = new DataSet();
        #region select data from database
        public DataTable Select()
        {
            ConnClass c = new ConnClass();
            SqlConnection conn = new SqlConnection(c.Appconnection);
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT* FROM  tbl_user";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error While Loading!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                //MetroMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }
        #endregion
        #region Insert data into database
        public bool insert(UserBLL u)
        {
            bool issucess = false;
            ConnClass c = new ConnClass();
            SqlConnection conn = new SqlConnection(c.Appconnection);
            try
            {
                string query = "Insert into tbl_user(email,username,password)Values(@email,@username,@password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);               
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    issucess = true;
                }
                else
                {
                    issucess = false;
                }


            }
            catch (Exception)
            {
                issucess = false;
                return issucess;
            }
            finally
            {
                conn.Close();
            }

            return issucess;
        }
        #endregion
        #region Update data in database

        public bool update(UserBLL u)
        {
            bool issucess = false;
            ConnClass c = new ConnClass();
            SqlConnection conn = new SqlConnection(c.Appconnection);
            try
            {
                string query = "UPDATE tbl_user set email=@email,username=@username,password=@password WHERE id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@id", u.id);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    issucess = true;
                }
                else
                {
                    issucess = false;
                }
            }

            catch (Exception)
            {
                issucess = false;
                return issucess;
            }
            finally
            {
                conn.Close();
            }

            return issucess;
        }

        #endregion
        #region Delete record in Data Base
        public bool delete(UserBLL u)
        {
            bool issucess = false;
            ConnClass c = new ConnClass();
            SqlConnection conn = new SqlConnection(c.Appconnection);
            try
            {
                string query = "DELETE FROM tbl_user WHERE id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", u.id);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    issucess = true;
                }
                else
                {
                    issucess = false;
                }
            }

            catch (Exception)
            {
                issucess = false;
                return issucess;
            }
            finally
            {
                conn.Close();
            }

            return issucess;
        }
        #endregion
        #region Search Data From DataBase
        public DataTable Search(string keyword)
        {
            ConnClass c = new ConnClass();
            SqlConnection conn = new SqlConnection(c.Appconnection);
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT* FROM  tbl_user WHERE id Like '%" + keyword + "%' OR username like '%" + keyword + "%' OR email like '%" + keyword + "%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return dt;

        }
        #endregion
        #region Check Username and Email
        public bool Check(UserBLL u)
        {
            bool isunique = false;
            ConnClass c = new ConnClass();
            SqlConnection conn = new SqlConnection(c.Appconnection);
            try
            {
                string query = "Select * From tbl_user where email='"+u.username+ "' OR username='" + u.email + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                conn.Open();
                dataAdapter.Fill(dataSet);
                int i = dataSet.Tables[0].Rows.Count;
                if (i > 0)
                {
                    isunique = true;
                }
                else
                {
                    isunique = false;
                }


            }
            catch (Exception)
            {
                isunique = false;
                return isunique;
            }
            finally
            {
                conn.Close();
            }
            return isunique;
        }
#endregion
    }
}
