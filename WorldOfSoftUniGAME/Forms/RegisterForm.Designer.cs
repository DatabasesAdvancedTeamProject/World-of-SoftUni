namespace WorldOfSoftuniRPG.Forms
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.userNameRegister = new System.Windows.Forms.TextBox();
            this.passwordRegister = new System.Windows.Forms.TextBox();
            this.emailRegister = new System.Windows.Forms.TextBox();
            this.userNameLabelRegister = new System.Windows.Forms.Label();
            this.passwordLabelRegister = new System.Windows.Forms.Label();
            this.emailLabelRegister = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordRegister = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.usernameInvalid = new System.Windows.Forms.Label();
            this.usernameLenght = new System.Windows.Forms.Label();
            this.usernameEmpty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameRegister
            // 
            this.userNameRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameRegister.Location = new System.Drawing.Point(71, 86);
            this.userNameRegister.MaxLength = 20;
            this.userNameRegister.Name = "userNameRegister";
            this.userNameRegister.Size = new System.Drawing.Size(201, 26);
            this.userNameRegister.TabIndex = 1;
            // 
            // passwordRegister
            // 
            this.passwordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRegister.Location = new System.Drawing.Point(71, 167);
            this.passwordRegister.MaxLength = 20;
            this.passwordRegister.Name = "passwordRegister";
            this.passwordRegister.Size = new System.Drawing.Size(201, 26);
            this.passwordRegister.TabIndex = 2;
            // 
            // emailRegister
            // 
            this.emailRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailRegister.Location = new System.Drawing.Point(70, 343);
            this.emailRegister.MaxLength = 20;
            this.emailRegister.Name = "emailRegister";
            this.emailRegister.Size = new System.Drawing.Size(201, 26);
            this.emailRegister.TabIndex = 3;
            // 
            // userNameLabelRegister
            // 
            this.userNameLabelRegister.AutoSize = true;
            this.userNameLabelRegister.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabelRegister.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabelRegister.ForeColor = System.Drawing.Color.White;
            this.userNameLabelRegister.Location = new System.Drawing.Point(117, 59);
            this.userNameLabelRegister.Name = "userNameLabelRegister";
            this.userNameLabelRegister.Size = new System.Drawing.Size(101, 25);
            this.userNameLabelRegister.TabIndex = 4;
            this.userNameLabelRegister.Text = "Username:";
            // 
            // passwordLabelRegister
            // 
            this.passwordLabelRegister.AutoSize = true;
            this.passwordLabelRegister.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabelRegister.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabelRegister.ForeColor = System.Drawing.Color.White;
            this.passwordLabelRegister.Location = new System.Drawing.Point(117, 140);
            this.passwordLabelRegister.Name = "passwordLabelRegister";
            this.passwordLabelRegister.Size = new System.Drawing.Size(98, 25);
            this.passwordLabelRegister.TabIndex = 5;
            this.passwordLabelRegister.Text = "Password:";
            this.passwordLabelRegister.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailLabelRegister
            // 
            this.emailLabelRegister.AutoSize = true;
            this.emailLabelRegister.BackColor = System.Drawing.Color.Transparent;
            this.emailLabelRegister.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabelRegister.ForeColor = System.Drawing.Color.White;
            this.emailLabelRegister.Location = new System.Drawing.Point(132, 317);
            this.emailLabelRegister.Name = "emailLabelRegister";
            this.emailLabelRegister.Size = new System.Drawing.Size(68, 25);
            this.emailLabelRegister.TabIndex = 6;
            this.emailLabelRegister.Text = "Email:";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(84, 229);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(171, 25);
            this.confirmPasswordLabel.TabIndex = 8;
            this.confirmPasswordLabel.Text = "Confirm Password:";
            // 
            // confirmPasswordRegister
            // 
            this.confirmPasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPasswordRegister.Location = new System.Drawing.Point(71, 257);
            this.confirmPasswordRegister.MaxLength = 20;
            this.confirmPasswordRegister.Name = "confirmPasswordRegister";
            this.confirmPasswordRegister.Size = new System.Drawing.Size(201, 26);
            this.confirmPasswordRegister.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.GreenYellow;
            this.button1.Location = new System.Drawing.Point(107, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "REGISTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernameInvalid
            // 
            this.usernameInvalid.AutoSize = true;
            this.usernameInvalid.BackColor = System.Drawing.Color.Transparent;
            this.usernameInvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameInvalid.ForeColor = System.Drawing.Color.Red;
            this.usernameInvalid.Location = new System.Drawing.Point(81, 116);
            this.usernameInvalid.Name = "usernameInvalid";
            this.usernameInvalid.Size = new System.Drawing.Size(179, 15);
            this.usernameInvalid.TabIndex = 10;
            this.usernameInvalid.Text = "Invalid USERNAME format!";
            this.usernameInvalid.Visible = false;
            // 
            // usernameLenght
            // 
            this.usernameLenght.AutoSize = true;
            this.usernameLenght.BackColor = System.Drawing.Color.Transparent;
            this.usernameLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLenght.ForeColor = System.Drawing.Color.Red;
            this.usernameLenght.Location = new System.Drawing.Point(12, 116);
            this.usernameLenght.Name = "usernameLenght";
            this.usernameLenght.Size = new System.Drawing.Size(317, 15);
            this.usernameLenght.TabIndex = 11;
            this.usernameLenght.Text = "USERNAME must be between 6 and 20 symbols!";
            this.usernameLenght.Visible = false;
            // 
            // usernameEmpty
            // 
            this.usernameEmpty.AutoSize = true;
            this.usernameEmpty.BackColor = System.Drawing.Color.Transparent;
            this.usernameEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameEmpty.ForeColor = System.Drawing.Color.Red;
            this.usernameEmpty.Location = new System.Drawing.Point(75, 115);
            this.usernameEmpty.Name = "usernameEmpty";
            this.usernameEmpty.Size = new System.Drawing.Size(197, 15);
            this.usernameEmpty.TabIndex = 12;
            this.usernameEmpty.Text = "USERNAME cannot be empty!";
            this.usernameEmpty.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 514);
            this.Controls.Add(this.usernameEmpty);
            this.Controls.Add(this.usernameLenght);
            this.Controls.Add(this.usernameInvalid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.confirmPasswordRegister);
            this.Controls.Add(this.emailLabelRegister);
            this.Controls.Add(this.passwordLabelRegister);
            this.Controls.Add(this.userNameLabelRegister);
            this.Controls.Add(this.emailRegister);
            this.Controls.Add(this.passwordRegister);
            this.Controls.Add(this.userNameRegister);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameRegister;
        private System.Windows.Forms.TextBox passwordRegister;
        private System.Windows.Forms.TextBox emailRegister;
        private System.Windows.Forms.Label userNameLabelRegister;
        private System.Windows.Forms.Label passwordLabelRegister;
        private System.Windows.Forms.Label emailLabelRegister;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox confirmPasswordRegister;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label usernameInvalid;
        private System.Windows.Forms.Label usernameLenght;
        private System.Windows.Forms.Label usernameEmpty;
    }
}