📌 When to Use Tuple / ValueTuple in Web Applications

Tuple and ValueTuple are lightweight containers for multiple values, so you use them when you need to return or pass multiple values without creating a separate class.

1. Returning multiple values from a method

Common in service layers or API logic.

Example: returning both status and data from a web API call.

public (int statusCode, string message) Login(string username, string password)
{
    if (username == "admin" && password == "1234")
        return (200, "Login successful");
    return (401, "Unauthorized");
}

// Usage
var result = Login("admin", "1234");
Console.WriteLine($"{result.statusCode} - {result.message}");


✅ Advantage: No need to create a dedicated class for simple return values.

2. Temporary grouping of data

When you need a quick container for passing around small sets of related values between layers.

var userInfo = (Id: 1, Name: "Montassar", Role: "Admin");
// Pass to another method or controller

3. Processing queries

Useful in LINQ queries where you need multiple fields from a collection.

var users = new List<User> { ... };
var results = users.Select(u => (u.Id, u.Name, u.Email));

foreach (var u in results)
    Console.WriteLine($"{u.Id} - {u.Name} - {u.Email}");

4. Avoiding small DTO classes

For internal logic or helper methods where creating a dedicated class or record is overkill.

Example: returning (min, max) values from a computation.

⚠️ When NOT to use Tuple / ValueTuple in web apps

❌ For API models → use DTOs (Data Transfer Objects) or records for clarity and serialization.

❌ For complex or large objects → classes/records are easier to maintain.

❌ When field names matter for JSON serialization → ValueTuple isn’t ideal.