using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            // Прямокутник, в якому буде виводитись графік функції
            form2.left = 20;
            form2.top = 20;
            form2.width = 300;
            form2.height = 300;
            form2.f_show = false;
            form2.x0 = 0;
            form2.y0 = 0;
            form2.z0 = 0;
            form2.A = -8;
            form2.alfa = 10;
            form2.beta = 12;
            form2.X_min = -3;
            form2.X_max = 3;
            form2.Y_min = -3;
            form2.Y_max = 3;
            form2.ShowDialog();
        }
    }
}
