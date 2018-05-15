using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace save3edit
{
    class Check
    {
        public static bool isValid(string path) {
            long length = new System.IO.FileInfo(path).Length;
            if (length > 9000)
            {
                MessageBox.Show("Invalid file");
                return false;   
            }
            return true;
        }
    }
}
