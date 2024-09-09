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
    public partial class frmKala : Form
    {
        Dictionary<string , Product> prdDic = new Dictionary<string, Product>();
        List<string> name = new List<string>();
        public frmKala()
        {
            InitializeComponent();
            button2.Hide();
        }

        public void Sabt()
        {
            //ثبت کالا جدید
            FileClass file = new FileClass();
            txtBarcode.Focus();

            try
            {
                string s = file.LoadFileUser();
                if (prdDic.ContainsKey(txtBarcode.Text))
                {
                    MessageBox.Show("کالا قبلا وارد شده است");
                }
                else
                {
                    Product pr = new Product(txtName.Text, txtBarcode.Text, Convert.ToInt32(txtPrice.Text), txtProducer.Text, comboBox1.Text, maskedTextBox1.Text);
                    prdDic.Add(txtBarcode.Text, pr);
                    name.Add(txtName.Text);
                    dataGridView1.Rows.Add("", txtName.Text, txtPrice.Text, txtBarcode.Text);
                    file.SaveFileProd(prdDic);
                    file.SavePrdn(name);
                    MessageBox.Show("با موفقیت اضافه شد");
                }

                txtName.Clear();
                txtPrice.Clear();
                txtProducer.Clear();
                txtBarcode.Clear();
                comboBox1.SelectedIndex = -1;
                maskedTextBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("لطفا همه مشخصات را وارد کنید");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //افزودن
            Sabt();
        }
        private void btnEX_Click(object sender, EventArgs e)
        {
            //بستن برنامه
            this.Close();
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //نوشتن فقط اعداد
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //نوشتن فقط اعداد
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //حذف کالا
            if (prdDic.ContainsKey(txtBarcode.Text))
            {

                if (MessageBox.Show("آیا می خواهید حذف کنید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    prdDic.Remove(txtBarcode.Text);
                    MessageBox.Show("کالا مورد نظر با موفقیت حذف شد");
                    txtName.Clear();
                    txtPrice.Clear();
                    txtProducer.Clear();
                    txtBarcode.Clear();
                    comboBox1.SelectedIndex = -1;
                    maskedTextBox1.Clear();

                    if (this.dataGridView1.SelectedRows.Count > 0)
                    {
                        dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
 
                    }
                }
            }
            else
            {
                MessageBox.Show("کالا موجود نیست");
                txtBarcode.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //نمایش هشدار حذف
            button2.Show();
            button1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            txtName.Hide();
            txtPrice.Hide();
            txtProducer.Hide();
            comboBox1.Hide();
            maskedTextBox1.Hide();
            btnAdd.Hide();
            btnPrint.Hide();

            MessageBox.Show("لطفا بارکد را وارد کنید", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            button1.Hide();
            txtBarcode.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //برگشت
            button1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            txtName.Show();
            txtPrice.Show();
            txtProducer.Show();
            comboBox1.Show();
            maskedTextBox1.Show();
            btnAdd.Show();
            txtName.Clear();
            txtPrice.Clear();
            txtProducer.Clear();
            txtBarcode.Clear();
            comboBox1.SelectedIndex = -1;
            maskedTextBox1.Clear();
            button2.Hide();
            btnPrint.Show();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //اضافه کردن ردیف
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            //هایلات نوشته
            if (maskedTextBox1.Text == "1402")
            {
                maskedTextBox1.Text = "";
                maskedTextBox1.ForeColor = Color.Black;
            }
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            //هایلات نوشته
            if (maskedTextBox1.Text == "")
            {
                maskedTextBox1.Text = "1402";
                maskedTextBox1.ForeColor = Color.Silver;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //چاپ کردن
            FileClass file = new FileClass();
            string s = file.LoadFileProd();
            MessageBox.Show(s);
        }
    }
}
