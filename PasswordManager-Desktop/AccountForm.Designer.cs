namespace PasswordManager_Desktop
{
    partial class AccountForm
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
            listView = new ListView();
            ID = new ColumnHeader();
            Title = new ColumnHeader();
            Website = new ColumnHeader();
            Email = new ColumnHeader();
            Username = new ColumnHeader();
            Password = new ColumnHeader();
            Add = new Button();
            Delete = new Button();
            Generate = new Button();
            Check = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { ID, Title, Website, Email, Username, Password });
            listView.Location = new Point(12, 67);
            listView.Name = "listView";
            listView.Size = new Size(660, 382);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 70;
            // 
            // Title
            // 
            Title.Text = "Title";
            Title.Width = 70;
            // 
            // Website
            // 
            Website.Text = "Website";
            Website.Width = 70;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 70;
            // 
            // Username
            // 
            Username.Text = "Username";
            Username.Width = 70;
            // 
            // Password
            // 
            Password.Text = "Password";
            Password.Width = 70;
            // 
            // Add
            // 
            Add.Location = new Point(276, 26);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 2;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(373, 26);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 3;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Generate
            // 
            Generate.Location = new Point(470, 26);
            Generate.Name = "Generate";
            Generate.Size = new Size(75, 23);
            Generate.TabIndex = 4;
            Generate.Text = "Generate";
            Generate.UseVisualStyleBackColor = true;
            Generate.Click += Generate_Click;
            // 
            // Check
            // 
            Check.Location = new Point(570, 26);
            Check.Name = "Check";
            Check.Size = new Size(75, 23);
            Check.TabIndex = 6;
            Check.Text = "Check";
            Check.UseVisualStyleBackColor = true;
            Check.Click += Check_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(231, 21);
            label1.TabIndex = 7;
            label1.Text = "Password Manager - Desktop";
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(label1);
            Controls.Add(Check);
            Controls.Add(Generate);
            Controls.Add(Delete);
            Controls.Add(Add);
            Controls.Add(listView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AccountForm";
            Text = "Account Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView;
        private ColumnHeader ID;
        private ColumnHeader Title;
        private ColumnHeader Email;
        private ColumnHeader Username;
        private ColumnHeader Password;
        private Button Add;
        private Button Delete;
        private Button Generate;
        private ColumnHeader Website;
        private Button Check;
        private Label label1;
    }
}