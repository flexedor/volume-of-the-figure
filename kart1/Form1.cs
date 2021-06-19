using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kart1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stronaA_TextChanged(object sender, EventArgs e)
        {

        }

        private void znalezć_Click(object sender, EventArgs e)
        {
            String StronaA1 = stronaA.Text;
            String StronaB1 = stronaB.Text;
            String StronaC1 = StronaC.Text;
            String Wysokos = wys.Text;
            double end1 = (2 /(Convert.ToDouble(StronaA1) + Convert.ToDouble(StronaB1)*Convert.ToDouble(Wysokos)))*Convert.ToDouble(StronaC1);
            textBox2.Text= Convert.ToString(end1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void StronaC_TextChanged(object sender, EventArgs e)
        {

        }

        private void stronaB_TextChanged(object sender, EventArgs e)
        {

        }

        private void wys_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
