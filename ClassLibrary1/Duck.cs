using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    public abstract class Duck
    {
        public virtual void Fly()
        {
            Console.WriteLine("Утка летит");
        }
        public virtual void Quack()
        {
            Console.WriteLine("Утка крякает");
        }
    }

}
