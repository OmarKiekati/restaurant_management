using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.Advanced
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sigin_Click(object sender, EventArgs e)
        {
            if (MainClass.Validation(user.Text, password.Text) == false)
            {
                Message.show("invalid username or password");
                return;

            }
            else
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
