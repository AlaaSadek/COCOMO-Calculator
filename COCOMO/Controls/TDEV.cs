using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOMO.Controls
{
    public partial class TDEV : UserControl
    {
        public TDEV()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void calcBTN_Click(object sender, EventArgs e)
        {
            if (inputSize.Text == "" || typeDDL.Text == "")
            {
                MessageBox.Show("Please enter data!");
            }

            else
            {
                double TDEV = COCOMO.Controls.Effort.project.getC() * Math.Pow(COCOMO.Controls.Effort.EI, COCOMO.Controls.Effort.project.getD());
                string tdev = TDEV.ToString();
                calculatedTDEV.Text = tdev;
            }
            
        }

        private void inputSize_TextChanged(object sender, EventArgs e)
        {
            if (inputSize.Text.ToString() != "" && System.Text.RegularExpressions.Regex.IsMatch(inputSize.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only!");
                inputSize.Text = inputSize.Text.Remove(inputSize.Text.Length - 1);
                return;
            }
            if (inputSize.Text.ToString() != "" && double.Parse(inputSize.Text.ToString()) == 0.0)
            {
                MessageBox.Show("KLOC must be greater than ZERO!");
                inputSize.Text = inputSize.Text.Remove(inputSize.Text.Length - 1);
                return;
            }
            if (inputSize.Text.Length == 0)
            {
                typeDDL.SelectedIndex = -1;
            }
            else if (int.Parse(inputSize.Text) < 50)
            {
                typeDDL.SelectedIndex = 0;
                COCOMO.Controls.Effort.project = new ProjectType(Program.organic.getA(), Program.organic.getB(), Program.organic.getC(), Program.organic.getD(), Program.organic.Gettype());


            }
            else if (int.Parse(inputSize.Text) > 50 && int.Parse(inputSize.Text) < 300)
            {
                typeDDL.SelectedIndex = 1;
                COCOMO.Controls.Effort.project = new ProjectType(Program.semidetached.getA(), Program.semidetached.getB(), Program.semidetached.getC(), Program.semidetached.getD(), Program.semidetached.Gettype());

            }
            else if (int.Parse(inputSize.Text) >= 300)
            {
                typeDDL.SelectedIndex = 2;
                COCOMO.Controls.Effort.project = new ProjectType(Program.embeded.getA(), Program.embeded.getB(), Program.embeded.getC(), Program.embeded.getD(), Program.embeded.Gettype());


            }
            if (inputSize.Text.Length > 0)
            {
                COCOMO.Controls.Effort.inputKLOC = double.Parse(inputSize.Text.ToString());

            }
        }

        private void CalcBTN_Click(object sender, EventArgs e)
        {
            COCOMO.Controls.Effort.EI = COCOMO.Controls.Effort.project.getA() * Math.Pow(int.Parse(inputSize.Text), COCOMO.Controls.Effort.project.getB());
            string ei = COCOMO.Controls.Effort.EI.ToString();
            calculatedTDEV.Text = ei;
        }

        private void typeDDL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
