﻿using System;
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
    public partial class frmCustomer : Form
    {
        Dictionary<string, User> Cusdic = new Dictionary<string, User>();
        List<string> user = new List<string>();
        List<string> code = new List<string>();
        public frmCustomer()
        {
            InitializeComponent();
            button2.Hide();
        }

        public void Sabt()
        {
            //ثبت مشتری جدید
            FileClass file = new FileClass();
            txtBarcode.Focus();

            try
            {
                string s = file.LoadFileUser();
                if (Cusdic.ContainsKey(txtBarcode.Text))
                {
                    MessageBox.Show("مشتری قبلا وارد شده است");
                }
                else
                {
                    User cus = new User (txtName.Text, txtBarcode.Text, Convert.ToInt32(txtPhone.Text), txtEmail.Text, txtAddress.Text);
                    Cusdic.Add(txtBarcode.Text, cus);
                    user.Add(txtName.Text);
                    code.Add(txtBarcode.Text);
                    dataGridView1.Rows.Add("", txtName.Text, txtBarcode.Text, txtPhone.Text);
                    file.SaveFileUser(Cusdic);
                    file.SaveUsern(user);
                    file.SaveUserc(code);
                    MessageBox.Show("با موفقیت اضافه شد");
                }

                txtName.Clear();
                txtPhone.Clear();
                txtAddress.Clear();
                txtBarcode.Clear();
                txtEmail.Clear();
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //اضافه کردن ردیف
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //حذف مشتری
            if (Cusdic.ContainsKey(txtBarcode.Text))
            {
                if (MessageBox.Show("آیا می خواهید حذف کنید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cusdic.Remove(txtBarcode.Text);
                    MessageBox.Show("مشتری مورد نظر با موفقیت حذف شد");
                    txtName.Clear();
                    txtPhone.Clear();
                    txtEmail.Clear();
                    txtBarcode.Clear();
                    txtAddress.Clear();

                    if (this.dataGridView1.SelectedRows.Count > 0)
                    {
                        dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);

                    }
                }
            }
            else
            {
                MessageBox.Show("مشتری موجود نیست");
                txtBarcode.Clear();
            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //نوشتن فقط اعداد
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //نوشتن فقط اعداد
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //بستن برنامه
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //نمایش هشدار حذف
            button2.Show();
            button1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            txtName.Hide();
            txtPhone.Hide();
            txtAddress.Hide();
            txtEmail.Hide();
            btnAdd.Hide();
            btnPrint.Hide();

            MessageBox.Show("لطفا بارکد را وارد کنید", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            button1.Hide();
            txtBarcode.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //برگشت
            button1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            txtName.Show();
            txtPhone.Show();
            txtAddress.Show();
            txtEmail.Show();
            btnAdd.Show();
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtBarcode.Clear();
            txtAddress.Clear();
            button2.Hide();
            btnPrint.Show();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            //هایلات نوشته
            if (txtEmail.Text == "gmail.com@")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            //هایلات نوشته
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "gmail.com@";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //چاپ کردن
            FileClass file = new FileClass();
            string s = file.LoadFileUser();
            MessageBox.Show(s);
        }
    }
}
