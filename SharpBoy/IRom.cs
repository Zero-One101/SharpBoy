using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBoy
{
    interface IRom
    {
        void Load(String path);
        byte ReadByte(int offset);
        short ReadWord(int offset);
    }
}
