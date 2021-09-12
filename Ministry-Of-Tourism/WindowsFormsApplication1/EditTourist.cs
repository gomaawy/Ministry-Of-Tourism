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
    public partial class EditTourist : Form
    {
        public EditTourist()
        {
            InitializeComponent();
        }
        public String s { get; set; }

        private void EditTourist_Load(object sender, EventArgs e)
        {
            label6.BackColor = Color.FromArgb(96, 199, 193);

            SqlConnection con = new SqlConnection("Data Source =DESKTOP-7RCG43D\\SQLEXPRESS; Initial Catalog = Ministry of tourism; Integrated Security=True");
            con.Open();
            String str = @"select * from Tourist where TouristID=@ID";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.Add(new SqlParameter("@ID", s));
            //  SqlParameter param1 = new SqlParameter("@ID", s);

            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    textBox8.Text = oReader["TouristName"].ToString();
                    textBox9.Text = oReader["Mail"].ToString();
                    textBox7.Text = oReader["Telephone"].ToString();
                    textBox2.Text = oReader["Pass"].ToString();
                    comboBox1.Text = oReader["WayOfPayment"].ToString();
                  //  textBox5.Text = ;
                }

                con.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            new mainmenu().Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source =DESKTOP-7RCG43D\\SQLEXPRESS; Initial Catalog = Ministry of tourism; Integrated Security=True");
            con.Open();
            string UpdateString = "UPDATE Tourist set TouristName=@tourname,Mail=@ml,Telephone=@tlphn,Pass=@ps,WayOfPayment=@wof where @id=TouristID";
            SqlCommand cmd = new SqlCommand(UpdateString, con);
            cmd.Parameters.AddWithValue("@tourname", textBox8.Text);
            cmd.Parameters.AddWithValue("@ml", textBox9.Text);
            cmd.Parameters.AddWithValue("@tlphn", textBox7.Text);
            cmd.Parameters.AddWithValue("@ps", textBox2.Text);
            cmd.Parameters.AddWithValue("@wof", comboBox1.GetItemText(comboBox1.SelectedItem));
            cmd.Parameters.AddWithValue("@id", s);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("UPDATED");
            new mainmenu().Show();
            this.Hide();
        }
    }
}
