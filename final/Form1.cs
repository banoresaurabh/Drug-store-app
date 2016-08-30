using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = String.Empty;
            metroTextBox2.Text = String.Empty;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            String a, b;
            a = metroTextBox1.Text;
            b = metroTextBox2.Text;
            if(a=="a" && b == "a")
            {
                MetroMessageBox.Show(this,"Login Successful","Welcome "+a, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
