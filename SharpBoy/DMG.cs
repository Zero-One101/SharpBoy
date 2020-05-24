using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBoy
{
    public class DMG : ICPU
    {
        public byte Opcode { get; private set; }
        public void Execute() => throw new NotImplementedException();
        public void Fetch() => throw new NotImplementedException();
        public void Tick() => throw new NotImplementedException();
    }
}
