using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using DataLogMonitor.BLL;
using DataLogMonitor.DAL;
namespace DataLogMonitor.UI
{
    public partial class Logs : MetroForm
    {
        private static Logs _instance;
        public static Logs Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Logs();
                return _instance;
            }
        }
        LogsBLL logsBLL = new LogsBLL();
        DataLogsDAL logsDAL = new DataLogsDAL();
        public Logs()
        {
            InitializeComponent();
        }

        private void Logs_Load(object sender, EventArgs e)
        {
            DataTable dataLogs = logsDAL.select();
            mGridLogs.DataSource = dataLogs;
        }

        private void Logs_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void txtBoxSearchLogs_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtBoxSearchLogs.Text;
            if (keyword != null)
            {
                DataTable dt = logsDAL.Search(keyword);
                mGridLogs.DataSource = dt;
            }
            else
            {
                DataTable dt = logsDAL.select();
                mGridLogs.DataSource = dt;
            }
        }
    }
}
