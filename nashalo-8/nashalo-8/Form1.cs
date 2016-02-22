using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nashalo_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int[] complicated = new int[55];

            for (int i = 0; i < 55; i = i+1)
            {
                complicated[i] = i * i;
            }
                
            this.label1.Text = complicated[50].ToString();
        }
    }
}
