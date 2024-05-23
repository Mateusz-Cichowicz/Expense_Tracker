using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;


namespace ExpenseTracker
{
    internal class Authentication
    {
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public string ValidateUser(MySqlConnection cnn, string username)
        {
            string sqlSelect = "SELECT EXISTS(SELECT* from user_info WHERE username= ?username)";
            MySqlCommand cmd = new MySqlCommand(sqlSelect, cnn);
            cmd.Parameters.Add("?username", MySqlDbType.VarChar).Value = username;
            return cmd.ExecuteScalar().ToString();
        }
        public bool ValidateUserPassword(MySqlConnection cnn, string username, string password) 
        {
            string sqlSelect2 = "SELECT password from user_info WHERE username = ?username";
            MySqlCommand cmd2 = new MySqlCommand(sqlSelect2, cnn);
            cmd2.Parameters.Add("?username", MySqlDbType.VarChar).Value = username;
            string storedPassword = cmd2.ExecuteScalar()?.ToString();
            string hashedPassword = HashPassword(password);
            if (storedPassword == hashedPassword)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
