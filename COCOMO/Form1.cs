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
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = homeBTN.Height;
            SidePanel.Top = homeBTN.Top;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = homeBTN.Height;
            SidePanel.Top = homeBTN.Top;
            homePanel.BringToFront();


        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tdevBTN_Click(object sender, EventArgs e)
        {
            SidePanel.Height = tdevBTN.Height;
            SidePanel.Top = tdevBTN.Top;
            tdevPanel.BringToFront();
        }

        private void effortBTN_Click(object sender, EventArgs e)
        {
            SidePanel.Height = effortBTN.Height;
            SidePanel.Top = effortBTN.Top;
            effortPanel.BringToFront();
        }

        private void attributesBTN_Click(object sender, EventArgs e)
        {
            SidePanel.Height = attributesBTN.Height;
            SidePanel.Top = attributesBTN.Top;
            costDriverPanel.BringToFront();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            teamPanel.BringToFront();
        }

    }
}
