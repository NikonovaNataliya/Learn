using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nashalo_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int[] complicated = new int[155];
            int complicated1 = 0;
            int complicated2;

            for (int i = 0; i < 100; i = i + 1)
            {
                complicated[i] = i * i;
                complicated1 = complicated1 + complicated[i];
            }
            complicated2 = complicated1 % 4;

            string[] massiv_imen = { "Анна", "Артур", "Игорь", "Вера" };
            if( complicated2 >= 4 )
            {
                this.linkLabel1.Text = "Недопустимый индекс";
            }
            else 
            //if( complicated2 < 4 )
            {
                this.linkLabel1.Text = massiv_imen[complicated2].ToString();
            }
            //тестовое изменение
        }
    }
}
