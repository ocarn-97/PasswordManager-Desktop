namespace PasswordManager_Desktop
{
    partial class AddForm
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
            titleTextBox = new TextBox();
            websiteTextBox = new TextBox();
            emailTextBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Add = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 27);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Add a new account.";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(138, 87);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(169, 23);
            titleTextBox.TabIndex = 1;
            // 
            // websiteTextBox
            // 
            websiteTextBox.Location = new Point(138, 139);
            websiteTextBox.Name = "websiteTextBox";
            websiteTextBox.Size = new Size(169, 23);
            websiteTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(138, 189);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(169, 23);
            emailTextBox.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(138, 240);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(169, 23);
            usernameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(138, 288);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(169, 23);
            passwordTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(63, 90);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 6;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(63, 142);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 7;
            label3.Text = "Website";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(60, 243);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 8;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(63, 291);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 9;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(63, 192);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 10;
            label6.Text = "Email";
            // 
            // Add
            // 
            Add.Location = new Point(182, 338);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 11;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 411);
            Controls.Add(Add);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(websiteTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "AddForm";
            Text = "Add Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titleTextBox;
        private TextBox websiteTextBox;
        private TextBox emailTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Add;
    }
}