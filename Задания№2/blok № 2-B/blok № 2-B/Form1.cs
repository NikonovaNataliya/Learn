using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blok___2_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            long factorial = 1;
            for (int i = 1; i <= 20; i = i + 1)
            {
                // factorial *= i;
                factorial = factorial * i;    
            }
            this.label1.Text = factorial.ToString();
        }
    }
}
