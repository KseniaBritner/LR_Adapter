using adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    public class Adapter : Duck
    {
        private Turkey _turkey;

        public Adapter(Turkey turkey)
        {
            if (turkey!=null) this._turkey = turkey;
        }

        public override void Quack()
        {
            _turkey.Gobble();
        }

        public override void Fly()
        {
            _turkey.Fly();
        }
    }
}
