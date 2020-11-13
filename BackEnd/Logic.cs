using System;
using System.Linq;

namespace BackEnd
{
    public class Logic
    {
        public Logic()
        {
        }

        public string GetFirstEmployeeName()
        {
            var empl = StaticDataStorage.Data.Employees.FirstOrDefault();
            return empl.Name;
        }

        public string GetLastEmployeeName()
        {
            var empl = StaticDataStorage.Data.Employees.LastOrDefault();
            return empl.Name;
        }
    }
}
