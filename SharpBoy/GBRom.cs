using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBoy
{
    public class GBRom : IRom
    {
        private IRomLoader romLoader;
        private byte[] data;

        public void SetRomLoader(IRomLoader loader)
        {
            romLoader = loader;
        }

        public void Load(String path)
        {
            data = romLoader.ReadROM(path);
        }

        public byte ReadByte(int offset)
        {
            if (offset < 0) { throw new ArgumentOutOfRangeException("offset", "Offset cannot be a negative number"); }
            if (offset >= data.Length) { throw new ArgumentOutOfRangeException("offset", "Offset cannot be larger than the ROM"); }
            return data[offset];
        }
        public short ReadWord(int offset) => throw new NotImplementedException();
    }
}
