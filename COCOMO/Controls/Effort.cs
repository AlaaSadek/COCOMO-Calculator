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
    public partial class Effort : UserControl
    {
        public static ProjectType project = new ProjectType();
        public static double EI = 0.0;
        public static double inputKLOC = 0.0;
        public static string projectSizeIn = "";
        public Effort()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void calculatedEffort_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EI = project.getA() * Math.Pow(int.Parse(inputSize.Text), project.getB());
            string ei = EI.ToString();
            calculatedEffort.Text = ei;
        }

        private void inputSize_TextChanged_1(object sender, EventArgs e)
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
            if (inputSize.Text.Length > 0)
            {
                
                inputKLOC = double.Parse(inputSize.Text.ToString());

            }
        }

        private void calcBTN_Click(object sender, EventArgs e)
        {
            if (inputSize.Text == "" || typeDDL.Text == "")
            {
                MessageBox.Show("Please enter data!");
            }
            else
            {
                EI = project.getA() * Math.Pow(double.Parse(inputSize.Text), project.getB());
                string ei = EI.ToString();
                calculatedEffort.Text = Math.Round(double.Parse(ei), 3).ToString();
               
            }

        }

        private void typeDDL_SelectedIndexChanged_1(object sender, EventArgs e)
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
            projectSizeIn = typeDDL.Text.ToString();
        }
    }
}
