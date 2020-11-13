using System;
using System.Collections.Generic;
using System.Linq;

namespace BackEnd
{
    public class FakeDataStorage : IDataStorage
    {
        public IQueryable<Employee> Employees => new List<Employee>() { new Employee() { Name = "Jonas", Position = "Developer" } }.AsQueryable();

        public IQueryable<Workplace> Workplaces => new List<Workplace>() { new Workplace() { Address = "Kauno g. 5-15, Vilnius", Description = "Place" } }.AsQueryable();

        public void Load()
        {

        }
    }
}
