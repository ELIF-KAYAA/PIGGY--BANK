using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace kumbara1
{
    public partial class Form2 : Form
    {
        private Kumbara kumbara;

        public Form2()
        {
            InitializeComponent();
            kumbara = new Kumbara(1000); // Kumbara nesnesini oluştur
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            grpKumbaraBilgileri.Text = "Kumbara Bilgileri";
            btnKumbaraKır.Text = "Kumbara Kır";
            btnShake.Text = "Kumbarayı Salla";

            // ComboBox'a para türlerini ekleme
            cmbParaSec.Items.Add("5 TL");
            cmbParaSec.Items.Add("10 TL");
            cmbParaSec.Items.Add("1 Kuruş");
            cmbParaSec.Items.Add("5 Kuruş");
            cmbParaSec.Items.Add("10 Kuruş");

            // Varsayılan olarak ilk seçeneği seçili yap
            cmbParaSec.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // "Para Ekle" butonuna tıklanıldığında çalışacak kod
            string paraIsmi = cmbParaSec.SelectedItem.ToString();
            double paraDegeri = 0;

            // Para değerini seçime göre belirle
            switch (paraIsmi)
            {
                case "5 TL":
                    paraDegeri = 5;
                    break;
                case "10 TL":
                    paraDegeri = 10;
                    break;
                case "1 Kuruş":
                    paraDegeri = 0.01;
                    break;
                case "5 Kuruş":
                    paraDegeri = 0.05;
                    break;
                case "10 Kuruş":
                    paraDegeri = 0.1;
                    break;
                default:
                    lblHataMesajı.Text = "Geçersiz para seçimi.";
                    return;
            }

            try
            {
                // Yeni KağıtPara veya BozukPara nesnesi oluştur ve kumbaraya ekle
                if (paraIsmi.Contains("TL"))
                {
                    var yeniPara = new KağıtPara(paraIsmi, paraDegeri, 0, 0, 0);
                    kumbara.ParaAt(yeniPara);
                }
                else
                {
                    var yeniPara = new BozukPara(paraIsmi, paraDegeri, 0, 0);
                    kumbara.ParaAt(yeniPara);
                }

                lstParalar.Items.Add($"{paraIsmi} - {paraDegeri:C}");
                lblHataMesajı.Text = ""; // Temizle
            }
            catch (Exception ex)
            {
                lblHataMesajı.Text = $"Hata: {ex.Message}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // "Kumbara Kır" butonuna tıklanıldığında çalışacak kod
            var paralar = kumbara.Break();
            lstParalar.Items.Clear();
            foreach (var para in paralar)
            {
                lstParalar.Items.Add($"{para.İsim} - {para.Değer:C}");
            }
            lblHataMesajı.Text = "Kumbara kırıldı ve paralar alındı.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // "Kumbarayı Sallama" butonuna tıklanıldığında çalışacak kod
            kumbara.Shake();
            lblHataMesajı.Text = "Kumbara sallandı.";
        }

        private void txtKumbaraHacmi_TextChanged(object sender, EventArgs e)
        {
            // Eğer Kumbara'nın mevcut hacmini TextBox ile göstermek istiyorsan buraya kod ekleyebilirsin
        }
    }
}
