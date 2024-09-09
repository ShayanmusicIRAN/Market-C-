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
    public partial class ChangeUP : Form
    {
        Queue<string> Qpass = new Queue<string>();
        public ChangeUP()
        {
            InitializeComponent();
        }

        private void ChangeUP_Load(object sender, EventArgs e)
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //تغییر رمز عبور
            if ("admin" == txtOP.Text && txtNP.Text != txtOP.Text && txtNP2.Text != txtOP.Text)
            {
                FileClass file = new FileClass();
                if (txtNP.Text.Equals(txtNP2.Text))
                {
                    Qpass.Enqueue(txtNP.Text);
                    file.SavePass(Qpass);
                    txtOP.Clear();
                    txtNP.Clear();
                    txtNP2.Clear();
                    if (MessageBox.Show ("رمز عبور با موفقیت تغییر کرد" , "Password Changed!" , MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("تکرار رمز عبور جدید تطابق ندارد!");
                    txtOP.Clear();
                    txtNP.Clear();
                    txtNP2.Clear();
                }
            }
            else
            {
                MessageBox.Show("رمز عبور تکراری می باشد");
                txtOP.Clear();
                txtNP.Clear();
                txtNP2.Clear();
            }
        }
    }
}
