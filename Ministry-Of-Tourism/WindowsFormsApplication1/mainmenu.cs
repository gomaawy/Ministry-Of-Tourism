using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }
        public String s { get; set; }
        public int adm { get; set; }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
  

        }
       
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            new Transportation().Show();
            this.Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            new place().Show();
            this.Hide();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (adm == 1)
            {
                new ViewTourist2().Show();
            }
                else {
                EditTourist t = new EditTourist();
                t.s = Global.GlobalVar ;
                t.Show();
                this.Hide(); }
         }

        private void panel3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
