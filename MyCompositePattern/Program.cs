using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a tree structure

            EmployeeComposite employees = new EmployeeComposite("FullTime");
            employees.Add(new EmployeeLeaf("jim"));
            employees.Add(new EmployeeLeaf("bob"));

            EmployeeComposite partTime = new EmployeeComposite("PartTime");
            partTime.Add(new EmployeeLeaf("jenny"));
            partTime.Add(new EmployeeLeaf("brian"));

            employees.Add(partTime);
            employees.Add(new EmployeeLeaf("Jess"));

            // Add and remove a leaf

            EmployeeLeaf james = new EmployeeLeaf("James");
            employees.Add(james);
            employees.Remove(james);

            // Recursively display tree

            employees.Display();

            // Wait for user

            Console.ReadKey();
        }
    }
}
