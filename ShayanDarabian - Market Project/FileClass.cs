using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShayanDarabian___Market_Project
{
    internal class FileClass
    {
        //فایل مشتری به همراه جزییات
        public void SaveFileUser (Dictionary<string, User> D)
        {
            try
            {
                FileStream fs = new FileStream("D:\\UserData.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                foreach (KeyValuePair <string, User> kvp in D)
                {
                    sw.WriteLine(" Code : " + kvp.Key + "\n" + " Name : " + kvp.Value.Getname() + "\n" + " Phone : " + kvp.Value.Getphone() + "\n" + " Email : " + kvp.Value.Getemail() + "\n" + " Address : " + kvp.Value.GetAddress() + "\n" + "--------------\n");
                }
                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("نمی توان فایل کاربر را ذخیره کرد");
            }
        }

        public string LoadFileUser()
        {
            string s = "";
            try
            {
                FileStream fs = new FileStream("D:\\UserData.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    s = s + line + "\n";
                }
                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("نمی توان فایل کاربر را خواند");
            }
            return s;
        }

        //فایل مشتری فقط اسم ها
        public void SaveUsern(List<string> l)
        {
            try
            {
                FileStream fs = new FileStream("D:\\User.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                for (int i = 0; i < l.Count; i++)
                {
                    sw.WriteLine(l[i] + "\n");
                }
                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("نمی توان فایل را ذخیره کرد");
            }
        }

        public string LoadUsern()
        {
            string s = "";
            try
            {
                FileStream fs = new FileStream("D:\\User.txt", FileMode.Create);
                StreamReader sr = new StreamReader(fs);

                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    s = s + line + "\n";
                }
                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("نمی توان فایل را خواند");
            }
            return s;
        }

        //فایل مشتری فقط بارکد ها
        public void SaveUserc(List<string> l)
        {
            try
            {
                FileStream fs = new FileStream("D:\\Code.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                for (int i = 0; i < l.Count; i++)
                {
                    sw.WriteLine(l[i] + "\n");
                }
                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("نمی توان فایل را ذخیره کرد");
            }
        }

        public string LoadUserc()
        {
            string s = "";
            try
            {
                FileStream fs = new FileStream("D:\\Code.txt", FileMode.Create);
                StreamReader sr = new StreamReader(fs);

                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    s = s + line + "\n";
                }
                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("نمی توان فایل را خواند");
            }
            return s;
        }

        //فایل محصولات فقط اسم ها
        public void SavePrdn(List<string> l)
        {
            try
            {
                FileStream fs = new FileStream("D:\\Prdname.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                for (int i = 0; i < l.Count; i++)
                {
                    sw.WriteLine(l[i] + "\n");
                }
                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("نمی توان فایل را ذخیره کرد");
            }
        }

        public string LoadPrdn()
        {
            string s = "";
            try
            {
                FileStream fs = new FileStream("D:\\Prdname.txt", FileMode.Create);
                StreamReader sr = new StreamReader(fs);

                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    s = s + line + "\n";
                }
                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("نمی توان فایل را خواند");
            }
            return s;
        }

        //فایل ذخیره رمز عبور جدید
        public void SavePass (Queue <string> q)
        {
            try
            {
                FileStream fs = new FileStream("D:\\Password.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                while (q.Count > 0)
                {
                    sw.WriteLine(q.Dequeue());
                }
                sw.Close();
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("نمی توان فایل را پیدا کرد");
            }
        }

        public string LoadPass()
        {
            string s = "";
            try
            {
            FileStream fs = new FileStream("D:\\Password.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                s = s + line + "\n";
            }

            sr.Close();
            fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("نمی توان فایل را پیدا کرد");
            }
            return s;
        }

        // فایل محصولات به همراه جزییات
        public void SaveFileProd(Dictionary<string, Product> D)
        {
            try
            {
                FileStream fs = new FileStream("D:\\ProdData.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                foreach (KeyValuePair<string, Product> kvp in D)
                {
                    sw.WriteLine(" Code : " + kvp.Key + "\n" + " Name : " + kvp.Value.get_name() + "\n" + " Price : " + kvp.Value.get_price() + "\n" + " Producer : " + kvp.Value.get_producer() + "\n" + " Kind : " + kvp.Value.get_kind() + "\n" + " EXdate : " + kvp.Value.get_exdate() + "\n" + "--------------\n");
                }
                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("نمی توان فایل کالا را ذخیره کرد");
            }
        }

        public string LoadFileProd()
        {
            string s = "";
            try
            {
                FileStream fs = new FileStream("D:\\ProdData.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    s = s + line + "\n";
                }
                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("نمی توان فایل کالا را خواند");
            }
            return s;
        }
    }
}
