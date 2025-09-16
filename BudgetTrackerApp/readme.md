# Budget Tracker App

A simple console-based budget tracking application built with C# and .NET 9.0 that helps you manage your personal finances by tracking fixed expenses and variable spending across different categories.

## Features

- **Fixed Expenses Management**: Track recurring expenses like rent, utilities, internet, phone bills, and subscriptions
- **Category Budgeting**: Set and monitor budgets for different spending categories (groceries, clothing, etc.)
- **Dynamic Expense Addition**: Easily add new fixed expenses to your tracking list
- **Budget Alerts**: Get warnings when you exceed your overall budget or individual category budgets
- **Real-time Calculations**: Automatic calculation of total expenses, remaining budget, and category-specific remaining amounts

## How It Works

The application tracks three types of financial data:

1. **Fixed Expenses**: Regular recurring expenses that don't change month to month
   - Rent: $50.00
   - Utilities: $25.00
   - Internet: $100.00
   - Phone Bill: $60.00
   - Subscription Service: $30.00

2. **Variable Budgets**: Categories where you set spending limits
   - Grocery Budget: $150.00
   - Clothing Budget: $75.00

3. **Actual Spending**: What you've actually spent in each variable category
   - Grocery Spent: $120.00
   - Clothing Spent: $50.00

## Sample Output

```text
Welcome to Budget Tracker App!
Grocery Budget: 150
Clothing Budget: 75
Fixed Expenses:
- Rent: 50
- Utilities: 25
- Internet: 100
- Phone Bill: 60
- Subscription Service: 30
Total Fixed Expenses: 265
Total Expenses: 435
Remaining Budget: 55
You are within your budget.
Remaining Grocery Budget: 30
Remaining Clothing Budget: 25
```

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- Windows, macOS, or Linux operating system

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/Lanthanum89/BudgetTrackerApp.git
cd BudgetTrackerApp
```

### Build and Run

1. **Build the application:**

   ```bash
   dotnet build
   ```

2. **Run the application:**

   ```bash
   dotnet run
   ```

### Customize Your Budget

To customize the budget for your personal use, modify the values in `Program.cs`:

```csharp
// Update budget amounts
double groceryBudget = 150.00;  // Change to your grocery budget
double clothingBudget = 75.00;  // Change to your clothing budget

// Update fixed expenses
List<double> fixedExpensesList = new() { 50.00, 25.00, 100.00 }; // rent, utilities, internet

// Add your own fixed expenses
fixedExpensesList.Add(60.00); // phone bill
fixedExpensesList.Add(30.00); // subscription service

// Update actual spending
double grocerySpent = 120.00;  // What you actually spent on groceries
double clothingSpent = 50.00;  // What you actually spent on clothing
```

## Project Structure

```text
BudgetTrackerApp/
├── Program.cs                 # Main application logic
├── BudgetTrackerApp.csproj   # Project configuration file
├── BudgetTrackerApp.sln      # Solution file
├── README.md                 # This file
├── bin/                      # Compiled binaries (generated)
└── obj/                      # Build artifacts (generated)
```

## Key Programming Concepts Demonstrated

- **Collections**: Using `List<T>` for dynamic expense management
- **Loops**: Foreach loops for iterating through expenses
- **Conditional Logic**: Budget status checking with if/else statements
- **String Interpolation**: Formatted output using `$"{variable}"` syntax
- **Mathematical Operations**: Budget calculations and comparisons

## Future Enhancements

This basic version could be extended with:

- [ ] User input for dynamic budget entry
- [ ] Data persistence (save/load budgets from files)
- [ ] Multiple budget categories
- [ ] Monthly/yearly budget tracking
- [ ] Expense history and reporting
- [ ] Budget recommendations based on spending patterns
- [ ] Graphical user interface (GUI)

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is open source and available under the [MIT License](LICENSE).

## Contact

Created by [Lanthanum89](https://github.com/Lanthanum89) as part of the Code First Girls C# kickstarter.

---

## Happy budgeting! 💰📊
