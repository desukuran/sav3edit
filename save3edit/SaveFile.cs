using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace save3edit
{

    class SaveFile
    {
        public byte[] data;
        public string fileName, filePath;

        public byte[] itemTypes = new byte[0xFF];
        public byte[] itemCount = new byte[0xFF];

        public void populateItems()
        {
            for (int i = 0; i < 0XFF; i++)
            {
                itemTypes[i] = data[i];
                itemCount[i] = data[i+itemCountGap];

            }
        }

        private int itemCountGap = 0x100;
    }
}
