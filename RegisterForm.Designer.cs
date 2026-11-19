namespace WinForms2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(23, 223);
            label1.Name = "label1";
            label1.Size = new Size(277, 29);
            label1.TabIndex = 0;
            label1.Text = "Ви успішно зареєстровані!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(255, 255, 128);
            label2.Location = new Point(42, 30);
            label2.Name = "label2";
            label2.Size = new Size(245, 38);
            label2.TabIndex = 1;
            label2.Text = "Вітання Вітання!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 70F);
            label3.ForeColor = Color.FromArgb(255, 255, 128);
            label3.Location = new Point(71, 80);
            label3.Name = "label3";
            label3.Size = new Size(182, 125);
            label3.TabIndex = 2;
            label3.Text = "👍";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(329, 291);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
    }
}