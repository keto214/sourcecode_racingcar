using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class CarOffline : Form
    {
        public CarOffline()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Form2 a = new Form2();
            //a.Show();
            //this.Close();
            Form2 f2 = new Form2();
            this.Visible = false; // de an button khi click 
            f2.ShowDialog();
            this.Visible = true;//tat form 2, button form 1 se hien lai
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            ;
        }
    }
}
