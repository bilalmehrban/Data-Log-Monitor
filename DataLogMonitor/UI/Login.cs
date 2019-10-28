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
using DataLogMonitor.UI;
using MetroFramework.Components;
using DataLogMonitor.BLL;
using DataLogMonitor.DAL;
namespace DataLogMonitor.UI
{
    public partial class Login : MetroForm
    {
        LoginBLL u = new LoginBLL();
        LoginDAL dal = new LoginDAL();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManagerLogin;
            metroStyleManagerLogin.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManagerLogin.Style = MetroFramework.MetroColorStyle.Green;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {                
                MetroFramework.MetroMessageBox.Show(this, "Please enter your username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter your Password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            u.username = txtUsername.Text.Trim();
            u.password = txtPassword.Text.Trim();
            bool check = dal.login(u);
            if (check == true)
            {
                MetroFramework.MetroMessageBox.Show(this, "Login Successful!", "Logged In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataLogMonitor admin = new DataLogMonitor();
                admin.Show();
                this.Hide();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Your username or password is incorrect", "Invalid Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}
