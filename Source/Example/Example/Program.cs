using Example.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBase raymondBirthdayApi = new BirthayAPI(new DateTime(2020, 08, 14));

            EmployeeBase philipBirthdayApi = new BirthayAPI(new DateTime(2020, 08, 17));

            EmployeeBase philipAniApi = new AniversaryAPI(new DateTime(2020, 08, 14));
            EmployeeBase rayAniApi = new AniversaryAPI(new DateTime(2020, 08, 17));


            raymondBirthdayApi.Execute();
            philipBirthdayApi.Execute();
            Console.WriteLine();
            philipAniApi.Execute();
            rayAniApi.Execute();

            Console.Read();
        }
    }
}
