using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using DataLogMonitor.BLL;
using DataLogMonitor.DAL;
using System;

namespace DataLogMonitor.UI
{
    public partial class Users : MetroForm
    {
        UserBLL u = new UserBLL();
        UserDAL dal = new UserDAL();
        private static Users _instance;
        public static Users Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Users();
                return _instance;
            }
        }
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, System.EventArgs e)
        {
            DataTable dt = dal.Select();
            mGridUsr.DataSource = dt;
        }

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        #region btnAdd User
        private void btnAddUsr_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxUsrName.Text) && !string.IsNullOrEmpty(txtBoxUsrEmail.Text) && !string.IsNullOrEmpty(txtBoxUsrPwd.Text))
            {               
                u.email = txtBoxUsrEmail.Text.Trim();
                u.username = txtBoxUsrName.Text.Trim();
                u.password = txtBoxUsrPwd.Text.Trim();
                bool isunique = dal.Check(u);
                if (!isunique == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Username or Email Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                   
                    txtBoxUsrName.Focus();
                }
                else
                {
                    bool check = dal.insert(u);
                    if (check == true)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "User data added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "User data was not added please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    DataTable dt = dal.Select();
                    mGridUsr.DataSource = dt;
                }               
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please fill in all the details!.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
        }
        #endregion
        private void clear()
        {
            txtBoxUsrId.Text = "";
            txtBoxUsrEmail.Text = "";
            txtBoxUsrName.Text = "";
            txtBoxUsrPwd.Text = "";  
        }
        #region mGridUsr_RowHeaderMouseClick
        private void mGridUsr_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ri = e.RowIndex;
            txtBoxUsrId.Text = mGridUsr.Rows[ri].Cells[0].Value.ToString();       
            txtBoxUsrEmail.Text = mGridUsr.Rows[ri].Cells[1].Value.ToString();
            txtBoxUsrName.Text = mGridUsr.Rows[ri].Cells[2].Value.ToString();
            txtBoxUsrPwd.Text = mGridUsr.Rows[ri].Cells[3].Value.ToString();
        }
        #endregion
        #region btnUpdteUsr_ClicK
        private void btnUpdteUsr_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxUsrName.Text) && !string.IsNullOrEmpty(txtBoxUsrEmail.Text) && !string.IsNullOrEmpty(txtBoxUsrPwd.Text))
            {
                u.id = Convert.ToInt32(txtBoxUsrId.Text);
                u.email = txtBoxUsrEmail.Text.Trim();
                u.username = txtBoxUsrName.Text.Trim();
                u.password = txtBoxUsrPwd.Text.Trim();
                bool check = dal.update(u);
                if (check == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "User data updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "User data was not updated please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DataTable dt = dal.Select();
                mGridUsr.DataSource = dt;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please fill in all the details!.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        #endregion
        #region BtnDelusr Click
        private void btnDelUsr_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxUsrId.Text))
            {
                u.id = Convert.ToInt32(txtBoxUsrId.Text);
                bool check = dal.delete(u);
                if (check == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "User deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "User data was not deleted please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DataTable dt = dal.Select();
                mGridUsr.DataSource = dt;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Select a user to proceed!.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        #endregion

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtBoxSearch.Text;
            if (keyword != null)
            {
                DataTable dt = dal.Search(keyword);
                mGridUsr.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                mGridUsr.DataSource = dt;
            }
        }
    }
}
