using System;
using System.Linq;

namespace BackEnd
{
    public class Logic : ILogic
    {
        IDataStorage dataStorage;

        public Logic(IDataStorage dataStorage)
        {
            this.dataStorage = dataStorage;
        }

        public string GetFirstEmployeeName()
        {
            var empl = dataStorage.Employees.FirstOrDefault();
            return empl.Name;
        }

        public string GetLastEmployeeName()
        {
            var empl = dataStorage.Employees.LastOrDefault();
            return empl.Name;
        }
    }
}
