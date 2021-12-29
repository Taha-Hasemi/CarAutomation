using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OtogaleriOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source=" + Application.StartupPath + "\\otogaleri.accdb");
        private void l_arama_Click(object sender, EventArgs e)
        {

        }

        private void t_arama_Click(object sender, EventArgs e)
        {
            if (t_arama.Focused)
            {
                t_arama.BackColor = Color.White;                
            }
            if (t_fiyat.Focused)
            {
                t_fiyat.BackColor = Color.White;
            }
            if (t_kilometre.Focused)
            {
                t_kilometre.BackColor = Color.White;
            }
            if (t_ruhsat_no.Focused)
            {
                t_ruhsat_no.BackColor = Color.White;
            }
            if (c_kasa_tipi.Focused)
            {
                c_kasa_tipi.BackColor = Color.White;
            }
            if (c_marka.Focused)
            {
                c_marka.BackColor = Color.White;
            }
            if (c_yakit_tipi.Focused)
            {
                c_yakit_tipi.BackColor = Color.White;
            }
            if (c_model.Focused)
            {
                c_model.BackColor = Color.White;
            }
        }

        private void t_arama_Leave(object sender, EventArgs e)
        {
            t_arama.BackColor = SystemColors.ButtonShadow;
            t_fiyat.BackColor = SystemColors.ButtonShadow;
            t_kilometre.BackColor = SystemColors.ButtonShadow;
            t_ruhsat_no.BackColor = SystemColors.ButtonShadow;
            c_kasa_tipi.BackColor = SystemColors.ButtonShadow;
            c_marka.BackColor = SystemColors.ButtonShadow;
            c_yakit_tipi.BackColor = SystemColors.ButtonShadow;
            c_model.BackColor = SystemColors.ButtonShadow;

        }

        private void ekle_butonu_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbDataAdapter ekle_komutu = new OleDbDataAdapter("insert into otomobil (ruhsatno,marka,model,yakit,kasatipi,km,fiyat) values ('" + t_ruhsat_no.Text + "','" + c_marka.SelectedItem.ToString() + "','" + c_model.SelectedItem.ToString() + "','" + c_yakit_tipi.SelectedItem.ToString() + "','" + c_kasa_tipi.SelectedItem.ToString() + "','" + t_kilometre.Text + "','" + t_fiyat.Text + "')", baglanti);
                DataSet sdhafiza = new DataSet();
                ekle_komutu.Fill(sdhafiza);
                baglanti.Close();
                MessageBox.Show("Araç başarı ile kaydedildi...", "Veri tabanı işlemleri");
                t_ruhsat_no.Clear();
                t_kilometre.Clear();
                t_fiyat.Clear();
                kayitlarilistele();
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Veri tabanı işlemleri");
                baglanti.Close();
            }
        }

        private void c_marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            c_model.Items.Clear();
            string marka = c_marka.SelectedItem.ToString();
            if (marka=="Toyota")
            {
                string[] model = { "Auris", "Yaris", "Corolla" };
                c_model.Items.AddRange(model);
            }
            if (marka == "Honda")
            {
                string[] model = { "Civic", "Accord"};
                c_model.Items.AddRange(model);
            }
            if (marka == "Opel")
            {
                string[] model = { "Astra", "Vectra", "Corsa" };
                c_model.Items.AddRange(model);
            }
        }
        private void kayitlarilistele()
        {
            try
            {
                baglanti.Open();
                OleDbDataAdapter listele = new OleDbDataAdapter("select ruhsatno,marka,model,yakit,kasatipi,km,fiyat from otomobil", baglanti);
                DataSet dshafiza = new DataSet();
                listele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                baglanti.Close();
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Veri Tabanı İşlemleri");
                baglanti.Close();
            }
        }
        private void kayitlarilistele(string a)
        {
            try
            {
                baglanti.Open();
                OleDbDataAdapter listele = new OleDbDataAdapter("select ruhsatno,marka,model,yakit,kasatipi,km,fiyat from otomobil where ruhsatno like '%"+a+ "%' or marka like '%" + a + "%' or model like '%" + a + "%' order by marka asc", baglanti);
                DataSet dshafiza = new DataSet();
                listele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                baglanti.Close();
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Veri Tabanı İşlemleri");
                baglanti.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kayitlarilistele();
        }

        private void ara_Click(object sender, EventArgs e)
        {
            kayitlarilistele(t_arama.Text);
        }

        private void sil_butonu_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbDataAdapter sil_komutu = new OleDbDataAdapter("delete from otomobil where ruhsatno='"+t_ruhsat_no.Text+"'", baglanti);
                DataSet sdhafiza = new DataSet();
                sil_komutu.Fill(sdhafiza);
                baglanti.Close();
                MessageBox.Show("Araç başarı ile silindi...", "Veri tabanı işlemleri");
                kayitlarilistele();
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Veri tabanı işlemleri");
                baglanti.Close();
            }
        }

        private void fiyat_guncelle_butonu_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbDataAdapter guncelle_komutu = new OleDbDataAdapter("update otomobil set fiyat='"+t_fiyat+"' where ruhsatno='"+t_ruhsat_no+"'", baglanti);
                DataSet sdhafiza = new DataSet();
                guncelle_komutu.Fill(sdhafiza);
                baglanti.Close();
                MessageBox.Show("Araç başarı ile güncellendi...", "Veri tabanı işlemleri");
                t_ruhsat_no.Clear();
                t_kilometre.Clear();
                t_fiyat.Clear();
                kayitlarilistele();
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Veri tabanı işlemleri");
                baglanti.Close();
            }
        }
    }
}
