using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public class StaticDataStorage
    {
        public static IEnumerable<Employee> Employees => new List<Employee>() { new Employee() { Name = "Jonas2", Position = "Developer" } };
        public static IEnumerable<Workplace> Workplaces => new List<Workplace>() { new Workplace() { Address = "Kauno g. 5-15, Vilnius", Description = "Place" } };
    }


    public class StaticDataStorage2
    {
        public static IEnumerable<Employee> Employees => new List<Employee>() { new Employee() { Name = "Jonas2", Position = "Developer" } };
        public static IEnumerable<Workplace> Workplaces => new List<Workplace>() { new Workplace() { Address = "Kauno g. 5-15, Vilnius", Description = "Place" } };
    }
}
