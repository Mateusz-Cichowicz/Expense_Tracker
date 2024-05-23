using MySql.Data.MySqlClient;

namespace ExpenseTracker
{
    internal class User
    {
        public string username { get; set; }
        Authentication authentication;
        Database database;
        public event EventHandler LoggedIn;
        public User()
        {
            authentication = new Authentication();
            database = new Database();
        }
        public void Register(string username, string password) 
        {
            try
            {
                MySqlConnection cnn = database.ConnectToDatabase();

                if (authentication.ValidateUser(cnn, username) == "0")
                {
                    string hashedPassword = authentication.HashPassword(password);
                    database.SaveUserData(username, hashedPassword);
                    MessageBox.Show($"Registration successful. Your username is: {username}.");
                }
                else
                {
                    MessageBox.Show("This username already exists!");
                }
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
        public void LogIn(string username, string password)
        {
            try
            {
                MySqlConnection cnn = database.ConnectToDatabase();
                if (authentication.ValidateUser(cnn, username) == "1")
                {
                    if (authentication.ValidateUserPassword(cnn, username, password))
                    {
                        MessageBox.Show("you are loged in");
                        this.username = username;
                        LoggedIn?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username");
                }
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
