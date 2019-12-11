using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOMO
{
    public partial class Form1 : Form
    {
        public static ProjectType project = new ProjectType();
        public static double EI = 0.0;
        double TDEV = 0.0;

        public Form1()
        {
            InitializeComponent();
        }


        private void solveBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void inputSize_TextChanged(object sender, EventArgs e)
        {
            if (inputSize.Text.Length == 0)
            {
                typeDDL.SelectedIndex = -1;
            }
            else if (int.Parse(inputSize.Text) < 50)
            {
                typeDDL.SelectedIndex = 0;
                project = new ProjectType(Program.organic.getA(), Program.organic.getB(), Program.organic.getC(), Program.organic.getD(), Program.organic.Gettype());


    }
            else if (int.Parse(inputSize.Text) > 50 && int.Parse(inputSize.Text) < 300)
            {
                typeDDL.SelectedIndex = 1;
                project = new ProjectType(Program.semidetached.getA(), Program.semidetached.getB(), Program.semidetached.getC(), Program.semidetached.getD(), Program.semidetached.Gettype());

            }
            else if (int.Parse(inputSize.Text) >= 300)
            {
                typeDDL.SelectedIndex = 2;
                project = new ProjectType(Program.embeded.getA(), Program.embeded.getB(), Program.embeded.getC(), Program.embeded.getD(), Program.embeded.Gettype());


            }

        }

        private void typeDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeDDL.Text == "Organic")
            {
                project = new ProjectType(Program.organic.getA(), Program.organic.getB(), Program.organic.getC(), Program.organic.getD(), Program.organic.Gettype());

            }
            else if (typeDDL.Text == "Semi-Detached")
            {
                project = new ProjectType(Program.semidetached.getA(), Program.semidetached.getB(), Program.semidetached.getC(), Program.semidetached.getD(), Program.semidetached.Gettype());

            }
            else if (typeDDL.Text == "Embeded")
            {
                project = new ProjectType(Program.embeded.getA(), Program.embeded.getB(), Program.embeded.getC(), Program.embeded.getD(), Program.embeded.Gettype());

            }
        }


            private void effortBTN_Click(object sender, EventArgs e)
        {
            EI = Math.Pow(project.getA() * int.Parse(inputSize.Text), project.getB());
            string ei = EI.ToString();
           calculatedEffort.Text = ei;
        }

        private void tdevBTN_Click(object sender, EventArgs e)
        {

            TDEV = Math.Pow(project.getC() * EI, project.getD());
            string tdev = TDEV.ToString();
            calculatedEffort.Text = tdev;

        }

        private void actualBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void attributesBTN_Click(object sender, EventArgs e)
        {
            CDattributes cdattributes = new CDattributes();
            cdattributes.ShowDialog();
        }
    }
}
