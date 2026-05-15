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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string user = Username.Text;
            string pass = Password.Text;

            // Hardcoded login (you can change later to SQL)
            if (user == "admin" && pass == "1234")
            {
                // Hide login form
                this.Hide();

                // Open main form
                Form1 main = new Form1();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
