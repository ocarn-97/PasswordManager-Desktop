namespace PasswordManager_Desktop
{
    partial class CheckForm
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
            checkTextBox = new TextBox();
            label1 = new Label();
            Check = new Button();
            SuspendLayout();
            // 
            // checkTextBox
            // 
            checkTextBox.Location = new Point(86, 78);
            checkTextBox.Name = "checkTextBox";
            checkTextBox.Size = new Size(147, 23);
            checkTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(74, 34);
            label1.Name = "label1";
            label1.Size = new Size(172, 19);
            label1.TabIndex = 1;
            label1.Text = "Enter a password to check.";
            // 
            // Check
            // 
            Check.Location = new Point(120, 132);
            Check.Name = "Check";
            Check.Size = new Size(75, 23);
            Check.TabIndex = 2;
            Check.Text = "Check";
            Check.UseVisualStyleBackColor = true;
            Check.Click += Check_Click;
            // 
            // CheckForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 215);
            Controls.Add(Check);
            Controls.Add(label1);
            Controls.Add(checkTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CheckForm";
            Text = "Check Form";
            Enter += Check_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox checkTextBox;
        private Label label1;
        private Button Check;
    }
}