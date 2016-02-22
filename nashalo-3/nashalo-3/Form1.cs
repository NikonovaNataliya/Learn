using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nashalo_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string first_sentence;
            first_sentence = "Это тестовая строка";
            this.label1.Text = first_sentence.ToString();

        }
    }
}
