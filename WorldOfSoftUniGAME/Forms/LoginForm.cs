namespace WorldOfSoftuniRPG.Forms
{
    using System;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    using WorldOfSoftUniRPG.Data;
    using WorldOfSoftUniRPG.Models.Utilities;

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            this.InitializeComponent();
        }
        private void logButton_Click(object sender, EventArgs e)
        {
            var context = new WorldOfSoftUniContext();

            var username = this.userName.Text;
            var password = PasswordHashAlgorithm.Hash(this.passwordBox.Text);

            var currentUser = context.Users.FirstOrDefault(user => user.UserName == username);
            if (currentUser == null || currentUser.PasswordHash != password)
            {
                this.wrongLabel.Visible = true;
                this.userName.Text = string.Empty;
                this.passwordBox.Text = string.Empty;
            }
            else
            {
                currentUser.IsLogged = true;
                context.SaveChanges();

                this.Hide();
                var menu = new Frm_Menu();
                menu.Closed += (s, args) => this.Close();
                menu.Show();
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Register();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }
    }
}