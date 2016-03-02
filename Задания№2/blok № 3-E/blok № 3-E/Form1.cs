using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blok___3_E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int n = 3;
            int m = 14;
            int apple = 14 % 3;

            this.label1.Text = apple.ToString();
        }
    }
}
