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
        double answer = 1;
        static public double EAF = 0;
        static public bool eafIsCalc = false;
        public CostDriver()
        {
            InitializeComponent();
        }

        private void calcBTN_Click(object sender, EventArgs e)
        {

            total = 1;
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
            for (int i = 0; i < nominalList.Items.Count; i++)
            {
                if (nominalList.GetItemChecked(i))
                {
                    total *= double.Parse(nominalList.Items[i].ToString());
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

            if (COCOMO.Controls.Effort.EI != 0.0)
            {

                EAF = Math.Round(total, 3);
                calculatedResult.Text = EAF.ToString();
                eafIsCalc = true;

            }

            else
            {
                MessageBox.Show("Please calculate effort then try again!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            answer = 1;

            if (total != 1)
            {

                answer = total * COCOMO.Controls.Effort.EI;

                calculatedResult.Text = Math.Round(answer, 3).ToString();

            }

            else
            {
                MessageBox.Show("Please calculate effort adjustement factor then try again!");
            }

        }

        private void CostDriver_Load(object sender, EventArgs e)
        {

        }

        private void calculatedResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void vlowList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = vlowList.SelectedIndex;
         
            if (index != -1 && vlowList.GetItemChecked(index) && (lowList.GetItemChecked(index)
                || highList.GetItemChecked(index) || vhighList.GetItemChecked(index)
                || extrahighList.GetItemChecked(index) || nominalList.GetItemChecked(index)))
            {
                MessageBox.Show("Please select one only!");
                vlowList.SetItemChecked(index, false);
                vlowList.SelectedIndex = -1;

            }
        }

        private void lowList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lowList.SelectedIndex;

            if ( index != -1 && lowList.GetItemChecked(index) && (vlowList.GetItemChecked(index)
                || highList.GetItemChecked(index) || vhighList.GetItemChecked(index)
                || extrahighList.GetItemChecked(index) || nominalList.GetItemChecked(index)))
            {
                MessageBox.Show("Please select one only!");
                lowList.SetItemChecked(index, false);
                lowList.SelectedIndex = -1;

            }
        }

        private void nominalList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nominalList.SelectedIndex;

            if (index != -1 && nominalList.GetItemChecked(index) && (vlowList.GetItemChecked(index)
                || highList.GetItemChecked(index) || vhighList.GetItemChecked(index)
                || extrahighList.GetItemChecked(index) || lowList.GetItemChecked(index)))
            {
                MessageBox.Show("Please select one only!");
                nominalList.SetItemChecked(index, false);
                nominalList.SelectedIndex = -1;

            }
        }

        private void highList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = highList.SelectedIndex;

            if (index != -1 && highList.GetItemChecked(index) && (vlowList.GetItemChecked(index)
                || nominalList.GetItemChecked(index) || vhighList.GetItemChecked(index)
                || extrahighList.GetItemChecked(index) || lowList.GetItemChecked(index)))
            {
                MessageBox.Show("Please select one only!");
                highList.SetItemChecked(index, false);
                highList.SelectedIndex = -1;

            }
        }

        private void vhighList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = vhighList.SelectedIndex;

            if (index != -1 && vhighList.GetItemChecked(index) && (vlowList.GetItemChecked(index)
                || nominalList.GetItemChecked(index) || highList.GetItemChecked(index)
                || extrahighList.GetItemChecked(index) || lowList.GetItemChecked(index)))
            {
                MessageBox.Show("Please select one only!");
                vhighList.SetItemChecked(index, false);
                vhighList.SelectedIndex = -1;

            }
        }

        private void extrahighList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = extrahighList.SelectedIndex;
            if (index != -1 && extrahighList.GetItemChecked(index) && (vlowList.GetItemChecked(index)
                || nominalList.GetItemChecked(index) || vhighList.GetItemChecked(index)
                || highList.GetItemChecked(index) || lowList.GetItemChecked(index)))
            {
                MessageBox.Show("Please select one only!");
                extrahighList.SetItemChecked(index, false);
                extrahighList.SelectedIndex = -1;
            }
           

        }
    }
}
    

