using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematiksel_İşlemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double TekSayilarToplam(int Baslangıcsayi, int Bitissayi)
        {
           double tekToplam=0;
       
            for (int i=Baslangıcsayi; i <= Bitissayi; i++)
            {
               if ((i % 2) == 1)
                tekToplam += i;
                
            }
            txtSayilarinToplami.Text = tekToplam.ToString();
            return tekToplam;
            
        }
        private BigInteger TekSayilarCarpim(int Baslangıcsayi, int Bitissayi)
        {
            BigInteger tekCarpim = 1;

            for (int i = Baslangıcsayi; i <= Bitissayi; i++)
            {
                if ((i % 2) == 1) {

                listTekSayilar.Items.Add(i.ToString());
                tekCarpim *= i;
                }
            }

               txtSayilarinCarpimi.Text = tekCarpim.ToString();
            return tekCarpim;      
            }
        private BigInteger armstrongSayilariToplam (int Baslangıcsayi, int Bitissayi)
        {
            int birlerBasamagi, onlarBasamagi, yuzlerBasamagi, binlerBasamagi;
            BigInteger armstrongToplam = 0;
            for(int i = Baslangıcsayi; i <= Bitissayi; i++)
            {
                if (i > 100  && i < 10000)
                {
                    birlerBasamagi = i % 10;
                    onlarBasamagi = ((i - birlerBasamagi) / 10) % 10;
                    yuzlerBasamagi = ((i - (onlarBasamagi * 10) - birlerBasamagi) / 100) % 10;
                    binlerBasamagi = (i - (100 * yuzlerBasamagi) - (10 * onlarBasamagi) - birlerBasamagi) / 1000;
                    if (i == Math.Pow(birlerBasamagi, 4) + Math.Pow(onlarBasamagi, 4) + Math.Pow(yuzlerBasamagi, 4) + Math.Pow(binlerBasamagi, 4))
                    {
                        
                        
                        armstrongToplam += i;
                    }

                }
                if (i > 10 && i < 1000)
                {
                    birlerBasamagi = i % 10;
                    onlarBasamagi = ((i - birlerBasamagi) / 10) % 10;
                    yuzlerBasamagi = ((i - (onlarBasamagi * 10) - birlerBasamagi) / 100) % 10;
                    if (i == Math.Pow(birlerBasamagi, 3) + Math.Pow(onlarBasamagi, 3) + Math.Pow(yuzlerBasamagi, 3) )
                    {
                        
                       
                        armstrongToplam += i;
                    }

                }
                if (i < 10)
                {
                    birlerBasamagi = i;
                    if(i==1){
                       
                        
                        armstrongToplam += i;

                    }
            }
           
        }
            txtSayilarinToplami.Text = armstrongToplam.ToString();
            return armstrongToplam;
        }
        private BigInteger armstrongSayilariCarpim(int Baslangıcsayi, int Bitissayi)
        {
            int birlerBasamagi, onlarBasamagi, yuzlerBasamagi, binlerBasamagi;
            BigInteger armstrongCarpim= 1;
            for (int i = Baslangıcsayi; i <= Bitissayi; i++)
            {
                if (i > 100 &&i < 10000)
                {
                    birlerBasamagi = i % 10;
                    onlarBasamagi = ((i - birlerBasamagi) / 10) % 10;
                    yuzlerBasamagi = ((i - (onlarBasamagi * 10) - birlerBasamagi) / 100) % 10;
                    binlerBasamagi = (i - (100 * yuzlerBasamagi) - (10 * onlarBasamagi) - birlerBasamagi) / 1000;
                    if (i == Math.Pow(birlerBasamagi, 4) + Math.Pow(onlarBasamagi, 4) + Math.Pow(yuzlerBasamagi, 4) + Math.Pow(binlerBasamagi, 4))
                    {
                        listArmstrongSayilar.Items.Add(Convert.ToString(i));

                        armstrongCarpim *= i;
                    }

                }
                if ( i>10   && i < 1000)
                {
                    birlerBasamagi = i % 10;
                    onlarBasamagi = ((i - birlerBasamagi) / 10) % 10;
                    yuzlerBasamagi = ((i - (onlarBasamagi * 10) - birlerBasamagi) / 100) % 10;
                    if (i == Math.Pow(birlerBasamagi, 3) + Math.Pow(onlarBasamagi, 3) + Math.Pow(yuzlerBasamagi, 3))
                    {
                        listArmstrongSayilar.Items.Add(Convert.ToString(i));

                        armstrongCarpim *= i;
                    }

                }
                if (i < 10)
                {
                    birlerBasamagi = i;
                    if (i == 1)
                    {
                        listArmstrongSayilar.Items.Add(Convert.ToString(i));

                        armstrongCarpim *= i;

                    }
                }

            }
            txtSayilarinCarpimi.Text = armstrongCarpim.ToString();
            return armstrongCarpim;
        }

        private double CiftSayilarToplam(int Baslangıcsayi, int Bitissayi)
        {
            double ciftToplam = 0;

            for (int i = Baslangıcsayi; i <= Bitissayi; i++)
            {
                if ((i % 2) == 0)
                    ciftToplam += i;

            }
            txtSayilarinToplami.Text = ciftToplam.ToString();
            return ciftToplam;
        }
        private BigInteger CiftSayilarCarpim(int Baslangıcsayi, int Bitissayi)
        {
            BigInteger ciftCarpim = 1;
            for (int i = Baslangıcsayi; i <= Bitissayi; i++)
            {
                if ((i % 2) == 0)
                {
                    listCiftSayilar.Items.Add(i.ToString());
                    ciftCarpim *= i;
                }
            }
            txtSayilarinCarpimi.Text = System.Convert.ToString(ciftCarpim);
            return ciftCarpim;
        }
        private BigInteger AsalSayilarCarpimi(int Baslangıcsayi, int Bitissayi)
        {
            BigInteger asalSayilarCarpimi = 1;
            for ( int ilkSayi = Baslangıcsayi; ilkSayi <= Bitissayi; ilkSayi++)
            {
                int sayac = 0;
                for(int j= ilkSayi - 1; j > 1; j--)
                {
                    if (ilkSayi % j == 0)
                    {
                        sayac++;

                    }


                }
                
               
                if ( sayac==0)
                {
                    
                    asalSayilarCarpimi *= ilkSayi;
                    listAsalSayilar.Items.Add(ilkSayi.ToString());
                }                
            }
            txtSayilarinCarpimi.Text = asalSayilarCarpimi.ToString();            
            return asalSayilarCarpimi;
        }
        private double AsalSayilarToplami(int Baslangıcsayi, int Bitissayi)
        {
            double asalSayilarToplami = 0;
            for (int ilkSayi = Baslangıcsayi; ilkSayi <= Bitissayi; ilkSayi++)
            {
                
                int sayac = 0;
                for (int j = ilkSayi - 1; j > 1; j--)
                {
                    if (ilkSayi % j == 0)
                    {
                        sayac++;
                    }
                }
                if (sayac == 0)
                {
                    asalSayilarToplami += ilkSayi;                    
                }
            }
            txtSayilarinToplami.Text = asalSayilarToplami.ToString();
            return asalSayilarToplami;
        }       
        private void EkranıHazirla ()
        {
            txtBaslangicSayisi.Text = txtBitisSayisi.Text =  null;
            txtBaslangicSayisi.Focus();
        }       
        private void BtnGeri_Click(object sender, EventArgs e)
        {
            
            if (tabIslemler.SelectedIndex <= 0)
            {
                tabIslemler.SelectedIndex = 3;
            }
            else
                tabIslemler.SelectedIndex--;
            EkranıHazirla();
            txtSayilarinToplami.Text = txtSayilarinCarpimi.Text = null;
        }       
        private void BtnIleri_Click(object sender, EventArgs e)
        {           
            if (tabIslemler.SelectedIndex >= 3)
            {
                tabIslemler.SelectedIndex = 0;
            }
            else
                tabIslemler.SelectedIndex++;
            EkranıHazirla();
           txtSayilarinToplami.Text = txtSayilarinCarpimi.Text = null;
        }      
        private Boolean Dogrula()
        {
            try
            {
               Convert.ToInt32(txtBaslangicSayisi.Text);
                Convert.ToInt32(txtBitisSayisi.Text);
                return true;               
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            if (Dogrula())
            {
                int BaslangicSayisi = Convert.ToInt32(txtBaslangicSayisi.Text);
                int BitisSayisi = Convert.ToInt32(txtBitisSayisi.Text);
                if (tabIslemler.SelectedTab == tabTekSayilar)
                {
                    TekSayilarToplam(BaslangicSayisi, BitisSayisi);
                    TekSayilarCarpim(BaslangicSayisi, BitisSayisi);
                    txtIslemZamani.Text = DateTime.Now.ToString();                   
                    EkranıHazirla();
                    string islemTuru = "Tek Sayılar";
                    DosyayaYazdirma(islemTuru, txtIslemZamani.Text, BaslangicSayisi, BitisSayisi, txtSayilarinToplami.Text, txtSayilarinCarpimi.Text);
                }
                else if (tabIslemler.SelectedTab == tabCiftSayilar)
                {
                    CiftSayilarToplam(BaslangicSayisi, BitisSayisi);
                    CiftSayilarCarpim(BaslangicSayisi, BitisSayisi);
                    txtIslemZamani.Text = DateTime.Now.ToString();                  
                    EkranıHazirla();
                    string islemTuru = "Çift Sayılar";
                    DosyayaYazdirma(islemTuru, txtIslemZamani.Text, BaslangicSayisi, BitisSayisi, txtSayilarinToplami.Text, txtSayilarinCarpimi.Text);
                }
                else if (tabIslemler.SelectedTab == tabAsalSayilar)
                {
                    AsalSayilarToplami(BaslangicSayisi, BitisSayisi);
                    AsalSayilarCarpimi(BaslangicSayisi, BitisSayisi);
                    txtIslemZamani.Text = DateTime.Now.ToString();
                   

                    EkranıHazirla();
                    string islemTuru = "Asal Sayılar";
                    DosyayaYazdirma(islemTuru, txtIslemZamani.Text, BaslangicSayisi, BitisSayisi, txtSayilarinToplami.Text, txtSayilarinCarpimi.Text);
                }
                else if (tabIslemler.SelectedTab == tabArmstrongSayılar)
                {
                    armstrongSayilariToplam(BaslangicSayisi, BitisSayisi);
                    armstrongSayilariCarpim(BaslangicSayisi, BitisSayisi);
                    txtIslemZamani.Text = DateTime.Now.ToString();
                   
                    EkranıHazirla();
                    string islemTuru = "Armstrong Sayılar";
                    DosyayaYazdirma(islemTuru, txtIslemZamani.Text, BaslangicSayisi, BitisSayisi, txtSayilarinToplami.Text, txtSayilarinCarpimi.Text);
                }
            }           
        }
        [Obsolete]
        private void Form1_Load(object sender, EventArgs e)
        {
            bildirimBalonu.BalloonTipText = "Nesne Yönelimli Programlama Ödev1";
            bildirimBalonu.Icon = SystemIcons.Application;
            bildirimBalonu.BalloonTipTitle = "Programa Hoşgeldiniz!";
            bildirimBalonu.Text = "başladı";
            bildirimBalonu.ShowBalloonTip(3000);


            String seciliTabAyari;
            seciliTabAyari = System.Configuration.ConfigurationSettings.AppSettings["işlem_tipi"];
            if (seciliTabAyari.Equals("ARMSTRONG"))
            {
                tabIslemler.SelectedIndex = 3;
            }
            else if (seciliTabAyari.Equals( "ASAL"))
            {
                tabIslemler.SelectedIndex = 2;
            }
            else if (seciliTabAyari.Equals ("ÇİFT"))
            {
                tabIslemler.SelectedIndex = 1;
            }
            else if(seciliTabAyari.Equals( "TEK"))
            {
                tabIslemler.SelectedIndex = 0;
            }
        }
    
        private void DosyayaYazdirma(string islemTuru, string islemZamani, int baslangicDegeri, int bitisDegeri,string sayilarinToplami, string sayilarinCarpimi)
        {
            using(StreamWriter  yaz = new StreamWriter("deneme.txt", true))
            {
                yaz.WriteLine("***********************************");
                 DateTime simdi = DateTime.Now;
                yaz.WriteLine( "İşlem Türü: " + islemTuru );
                yaz.WriteLine("İşlem Zamanı:" + islemZamani);
                yaz.WriteLine("Başlangıç değeri:" + baslangicDegeri);
                yaz.WriteLine("Bitiş değeri:" + bitisDegeri);
                yaz.WriteLine("Sayıların Toplamı:" + sayilarinToplami);
                yaz.WriteLine("Sayıların Çarpımı:" + sayilarinCarpimi);
                yaz.WriteLine("***********************************");
            }




        }
        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            this.Activate();
        }
    }
   
}