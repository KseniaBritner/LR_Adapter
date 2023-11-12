using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    public class RubberDuck : Duck
    {
        public override void Fly()
        {
            Console.WriteLine("Резиновая утка не летает");
        }
        public override void Quack()
        {
            Console.WriteLine("Резиновая утка крякает");
        }
    }
}
