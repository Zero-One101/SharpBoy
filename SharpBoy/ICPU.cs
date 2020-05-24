using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBoy
{
    interface ICPU
    {
        void Tick();
        void Fetch();
        void Execute();
    }
}
