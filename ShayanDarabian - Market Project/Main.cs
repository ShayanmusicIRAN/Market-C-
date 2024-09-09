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
    public partial class Main : Form
    {
        private static Main instance = null;
        public static Main GetInstance()
        {
            //برگشت به فرم اصلی
            if (instance == null)
                instance = new Main();

            return instance;
        }

        public Main()
        {
            InitializeComponent();
        }

        private void btnKala_Click(object sender, EventArgs e)
        {
            //نمایش پنل ثبت محصول
            frmKala f = new frmKala();
            f.ShowDialog();
        }

        private void btnMoshtari_Click(object sender, EventArgs e)
        {
            //نمایش پنل ثبت مشتری
            frmCustomer f = new frmCustomer();
            f.ShowDialog();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            //بستن برنامه
            Application.Exit();
        }

        private void تغییررمزعبورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //نمایش پنل تغییر رمز عبور
            ChangeUP f = new ChangeUP();
            f.ShowDialog();
        }

        private void btnFrosh_Click(object sender, EventArgs e)
        {
            //نمایش پنل ثبت فاکتور
            frmFrosh f = new frmFrosh();
            f.ShowDialog();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            //نمایش پنل ارتباط با ما
            MessageBox.Show("نام: شایان\n نام خانوادگی: دارابیان\n تلفن همراه: 09155657226", "ارتباط با ما", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
