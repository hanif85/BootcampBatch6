using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 },
            new Person { Name = "Charlie", Age = 35 },
            new Person { Name = "David", Age = 40 },
            new Person { Name = "Eve", Age = 45 }
        };

        // Filter and project using lambda expressions
        var filteredPeople = people
            .Where(person => person.Age >= 30)
            .Select(person => new { person.Name, BirthYear = DateTime.Now.Year - person.Age })
            .ToList();

        // Print the filtered data
        Console.WriteLine("Filtered People:");
        foreach (var person in filteredPeople)
        {
            Console.WriteLine($"Name: {person.Name}, Birth Year: {person.BirthYear}");
        }

        // Calculate the average age using lambda expressions
        double averageAge = people.Average(person => person.Age);
        Console.WriteLine($"Average Age: {averageAge}");

        // Group people by their age using lambda expressions
        var groupedPeople = people.GroupBy(person => person.Age)
                                 .Select(group => new { Age = group.Key, Count = group.Count() })
                                 .OrderBy(group => group.Age)
                                 .ToList();

        // Print the grouped data
        Console.WriteLine("Grouped People:");
        foreach (var group in groupedPeople)
        {
            Console.WriteLine($"Age: {group.Age}, Count: {group.Count}");
        }
    }
}
