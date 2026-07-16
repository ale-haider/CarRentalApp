namespace CarRentalApp
{
    partial class Login
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
            label1 = new Label();
            username = new Label();
            tbUsername = new TextBox();
            password = new Label();
            tbPassword = new TextBox();
            button1 = new Button();
            btnLogin = new Button();
            btnSignUP = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F);
            label1.Location = new Point(97, 50);
            label1.Name = "label1";
            label1.Size = new Size(91, 37);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(34, 138);
            username.Name = "username";
            username.Size = new Size(59, 15);
            username.TabIndex = 4;
            username.Text = "username";
            username.Click += label2_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(34, 165);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(215, 23);
            tbUsername.TabIndex = 5;
            tbUsername.TextChanged += textBox1_TextChanged;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(34, 244);
            password.Name = "password";
            password.Size = new Size(57, 15);
            password.TabIndex = 6;
            password.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(34, 282);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(215, 23);
            tbPassword.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(53, 339);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(99, 72);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button2_Click;
            // 
            // btnSignUP
            // 
            btnSignUP.Location = new Point(218, 339);
            btnSignUP.Name = "btnSignUP";
            btnSignUP.Size = new Size(99, 72);
            btnSignUP.TabIndex = 10;
            btnSignUP.Text = "SIGN IN";
            btnSignUP.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSignUP);
            Controls.Add(btnLogin);
            Controls.Add(button1);
            Controls.Add(tbPassword);
            Controls.Add(password);
            Controls.Add(tbUsername);
            Controls.Add(username);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label username;
        private TextBox tbUsername;
        private Label password;
        private TextBox tbPassword;
        private Button button1;
        private Button btnLogin;
        private Button btnSignUP;
    }
}