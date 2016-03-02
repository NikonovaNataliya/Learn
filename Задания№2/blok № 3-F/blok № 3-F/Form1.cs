using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blok___3_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            double n = 60;
            double m = 2;
            double s = n*m;

            if (s > 109 * 2)
                s = s % 109;


            else if (s > 109)
                s = n * m - 109;

            else if (s < 109)
                s = m * n;



            this.label1.Text = s.ToString();
        }
    }
}
