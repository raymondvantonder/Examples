using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Abstractions
{
    public class AniversaryAPI : EmployeeBase
    {
        public AniversaryAPI(DateTime dateTime) : base(dateTime)
        {
        }

        protected override bool ExecuteInternal()
        {
            return true;
        }
    }
}
