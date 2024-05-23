namespace ExpenseTracker
{
    partial class EditCategory_Form
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
            Save_Button = new Button();
            Category_Label = new Label();
            Category_ComboBox = new ComboBox();
            Delete_Button = new Button();
            Back_Button = new Button();
            Edit_Button = new Button();
            SuspendLayout();
            // 
            // Save_Button
            // 
            Save_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Save_Button.Location = new Point(250, 10);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(87, 25);
            Save_Button.TabIndex = 12;
            Save_Button.Text = "Save";
            Save_Button.UseVisualStyleBackColor = true;
            Save_Button.Click += Save_Button_Click;
            // 
            // Category_Label
            // 
            Category_Label.AutoSize = true;
            Category_Label.Location = new Point(3, 15);
            Category_Label.Name = "Category_Label";
            Category_Label.Size = new Size(55, 15);
            Category_Label.TabIndex = 11;
            Category_Label.Text = "Category";
            // 
            // Category_ComboBox
            // 
            Category_ComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Category_ComboBox.FormattingEnabled = true;
            Category_ComboBox.Location = new Point(64, 12);
            Category_ComboBox.Name = "Category_ComboBox";
            Category_ComboBox.Size = new Size(180, 23);
            Category_ComboBox.TabIndex = 10;
            Category_ComboBox.SelectedIndexChanged += Category_ComboBox_SelectedIndexChanged;
            // 
            // Delete_Button
            // 
            Delete_Button.Location = new Point(250, 41);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(87, 25);
            Delete_Button.TabIndex = 13;
            Delete_Button.Text = "Delete";
            Delete_Button.UseVisualStyleBackColor = true;
            Delete_Button.Click += Delete_Button_Click;
            // 
            // Back_Button
            // 
            Back_Button.Location = new Point(64, 41);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(87, 25);
            Back_Button.TabIndex = 14;
            Back_Button.Text = "Back";
            Back_Button.UseVisualStyleBackColor = true;
            Back_Button.Click += Back_Button_Click;
            // 
            // Edit_Button
            // 
            Edit_Button.Location = new Point(157, 41);
            Edit_Button.Name = "Edit_Button";
            Edit_Button.Size = new Size(87, 25);
            Edit_Button.TabIndex = 15;
            Edit_Button.Text = "Edit";
            Edit_Button.UseVisualStyleBackColor = true;
            Edit_Button.Click += Edit_Button_Click;
            // 
            // EditCategory_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 76);
            Controls.Add(Edit_Button);
            Controls.Add(Back_Button);
            Controls.Add(Delete_Button);
            Controls.Add(Save_Button);
            Controls.Add(Category_Label);
            Controls.Add(Category_ComboBox);
            MaximumSize = new Size(370, 115);
            MinimumSize = new Size(370, 115);
            Name = "EditCategory_Form";
            Text = "EditCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Save_Button;
        private Label Category_Label;
        private ComboBox Category_ComboBox;
        private Button Delete_Button;
        private Button Back_Button;
        private Button Edit_Button;
    }
}