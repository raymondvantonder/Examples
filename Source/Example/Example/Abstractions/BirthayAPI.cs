using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Abstractions
{
    public class BirthayAPI : EmployeeBase
    {
        public BirthayAPI(DateTime dateTime) : base(dateTime)
        {

        }

        protected override bool ExecuteInternal()
        {
            // Logic
            return true;
        }
    }
}
