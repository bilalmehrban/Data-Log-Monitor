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
using DataLogMonitor.UI;
namespace DataLogMonitor
{
    public partial class DataLogMonitor : MetroForm
    {
        
        
        public DataLogMonitor()
        {
            InitializeComponent();
        }
        private void ShowForm(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
            frm.Activate();
        }

        private void toolStripLogs_Click(object sender, EventArgs e)
        {
            ShowForm(Logs.Instance);
        }

        private void toolStripUsers_Click(object sender, EventArgs e)
        {
            ShowForm(Users.Instance);
        }
    }
}
