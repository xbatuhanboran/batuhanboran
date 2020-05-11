using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Data.OleDb;
using HtmlAgilityPack;

namespace BirkelimeBirişlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random Rastgele = new Random();
        int harfsayac = 0;
        int sayisayac = 0;
        private void btnHarfGetir_Click(object sender, EventArgs e)
        {
            harfsayac++;
            string ch1, ch2, ch3, ch4, ch5, ch6, ch7, ch8;
            int harfler;
            string[] dizi = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "V", "U", "Ü", "Y", "Z" };

            if (harfsayac == 1)
            {
                harfler = Rastgele.Next(0, dizi.Length);
                ch1 = (dizi[harfler]);
                btnHarf1.Text = ch1.ToString();
                btnHarf1.Visible = true;
            }
            if (harfsayac == 2)
            {
                harfler = Rastgele.Next(0, dizi.Length);
                ch2 = (dizi[harfler]);
                btnHarf2.Text = ch2.ToString();
                btnHarf2.Visible = true;
            }
            if (harfsayac == 3)
            {
                harfler = Rastgele.Next(0, dizi.Length);
                ch3 = (dizi[harfler]);
                btnHarf3.Text = ch3.ToString();
                btnHarf3.Visible = true;
            }
            if (harfsayac == 4)
            {
                harfler = Rastgele.Next(0, dizi.Length);
                ch4 = (dizi[harfler]);
                btnHarf4.Text = ch4.ToString();
                btnHarf4.Visible = true;
            }
            if (harfsayac == 5)
            {
                harfler = Rastgele.Next(0, dizi.Length);
                ch5 = (dizi[harfler]);
                btnHarf5.Text = ch5.ToString();
                btnHarf5.Visible = true;
            }
            if (harfsayac == 6)
            {
                harfler = Rastgele.Next(0, dizi.Length);
                ch6 = (dizi[harfler]);
                btnHarf6.Text = ch6.ToString();
                btnHarf6.Visible = true;
            }
            if (harfsayac == 7)
            {
                harfler = Rastgele.Next(0, dizi.Length);
                ch7 = (dizi[harfler]);
                btnHarf7.Text = ch7.ToString();
                btnHarf7.Visible = true;
            }
            if (harfsayac == 8)
            {
                harfler = Rastgele.Next(0, dizi.Length);
                ch8 = (dizi[harfler]);
                btnHarf8.Text = ch8.ToString();
                btnHarf8.Visible = true;
                btnHarfj.Visible = true;
                btnHarfGetir.Visible = false;
                button1.Visible = true;
                textBox1.Visible = true;
                textBox1.Enabled = false;

            }
        }


        private void btnSayiGetir_Click(object sender, EventArgs e)
        {
            sayisayac++;
            string sayi1, sayi2, sayi3, sayi4, sayi5, sayi6;
            int hedef;
            string[] dizi2 = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] dizi3 = { "10", "20", "30", "40", "50", "60", "70", "80", "90" };
            int sayilar;
            int[] işlemsayıları = new int[7];
            if (sayisayac == 1)
            {
                sayilar = Rastgele.Next(0, dizi2.Length);
                sayi1 = (dizi2[sayilar]);
                btnSayi1.Text = sayi1.ToString();
                btnSayi1.Visible = true;
                işlemsayıları[0] = Convert.ToInt32(sayi1);
            }
            if (sayisayac == 2)
            {
                sayilar = Rastgele.Next(0, dizi2.Length);
                sayi2 = (dizi2[sayilar]);
                btnSayi2.Text = sayi2.ToString();
                btnSayi2.Visible = true;
                işlemsayıları[1] = Convert.ToInt32(sayi2);
            }
            if (sayisayac == 3)
            {
                sayilar = Rastgele.Next(0, dizi2.Length);
                sayi3 = (dizi2[sayilar]);
                btnSayi3.Text = sayi3.ToString();
                btnSayi3.Visible = true;
                işlemsayıları[2] = Convert.ToInt32(sayi3);
            }
            if (sayisayac == 4)
            {
                sayilar = Rastgele.Next(0, dizi2.Length);
                sayi4 = (dizi2[sayilar]);
                btnSayi4.Text = sayi4.ToString();
                btnSayi4.Visible = true;
                işlemsayıları[3] = Convert.ToInt32(sayi4);
            }
            if (sayisayac == 5)
            {
                sayilar = Rastgele.Next(0, dizi2.Length);
                sayi5 = (dizi2[sayilar]);
                btnSayi5.Text = sayi5.ToString();
                btnSayi5.Visible = true;
                işlemsayıları[4] = Convert.ToInt32(sayi5);
            }
            if (sayisayac == 6)
            {
                sayilar = Rastgele.Next(0, dizi3.Length);
                sayi6 = (dizi3[sayilar]);
                btnSayi10k.Text = sayi6.ToString();
                btnSayi10k.Visible = true;
                işlemsayıları[5] = Convert.ToInt32(sayi6);
                hedef = Rastgele.Next(100, 999);
                işlemsayıları[6] = Convert.ToInt32(hedef);
                btnEsit.Visible = true;
                btnSayiHedef.Text = hedef.ToString();
                btnSayiHedef.Visible = true;
                btnSayiGetir.Visible = false;
                button2.Visible = true;
                textBox2.Visible = true;
                textBox2.Enabled = false;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;
                radioButton8.Visible = true;
                radioButton9.Visible = true;
                radioButton10.Visible = true;
                radioButton11.Visible = true;
                label4.Visible = true;
                button3.Visible = true;
                label5.Text ="Hedef Sayı : " + btnSayiHedef.Text;

            }
            





        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            
            this.Height = 272;
            this.Width = 570;
            harfsayac = 0;
            sayisayac = 0;
            btnHarf1.Visible = false;
            btnHarf2.Visible = false;
            btnHarf3.Visible = false;
            btnHarf4.Visible = false;
            btnHarf5.Visible = false;
            btnHarf6.Visible = false;
            btnHarf7.Visible = false;
            btnHarf8.Visible = false;
            btnHarfj.Visible = false;
            btnSayi1.Visible = false;
            btnSayi2.Visible = false;
            btnSayi3.Visible = false;
            btnSayi4.Visible = false;
            btnSayi5.Visible = false;
            btnEsit.Visible = false;
            btnSayi10k.Visible = false;
            btnSayiHedef.Visible = false;
            button1.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button2.Enabled = true;
            textBox1.Text = "";
            textBox1.Enabled = true;
            textBox1.Visible = false;
            button1.Visible = false;
            label1.Text = "";
            label1.Visible = false;
            btnSayiGetir.Visible = true;
            textBox2.Text = "";
            textBox2.Enabled = true;
            textBox2.Visible = false;
            button2.Visible = false;
            label2.Text = "";
            label2.Visible = false;
            btnSayiGetir.Visible = true;
            btnHarfGetir.Visible = true;
            temppuan = 0;
            temppuans = 0;
            textBox3.Enabled = true;
            label3.Enabled = true;
            btnEkle.Enabled = true;
            label3.Text = "";
            textBox3.Text="";
            btnHarf8.Enabled = true;
            btnHarf7.Enabled = true;
            btnHarf6.Enabled = true;
            btnHarf5.Enabled = true;
            btnHarf4.Enabled = true;
            btnHarf3.Enabled = true;
            btnHarf2.Enabled = true;
            btnHarf1.Enabled = true;
            textBox1.Enabled = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            label4.Visible = false;
            btnSayiGetir.Visible = false;
            button3.Visible = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {


            DialogResult secenek = MessageBox.Show("Bir Kelime\nSize verilen 8 rastgele harf ve bir adet joker harf ile en uzun kelimeyi oluşturmaya çalışacaksınız.\n\n-3 Harf = 3 puan\n-4 Harf = 4 puan\n-5 Harf = 5 puan\n-6 Harf = 7 puan\n-7 Harf = 9 puan\n-8 Harf = 11 puan\n-9 Harf = 15 puan ", "Yardım", MessageBoxButtons.OK, MessageBoxIcon.Question);

            if (secenek == DialogResult.OK)
            {
                MessageBox.Show("Bir İşlem\n\nSize verilen 5 rastgele rakam ve bir çift basamaklı sayı ile hedeflenen 3 basamaklı sayıya ulaşmayı/en yakın sonucu bulmaya çalışacaksınız.\n\nSayı farkı en az +/-9 olabilir.\n", "Yardım", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }

        }
        int temppuan;
        private void button1_Click(object sender, EventArgs e)
        {
            string cevap;
            int uzunluk;
            cevap = textBox1.Text;
            uzunluk = cevap.Length;
            btnSayiGetir.Visible = true;


            this.Height = 500;
            

            StreamReader SW = new StreamReader(Application.StartupPath + "\\kelimeler.txt", Encoding.GetEncoding("windows-1254"));
            string satır;
            int sayac = 0;
            while ((satır = SW.ReadLine()) != null)
            {
                if(satır==cevap)
                {
                    sayac = 1;
                    
                        
                        break;   
                }
                 if(satır!=cevap)
                {
                    sayac = 2;
                    label1.Text = "Eksik/Fazla Harf yada Yanlış Kelime Girildi.";
                    temppuan = 0;
                }
            }

                
            if (sayac == 1)
            {
                if (uzunluk < 3)
                {
                    label1.Text = "Yetersiz Harf.";
                    temppuan = 0;
                }
                if (uzunluk > 9)
                {
                    label1.Text = "Fazla Harf.";
                    temppuan = 0;
                }
                if (uzunluk == 3)
                {
                    label1.Text = uzunluk + "Harf.   Puan = 3";
                    temppuan = 3;
                }
                if (uzunluk == 4)
                {
                    label1.Text = uzunluk + "Harf.   Puan = 4";
                    temppuan = 4;
                }
                if (uzunluk == 5)
                {
                    label1.Text = uzunluk + "Harf.   Puan = 5";
                    temppuan = 5;
                }
                if (uzunluk == 6)
                {
                    label1.Text = uzunluk + "Harf.   Puan = 7";
                    temppuan = 6;
                }
                if (uzunluk == 7)
                {
                    label1.Text = uzunluk + "Harf.   Puan = 9";
                    temppuan = 9;
                }
                if (uzunluk == 8)
                {
                    label1.Text = uzunluk + "Harf.   Puan = 11";
                    temppuan = 11;
                }
                if (uzunluk == 9)
                {
                    label1.Text = uzunluk + "Harf.   Puan = 15";
                    temppuan = 15;
                }
                if (uzunluk >= 10)
                {
                    label1.Text = "Fazla Harf Girildi.";
                    temppuan = 0;
                }

            }

            textBox1.Enabled = false;
            button1.Enabled = false;
            label1.Visible = true;
            
            






        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 272;
            this.Width = 570;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        int temppuans;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            button2.Enabled = false;
            label3.Visible = true;
            textBox3.Visible = true;
            int toppuan;
            toppuan = temppuan + temppuans;
            label3.Text = toppuan.ToString();
            toppuan = 0;

            this.Height = 562;

            if (radioButton1.Enabled==true)
            {
                
            }

        }




        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\antuan\\Desktop\\BkBidatabase.mdb");

        private void puanEkle()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into puan(ad,puan) values('"+ textBox3.Text.ToString()+"','"+ Convert.ToInt32(label3.Text)+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
       
        private void btnPuanTablosu_Click(object sender, EventArgs e)
        {
            Form2 puanform= new Form2();
            puanform.ShowDialog();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            puanEkle();
            label3.Enabled = false;
            textBox3.Enabled = false;
            btnEkle.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
       
        }

        private void btnHarf1_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnHarf1.Text.ToLower();
            btnHarf1.Enabled = false;
        }

        private void btnHarf2_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnHarf2.Text.ToLower();
            btnHarf2.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled=true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)==false)
            {
                e.Handled = true;
            }
        }

        private void btnHarf3_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnHarf3.Text.ToLower();
            btnHarf3.Enabled = false;
        }

        private void btnHarf4_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnHarf4.Text.ToLower();
            btnHarf4.Enabled = false;
        }

        private void btnHarf5_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnHarf5.Text.ToLower();
            btnHarf5.Enabled = false;
        }

        private void btnHarf6_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnHarf6.Text.ToLower();
            btnHarf6.Enabled = false;
        }

        private void btnHarf7_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnHarf7.Text.ToLower();
            btnHarf7.Enabled = false;
        }

        private void btnHarf8_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnHarf8.Text.ToLower();
            btnHarf8.Enabled = false;
        }

        private void btnHarfj_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            btnHarf8.Enabled = true;
            btnHarf7.Enabled = true;
            btnHarf6.Enabled = true;
            btnHarf5.Enabled = true;
            btnHarf4.Enabled = true;
            btnHarf3.Enabled = true;
            btnHarf2.Enabled = true;
            btnHarf1.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }
        
        private void button3_Click_2(object sender, EventArgs e)
        {
                this.Width = 893;
            button3.Visible = false;
            button4.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Width = 572;
            button4.Visible = false;
            button3.Visible = true;
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            int a, b,c=0;
            
            a = Convert.ToInt32(textBoxtahta1.Text);
            b = Convert.ToInt32(textBoxtahta2.Text);
            if (radiotopla.Enabled==true)
            {   
                c+=a+b;
                label6.Text = c.ToString();
            }
            if (radioçıkar.Enabled == true)
            {
                c += a - b;
                label6.Text = c.ToString();
            }
            if (radioçarp.Enabled == true)
            {
                c += a * b;
                label6.Text = c.ToString();
            }
            if (radioböl.Enabled == true)
            {
                c += a / b;
                label6.Text = c.ToString();
            }
        }
    }
}
