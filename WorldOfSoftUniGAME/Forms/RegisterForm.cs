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
    using WorldOfSoftUniRPG.Data;
    using WorldOfSoftUniRPG.Models;
    using WorldOfSoftUniRPG.Models.Utilities;

    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new WorldOfSoftUniContext();

            var userName = this.userNameRegister.Text;
            var password = this.passwordRegister.Text;
            var confirmPassword = this.confirmPasswordRegister.Text;
            var email = this.emailRegister.Text;
            var validationUsername = UsernameRegisterValidation.IsValid(userName);
            var validationPassword = PasswordRegisterValidation.IsValid(password);
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
            else if (context.Users.Any(user => user.UserName == userName.ToLower()))
            {
                this.usernameExists.Visible = true;
            }
            else if (validationPassword != PasswordRegisterValidation.PasswordType.Success)
            {
                if (validationPassword == PasswordRegisterValidation.PasswordType.Empty)
                {
                    this.passwordEmpty.Visible = true;
                }
                else if (validationPassword == PasswordRegisterValidation.PasswordType.Lenght)
                {
                    this.passwordLenght.Visible = true;
                }
                else
                {
                    this.passwordInvalid.Visible = true;
                }

                this.passwordRegister.Text = string.Empty;
            }
            else if (password != confirmPassword)
            {
                this.confirmPasswordInvalid.Visible = true;

                this.confirmPasswordRegister.Text = string.Empty;
            }
            else if (validationEmail != EmailRegisterValidation.EmailValidationMsg.Success)
            {
                if (validationEmail == EmailRegisterValidation.EmailValidationMsg.Empty)
                {
                    this.emailEmpty.Visible = true;
                }
                else
                {
                    this.emailInvalid.Visible = true;
                }

                this.emailRegister.Text = string.Empty;
            }
            else
            {
                User user = new User()
                                {
                                    UserName = userName.ToLower(),
                                    PasswordHash = PasswordHashAlgorithm.Hash(password),
                                    Email = email
                                };

                context.Users.Add(user);

                context.SaveChanges();
            }
        }
    }
}
