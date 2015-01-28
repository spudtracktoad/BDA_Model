using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BDA_Simulator
{
    public partial class BDA_Simulator_Main : Contorller
    {
        public BDA_Simulator_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Build_M1();
            label1.Text = GetM1Info().ToString();
            Build_T90();
            label2.Text = GetT90Info().ToString();
        }
    }
}
