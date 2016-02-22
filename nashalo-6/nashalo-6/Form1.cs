using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nashalo_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int[] integer;
            integer = new int[6];
            integer[0] = 0;
            integer[1] = 1;
            integer[2] = 2;
            integer[3] = 3;
            integer[4] = 4;
            integer[5] = 5;

            this.label1.Text = integer[4].ToString();            

        }
    }
}
