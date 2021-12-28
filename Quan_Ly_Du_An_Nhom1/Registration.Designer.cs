
namespace Quan_Ly_Du_An_Nhom1
{
    partial class Registration
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
            this.lblSignUp = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblRetype = new System.Windows.Forms.Label();
            this.txtRetype = new System.Windows.Forms.TextBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.lblMK = new System.Windows.Forms.Label();
            this.rdbNhanVien = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbKH = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSignUp
            // 
            this.lblSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Location = new System.Drawing.Point(186, 46);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(51, 13);
            this.lblSignUp.TabIndex = 15;
            this.lblSignUp.Text = "SIGN UP";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignUp.Location = new System.Drawing.Point(189, 308);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(153, 56);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(221, 113);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(173, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtAccount
            // 
            this.txtAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccount.Location = new System.Drawing.Point(221, 78);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(173, 20);
            this.txtAccount.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(75, 124);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "PASSWORD";
            // 
            // lblAccount
            // 
            this.lblAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(75, 85);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(59, 13);
            this.lblAccount.TabIndex = 4;
            this.lblAccount.Text = "ACCOUNT";
            // 
            // lblRetype
            // 
            this.lblRetype.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRetype.AutoSize = true;
            this.lblRetype.Location = new System.Drawing.Point(75, 158);
            this.lblRetype.Name = "lblRetype";
            this.lblRetype.Size = new System.Drawing.Size(116, 13);
            this.lblRetype.TabIndex = 6;
            this.lblRetype.Text = "RETYPE PASSWORD";
            // 
            // txtRetype
            // 
            this.txtRetype.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRetype.Location = new System.Drawing.Point(221, 147);
            this.txtRetype.Name = "txtRetype";
            this.txtRetype.PasswordChar = '*';
            this.txtRetype.Size = new System.Drawing.Size(173, 20);
            this.txtRetype.TabIndex = 2;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Location = new System.Drawing.Point(417, 120);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(78, 13);
            this.lblMK.TabIndex = 16;
            this.lblMK.Text = "Điền Mật Khẩu";
            // 
            // rdbNhanVien
            // 
            this.rdbNhanVien.AutoSize = true;
            this.rdbNhanVien.Checked = true;
            this.rdbNhanVien.Location = new System.Drawing.Point(22, 39);
            this.rdbNhanVien.Name = "rdbNhanVien";
            this.rdbNhanVien.Size = new System.Drawing.Size(75, 17);
            this.rdbNhanVien.TabIndex = 17;
            this.rdbNhanVien.TabStop = true;
            this.rdbNhanVien.Text = "Nhân Viên";
            this.rdbNhanVien.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbKH);
            this.groupBox1.Controls.Add(this.rdbNhanVien);
            this.groupBox1.Location = new System.Drawing.Point(141, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quyền";
            // 
            // rdbKH
            // 
            this.rdbKH.AutoSize = true;
            this.rdbKH.Location = new System.Drawing.Point(143, 39);
            this.rdbKH.Name = "rdbKH";
            this.rdbKH.Size = new System.Drawing.Size(85, 17);
            this.rdbKH.TabIndex = 17;
            this.rdbKH.Text = "Khách Hàng";
            this.rdbKH.UseVisualStyleBackColor = true;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 395);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtRetype);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblRetype);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblAccount);
            this.Name = "Registration";
            this.Text = "Registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblRetype;
        private System.Windows.Forms.TextBox txtRetype;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.RadioButton rdbNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbKH;
    }
}