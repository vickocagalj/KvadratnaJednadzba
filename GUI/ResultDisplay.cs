using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KvadratnaJednadzba;

namespace Vsite.CSharp.KvadratnaJednadžba.GUI
{
    public partial class ResultDisplay : UserControl
    {
        public ResultDisplay()
        {
            InitializeComponent();
        }

        public readonly QuadraticEquation qE = new QuadraticEquation();

        public void FillResults()
        {
            qE.A = (double) numericUpDowna.Value;
            qE.B = (double) numericUpDownb.Value;
            qE.C = (double) numericUpDownc.Value;

            double discriminant = qE.Discriminant;
            Discriminant.Text = discriminant.ToString();
            Roots1.Text = qE.Roots[0].ToString();
            Roots2.Text = qE.Roots[1].ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            FillResults();
        }
    }
}
