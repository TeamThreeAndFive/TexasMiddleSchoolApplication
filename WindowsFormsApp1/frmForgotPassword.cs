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
    public partial class frmForgotPassword : Form
    {
        static string  _recoveryCode;
        static int _attemptsCount = 0;
        static string _email;

        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSend_Click(object sender, EventArgs e)
        {

            // reset the password
            if (tbxEmail.Text != string.Empty)
            {
                // Disable send button, so user cannot send twice.
                btnSend.Enabled = false;

                // set email
                 _email = tbxEmail.Text;
            
                // set the recovery code
                _recoveryCode = Authentication.GenerateRecoveryCode(tbxEmail.Text);
                _attemptsCount = 0;

                tbxEmail.ReadOnly = true;
                
            }
            else
            {
                MessageBox.Show("Please enter required filed's. Required filed's are highlighted as yellow", "Filed Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // re enable send button
            btnSend.Enabled = true;

        }

        private void btnConfirmReset_Click(object sender, EventArgs e)
        {
            // check how many time user already attempted.
            if (_attemptsCount < 3)
            {
                
                // increment attempts counter by one
                _attemptsCount++;
                
                // check if all filled's have some value
                if (tbxNewPassword.Text != string.Empty && tbxConfirmPassword.Text != string.Empty && tbxRecoveryCode.Text != string.Empty)
                {
                    // if so, we change the password
                    Authentication.ChangePassword(tbxNewPassword.Text, tbxConfirmPassword.Text, tbxRecoveryCode.Text, _email, _recoveryCode);
                }
                else
                {
                    // if not, ask user to enter information.
                    MessageBox.Show("Please enter required filed's. Required filed's are highlighted as yellow", "Filed Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Show message that user have already attempted 3 times in a row.
                MessageBox.Show("You can not attempts more than 3. Please re-enter your email and hit send to receive a new code", "Recovery code expires", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // clear recovery code and email text box
                _recoveryCode = "";
                tbxEmail.Text = "";

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear each filed's
            tbxEmail.Text = "";
            tbxConfirmPassword.Text = "";
            tbxNewPassword.Text = "";
            tbxRecoveryCode.Text = "";

        }

        private void pbxShowNoShowPassword_Click_1(object sender, EventArgs e)
        {
            // change password visibility
            if (tbxConfirmPassword.PasswordChar == '*')
            {
                tbxConfirmPassword.PasswordChar = '\0';
                tbxNewPassword.PasswordChar = '\0';
            }
            else
            {
                tbxConfirmPassword.PasswordChar = '*';
                tbxNewPassword.PasswordChar = '*';
            }
        }
    }
}
