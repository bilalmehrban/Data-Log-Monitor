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
    class DataLogsDAL
    {
        #region select data from database
        public DataTable select()
        {
            ConnClass cDL = new ConnClass();
            SqlConnection connDL = new SqlConnection(cDL.Datalogconnection);
            DataTable dtDL = new DataTable();
            try
            {
                string query = "SELECT* FROM Logs";
                SqlCommand cmdDL = new SqlCommand(query, connDL);
                SqlDataAdapter adapter = new SqlDataAdapter(cmdDL);
                connDL.Open();
                adapter.Fill(dtDL);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error While Loading!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MetroMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connDL.Close();
            }
            return dtDL;

        }
        #endregion
        #region Search Data From DataBase
        public DataTable Search(string keyword)
        {
            ConnClass c = new ConnClass();
            SqlConnection conn = new SqlConnection(c.Datalogconnection);
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT* FROM  Logs WHERE id Like '%" + keyword + "%' OR Level like '%" + keyword + "%' OR Type like '%" + keyword + "%'";
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
    }
}
