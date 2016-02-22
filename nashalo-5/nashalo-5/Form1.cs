using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nashalo_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string part1 = " Начало строки, ";
            string part2 = " конец строки ";
            string part3 = " а это - ";
            string part4 = part1 + part3 + part2;

            this.linkLabel1.Text = part4.ToString();



        }
    }
}
