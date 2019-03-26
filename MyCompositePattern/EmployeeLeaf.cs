using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCompositePattern
{
    class EmployeeLeaf : EmployeeComponent
    {
        public EmployeeLeaf(string name) : base(name)
        {

        }

        public override void Add(EmployeeComponent employeeComponent)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Display()
        {
            Console.WriteLine(Name);
        }

        public override void Remove(EmployeeComponent employeeComponent)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }
    }
}
