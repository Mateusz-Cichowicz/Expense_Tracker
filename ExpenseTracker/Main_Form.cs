using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ExpenseTracker
{
    public partial class Main_Form : Form
    {
        Form logIn_Form;
        Controller controller;
        Database database;
        int totalWidth;
        public Main_Form(LogIn_Form logIn_Form)
        {
            InitializeComponent();
            this.logIn_Form = logIn_Form;
            database = new Database();
            controller = Controller.GetInstance();
            ShowData();
            sizeDGV(dataGridView1);
        }

        private void Add_Expense_Button_Click(object sender, EventArgs e)
        {
            var frm = new AddExpense_Form();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.FormClosing += delegate { this.Show(); this.ShowData(); };
            frm.Show();
            this.Hide();
        }

        private void Log_Out_Button_Click(object sender, EventArgs e)
        {
            logIn_Form.Show();
            this.Dispose();

        }
        private void ShowData()
        {
            DataTable dtbl = database.GetExpenseDataForUser(controller.user.username);
            dataGridView1.DataSource = dtbl;
            dataGridView1.Columns[0].Visible = false;
            sizeDGV(dataGridView1);
        }
        void sizeDGV(DataGridView dgv)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            var totalHeight = dgv.Rows.GetRowsHeight(states) + dgv.ColumnHeadersHeight;
            totalHeight += dgv.Rows.Count;
            if (totalWidth == 0)
            {
                totalWidth = dgv.Columns.GetColumnsWidth(states) + dgv.RowHeadersWidth;
                dgv.MinimumSize = new Size(totalWidth, 0);
            }
            dgv.ClientSize = new Size(totalWidth, totalHeight);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.MaximumSize = new Size(dgv.Width + 145, dgv.Height + 60);
            this.MinimumSize = new Size(dgv.Width + 145, (dgv.Height + 60 < 175) ? 175 : dgv.Height + 60);
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    database.RemoveExpenseData((int)row.Cells[0].Value);
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
            }
            sizeDGV(dataGridView1);
        }

        private void Edit_Expense_Button_Click(object sender, EventArgs e)
        {
            var frm = new EditExpense_Form();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    frm.id = (int)row.Cells[0].Value;
                    frm.amount = (decimal)row.Cells[1].Value;
                    frm.category = (string)row.Cells[2].Value;
                    frm.description = (string)row.Cells[3].Value;
                    frm.date = (DateTime)row.Cells[4].Value;
                }
                else
                {
                    return;
                }
            }
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.FormClosing += delegate { this.Show(); this.ShowData(); };
            frm.Show();
            this.Hide();
        }
    }
}
