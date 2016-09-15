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
    public partial class loginform : MetroFramework.Forms.MetroForm
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            username.Text = String.Empty;
            password.Text = String.Empty;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            String a, b;
            a = username.Text;
            b = password.Text;
            if (a == "a" && b == "a")
            {
                MetroMessageBox.Show(this, "Login Successful", "Welcome " + a, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            username.Text = " ";
            password.Text = " ";
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
