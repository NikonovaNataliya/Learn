using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blok___3_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int n = 179;
            string first = "The next number for the number ";
            string first1 = "  is ";
            int a = n + 1;

            string second = "The previous number for the number ";
            string second1 = "  is ";
            int b = n - 1;

            first = first + n + first1 + a;
            second = second + n + second1 + b;
            first = first + "\n" + second;

            this.label1.Text = first.ToString();


        }
    }
}
