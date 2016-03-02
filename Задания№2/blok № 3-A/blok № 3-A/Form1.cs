using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blok___3_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int a = 3;
            int b = 4;

            double hypo = Math.Sqrt(a * a + b * b);

            this.label1.Text = hypo.ToString();

        }
    }
}
