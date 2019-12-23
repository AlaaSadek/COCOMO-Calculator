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
    public partial class CostDriver : UserControl
    {
        double total = 1;
        public CostDriver()
        {
            InitializeComponent();
        }

        private void calcBTN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vlowList.Items.Count; i++)
            {
                if (vlowList.GetItemChecked(i))
                {
                    total *= double.Parse(vlowList.Items[i].ToString());
                }
            }
            for (int i = 0; i < lowList.Items.Count; i++)
            {
                if (lowList.GetItemChecked(i))
                {
                    total *= double.Parse(lowList.Items[i].ToString());
                }
            }
            for (int i = 0; i < highList.Items.Count; i++)
            {
                if (highList.GetItemChecked(i))
                {
                    total *= double.Parse(highList.Items[i].ToString());
                }
            }
            for (int i = 0; i < vhighList.Items.Count; i++)
            {
                if (vhighList.GetItemChecked(i))
                {
                    total *= double.Parse(vhighList.Items[i].ToString());
                }
            }
            for (int i = 0; i < extrahighList.Items.Count; i++)
            {
                if (extrahighList.GetItemChecked(i))
                {
                    total *= double.Parse(extrahighList.Items[i].ToString());
                }
            }

            if (total != 1 && COCOMO.Controls.Effort.EI != 0.0)
            {
                calculatedResult.Text = total.ToString();
            }

            else
            {
                MessageBox.Show("Please calculate effort then try again!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (total != 1)
            {
                double answer = 1;
                answer = total * COCOMO.Controls.Effort.EI;
                calculatedResult.Text = answer.ToString();
            }

            else
            {
                MessageBox.Show("Please calculate effort adjustement factor then try again!");
            }
            
        }

        private void CostDriver_Load(object sender, EventArgs e)
        {

        }
    }
    }

