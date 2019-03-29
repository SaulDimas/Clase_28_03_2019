using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_28_03_2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkBox1.Checked == true)
            {
                label1.Text = "Seleccione el check1";
            }
            if (this.checkBox2.Checked == true)
            {
                label1.Text = "Seleccione el check2";
            }
            if (this.checkBox3.Checked == true)
            {
                label1.Text = "Seleccione el check3";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label1.BackColor = Color.Blue;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label1.BackColor = Color.Red;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                
                this.BackColor = Color.LimeGreen;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i = 10:i++)
            {
                comboBox1.Items
            }
        }
    }
}
