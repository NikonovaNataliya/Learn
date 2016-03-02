using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blok___3_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string n = "Harry";
            string greeting = "Hello, ";
            string greeting1 = "!";
            greeting = greeting + n + greeting1;

            this.label1.Text = greeting.ToString();


        }
    }
}
