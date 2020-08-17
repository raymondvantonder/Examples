using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Abstractions
{
    public abstract class EmployeeBase<T>
    {
        private DateTime _endDate;

        public EmployeeBase(DateTime endDate)
        {
            _endDate = endDate;
        }

        protected abstract bool ExecuteInternal();

        public bool Execute()
        {
            Console.WriteLine($"Executing for {typeof(T).Name} now");

            if (!HasEnded())
            {
                bool result = ExecuteInternal();
                Console.WriteLine($"Result is {result}");
                return result;
            }
            else
            {
                Console.WriteLine($"End date reached {_endDate}");

                return false;
            }
        }

        public bool HasEnded()
        {
            if (DateTime.Now > _endDate)
            {
                return true;
            }

            return false;
        }
    }
}
