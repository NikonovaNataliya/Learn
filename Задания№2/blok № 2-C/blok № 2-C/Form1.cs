using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blok___2_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            double catet1 = 179;
            double catet2 = 971;
            double hipot = Math.Sqrt(catet1 * catet1 + catet2 * catet2);

            this.label1.Text = hipot.ToString();
        }
    }
}
