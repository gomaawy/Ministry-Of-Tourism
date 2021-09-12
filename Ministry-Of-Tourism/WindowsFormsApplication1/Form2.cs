using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(96,199,193);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source =DESKTOP-7RCG43D\\SQLEXPRESS; Initial Catalog = Ministry of tourism; Integrated Security=True");
            con.Open();
            String countt = @"select dbo.signin4(@username,@passwor)";
            SqlCommand cmd1 = new SqlCommand(countt, con);
            SqlParameter param1 = new SqlParameter("@username", textBox2.Text);
            SqlParameter param2 = new SqlParameter("@passwor", textBox3.Text);
            cmd1.Parameters.Add(param1);
            cmd1.Parameters.Add(param2);
            int koko = (int)cmd1.ExecuteScalar();
            if (koko == 1) {
                mainmenu m = new mainmenu();
              //  m.s=Id(textBox2.Text);
                MessageBox.Show("nk");

                m.Show();
            this.Hide();
        }
            else
            {
                MessageBox.Show("Username or Password is incorrect");
            }
            
        }
        private String Id(String fn)
        {
            SqlConnection con = new SqlConnection("Data Source =DESKTOP-7RCG43D\\SQLEXPRESS; Initial Catalog = Ministry of tourism; Integrated Security=True");
            con.Open();
            String str = @"select * from Tourist where TouristName=@fn";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.Add(new SqlParameter("@fn", fn));
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {

                    return oReader["TouristID"].ToString();
                   
                }

                con.Close();
            }
            return "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';

        }
        private void textBox2_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == "Full Name")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }
        private void textBox3_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "Password")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            click();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            click();
        }
        private void click()
        {
            mainmenu m = new mainmenu();
            m.adm = admin();
            SqlConnection con = new SqlConnection("Data Source =DESKTOP-7RCG43D\\SQLEXPRESS; Initial Catalog = Ministry of tourism; Integrated Security=True");
            con.Open();
            String countt = @"select dbo.signin4(@username,@passwor)";
            SqlCommand cmd1 = new SqlCommand(countt, con);
            SqlParameter param1 = new SqlParameter("@username", textBox2.Text);
            SqlParameter param2 = new SqlParameter("@passwor", textBox3.Text);
            cmd1.Parameters.Add(param1);
            cmd1.Parameters.Add(param2);
            int koko = (int)cmd1.ExecuteScalar();
            if (koko == 1 || m.adm==1)
            {
                reservePlace a = new reservePlace();
                ReserveTransport b = new ReserveTransport();
                String i = Id(textBox2.Text);
                m.s = i;
                a.id = i;
                b.id = i;
                Global.GlobalVar = i;

                    m.Show();
                    this.Hide();
                
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect");
            }
        }
        private int admin()
        {
            SqlConnection con = new SqlConnection("Data Source =DESKTOP-7RCG43D\\SQLEXPRESS; Initial Catalog = Ministry of tourism; Integrated Security=True");
            con.Open();
            String countt = @"select dbo.adminsign(@username,@passwor)";
            SqlCommand cmd1 = new SqlCommand(countt, con);
            SqlParameter param1 = new SqlParameter("@username", textBox2.Text);
            SqlParameter param2 = new SqlParameter("@passwor", textBox3.Text);
            cmd1.Parameters.Add(param1);
            cmd1.Parameters.Add(param2);
            int koko = (int)cmd1.ExecuteScalar();
            if (koko == 1)
            {
                return 1;
            }
            else return 0;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
           
            new Form1().Show();
            this.Hide();
        
    }
    }
}
