using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nashalo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            double a = 64.542;

            this.label1.Text = a.ToString();
        }
    }
}
