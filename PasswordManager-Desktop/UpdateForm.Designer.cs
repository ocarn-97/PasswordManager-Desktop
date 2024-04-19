namespace PasswordManager_Desktop
{
    partial class UpdateForm
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
            Update = new Button();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            emailTextBox = new TextBox();
            websiteTextBox = new TextBox();
            titleTextBox = new TextBox();
            SuspendLayout();
            // 
            // Update
            // 
            Update.Location = new Point(182, 338);
            Update.Name = "Update";
            Update.Size = new Size(75, 23);
            Update.TabIndex = 0;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 27);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 1;
            label1.Text = "Update an account.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(63, 90);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Title";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(63, 192);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 19;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(63, 291);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 18;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(60, 243);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 17;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(63, 142);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 16;
            label3.Text = "Website";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(138, 288);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(169, 23);
            passwordTextBox.TabIndex = 15;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(138, 240);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(169, 23);
            usernameTextBox.TabIndex = 14;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(138, 189);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(169, 23);
            emailTextBox.TabIndex = 13;
            // 
            // websiteTextBox
            // 
            websiteTextBox.Location = new Point(138, 139);
            websiteTextBox.Name = "websiteTextBox";
            websiteTextBox.Size = new Size(169, 23);
            websiteTextBox.TabIndex = 12;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(138, 87);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(169, 23);
            titleTextBox.TabIndex = 11;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 411);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(websiteTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Update);
            Name = "UpdateForm";
            Text = "Update Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Update;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private TextBox emailTextBox;
        private TextBox websiteTextBox;
        private TextBox titleTextBox;
    }
}