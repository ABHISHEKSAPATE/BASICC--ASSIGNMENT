using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        

        private void Loginbt_Click(object sender, EventArgs e)
        {
            if(namebox.Text=="admin" && passwordbox.Text=="admin123")
            {

                MessageBox.Show("Login Sussessful");

            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void ResetBt_Click(object sender, EventArgs e)
        {
            namebox.Clear();
            passwordbox.Clear();
        }
    }
}
