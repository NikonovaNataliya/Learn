using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blok___2_D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

             string letter = "A";
             string sum = "";
            // sum = sum + letter;
       

            for (int i =0; i < 100; i = i + 1)
            {
             sum = sum + letter.ToString();
            }
            this.label1.Text = sum.ToString();


          
    
            
        }
    }
}
