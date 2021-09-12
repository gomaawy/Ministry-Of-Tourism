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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(96, 199, 193);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
     
     
        private void click()
        {
            SqlConnection con = new SqlConnection("Data Source =DESKTOP-7RCG43D\\SQLEXPRESS; Initial Catalog = Ministry of tourism; Integrated Security=True");
            con.Open();
            string selected = comboBox1.GetItemText(comboBox1.SelectedItem);
            String signUp = @"insert into Tourist (TouristName,Mail,Telephone,pass,WayOfPayment)
                values(@name,@email,@tele,@pass,@credit)";
            SqlParameter param1 = new SqlParameter("@name", textBox2.Text);
            SqlParameter param2 = new SqlParameter("@email", textBox1.Text);
            SqlParameter param3 = new SqlParameter("@tele", textBox4.Text);
            SqlParameter param4 = new SqlParameter("@pass", textBox5.Text);
            SqlParameter param5 = new SqlParameter("@credit", selected);
            SqlCommand cmd = new SqlCommand(signUp, con);
            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);
            cmd.Parameters.Add(param3);
            cmd.Parameters.Add(param4);
            cmd.Parameters.Add(param5);
            cmd.ExecuteNonQuery();
            new Form1().Show();
            this.Hide();
        }
       
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            click();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            click();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "E-MAIL")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Name")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }
       
        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "Telephone")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.ForeColor = Color.Black;
            
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "Password")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.PasswordChar = '*';
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "Date Of Birth ")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }
    }
}
