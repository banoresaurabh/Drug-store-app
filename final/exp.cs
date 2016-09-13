using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
namespace final
{
    public partial class exp : MetroFramework.Forms.MetroForm
    {
        public exp()
        {
            InitializeComponent();
        }

        private void exp_Load(object sender, EventArgs e)
        {

        }
        private void color_changer(object sender, EventArgs e) {
            Control ctr = (Control)sender;
            ctr.BackColor = System.Drawing.Color.FromArgb(0, 119, 1);
        }

        private void color_changer2(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            ctr.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void metroPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(0, 119, 1);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
