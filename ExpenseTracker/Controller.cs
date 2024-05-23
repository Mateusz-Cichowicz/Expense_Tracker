
namespace ExpenseTracker
{
    internal class Controller
    {
        private static Controller instance;
        private LogIn_Form loginForm;
        private AddExpense_Form addExpenseForm;
        private EditExpense_Form editExpenseForm;
        private EditCategory_Form editCategoryForm;
        public User user;
        public Expense expense;
        public Category category;

        private Controller()
        {
            expense = new Expense();
            category= new Category();
        }

        public static Controller GetInstance()
        {
            if (instance == null)
            {
                instance = new Controller();
            }
            return instance;
        }

        public void Initialize(LogIn_Form form)
        {
            loginForm = form;
            loginForm.RegisterButtonClicked += RegisterButtonClickedHandler;
            loginForm.LoginButtonClicked += LoginButtonClickedHandler;
            user = new User();
            user.LoggedIn += LoggedInHandler;
        }

        public void Initialize(AddExpense_Form form)
        {
            addExpenseForm = form;
            addExpenseForm.AddButtonClicked += AddButtonClickedHandler;
            expense.ExpenseAdded += ExpenseAddedHandler;
        }
        public void Initialize(EditExpense_Form form)
        {
            editExpenseForm = form;
            editExpenseForm.EditButtonClicked += EditButtonClickedHandler;
            expense.ExpenseEdited += ExpenseEditedHandler;
        }
        public void Initialize(EditCategory_Form form)
        {
            editCategoryForm = form;
            editCategoryForm.SaveCategoryButtonClicked += SaveCategoryButtonClickedHandler;
            editCategoryForm.DeleteCategoryButtonClicked += DeleteCategoryButtonClickedHandler;
            editCategoryForm.EditCategoryButtonClicked += EditCategoryButtonClickedHandler;
        }
        private void AddButtonClickedHandler(object sender, EventArgs e)
        {
            decimal amount = addExpenseForm.amount;
            string category = addExpenseForm.category;
            string description = addExpenseForm.description;
            DateTime date = addExpenseForm.date;
            expense.AddExpense(amount, user.username, category, description, date);
        }
        private void SaveCategoryButtonClickedHandler(object sender, EventArgs e)
        {
            category.AddCategory(editCategoryForm.category, user.username);
        }
        private void DeleteCategoryButtonClickedHandler(object sender, EventArgs e)
        {
            category.DeleteCategory(editCategoryForm.category, user.username);
        }
        private void EditCategoryButtonClickedHandler(object sender, EventArgs e)
        {
            category.EditCategory(editCategoryForm.category, user.username, editCategoryForm.selectedCategory);
        }
        private void EditButtonClickedHandler(object sender, EventArgs e)
        {
            int id = editExpenseForm.id;
            decimal amount = editExpenseForm.amount;
            string category = editExpenseForm.category;
            string description = editExpenseForm.description;
            DateTime date = editExpenseForm.date;
            expense.EditExpense(id, amount, category, description, date);
        }
        private void ExpenseAddedHandler(object sender, EventArgs e)
        {
            addExpenseForm.Close();
        }
        private void ExpenseEditedHandler(object sender, EventArgs e)
        {
            editExpenseForm.Close();
        }
        private void RegisterButtonClickedHandler(object sender, EventArgs e)
        {
            string username = loginForm.Username;
            string password = loginForm.Password;
            user.Register(username, password);
        }

        private void LoginButtonClickedHandler(object sender, EventArgs e)
        {
            string username = loginForm.Username;
            string password = loginForm.Password;
            user.LogIn(username, password);
        }
        private void LoggedInHandler(object sender, EventArgs e)
        {
            loginForm.SwapForm();
        }
    }
}
