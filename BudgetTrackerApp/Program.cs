// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Budget Tracker App!");


double groceryBudget = 150.00; 
double clothingBudget = 75.00;  


Console.WriteLine($"Grocery Budget: {groceryBudget}");
Console.WriteLine($"Clothing Budget: {clothingBudget}");

"""// create an array to hold fixed expenses 
double[] fixedExpenses = { 50.00, 25.00, 100.00 }; //  rent, utilities, internet

Console.WriteLine("Fixed Expenses:");
Console.WriteLine($"- Rent: {fixedExpenses[0]}");
Console.WriteLine($"- Utilities: {fixedExpenses[1]}");
Console.WriteLine($"- Internet: {fixedExpenses[2]}");
"""

// replace the array with a List to allow dynamic management of fixed expenses
List<double> fixedExpensesList = new List<double> { 50.00, 25.00, 100.00 }; // rent, utilities, internet

fixedExpensesList.Add(60.00); // adding a new fixed expense (e.g., phone bill)
fixedExpensesList.Add(30.00); // adding another fixed expense (e.g., subscription service)

Console.WriteLine("Fixed Expenses:");
Console.WriteLine($"- Rent: {fixedExpensesList[0]}");
Console.WriteLine($"- Utilities: {fixedExpensesList[1]}");
Console.WriteLine($"- Internet: {fixedExpensesList[2]}");
Console.WriteLine($"- Phone Bill: {fixedExpensesList[3]}");
Console.WriteLine($"- Subscription Service: {fixedExpensesList[4]}");