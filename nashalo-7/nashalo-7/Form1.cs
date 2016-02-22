using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nashalo_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int[] brackets = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };
            this.label1.Text = brackets[5].ToString();
        }
    }
}
