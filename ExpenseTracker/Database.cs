using MySql.Data.MySqlClient;
using System.Data;

namespace ExpenseTracker
{
    internal class Database
    {
        private string myConnectionString = "server=localhost;user=root;database=expense_tracker;pwd=1575;";
        private string baseConnectionString = "server=localhost;user=root;pwd=1575;";
        MySqlConnection cnn;

        public void InitializeDatabase()
        {
            MySqlConnection cnn = new MySqlConnection(baseConnectionString);
            try
            {
                cnn.Open();

                string sqlCreate = "CREATE DATABASE IF NOT EXISTS expense_tracker;";
                MySqlCommand cmd = new MySqlCommand(sqlCreate, cnn);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `expense_tracker`.`user_info` (  `id` INT NOT NULL AUTO_INCREMENT,  `username` VARCHAR(45) NULL, `password` LONGTEXT NULL, PRIMARY KEY (`id`));";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `expense_tracker`.`expenses` (`id` INT NOT NULL AUTO_INCREMENT, `amount` DECIMAL(50) NULL, `username` VARCHAR(45) NULL, `category` VARCHAR(45) NULL, `description` LONGTEXT NULL, `date` DATETIME NULL, PRIMARY KEY (`id`));";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `expense_tracker`.`category` (`username` VARCHAR(45) NULL, `category` VARCHAR(45) NULL);";//, UNIQUE INDEX `category_UNIQUE` (`category` ASC));";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
            finally 
            { 
                cnn.Close(); 
            }
        }
        public MySqlConnection ConnectToDatabase()
        {
            cnn = new MySqlConnection(myConnectionString);
            cnn.Open();
            return cnn;
        }
        public void DisconnectFromDatabase() 
        {
            cnn.Close();
        }

        public void SaveUserData(string username, string hashedPassword) 
        {
            string sqlInsert = "INSERT INTO user_info (username, password) VALUES (?username, ?password)";
            MySqlCommand cmd = new MySqlCommand(sqlInsert, cnn);
            cmd.Parameters.Add("?username", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("?password", MySqlDbType.LongText).Value = hashedPassword;
            cmd.ExecuteNonQuery();
        }

        public void SaveExpenseData(decimal amount,string username, string category, string description, DateTime date) 
        {
            MySqlConnection cnn = ConnectToDatabase();
            string sqlInsert = "INSERT INTO expenses (amount, username, category, description, date) VALUES (?amount, ?username, ?category, ?description, ?date)";
            MySqlCommand cmd = new MySqlCommand(sqlInsert, cnn);
            cmd.Parameters.Add("?amount", MySqlDbType.Decimal).Value = amount;
            cmd.Parameters.Add("?username", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("?category", MySqlDbType.VarChar).Value = category;
            cmd.Parameters.Add("?description", MySqlDbType.LongText).Value = description;
            cmd.Parameters.Add("?date", MySqlDbType.DateTime).Value = date;
            cmd.ExecuteNonQuery();
        }
        public void UpdateExpenseData(int id, decimal amount, string category, string description, DateTime date)
        {
            MySqlConnection cnn = ConnectToDatabase();
            string sqlUpdate = "UPDATE expenses SET amount = ?amount, category = ?category, description = ?description, date = ?date WHERE id = ?id;";
            MySqlCommand cmd = new MySqlCommand(sqlUpdate, cnn);
            cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = id;
            cmd.Parameters.Add("?amount", MySqlDbType.Decimal).Value = amount;
            cmd.Parameters.Add("?category", MySqlDbType.VarChar).Value = category;
            cmd.Parameters.Add("?description", MySqlDbType.LongText).Value = description;
            cmd.Parameters.Add("?date", MySqlDbType.DateTime).Value = date;
            cmd.ExecuteNonQuery();
        }


        public void RemoveExpenseData(int id) 
        {
            try
            {
                MySqlConnection cnn = ConnectToDatabase();
                string sqlDelete = "DELETE FROM expenses WHERE id = ?id;";
                MySqlCommand cmd = new MySqlCommand(sqlDelete, cnn);
                cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DisconnectFromDatabase();
            }
        }
        public DataTable GetExpenseDataForUser(string username) 
        {
            DataTable dtbl = new DataTable();
            using (MySqlConnection cnn = ConnectToDatabase())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id, amount, category, description, date FROM expenses WHERE username = @username;", cnn);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dtbl);
            }
            return dtbl;
        }
        public void SaveCategory(string category, string username)
        {
            MySqlConnection cnn = ConnectToDatabase();
            string sqlInsert = "INSERT INTO category (username, category) VALUES (?username, ?category)";
            MySqlCommand cmd = new MySqlCommand(sqlInsert, cnn);
            cmd.Parameters.Add("?username", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("?category", MySqlDbType.VarChar).Value = category;
            cmd.ExecuteNonQuery();
        }
        public DataTable GetCategoryDataForUser(string username)
        {
            DataTable dtbl = new DataTable();
            using (MySqlConnection cnn = ConnectToDatabase())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT category FROM category WHERE username = @username;", cnn);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dtbl);
            }
            return dtbl;
        }
        public void DeleteCategoryData(string category, string username)
        {
            try
            {
                MySqlConnection cnn = ConnectToDatabase();
                string sqlDelete = "DELETE FROM category WHERE username = ?username AND category = ?category;";
                MySqlCommand cmd = new MySqlCommand(sqlDelete, cnn);
                cmd.Parameters.Add("?category", MySqlDbType.VarChar).Value = category;
                cmd.Parameters.Add("?username", MySqlDbType.VarChar).Value = username;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DisconnectFromDatabase();
            }
        }
        public void UpdateCategoryData(string category, string username, string selectedCategory)
        {
            try
            {
                MySqlConnection cnn = ConnectToDatabase();
                string sqlDelete = "UPDATE category SET category = ?category WHERE username = ?username AND category = ?selectedCategory;";
                MySqlCommand cmd = new MySqlCommand(sqlDelete, cnn);
                cmd.Parameters.Add("?category", MySqlDbType.VarChar).Value = category;
                cmd.Parameters.Add("?selectedCategory", MySqlDbType.VarChar).Value = selectedCategory;
                cmd.Parameters.Add("?username", MySqlDbType.VarChar).Value = username;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DisconnectFromDatabase();
            }
        }
    }
}