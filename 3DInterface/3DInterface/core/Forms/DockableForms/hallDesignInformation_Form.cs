﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DInterface.core.Forms.DockableForms
{
    public partial class hallDesignInformation_Form : Form
    {
        public hallDesignInformation_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.ToString().Equals("") && !textBox1.Text.ToString().Equals("0"))
            {
                UIController contrl = new UIController();
                contrl.setPeople(int.Parse(textBox1.Text));
                contrl.AutoGenerateDesign();
                this.Close();
            }
            
        }
    }
}
