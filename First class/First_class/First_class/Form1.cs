using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            First_class whole_numbers = new First_class();
           // int a = whole_numbers.Sum_whole_numbers();
            string a = whole_numbers.Sample_template();
            this.label1.Text = a.ToString();
        }
    }
    public class First_class
    {
        public int start;
        public int end;

        public First_class()
        {
            start = 1;
            end = 123;
        }

        public int Sum_whole_numbers()
        {
            int sum = 0;
            for (int i = start; i<=end; i++)
            {
                sum = sum + i;
            }
            return sum;
        }

        public string Sample_template()
        {
            string part1 = "От числа 1 до числа 123 присутствует ";
            int part2 = Sum_whole_numbers() ;
            string part3 = " целых чисел";
 
            string template = part1 + part2.ToString() + part3;
            return template;            
        }

    }
    
}
