using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShayanDarabian___Market_Project
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //پنهان کردن رمز عبور
            txtPass.UseSystemPasswordChar = true;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //ورود به برنامه
            try
            {
                if (txtUser1.Text == "admin" && txtPass.Text == "admin")
                {
                    this.Hide();
                    Main m = new Main();
                    m.ShowDialog();
                }
                else if (txtUser1.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("لطفا نام کاربری و رمز عبور را کامل وارد کنید");
                }
                else
                {
                    MessageBox.Show("نام کاربری و رمز عبور غلط است");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("نام کاربری و رمز عبور غلط است");
            }

            txtUser1.Clear();
            txtPass.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //بستن برنامه
            Application.Exit();
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            //نمایش یا پنهان کردن رمز عبور
            if (cbShow.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
          
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
        }

        private void txtUser1_Enter(object sender, EventArgs e)
        {
            //هایلات نوشته
            if (txtUser1.Text == "نام کاربری را وارد کنید")
            {
                txtUser1.Text = "";
                txtUser1.ForeColor = Color.Black;
            }
        }

        private void txtUser1_Leave(object sender, EventArgs e)
        {
            //هایلات نوشته
            if (txtUser1.Text == "")
            {
                txtUser1.Text = "نام کاربری را وارد کنید";
                txtUser1.ForeColor = Color.Silver;
            }
        }
    }
}
