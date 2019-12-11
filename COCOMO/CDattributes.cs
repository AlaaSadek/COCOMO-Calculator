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
    public partial class CDattributes : Form
    {
        public CDattributes()
        {
            InitializeComponent();
        }
        double total = 1;

        private void vlowList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CDattributes_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void aefortBTN_Click(object sender, EventArgs e)
        {
            double answer = 1;
            answer = total * Form1.EI;
            MessageBox.Show(answer.ToString());
        }

        private void eafBTN_Click(object sender, EventArgs e)
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

            MessageBox.Show(total.ToString());
        }
    }
}
