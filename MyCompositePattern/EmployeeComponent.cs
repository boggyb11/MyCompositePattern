using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCompositePattern
{
    abstract class EmployeeComponent
    {
        public string Name;
        public float salary;

        public EmployeeComponent(string name)
        {
            this.Name = name;
        }



        public abstract void Add(EmployeeComponent employeeComponent);
        public abstract void Remove(EmployeeComponent employeeComponent);
        public abstract void Display();

    }
}
