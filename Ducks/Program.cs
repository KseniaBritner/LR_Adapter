using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>();
            ducks.Add(new RubberDuck());
            ducks.Add(new WildDuck());
            Turkey turkey = new Turkey();
            ducks.Add(turkey);

            foreach (var duck in ducks)
            {
                if (duck is Turkey)
                {
                    Duck Adapter = new Adapter(turkey);
                    Adapter.Quack();
                    Adapter.Fly();
                }
                else
                {
                    duck.Quack();
                    duck.Fly();
                }
                Console.WriteLine();
            }
        }
    }
}
