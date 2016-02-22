using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nashalo_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int[] complicated = new int[155];
            int complicated1 = 0;
            int complicated2;

            for (int i=0; i<100; i = i + 1)
            {
                complicated[i] = i * i;
                complicated1 = complicated1 + complicated[i];   
            }
            complicated2 = complicated1 % 4; 

            this.label1.Text = complicated2.ToString();
        }
    }
}
