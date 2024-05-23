namespace ExpenseTracker
{
    partial class Main_Form
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
            components = new System.ComponentModel.Container();
            Log_Out_Button = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            Add_Expense_Button = new Button();
            dataGridView1 = new DataGridView();
            Delete_Button = new Button();
            Edit_Expense_Button = new Button();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Log_Out_Button
            // 
            Log_Out_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Log_Out_Button.Location = new Point(458, 105);
            Log_Out_Button.Name = "Log_Out_Button";
            Log_Out_Button.Size = new Size(96, 25);
            Log_Out_Button.TabIndex = 0;
            Log_Out_Button.Text = "Log out";
            Log_Out_Button.UseVisualStyleBackColor = true;
            Log_Out_Button.Click += Log_Out_Button_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // Add_Expense_Button
            // 
            Add_Expense_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Add_Expense_Button.Location = new Point(458, 12);
            Add_Expense_Button.Name = "Add_Expense_Button";
            Add_Expense_Button.Size = new Size(96, 25);
            Add_Expense_Button.TabIndex = 7;
            Add_Expense_Button.Text = "Add Expense";
            Add_Expense_Button.UseVisualStyleBackColor = true;
            Add_Expense_Button.Click += Add_Expense_Button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ControlLight;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(440, 87);
            dataGridView1.TabIndex = 8;
            // 
            // Delete_Button
            // 
            Delete_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Delete_Button.Location = new Point(458, 74);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(96, 25);
            Delete_Button.TabIndex = 9;
            Delete_Button.Text = "Delete Expense";
            Delete_Button.TextAlign = ContentAlignment.MiddleRight;
            Delete_Button.UseVisualStyleBackColor = true;
            Delete_Button.Click += Delete_Button_Click;
            // 
            // Edit_Expense_Button
            // 
            Edit_Expense_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Edit_Expense_Button.Location = new Point(458, 43);
            Edit_Expense_Button.Name = "Edit_Expense_Button";
            Edit_Expense_Button.Size = new Size(96, 25);
            Edit_Expense_Button.TabIndex = 10;
            Edit_Expense_Button.Text = "Edit Expense";
            Edit_Expense_Button.UseVisualStyleBackColor = true;
            Edit_Expense_Button.Click += Edit_Expense_Button_Click;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 148);
            Controls.Add(Edit_Expense_Button);
            Controls.Add(Delete_Button);
            Controls.Add(dataGridView1);
            Controls.Add(Add_Expense_Button);
            Controls.Add(Log_Out_Button);
            MinimumSize = new Size(0, 175);
            Name = "Main_Form";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Expense Tracker";
            contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Log_Out_Button;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private Button Add_Expense_Button;
        private DataGridView dataGridView1;
        private Button Delete_Button;
        private Button Edit_Expense_Button;
    }
}