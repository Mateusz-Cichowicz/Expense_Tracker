
namespace ExpenseTracker
{
    internal class Expense
    {
        private Database database;
        public event EventHandler ExpenseAdded;
        public event EventHandler ExpenseEdited;
        public Expense()
        {
            database = new Database();
        }
        public void AddExpense(decimal amount,string username, string category, string description, DateTime date)
        {
            try
            {
                database.SaveExpenseData(amount, username, category, description, date);
                MessageBox.Show("Expense added.");
                ExpenseAdded?.Invoke(this, new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                database.DisconnectFromDatabase();
            }
        }
        public void EditExpense(int id, decimal amount, string category, string description, DateTime date) 
        {
            try
            {
                database.UpdateExpenseData(id, amount, category, description, date);
                MessageBox.Show("Expense edited.");
                ExpenseEdited?.Invoke(this, new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                database.DisconnectFromDatabase();
            }
        }
    }
}
