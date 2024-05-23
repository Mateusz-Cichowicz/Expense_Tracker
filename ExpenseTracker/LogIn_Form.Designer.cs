namespace ExpenseTracker
{
    partial class LogIn_Form
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
            Register_Button = new Button();
            Username_TextBox = new TextBox();
            Password_TextBox = new TextBox();
            Username_Label = new Label();
            Password_Label = new Label();
            Login_Button = new Button();
            SuspendLayout();
            // 
            // Register_Button
            // 
            Register_Button.Location = new Point(76, 70);
            Register_Button.Name = "Register_Button";
            Register_Button.Size = new Size(87, 25);
            Register_Button.TabIndex = 0;
            Register_Button.Text = "Register";
            Register_Button.UseVisualStyleBackColor = true;
            Register_Button.Click += Register_Button_Click;
            // 
            // Username_TextBox
            // 
            Username_TextBox.Location = new Point(76, 12);
            Username_TextBox.Name = "Username_TextBox";
            Username_TextBox.Size = new Size(180, 23);
            Username_TextBox.TabIndex = 1;
            // 
            // Password_TextBox
            // 
            Password_TextBox.Location = new Point(76, 41);
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.Size = new Size(180, 23);
            Password_TextBox.TabIndex = 2;
            Password_TextBox.UseSystemPasswordChar = true;
            // 
            // Username_Label
            // 
            Username_Label.AutoSize = true;
            Username_Label.Location = new Point(13, 15);
            Username_Label.Name = "Username_Label";
            Username_Label.Size = new Size(60, 15);
            Username_Label.TabIndex = 3;
            Username_Label.Text = "Username";
            // 
            // Password_Label
            // 
            Password_Label.AutoSize = true;
            Password_Label.Location = new Point(13, 44);
            Password_Label.Name = "Password_Label";
            Password_Label.Size = new Size(57, 15);
            Password_Label.TabIndex = 4;
            Password_Label.Text = "Password";
            // 
            // Login_Button
            // 
            Login_Button.Location = new Point(169, 70);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(87, 25);
            Login_Button.TabIndex = 6;
            Login_Button.Text = "Login";
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Click += Login_Button_Click;
            // 
            // LogIn_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 106);
            Controls.Add(Login_Button);
            Controls.Add(Password_Label);
            Controls.Add(Username_Label);
            Controls.Add(Password_TextBox);
            Controls.Add(Username_TextBox);
            Controls.Add(Register_Button);
            MaximumSize = new Size(285, 145);
            MinimumSize = new Size(285, 145);
            Name = "LogIn_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Register_Button;
        private TextBox Username_TextBox;
        private TextBox Password_TextBox;
        private Label Username_Label;
        private Label Password_Label;
        private Button Login_Button;
    }
}