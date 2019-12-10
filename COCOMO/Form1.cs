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
            }
            else if (int.Parse(inputSize.Text) > 50 && int.Parse(inputSize.Text) < 300)
            {
                typeDDL.SelectedIndex = 1;
            }
            else if (int.Parse(inputSize.Text) >= 300)
            {
                typeDDL.SelectedIndex = 2;
            }
           
        }

        private void typeDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
