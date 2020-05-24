using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBoy
{
    public interface IRomLoader
    {
        byte[] ReadROM(String path);
    }
}
