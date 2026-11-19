namespace WinForms2
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtEmail = new TextBox();
            txtPassword = new Label();
            textBox1 = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(193, 29);
            label1.TabIndex = 0;
            label1.Text = "Електронна пошта";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 15F);
            txtEmail.Location = new Point(12, 60);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(285, 34);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtPassword.ForeColor = Color.Blue;
            txtPassword.Location = new Point(12, 123);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(88, 29);
            txtPassword.TabIndex = 0;
            txtPassword.Text = "Пароль";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(12, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 34);
            textBox1.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 255, 128);
            btnLogin.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLogin.Location = new Point(164, 215);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(133, 36);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Вхід";
            btnLogin.TextImageRelation = TextImageRelation.TextAboveImage;
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(255, 255, 128);
            btnRegister.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRegister.Location = new Point(12, 215);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(133, 36);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Реєстрація";
            btnRegister.TextImageRelation = TextImageRelation.TextAboveImage;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(327, 315);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(textBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Label txtPassword;
        private TextBox textBox1;
        private Button btnLogin;
        private Button btnRegister;
    }
}
