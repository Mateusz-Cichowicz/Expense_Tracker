# Expense Tracker

## Overview
Expense Tracker is a simple application designed to help users manage and track their expenses. It allows users to add, edit, and delete expenses, providing a clear overview of their financial activities.

## Features
- Add new expenses with details such as amount, category, and date
- Edit existing expenses
- Delete expenses
- View a summary of expenses

## Technologies Used
- C#
- .NET Framework
- MySQL

## Getting Started

### Prerequisites
- Visual Studio 2019 or later
- .NET Framework 4.7.2 or later
- MySQL Server

### Installation
1. Clone the repository:
    ```sh
    git clone https://github.com/Mateusz-Cichowicz/Expense_Tracker.git
    ```
2. Open the solution file `Expense_Tracker.sln` in Visual Studio.
3. Build the solution to restore dependencies.
4. Ensure MySQL Server is installed and running on `localhost` with the following credentials:
    - **User**: root
    - **Password**: 1575

### Configuration
The application is configured to connect to the MySQL server using the default credentials provided above (`server=localhost;user=root;password=1575`). The application will take care of creating and connecting to the database.

### Running the Application
1. Run the application from Visual Studio.
2. The application will automatically create the necessary database and tables upon first run.
3. Use the interface to add, edit, or delete expenses and view summaries.

## Usage
1. Launch the application.
2. Use the interface to manage your expenses.
3. View the summary of your expenses.

## Contributing
Contributions are welcome! Please fork the repository and create a pull request with your changes.

## License
This project is licensed under the MIT License.

## Contact
For any questions or suggestions, please open an issue in the repository.
