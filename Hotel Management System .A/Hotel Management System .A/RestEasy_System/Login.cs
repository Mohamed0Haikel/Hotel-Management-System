using RestEasy_System.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestEasy_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (userTextBox.Text == "Admin" && PassTextBox.Text == "12345" || userTextBox.Text == "Ahmed" && PassTextBox.Text == "12345"|| userTextBox.Text == "Mahmoud" && PassTextBox.Text == "12345"|| userTextBox.Text == "Eldahaby" && PassTextBox.Text == "12345" || userTextBox.Text == "Taghreed" && PassTextBox.Text == "12345")
            {
                MessageBox.Show("Welcome " + userTextBox.Text);
                GuestMDIParent g2 = new GuestMDIParent();
                g2.Show();

            }
            else
            {
                MessageBox.Show("Error...User name/Password incorrect!!");
                userTextBox.Text = "";
                PassTextBox.Clear();

            }
        }

        private void BunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked)
            {


                PassTextBox.UseSystemPasswordChar = false;

            }
            else
            {
                PassTextBox.UseSystemPasswordChar = true;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
            DialogResult x = MessageBox.Show("Do you want to close?", "Warrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                timer1.Start();
                
            }
            else
            {

            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity = this.Opacity - 0.05;
            }
            else
            {

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
