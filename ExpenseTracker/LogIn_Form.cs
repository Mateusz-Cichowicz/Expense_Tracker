
using MySql.Data.MySqlClient;
using System.Data;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace ExpenseTracker
{

    public partial class LogIn_Form : Form
    {
        private readonly Controller controller;
        public event EventHandler RegisterButtonClicked;
        public event EventHandler LoginButtonClicked;

        public LogIn_Form()
        {
            InitializeComponent();
            controller = Controller.GetInstance();
            controller.Initialize(this);

        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            RegisterButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void Login_Button_Click(object sender, EventArgs e)
        {
            LoginButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        public void SwapForm()
        {
            var frm = new Main_Form(this);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { Application.Exit(); };
            frm.Show();
            this.Hide();
        }

        public string Username
        {
            get { return Username_TextBox.Text; }
        }
        public string Password
        {
            get { return Password_TextBox.Text; }
        }

    }
}