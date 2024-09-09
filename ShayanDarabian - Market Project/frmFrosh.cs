using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShayanDarabian___Market_Project
{
    public partial class frmFrosh : Form
    {
        public frmFrosh()
        {
            InitializeComponent();
            DateTime date = DateTime.Today;
        }

        public void Sums()
        {
            //محاسبه جمع کل
            Int64 sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt64(dataGridView1.Rows[i].Cells[4].Value.ToString().Replace(",", "").Trim());
            }
            textBox8.Text = sum.ToString();
            textBox10.Text = sum.ToString();
        }

        private void frmFrosh_Load_1(object sender, EventArgs e)
        {
            //انتقال دیتای فایل ها
            lblDT.Text = DateTime.Now.ToString();
            try
            {
                string[] allLine = File.ReadAllLines(@"D:\\User.txt");
                string[] allLine1 = File.ReadAllLines(@"D:\\Code.txt");
                string[] allLine2 = File.ReadAllLines(@"D:\\Prdname.txt");

                comboBox1.DataSource = allLine;
                comboBox2.DataSource = allLine1;
                comboBox4.DataSource = allLine2;

                comboBox3.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("شما هیچ مشتری یا کالایی ثبت نکرده اید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //بستن برنامه
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //افزودن به لیست
            if (textBox4.Text == "" && textBox7.Text == "")
            {
                MessageBox.Show("فیلدهای خالی را پر کنید");

            }
            else
            {

                string Column1 = comboBox2.Text;
                string Column2 = comboBox4.Text;
                string Column3 = textBox4.Text;
                string Column4 = textBox7.Text;
                string Column5 = textBox3.Text;
                string[] row = { Column1, Column2, Column3, Column4, Column5 };
                dataGridView1.Rows.Add(row);
                Sums();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //حذف از لیست
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                Sums();
            }
            if (textBox4.Text == "" && textBox7.Text == "")
            {
                MessageBox.Show("فیلدهای خالی را پر کنید");

            }
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            //محاسبه ضرب تعداد در قیمت تکی
            if (textBox4.Text != "" && textBox7.Text != "")
            {
                int A, B, C;
                A = int.Parse(textBox4.Text.Trim());
                B = int.Parse(textBox7.Text.Trim());
                C = A * B;
                textBox3.Text = C.ToString();
            }
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            //محاسبه ضرب تعداد در قیمت تکی
            if (textBox4.Text != "" && textBox7.Text != "")
            {
                int A, B, C;
                A = int.Parse(textBox4.Text.Trim());
                B = int.Parse(textBox7.Text.Trim());
                C = A * B;
                textBox3.Text = C.ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("کالایی ثبت نشده است");
            }
            else
            {
                //ثبت فاکتور
                DateTime today = DateTime.Now;
                string s = "";
                s += " تاریخ : " + today + "\n";

                MessageBox.Show("فاکتور با موفقیت ثبت شد" , "" , MessageBoxButtons.OK);
                MessageBox.Show(s + " شماره فاکتور : " + label13.Text + "\n" + " نام مشتری : " + comboBox1.Text + "\n" + " کد مشتری :" + comboBox2.Text + "\n" + "~~~~~~~~~~~~~~" + "\n" + " نام محصول : " + comboBox4.Text + "  " + "|  تعداد : " + textBox4.Text + "  " + "|  قیمت تکی : " + textBox7.Text + "  " + "|  قیمت کل : " + textBox3.Text + "\n" + "______________" + "\n" + " جمع فاکتور : " + textBox8.Text + "\n" + " تخفیف : " + textBox9.Text + " % " + "\n" + " نوع پرداخت : " + comboBox3.Text + "\n" + " قابل پرداخت : " + textBox10.Text, "فاکتور", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);

                textBox4.Clear();
                textBox7.Clear();
                textBox3.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                dataGridView1.Rows.Clear();

                label13.Text = (Convert.ToInt32(label13.Text)+1).ToString();
            }
        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {
            //محاسبه تخفیف
            if (textBox8.Text != "" && textBox9.Text != "")
            {
                if (Convert.ToInt32(textBox9.Text) > 0)
                {
                    int A, B, C;
                    A = int.Parse(textBox8.Text.Trim());
                    B = int.Parse(textBox9.Text.Trim());
                    C = A - ((A * B) / 100);
                    textBox10.Text = C.ToString();
                }
            }
        }
    }
}
