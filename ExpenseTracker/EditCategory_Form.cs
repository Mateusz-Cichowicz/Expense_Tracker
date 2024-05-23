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
    public partial class EditCategory_Form : Form
    {
        public event EventHandler SaveCategoryButtonClicked;
        public event EventHandler DeleteCategoryButtonClicked;
        public event EventHandler EditCategoryButtonClicked;
        Controller controller;
        Database database;
        public string selectedCategory { get; set; }
        public EditCategory_Form()
        {
            InitializeComponent();
            controller = Controller.GetInstance();
            controller.Initialize(this);
            database = new Database();
            LoadCategories();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            SaveCategoryButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            DeleteCategoryButtonClicked?.Invoke(this, EventArgs.Empty);
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

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            EditCategoryButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Category_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategory = Category_ComboBox.Text;
        }

        public string category
        {
            get { return Category_ComboBox.Text; }
            set { Category_ComboBox.Text = value; }
        }
    }
}
