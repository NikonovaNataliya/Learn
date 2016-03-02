using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blok___2_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            double just_a_number = 2;
            byte degree = 179;
        
            just_a_number = Math.Pow(just_a_number, degree);

            this.label1.Text = just_a_number.ToString();
        }
    }
}
