using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackEnd
{
    public class DefaultDataStorage : IDataStorage
    {
        public IQueryable<Employee> Employees => new List<Employee>() { new Employee() { Name = "Jonas", Position = "Developer" } }.AsQueryable();

        public IQueryable<Workplace> Workplaces => new List<Workplace>() { new Workplace() { Address = "Kauno g. 5-15, Vilnius", Description = "Place" } }.AsQueryable();

        public void Load()
        {
            
        }
    }
}
