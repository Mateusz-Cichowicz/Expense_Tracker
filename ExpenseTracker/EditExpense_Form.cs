using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class EditExpense_Form : Form
    {
        public event EventHandler EditButtonClicked;
        private readonly Controller controller;
        private Database database;
        public EditExpense_Form()
        {
            InitializeComponent();
            controller = Controller.GetInstance();
            controller.Initialize(this);
            database = new Database();
            LoadCategories();
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            EditButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void Edit_Category_Button_Click(object sender, EventArgs e)
        {
            var frm = new EditCategory_Form();
            frm.category = category;
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.FormClosing += delegate { this.Show(); LoadCategories(); };
            frm.Show();
            this.Hide();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadCategories()
        {
            DataTable dtbl = database.GetCategoryDataForUser(controller.user.username);
            Category_ComboBox.DisplayMember = dtbl.Columns[0].ToString();
            Category_ComboBox.DataSource = dtbl;
        }

        public int id
        {
            get;
            set;
        }
        public decimal amount
        {
            get { return Amount_NumericUpDown.Value; }
            set { Amount_NumericUpDown.Value = value; }
        }
        public string category
        {
            get { return Category_ComboBox.Text; }
            set { Category_ComboBox.Text = value; }
        }
        public string description
        {
            get { return Description_TextBox.Text; }
            set { Description_TextBox.Text = value; }
        }
        public DateTime date
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }
    }
}
