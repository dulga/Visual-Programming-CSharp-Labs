using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            int a = int.Parse(multiplicand.Text);
            int b = int.Parse(multiplier.Text);
            int result = a * b;
            Result.Text = result.ToString();



        }

        private void exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", 
                "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes) { Application.Exit(); }
        }
    }
}
