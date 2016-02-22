using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nashalo_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int[] complicated = new int[155];
            int complicated1=0;

            for (int i=0; i<155; i = i + 1)
            {
                complicated[i]= i * i;
                complicated1 = complicated1 + complicated[i];
            }

            this.label1.Text = complicated1.ToString();
        }
    }
}
