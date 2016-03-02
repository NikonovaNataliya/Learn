using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blok___2_E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string repetition = "Programm";
            string sum = "";

            for (int i = 0; i < 100; i++)
            {
                sum = sum +"\n" + repetition.ToString();
            }
            this.label1.Text = sum.ToString();
        }
    }
}
