namespace ExpenseTracker
{
    partial class EditExpense_Form
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
            Edit_Button = new Button();
            Amount_NumericUpDown = new NumericUpDown();
            Amount_Label = new Label();
            Description_Label = new Label();
            Description_TextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            Back_Button = new Button();
            Add_Category_Button = new Button();
            Category_Label = new Label();
            Category_ComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)Amount_NumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // Edit_Button
            // 
            Edit_Button.Anchor = AnchorStyles.Bottom;
            Edit_Button.Location = new Point(236, 186);
            Edit_Button.Name = "Edit_Button";
            Edit_Button.Size = new Size(87, 25);
            Edit_Button.TabIndex = 13;
            Edit_Button.Text = "Edit";
            Edit_Button.UseVisualStyleBackColor = true;
            Edit_Button.Click += Edit_Button_Click;
            // 
            // Amount_NumericUpDown
            // 
            Amount_NumericUpDown.Anchor = AnchorStyles.Bottom;
            Amount_NumericUpDown.DecimalPlaces = 2;
            Amount_NumericUpDown.Location = new Point(85, 188);
            Amount_NumericUpDown.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            Amount_NumericUpDown.Name = "Amount_NumericUpDown";
            Amount_NumericUpDown.Size = new Size(142, 23);
            Amount_NumericUpDown.TabIndex = 12;
            // 
            // Amount_Label
            // 
            Amount_Label.Anchor = AnchorStyles.Bottom;
            Amount_Label.AutoSize = true;
            Amount_Label.Location = new Point(28, 190);
            Amount_Label.Name = "Amount_Label";
            Amount_Label.Size = new Size(51, 15);
            Amount_Label.TabIndex = 11;
            Amount_Label.Text = "Amount";
            // 
            // Description_Label
            // 
            Description_Label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Description_Label.AutoSize = true;
            Description_Label.Location = new Point(12, 9);
            Description_Label.Name = "Description_Label";
            Description_Label.Size = new Size(67, 15);
            Description_Label.TabIndex = 10;
            Description_Label.Text = "Description";
            // 
            // Description_TextBox
            // 
            Description_TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Description_TextBox.Location = new Point(85, 6);
            Description_TextBox.Multiline = true;
            Description_TextBox.Name = "Description_TextBox";
            Description_TextBox.Size = new Size(237, 175);
            Description_TextBox.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Bottom;
            dateTimePicker1.Location = new Point(30, 248);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // Back_Button
            // 
            Back_Button.Anchor = AnchorStyles.Bottom;
            Back_Button.Location = new Point(236, 248);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(87, 25);
            Back_Button.TabIndex = 7;
            Back_Button.Text = "Back";
            Back_Button.UseVisualStyleBackColor = true;
            Back_Button.Click += Back_Button_Click;
            // 
            // Add_Category_Button
            // 
            Add_Category_Button.Anchor = AnchorStyles.Bottom;
            Add_Category_Button.Location = new Point(236, 217);
            Add_Category_Button.Name = "Add_Category_Button";
            Add_Category_Button.Size = new Size(87, 25);
            Add_Category_Button.TabIndex = 14;
            Add_Category_Button.Text = "Edit category";
            Add_Category_Button.UseVisualStyleBackColor = true;
            Add_Category_Button.Click += Edit_Category_Button_Click;
            // 
            // Category_Label
            // 
            Category_Label.Anchor = AnchorStyles.Bottom;
            Category_Label.AutoSize = true;
            Category_Label.Location = new Point(23, 220);
            Category_Label.Name = "Category_Label";
            Category_Label.Size = new Size(55, 15);
            Category_Label.TabIndex = 15;
            Category_Label.Text = "Category";
            // 
            // Category_ComboBox
            // 
            Category_ComboBox.Anchor = AnchorStyles.Bottom;
            Category_ComboBox.FormattingEnabled = true;
            Category_ComboBox.Location = new Point(84, 217);
            Category_ComboBox.Name = "Category_ComboBox";
            Category_ComboBox.Size = new Size(143, 23);
            Category_ComboBox.TabIndex = 16;
            // 
            // EditExpense_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 281);
            Controls.Add(Category_ComboBox);
            Controls.Add(Category_Label);
            Controls.Add(Add_Category_Button);
            Controls.Add(Edit_Button);
            Controls.Add(Amount_NumericUpDown);
            Controls.Add(Amount_Label);
            Controls.Add(Description_Label);
            Controls.Add(Description_TextBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(Back_Button);
            MinimumSize = new Size(350, 320);
            Name = "EditExpense_Form";
            Text = "EditExpense_Form";
            ((System.ComponentModel.ISupportInitialize)Amount_NumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Edit_Button;
        private NumericUpDown Amount_NumericUpDown;
        private Label Amount_Label;
        private Label Description_Label;
        private TextBox Description_TextBox;
        private DateTimePicker dateTimePicker1;
        private Button Back_Button;
        private Button Add_Category_Button;
        private Label Category_Label;
        private ComboBox Category_ComboBox;
    }
}