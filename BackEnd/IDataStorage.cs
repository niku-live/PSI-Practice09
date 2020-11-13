using System;
using System.Collections.Generic;
using System.Linq;

namespace BackEnd
{
    public interface IDataStorage
    {
        void Load();
        IQueryable<Employee> Employees { get; }
        IQueryable<Workplace> Workplaces { get; }
    }
}
