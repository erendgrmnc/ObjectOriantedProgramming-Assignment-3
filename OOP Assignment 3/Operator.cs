using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ODEV_3_1._1
{
    class Operator
    {
        //Create ne dataTable
        DataTable data_Operator = new DataTable();

        protected string temp_Entry;
        protected string result;

        public string _restarter;
        public bool restarter;

        public void Calculate()
        {
            Console.WriteLine("Please Enter A Problem : ");

            temp_Entry = Console.ReadLine();


            //Uses DataTable's Compute function to Calculate Entered Problem.
            result = Convert.ToString(data_Operator.Compute(temp_Entry.Trim(), null));

            Console.WriteLine("The Result is :" + result);

            Console.WriteLine("Do you want to calculate another problem ?(Press 'Y' if you want to.)");

            _restarter = Console.ReadLine();

            //For running again the problem computer.
            if (_restarter == "y")
            {
                restarter = true;
            }
            else
            {
                restarter = false;
            }

        }

    }
}
