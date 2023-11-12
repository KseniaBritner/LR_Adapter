using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    public class Turkey : Duck
    {
        public void Fly()
        {
            Console.WriteLine("Индюк летит");
        }
        public void Gobble()
        {
            Console.WriteLine("Индюк гогочет");
        }
    }
}
