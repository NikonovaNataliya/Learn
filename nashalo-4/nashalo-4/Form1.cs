using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nashalo_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int a = 23;
            double a1 = 48.543;
            double a2 = a + a1;

            this.label1.Text = a2.ToString();


        }
    }
}
