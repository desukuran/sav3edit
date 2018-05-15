using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace save3edit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Chrono Trigger Save|*.srm";
            openFileDialog1.Title = "Select a Save File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (Check.isValid(openFileDialog1.FileName) == false)
                {
                    MessageBox.Show("File Invalid: Unable to load");
                }


                save.data = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
                MessageBox.Show("File loaded!");


            }
        }
        SaveFile save = new SaveFile();
    }
}
