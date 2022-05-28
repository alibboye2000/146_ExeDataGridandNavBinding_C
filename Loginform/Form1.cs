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

namespace Loginform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-Q3E2M1Q;Initial Catalog=ProdiTI;Persist Security Info=True;User ID=sa;Password=***********");
            SqlDataAdapter Loginform = new SqlDataAdapter("select count(*)from login where username ='" + textBox1.Text + "'and password='" + textBox2.Text + "'", conn);
            DataTable dt = new DataTable();
            Loginform.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form1 mm = new Form1();
                mm.Show();
            }
            else
                MessageBox.Show("please enter correct username and password", "alart", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
