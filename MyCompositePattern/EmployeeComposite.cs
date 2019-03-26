using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCompositePattern
{
    class EmployeeComposite : EmployeeComponent
    {
        private List<EmployeeComponent> employeeChildrenComponents = new List<EmployeeComponent>();

        public EmployeeComposite(string name) : base(name)
        {

        }


        public override void Add(EmployeeComponent employeeComponent)
        {
            employeeChildrenComponents.Add(employeeComponent);
        }

        public override void Display()
        {
            foreach (var item in employeeChildrenComponents)
            {
                Console.WriteLine($"{item.Name}");
            }

        }

        public override void Remove(EmployeeComponent employeeComponent)
        {
            employeeChildrenComponents.Remove(employeeComponent);
        }
    }
}
