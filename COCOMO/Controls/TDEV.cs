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
        public void SetInputSize(string inputS)
        {
            inputSize.Text = inputS;
        }
        public void SetTypeDDL (string inputType)
        {
            typeDDL.Text = inputType;
        }
        private void calcBTN_Click(object sender, EventArgs e)
        {
           

             if (COCOMO.Controls.Effort.EI == 0)
            {
                MessageBox.Show("Please calculate effort then try again!");
            }
            else
            {
                double TDEV = COCOMO.Controls.Effort.project.getC() * Math.Pow(COCOMO.Controls.Effort.EI, COCOMO.Controls.Effort.project.getD());
                string tdev = TDEV.ToString();
                calculatedTDEV.Text = Math.Round(double.Parse(tdev), 3).ToString(); ;
                inputSize.Text = COCOMO.Controls.Effort.inputKLOC.ToString();
                typeDDL.Text = COCOMO.Controls.Effort.projectSizeIn.ToString();
                effortBOX.Text = Math.Round(COCOMO.Controls.Effort.EI,3).ToString();
 
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
                
                if (inputSize.Text.Length > 0)
                {
                    COCOMO.Controls.Effort.inputKLOC = double.Parse(inputSize.Text.ToString());

                }
            }

            private void CalcBTN_Click(object sender, EventArgs e)
            {
                COCOMO.Controls.Effort.EI = COCOMO.Controls.Effort.project.getA() * Math.Pow(int.Parse(inputSize.Text), COCOMO.Controls.Effort.project.getB());
                string ei = COCOMO.Controls.Effort.EI.ToString();
          
            }

        private void effortBOX_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

