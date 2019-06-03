using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dom
{
    class StartDom
    {
        static void Main()
        {
            ParametrDom haus = new ParametrDom();

            Write("Наименование - .....");
            haus.S = ReadLine();
            Write("Колличество этажей - .....");
            haus.A = Convert.ToInt32(Console.ReadLine());
            Write("Oбщая площадь здания - .....");
            haus.B = Convert.ToInt32(Console.ReadLine());
            Write("Колличество жильцов - .....");
            haus.C = Convert.ToInt32(Console.ReadLine());

            haus.Oth();
        }
    }
}
