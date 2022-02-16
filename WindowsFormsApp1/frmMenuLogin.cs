using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMenuLogin : Form
    {
        public frmMenuLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            if (cbxKeepLoggedIn.Checked)
            {
                /// This check if user want to keep logged in
                /// If user want to keep logged in then
                
                // Set UserName and Password in properties setting
                Properties.Settings.Default.UserName = tbxUserName.Text;
                Properties.Settings.Default.Password = tbxPassword.Text;
                Properties.Settings.Default.Save();

                
            }
            
            if (!cbxKeepLoggedIn.Checked)
            {
                /// This check if user want to keep logged in
                /// If user do not want to keep logged in then

                // Set UserName and Password to empty string in properties setting
                // This will remove any existing value from userName and password
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }

            // Finally Show Menu
            frmMenuTeacher fm = new frmMenuTeacher();
            fm.Show();
        }

        private void frmMenuLogin_Load(object sender, EventArgs e)
        {
            ///
            /// First check if user already have checked keep logged in
            /// 

            if (Properties.Settings.Default.UserName != string.Empty)
            {
                // This body only runs if Properties has any value
                // for userName and password

                // Show userName and password
                tbxUserName.Text = Properties.Settings.Default.UserName;
                tbxPassword.Text = Properties.Settings.Default.Password;
            }
            
        }
    }
}
