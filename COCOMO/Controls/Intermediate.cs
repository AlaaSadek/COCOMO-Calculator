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
    public partial class Intermediate : UserControl
    {
        public Intermediate()
        {
            InitializeComponent();
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            if(COCOMO.Controls.Effort.EI!=0 && COCOMO.Controls.CostDriver.eafIsCalc == true)
            {
                eafBOX.Text = COCOMO.Controls.CostDriver.EAF.ToString();
                actualEffortBox.Text = Math.Round((COCOMO.Controls.Effort.EI * COCOMO.Controls.CostDriver.EAF),3).ToString();
                double temp = Math.Round(Math.Pow(double.Parse(actualEffortBox.Text), COCOMO.Controls.Effort.project.getD()),3);
                tdevBOX.Text = Math.Round( (COCOMO.Controls.Effort.project.getC() * temp),3).ToString();
            }
            else
            {
                MessageBox.Show("Please calculate EAF then try again!");
            }
            
        }
    }
}
