
namespace Quan_Ly_Du_An_Nhom1
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
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnForgot = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.SuspendLayout();
            // 
            // lblAccount
            // 
            this.lblAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(129, 83);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(59, 13);
            this.lblAccount.TabIndex = 5;
            this.lblAccount.Text = "ACCOUNT";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(129, 135);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "PASSWORD";
            // 
            // txtAccount
            // 
            this.txtAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccount.Location = new System.Drawing.Point(235, 80);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(155, 20);
            this.txtAccount.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(235, 128);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(155, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignIn.Location = new System.Drawing.Point(146, 180);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(107, 32);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignUp.Location = new System.Drawing.Point(272, 180);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(107, 32);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnForgot
            // 
            this.btnForgot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnForgot.Location = new System.Drawing.Point(146, 234);
            this.btnForgot.Name = "btnForgot";
            this.btnForgot.Size = new System.Drawing.Size(233, 38);
            this.btnForgot.TabIndex = 4;
            this.btnForgot.Text = "FORGOT PASSWORD";
            this.btnForgot.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(204, 33);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(90, 13);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "SIGN IN TO USE";
            // 
            // sqlConnection
            // 
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 284);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnForgot);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblAccount);
            this.Name = "Login";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnForgot;
        private System.Windows.Forms.Label lblWelcome;
        private System.Data.SqlClient.SqlConnection sqlConnection;
    }
}

