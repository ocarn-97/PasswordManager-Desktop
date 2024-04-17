namespace PasswordManager_Desktop
{
    partial class RegistrationForm
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
            usernameTextBox = new TextBox();
            emailTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            passwordTextBox = new TextBox();
            label4 = new Label();
            RegisterAccount = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.None;
            usernameTextBox.Location = new Point(190, 131);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(157, 23);
            usernameTextBox.TabIndex = 0;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.None;
            emailTextBox.Location = new Point(190, 86);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(157, 23);
            emailTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(118, 89);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Email";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(118, 134);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(118, 177);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.Location = new Point(190, 174);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '●';
            passwordTextBox.Size = new Size(157, 23);
            passwordTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(158, 19);
            label4.Name = "label4";
            label4.Size = new Size(231, 21);
            label4.TabIndex = 6;
            label4.Text = "Password Manager - Desktop";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterAccount
            // 
            RegisterAccount.Location = new Point(226, 229);
            RegisterAccount.Name = "RegisterAccount";
            RegisterAccount.Size = new Size(75, 23);
            RegisterAccount.TabIndex = 7;
            RegisterAccount.Text = "Register";
            RegisterAccount.UseVisualStyleBackColor = true;
            RegisterAccount.Click += Register_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 40);
            label5.Name = "label5";
            label5.Size = new Size(156, 15);
            label5.TabIndex = 8;
            label5.Text = "Create your master account.";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 323);
            Controls.Add(label5);
            Controls.Add(RegisterAccount);
            Controls.Add(label4);
            Controls.Add(passwordTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(emailTextBox);
            Controls.Add(usernameTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegistrationForm";
            Text = "  Registration Form";
            Enter += Register_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox emailTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox passwordTextBox;
        private Label label4;
        private Button RegisterAccount;
        private Label label5;
    }
}
