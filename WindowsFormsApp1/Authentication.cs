using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.ComponentModel;

namespace WindowsFormsApp1
{


    class Authentication
    {

        private static string fromEmail = "teammiddleschooltstc@gmail.com";
        private static string emailPassword = "yycpdqbqhxumoaap";

        /// <summary>
        /// Login the user, if exists
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns> Boolean: True if user exists. false if user is not exists</returns>
        public static bool Authenticate(string email, string password)
        {
            // make a query to authenticate user
            String query = "SELECT FirstName, LastName, Email, Phone, Role FROM group3fa212330.Employees " +
                "WHERE email = '" + email + "' " +
                "AND " +
                "password = '" + password + "'";

            // Return boolean based on login
            return ProgOps.Login(query);
        }


        /// <summary>
        /// This will generate random 6 digit code. if user exist and send email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>String: Random 6 digit code, if user not exists it return empty string</returns>
        public static string GenerateRecoveryCode(string email)
        {
            // define recovery code
            string recoveryCode = "";
            Random rand = new Random();

            // if user fond generate the number
            if (ProgOps.SearchByEmail(email) == true)
            {
                // generate 6 digit code 
                int counter = 0;
                while (counter < 6)
                {
                    recoveryCode += rand.Next(0, 9).ToString();
                    counter++;
                }


                // Est email server connection
                SmtpClient client = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential()
                    {
                        UserName = fromEmail,
                        Password = emailPassword
                    }
                };

                // Set from, to and body.
                MailAddress from = new MailAddress(fromEmail, "Texas Middle School");
                MailAddress to = new MailAddress(email);
                string body = "This message contains a password reset code/recovery code. This recovery code can be used to recover your account. We found that someone is trying to reset your password. If this is not you trying to recover your account, please discard this email and you do not need to take any further action." +
                    "\n\n" +
                    "NOTE: PLEASE KEEP THIS CODE PRIVATE" +
                    "\n\n" +
                    "Recovery Code: " + recoveryCode + 
                    "\n\n" +
                    "Thank you," +
                    "\n\n" +
                    "Texas Middle School";

                MailMessage message = new MailMessage()
                {
                    From = from,
                    Subject = "Recovery Code",
                    Body = body,

                };

                message.To.Add(to);

                // try to send an email.
                try
                {

                    client.SendMailAsync(message);

                    MessageBox.Show("Message sent success fully.", "Email send", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Please remember you will only have 3 attempts to enter recovery code. The recovery code will expires after 3rd attempts.", "Guidelines", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error sending email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                // show message saying user with this email does not exist.
                MessageBox.Show($"Account does not exists with '{email}', if this is your email please double check and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            return recoveryCode;
        }




        /// <summary>
        /// Check if password and recovery code match.
        /// If so update the new old password to new password.
        /// 
        /// </summary>
        /// <param name="newPassword"></param>
        /// <param name="confirmPassword"></param>
        /// <param name="recoveryCode"></param>
        /// <param name="email"></param>
        /// <param name="generatedRecoveryCode"></param>
        public static void ChangePassword(string newPassword, string confirmPassword, string recoveryCode, string email, string generatedRecoveryCode)
        {
            // check if recovery code & password match
            if (newPassword == confirmPassword)
            {
                if (recoveryCode == generatedRecoveryCode)
                {
                    // if everything match correctly, reset the password
                    ProgOps.UpdatePassword(email, newPassword);
                }
                else
                {
                    // Show message if recovery code is not entered right
                    MessageBox.Show("Recovery code is not quite right. Please double check your recovery code then try again.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // show message if password doesn't match
                MessageBox.Show("Confirm password does not match to the new password. Please double check your password then try again.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }

}
