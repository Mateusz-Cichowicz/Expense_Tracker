

namespace ExpenseTracker
{
    internal class Category
    {
        public Database database;
        public Category() 
        {
            database = new Database();
        }
        public void AddCategory(string categoryName, string username) 
        {
            try
            {
                database.SaveCategory(categoryName, username);
                MessageBox.Show("Category added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("This category already exists");
            }
            finally
            {
                database.DisconnectFromDatabase();
            }

        }
        public void DeleteCategory(string categoryName, string username)
        {
            try
            {
                database.DeleteCategoryData(categoryName, username);
                MessageBox.Show("Category deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("This category doesn't exist");
            }
            finally
            {
                database.DisconnectFromDatabase();
            }
        }
        public void EditCategory(string categoryName, string username, string selectedCategory)
        {
            try
            {
                database.UpdateCategoryData(categoryName, username, selectedCategory);
                MessageBox.Show("Category edited.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("This category already exist");
            }
            finally
            {
                database.DisconnectFromDatabase();
            }
        }
    }
}
