using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldOfSoftuniRPG.Forms
{
    using WorldOfSoftUniRPG.Models.Utilities;

    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userName = this.userNameRegister.Text;
            var password = this.passwordRegister.Text;
            var confirmPassword = this.confirmPasswordRegister.Text;
            var email = this.emailRegister.Text;
            var validationUsername = UsernameRegisterValidation.IsValid(userName);
            var validationEmail = EmailRegisterValidation.IsValid(email);

            if (validationUsername != UsernameRegisterValidation.UsernameType.Success)
            {
                if (validationUsername == UsernameRegisterValidation.UsernameType.Empty)
                {
                    this.usernameEmpty.Visible = true;
                }
                else if (validationUsername == UsernameRegisterValidation.UsernameType.Lenght)
                {
                    this.usernameLenght.Visible = true;
                }
                else
                {
                    this.usernameInvalid.Visible = true;
                }
            }
            else if ()
            {
                
            }

            else if (validationEmail != EmailRegisterValidation.EmailValidationMsg.Success)
            {
                if (validationEmail == EmailRegisterValidation.EmailValidationMsg.Empty)
                {
                    this.EmailEmpty.Visible = true;
                }
                else
                {
                    this.InvalidEmail.Visible = true;
                }

                this.emailRegister.Text = string.Empty;
            }
        }
    }
}
