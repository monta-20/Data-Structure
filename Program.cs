//ValueTuple
/*
Introduced in C# 7.0 (System.ValueTuple namespace).

A lightweight, value-type tuple (faster than reference-type Tuple).

Can hold multiple items of different types.

Supports naming fields (unlike classic Tuple’s Item1, Item2...).

Immutable by default.

👉 Think of it as the modern way to return multiple values or group data quickly.
*/
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Basic
        var user = (1, "Montassar");
        // With explicit types
        ValueTuple<int, string> product = (101, "Laptop");
        // With field names
        (var id, var name) = (1, "Ben Brahim");
        // Or named directly
        var employee = (Id: 200, Name: "Ali", Salary: 3500.75);

        // Without names
        Console.WriteLine(user.Item1); // 1
        Console.WriteLine(user.Item2); // Montassar
        // With names
        Console.WriteLine(employee.Id);    // 200
        Console.WriteLine(employee.Name);  // Ali
        Console.WriteLine(employee.Salary); // 3500.75
        // Deconstruction
        var (empId, empName, empSalary) = employee;
        Console.WriteLine($"{empId} - {empName} - {empSalary}");
        // Nested
        var order = (OrderId: 5001, Product: (ProductId: 101, ProductName: "Laptop"), Quantity: 2);
        Console.WriteLine(order.Product.ProductName); // Laptop
        // Comparison
        var tuple1 = (1, "Alice");
        var tuple2 = (1, "Alice");
        Console.WriteLine(tuple1 == tuple2); // True
        // Immutability
        // tuple1.Item1 = 2; // Error: Cannot modify
    }
}
