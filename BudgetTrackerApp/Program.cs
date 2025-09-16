using System.Collections.Generic;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Budget Tracker App!");

double groceryBudget = 150.00; 
double clothingBudget = 75.00;  

Console.WriteLine($"Grocery Budget: {groceryBudget}");
Console.WriteLine($"Clothing Budget: {clothingBudget}");

/* create an array to hold fixed expenses 
double[] fixedExpenses = { 50.00, 25.00, 100.00 }; //  rent, utilities, internet

Console.WriteLine("Fixed Expenses:");
Console.WriteLine($"- Rent: {fixedExpenses[0]}");
Console.WriteLine($"- Utilities: {fixedExpenses[1]}");
Console.WriteLine($"- Internet: {fixedExpenses[2]}");
*/

// replace the array with a List to allow dynamic management of fixed expenses
List<double> fixedExpensesList = new() { 50.00, 25.00, 100.00 }; // rent, utilities, internet

fixedExpensesList.Add(60.00); // adding a new fixed expense (e.g., phone bill)
fixedExpensesList.Add(30.00); // adding another fixed expense (e.g., subscription service)

Console.WriteLine("Fixed Expenses:");
Console.WriteLine($"- Rent: {fixedExpensesList[0]}");
Console.WriteLine($"- Utilities: {fixedExpensesList[1]}");
Console.WriteLine($"- Internet: {fixedExpensesList[2]}");
Console.WriteLine($"- Phone Bill: {fixedExpensesList[3]}");
Console.WriteLine($"- Subscription Service: {fixedExpensesList[4]}");

// calculating total fixed expenses
double totalFixedExpenses = 0.00;
foreach (double expense in fixedExpensesList)
{
    totalFixedExpenses += expense;
}

double grocerySpent = 120.00;
double clothingSpent = 50.00;   

// calculate total expenses (fixed + variable)
double totalExpenses = totalFixedExpenses + grocerySpent + clothingSpent;
double totalBudget = groceryBudget + clothingBudget + totalFixedExpenses;
double remainingBudget = totalBudget - totalExpenses;

Console.WriteLine($"Total Fixed Expenses: {totalFixedExpenses}");
Console.WriteLine($"Total Expenses: {totalExpenses}");
Console.WriteLine($"Remaining Budget: {remainingBudget}");

// Check overall budget status
if (remainingBudget < 0)
{
    Console.WriteLine("Warning: You have exceeded your budget!");
}
else
{
    Console.WriteLine("You are within your budget.");
}

// Check individual category budgets
double remainingGroceryBudget = groceryBudget - grocerySpent;
double remainingClothingBudget = clothingBudget - clothingSpent;

Console.WriteLine($"Remaining Grocery Budget: {remainingGroceryBudget}");
Console.WriteLine($"Remaining Clothing Budget: {remainingClothingBudget}");

if (remainingGroceryBudget < 0)
{
    Console.WriteLine("Alert: You have exceeded your grocery budget!");
}

if (remainingClothingBudget < 0)
{
    Console.WriteLine("Alert: You have exceeded your clothing budget!");
}

// End of the Budget Tracker App