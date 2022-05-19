using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//SQl Baðlantý
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;//Text Yazdýrma
using System.Data.SqlClient;//SQl Baðlantý
namespace Kullanici_Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-4F37LKP\\;Initial Catalog=Kullanici_Giris;Integrated Security=True");//SQL Baðlantý
        private void button1_Click(object sender, EventArgs e)
        {

            try//Butona basýldýðýnda bu blok çalýþýr
            {
                con.Open();//baðlantýyý aç
                string sql_sorgu = "Select * from Giris where Kullanici_Adi = @kullanici AND Sifre =@sifre";//SQL sorgu komutu
                SqlParameter prmtr1 = new SqlParameter("kullanici", tb1_Kullanici.Text);//Sorgu komutlarýnda ki paremetreleri baðladým
                SqlParameter prmtr2 = new SqlParameter("sifre", tb2_Sifre.Text);//Sorgu komutlarýnda ki paremetreleri baðladým
                SqlCommand cmd = new SqlCommand(sql_sorgu, con);//Sql baðlantý ile yaptýrdým
                cmd.Parameters.Add(prmtr1);//paremetreleri sorgularýn yerine koydum
                cmd.Parameters.Add(prmtr2);//paremetreleri sorgularýn yerine koydum
                DataTable dt=new DataTable();//sanal datatable oluþturdum
                SqlDataAdapter da = new SqlDataAdapter(cmd);//referans verildi
                da.Fill(dt);//gelen verileri tablolara yükleme iþlemi yapar

                if (dt.Rows.Count > 0)//Gelen veri olursa dt 1 arttýðý için bu blok çalýþýr
                {
                        MessageBox.Show("Baþarýlý Giriþ");//ekrana çýktý verir
                }
                else//eðer veri tabanýndan girilen bilgilerle veri gelmediyse blok çalýþýr
                {
                    MessageBox.Show("Yanlýþ Kullanýcý Adý Veya Þifre ");//Ekrana messagebox aç ve çýktý ver
                    StreamWriter Yaz1 = File.AppendText("C:\\Users\\USER\\Desktop\\Basarisiz_Deneme.txt");//Konuma git ve dosya var içine gir yoksa oluþtur
                    Yaz1.WriteLine("Basarisiz Deneme");//dosyanýn içine yaz
                    DateTime date = new DateTime();//referans verildi
                    Yaz1.WriteLine(date);//dosyaya date yaz
                    Yaz1.WriteLine("");//Boþluk Býrak
                    Yaz1.Close();//Dosyadan Kapat
                }
                con.Close();//Baðlantýyý Kapat
            }
            catch (Exception hata)//TRY blok hata alýrsa bu blok çalýþýr
            {
                MessageBox.Show("Beklenmedik Bir Hata Tekrar Deneyiniz");//messagebox aç ve ekrana çýktý ver
                StreamWriter Yaz1 = File.AppendText("C:\\Users\\USER\\Desktop\\Hatalar.txt");//dosya konumuna git dosya varsa gir yoksa oluþtur
                Yaz1.WriteLine(hata.Message);//hatayý log ile gir
                DateTime date = new DateTime();//referans verildi
                Yaz1.WriteLine(date);//tarihi yazdýr
                Yaz1.WriteLine("");//boþluk býrak
                Yaz1.Close ();//Dosyayý kapat
            }
    }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
        }
    }
}