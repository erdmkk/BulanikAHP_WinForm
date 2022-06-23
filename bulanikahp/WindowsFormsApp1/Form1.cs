using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=SEYFI;Initial Catalog=Bulanik_Ahp;Integrated Security=True");
        clssBulanikAhp clssBulanikAhp = new clssBulanikAhp();
        SqlCommand komut;
        double kAgirlik1, kAgirlik2, kAgirlik3;
        double altkAgirlik1, altkAgirlik2, altkAgirlik3, altkAgirlik4;
        double anaAltBaglanti1, anaAltBaglanti2, anaAltBaglanti3, anaAltBaglanti4;
        double altAlterBaglanti1, altAlterBaglanti2, altAlterBaglanti3, altAlterBaglanti4, altAlterBaglanti5;
        double sonuc;
        bool durum;
        public Form1()
        {            
            InitializeComponent();
        }

         void verilerimigöster(string veriler)
        {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(veriler, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connection.Close();

        }
        
        void kontrol()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * From adayPersonel Where telefon=@telefon", connection);
            komut.Parameters.AddWithValue("@telefon", textBox44.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if(dr.Read())
            {
                durum = false;
                MessageBox.Show("Girilen Telefon Numarası Aynı Olamaz.","Hata!");
            }
            else
            {
                durum = true;
                tabControl1.SelectedIndex = 1;
            }
            connection.Close();

   

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'bulanik_AhpDataSet1.adayPersonel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adayPersonelTableAdapter2.Fill(this.bulanik_AhpDataSet1.adayPersonel);
            // TODO: Bu kod satırı 'bulanik_AhpDataSet.adayPersonel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adayPersonelTableAdapter1.Fill(this.bulanik_AhpDataSet.adayPersonel);
            verilerimigöster("Select * From adayPersonel Order By sonuc DESC");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true; 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        /////// Ekle Butonu
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (textBox44.Text == "")
            {

                MessageBox.Show("Telefon numarası boş geçilemez");

                return;

            }
            else {
                kontrol();
                
            }
            

        }


        ////////////////////////////// BİRİNCİ KAYDET BUTONU //////////////////////////////

        private void button10_Click(object sender, EventArgs e)
        {

            double c1x2 = 1;
            double c1x3 = 1;
            double c2x1 = 1;            
            double c2x3 = 1;
            double c3x1 = 1;
            double c3x2 = 1;

            if (comboBox60.SelectedItem != null)
            {
                c2x1 = Convert.ToDouble(comboBox60.Text);
                c1x2 = 1 / Convert.ToDouble(comboBox60.Text);
            }
            if (comboBox62.SelectedItem != null)
            {
                c1x2 = Convert.ToDouble(comboBox62.Text);
                c2x1 = 1 / Convert.ToDouble(comboBox62.Text);
            }
            if (comboBox61.SelectedItem != null)
            {
                c1x3 = Convert.ToDouble(comboBox61.Text);
                c3x1 = 1 / Convert.ToDouble(comboBox61.Text);
            }
            if (comboBox59.SelectedItem != null)
            {
                c3x1 = Convert.ToDouble(comboBox59.Text);
                c1x3 = 1 / Convert.ToDouble(comboBox59.Text);
            }
            if (comboBox57.SelectedItem != null)
            {
                c2x3 = Convert.ToDouble(comboBox57.Text);
                c3x2 = 1 / Convert.ToDouble(comboBox57.Text);
            }
            if (comboBox58.SelectedItem != null)
            {
                c3x2 = Convert.ToDouble(comboBox58.Text);
                c2x3 = 1 / Convert.ToDouble(comboBox58.Text);
            }


            double ana1x1, ana1x2, ana1x3, ana2x1, ana2x2, ana2x3, ana3x1, ana3x2, ana3x3;


            ana1x1 = 1 / (1 + c2x1 + c3x1);
            ana1x2 = c1x2 / (1 + c1x2 + c3x2);
            ana1x3 = c1x3 / (1 + c2x3 + c1x3);
            ana2x1 = c2x1 / (1 + c2x1 + c3x1);
            ana2x2 = 1 / (1 + c1x2 + c3x2);
            ana2x3 = c2x3 / (1 + c2x3 + c1x3);
            ana3x1 = c3x1 / (1 + c2x1 + c3x1);
            ana3x2 = c3x2 / (1 + c1x2 + c3x2);
            ana3x3 = 1 / (1 + c2x3 + c1x3);

            //Ana Kriter Ağırlığı hesaplama:
            
            kAgirlik1 = (ana1x1 + ana1x2 + ana1x3) / 3; //Temel Yetkinlik
            kAgirlik2 = (ana2x1 + ana2x2 + ana2x3) / 3; //Yönetsel Yetkinlik
            kAgirlik3 = (ana3x1 + ana3x2 + ana3x3) / 3; //Fonksiyonel Yetkinlik Ağırlıkları

            //Ana Kriterler İçin Tutarlılık hesabı
            double tut1x1 = kAgirlik1 * 1;
            double tut1x2 = kAgirlik2 * c1x2;
            double tut1x3 = kAgirlik3 * c1x3;
            double tut2x1 = kAgirlik1 * c2x1;
            double tut2x2 = kAgirlik2 * 1;
            double tut2x3 = kAgirlik3 * c2x3;
            double tut3x1 = kAgirlik1 * c3x1;
            double tut3x2 = kAgirlik2 * c3x2;
            double tut3x3 = kAgirlik3 * 1;
            //Tutarlılık toplamı:
            double ttop1 = (tut1x1 + tut1x2 + tut1x3);
            double ttop2 = (tut2x1 + tut2x2 + tut2x3);
            double ttop3 = (tut3x1 + tut3x2 + tut3x3);
            
        
            //tutarlılık toplamı/kriter ağırlığı:
            double tc1 = ttop1 / kAgirlik1;
            double tc2 = ttop2 / kAgirlik2;
            double tc3 = ttop3 / kAgirlik3;
            double tcort = (tc1 + tc2 + tc3) / 3; //Lambda max. Değerimiz.
            
            double tindex = (tcort - 3) / 2; //Consistency index (ci)

            double tutarlilik = tindex /(0.5) ; //Tutarlılık=CI/RI (RI=0.525)
            
            if (tutarlilik > 0.10)
            {
                MessageBox.Show("Girilen Değerler Tutarsızdır!", "Tekrar Dene");
               
            }

            else {
                tabControl1.SelectedIndex = 2; }

        }

        private void comboBox57_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox58.Enabled = false;
        }
        private void comboBox58_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox57.Enabled = false;
        }
        private void comboBox59_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox61.Enabled = false;
        }
        public void comboBox60_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox62.Enabled = false;
        }
        private void comboBox61_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox59.Enabled = false;
        }
        public void comboBox62_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox60.Enabled = false;
        }

        ////// BİRİNCİ YENİLE BUTONU //////
        private void button11_Click(object sender, EventArgs e)
        {
            comboBox57.SelectedIndex = -1;
            comboBox58.SelectedIndex = -1;
            comboBox59.SelectedIndex = -1;
            comboBox60.SelectedIndex = -1;
            comboBox61.SelectedIndex = -1;
            comboBox62.SelectedIndex = -1;
            comboBox57.Enabled = true;
            comboBox58.Enabled = true;
            comboBox59.Enabled = true;
            comboBox60.Enabled = true;
            comboBox61.Enabled = true;
            comboBox62.Enabled = true;

        }

        ////////////////////////////// İKİNCİ KAYDET BUTONU //////////////////////////////
        
        private void button6_Click(object sender, EventArgs e)
        {
            double a1x2 = 1;
            double a1x3 = 1;
            double a1x4 = 1;
            double a2x1 = 1;
            double a2x3 = 1;
            double a2x4 = 1;
            double a3x1 = 1;
            double a3x2 = 1;
            double a3x4 = 1;
            double a4x1 = 1;
            double a4x2 = 1;
            double a4x3 = 1;

            if (comboBox26.SelectedItem != null)
            {
                a1x2 = Convert.ToDouble(comboBox26.Text);
                a2x1 = 1 / Convert.ToDouble(comboBox26.Text);
            }
            if (comboBox21.SelectedItem != null)
            {
                a2x1 = Convert.ToDouble(comboBox21.Text);
                a1x2 = 1 / Convert.ToDouble(comboBox21.Text);
            }
            if (comboBox25.SelectedItem != null)
            {
                a1x3 = Convert.ToDouble(comboBox25.Text);
                a3x1 = 1 / Convert.ToDouble(comboBox25.Text);
            }
            if (comboBox19.SelectedItem != null)
            {
                a3x1 = Convert.ToDouble(comboBox19.Text);
                a1x3 = 1 / Convert.ToDouble(comboBox19.Text);
            }
            if (comboBox24.SelectedItem != null)
            {
                a1x4 = Convert.ToDouble(comboBox24.Text);
                a4x1 = 1 / Convert.ToDouble(comboBox24.Text);
            }
            if (comboBox20.SelectedItem != null)
            {
                a4x1 = Convert.ToDouble(comboBox20.Text);
                a1x4 = 1 / Convert.ToDouble(comboBox20.Text);
            }
            if (comboBox10.SelectedItem != null)
            {
                a2x3 = Convert.ToDouble(comboBox10.Text);
                a3x2 = 1 / Convert.ToDouble(comboBox10.Text);
            }
            if (comboBox11.SelectedItem != null)
            {
                a3x2 = Convert.ToDouble(comboBox11.Text);
                a2x3 = 1 / Convert.ToDouble(comboBox11.Text);
            }
            if (comboBox9.SelectedItem != null)
            {
                a2x4 = Convert.ToDouble(comboBox9.Text);
                a4x2 = 1 / Convert.ToDouble(comboBox9.Text);
            }
            if (comboBox2.SelectedItem != null)
            {
                a4x2 = Convert.ToDouble(comboBox2.Text);
                a2x4 = 1 / Convert.ToDouble(comboBox2.Text);
            }
            if (comboBox7.SelectedItem != null)
            {
                a3x4 = Convert.ToDouble(comboBox7.Text);
                a4x3 = 1 / Convert.ToDouble(comboBox7.Text);
            }
            if (comboBox3.SelectedItem != null)
            {
                a4x3 = Convert.ToDouble(comboBox3.Text);
                a3x4 = 1 / Convert.ToDouble(comboBox3.Text);
            }

            double alt1x1, alt1x2, alt1x3, alt1x4, alt2x1, alt2x2, alt2x3, alt2x4, alt3x1, alt3x2, alt3x3, alt3x4, alt4x1, alt4x2, alt4x3, alt4x4;

            alt1x1 = 1 / (1 + a2x1 + a3x1 +a4x1); 
            alt1x2 = a1x2 / (a1x2 + 1 + a3x2 + a4x2); 
            alt1x3 = a1x3 / (a1x3 + a2x3 + 1 + a4x3);
            alt1x4 = a1x4 / (a1x4 + a2x4 + a3x4 + 1);
            alt2x1 = a2x1 / (1 + a2x1 + a3x1 + a4x1); 
            alt2x2 = 1 / (a1x2 + 1 + a3x2 + a4x2);
            alt2x3 = a2x3 / (a1x3 + a2x3 + 1 + a4x3); 
            alt2x4 = a2x4 / (a1x4 + a2x4 + a3x4 + 1);
            alt3x1 = a3x1 / (1 + a2x1 + a3x1 + a4x1);
            alt3x2 = a3x2 / (a1x2 + 1 + a3x2 + a4x2);
            alt3x3 = 1 / (a1x3 + a2x3 + 1 + a4x3);
            alt3x4 = a3x4 / (a1x4 + a2x4 + a3x4 + 1);
            alt4x1 = a4x1 / (1 + a2x1 + a3x1 + a4x1);
            alt4x2 = a4x2 / (a1x2 + 1 + a3x2 + a4x2);
            alt4x3 = a4x3 / (a1x3 + a2x3 + 1 + a4x3);
            alt4x4 = 1 / (a1x4 + a2x4 + a3x4 + 1);

            //Alt Kriterlerin Ağırlığını hesaplama:
            altkAgirlik1 = (alt1x1 + alt1x2 + alt1x3 + alt1x4) / 4;
            altkAgirlik2 = (alt2x1 + alt2x2 + alt2x3 + alt2x4) / 4;
            altkAgirlik3 = (alt3x1 + alt3x2 + alt3x3 + alt3x4) / 4;
            altkAgirlik4 = (alt4x1 + alt4x2 + alt4x3 + alt4x4) / 4;

            //Alt Kriterler İçin Tutarlılık hesabı:
            double alttut1x1 = altkAgirlik1 * 1;
            double alttut1x2 = altkAgirlik2 * a1x2;
            double alttut1x3 = altkAgirlik3 * a1x3;
            double alttut1x4 = altkAgirlik4 * a1x4;
            double alttut2x1 = altkAgirlik1 * a2x1;
            double alttut2x2 = altkAgirlik2 * 1;
            double alttut2x3 = altkAgirlik3 * a2x3;
            double alttut2x4 = altkAgirlik4 * a2x4;
            double alttut3x1 = altkAgirlik1 * a3x1;
            double alttut3x2 = altkAgirlik2 * a3x2;
            double alttut3x3 = altkAgirlik3 * 1;
            double alttut3x4 = altkAgirlik4 * a3x4;
            double alttut4x1 = altkAgirlik1 * a4x1;
            double alttut4x2 = altkAgirlik2 * a4x2;
            double alttut4x3 = altkAgirlik3 * a4x3;
            double alttut4x4 = altkAgirlik4 * 1;
            //Tutarlılık Toplamı:
            double altTtop1 = (alttut1x1 + alttut1x2 + alttut1x3 + alttut1x4);
            double altTtop2 = (alttut2x1 + alttut2x2 + alttut2x3 + alttut2x4);
            double altTtop3 = (alttut3x1 + alttut3x2 + alttut3x3 + alttut3x4);
            double altTtop4 = (alttut4x1 + alttut4x2 + alttut4x3 + alttut4x4);

            //tutarlılık toplamı/kriter ağırlığı:
            double alttc1 = altTtop1 / altkAgirlik1;
            double alttc2 = altTtop2 / altkAgirlik2;
            double alttc3 = altTtop3 / altkAgirlik3;
            double alttc4 = altTtop4 / altkAgirlik4;
            double alttcort = (alttc1 + alttc2 + alttc3 + alttc4) / 4; //Lambda max. Değerimiz.

            double alttindex = (alttcort - 4) / 3; //Consistency index (ci)

            double alttutarlilik = alttindex / (0.9); //Tutarlılık=CI/RI (RI=0.882)
         

            if (alttutarlilik > 0.10)
            {
                MessageBox.Show("Girilen Değerler Tutarsızdır!", "Tekrar Dene");            

            }
            else
            {
                anaAltBaglanti1 = kAgirlik1 * altkAgirlik1;
                anaAltBaglanti2 = kAgirlik1 * altkAgirlik2;
                anaAltBaglanti3 = kAgirlik1 * altkAgirlik3;
                anaAltBaglanti4 = kAgirlik1 * altkAgirlik4;
                tabControl1.SelectedIndex = 3;
            }


        }

        

        ////// İKİNCİ YENİLE BUTONU //////
        private void button7_Click(object sender, EventArgs e)
        {
            
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox10.SelectedIndex = -1;
            comboBox11.SelectedIndex = -1;
            comboBox20.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox19.SelectedIndex = -1;
            comboBox9.SelectedIndex = -1;
            comboBox21.SelectedIndex = -1;
            comboBox24.SelectedIndex = -1;
            comboBox25.SelectedIndex = -1;
            comboBox26.SelectedIndex = -1;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox10.Enabled = true;
            comboBox11.Enabled = true;
            comboBox20.Enabled = true;
            comboBox7.Enabled = true;
            comboBox19.Enabled = true;
            comboBox9.Enabled = true;
            comboBox21.Enabled = true;
            comboBox24.Enabled = true;
            comboBox25.Enabled = true;
            comboBox26.Enabled = true;

        }

        ////////////////////////////// ÜÇÜNCÜ KAYDET BUTONU //////////////////////////////
        private void button4_Click(object sender, EventArgs e)
        {

            double b1x2 = 1;
            double b1x3 = 1;
            double b1x4 = 1;
            double b1x5 = 1;
            double b2x1 = 1;
            double b2x3 = 1;
            double b2x4 = 1;
            double b2x5 = 1;
            double b3x1 = 1;
            double b3x2 = 1;
            double b3x4 = 1;
            double b3x5 = 1;
            double b4x1 = 1;
            double b4x2 = 1;
            double b4x3 = 1;
            double b4x5 = 1;
            double b5x1 = 1;
            double b5x2 = 1;
            double b5x3 = 1;
            double b5x4 = 1;

            if (comboBox1.SelectedItem != null)
            {
                b1x2 = Convert.ToDouble(comboBox1.Text);
                b2x1 = 1 / Convert.ToDouble(comboBox1.Text);
            }
            if (comboBox8.SelectedItem != null)
            {
                b2x1 = Convert.ToDouble(comboBox8.Text);
                b1x2 = 1 / Convert.ToDouble(comboBox8.Text);
            }
            if (comboBox6.SelectedItem != null)
            {
                b1x3 = Convert.ToDouble(comboBox6.Text);
                b3x1 = 1 / Convert.ToDouble(comboBox6.Text);
            }
            if (comboBox14.SelectedItem != null)
            {
                b3x1 = Convert.ToDouble(comboBox14.Text);
                b1x3 = 1 / Convert.ToDouble(comboBox14.Text);
            }
            if (comboBox5.SelectedItem != null)
            {
                b1x4 = Convert.ToDouble(comboBox5.Text);
                b4x1 = 1 / Convert.ToDouble(comboBox5.Text);
            }
            if (comboBox13.SelectedItem != null)
            {
                b4x1 = Convert.ToDouble(comboBox13.Text);
                b1x4 = 1 / Convert.ToDouble(comboBox13.Text);
            }
            if (comboBox4.SelectedItem != null)
            {
                b1x5 = Convert.ToDouble(comboBox4.Text);
                b5x1 = 1 / Convert.ToDouble(comboBox4.Text);
            }
            if (comboBox12.SelectedItem != null)
            {
                b5x1 = Convert.ToDouble(comboBox12.Text);
                b1x5 = 1 / Convert.ToDouble(comboBox12.Text);
            }
            if (comboBox16.SelectedItem != null)
            {
                b2x3 = Convert.ToDouble(comboBox16.Text);
                b3x2 = 1 / Convert.ToDouble(comboBox16.Text);
            }
            if (comboBox15.SelectedItem != null)
            {
                b3x2 = Convert.ToDouble(comboBox15.Text);
                b2x3 = 1 / Convert.ToDouble(comboBox15.Text);
            }
            if (comboBox17.SelectedItem != null)
            {
                b2x4 = Convert.ToDouble(comboBox17.Text);
                b4x2 = 1 / Convert.ToDouble(comboBox17.Text);
            }
            if (comboBox32.SelectedItem != null)
            {
                b4x2 = Convert.ToDouble(comboBox32.Text);
                b2x4 = 1 / Convert.ToDouble(comboBox32.Text);
            }
            if (comboBox18.SelectedItem != null)
            {
                b2x5 = Convert.ToDouble(comboBox18.Text);
                b5x2 = 1 / Convert.ToDouble(comboBox18.Text);
            }
            if (comboBox33.SelectedItem != null)
            {
                b5x2 = Convert.ToDouble(comboBox33.Text);
                b2x5 = 1 / Convert.ToDouble(comboBox33.Text);
            }
            if (comboBox22.SelectedItem != null)
            {
                b3x4 = Convert.ToDouble(comboBox22.Text);
                b4x3 = 1 / Convert.ToDouble(comboBox22.Text);
            }
            if (comboBox31.SelectedItem != null)
            {
                b4x3 = Convert.ToDouble(comboBox31.Text);
                b3x4 = 1 / Convert.ToDouble(comboBox59.Text);
            }
            if (comboBox23.SelectedItem != null)
            {
                b3x5 = Convert.ToDouble(comboBox23.Text);
                b5x3 = 1 / Convert.ToDouble(comboBox23.Text);
            }
            if (comboBox34.SelectedItem != null)
            {
                b5x3 = Convert.ToDouble(comboBox34.Text);
                b3x5 = 1 / Convert.ToDouble(comboBox34.Text);
            }
            if (comboBox27.SelectedItem != null)
            {
                b4x5 = Convert.ToDouble(comboBox27.Text);
                b5x4 = 1 / Convert.ToDouble(comboBox27.Text);
            }
            if (comboBox35.SelectedItem != null)
            {
                b5x4 = Convert.ToDouble(comboBox35.Text);
                b4x5 = 1 / Convert.ToDouble(comboBox35.Text);
            }

            double alter1x1 = 1 / (1 + b2x1 + b3x1 + b4x1 + b5x1);
            double alter1x2 = b1x2 / (b1x2 + 1 + b3x2 + b4x2 + b5x2);
            double alter1x3 = b1x3 / (b1x3 + b2x3 + 1 + b4x3 + b5x3);
            double alter1x4 = b1x4 / (b1x4 + b2x4 + b3x4 + 1 + b5x4);
            double alter1x5 = b1x5 / (b1x5 + b2x5 + b3x5 + b4x5 + 1);
            double alter2x1 = b2x1 / (1 + b2x1 + b3x1 + b4x1 + b5x1);
            double alter2x2 = 1 / (b2x1 + 1 + b3x1 + b4x1 + b5x1);
            double alter2x3 = b2x3 / (b1x3 + b2x3 + 1 + b4x3 + b5x3);
            double alter2x4 = b2x4 / (b1x4 + b2x4 + b3x4 + 1 + b5x4);
            double alter2x5 = b2x5 / (b1x5 + b2x5 + b3x5 + b4x5 + 1);
            double alter3x1 = b3x1 / (1 + b2x1 + b3x1 + b4x1 + b5x1);
            double alter3x2 = b3x2 / (b1x2 + 1 + b3x2 + b4x2 + b5x2);
            double alter3x3 = 1 / (b1x3 + b2x3 + 1 + b4x3 + b5x3);
            double alter3x4 = b3x4 / (b1x4 + b2x4 + b3x4 + 1 + b5x4);
            double alter3x5 = b3x5 / (b1x5 + b2x5 + b3x5 + b4x5 + 1);
            double alter4x1 = b4x1 / (1 + b2x1 + b3x1 + b4x1 + b5x1);
            double alter4x2 = b4x2 / (b1x2 + 1 + b3x2 + b4x2 + b5x2);
            double alter4x3 = b4x3 / (b1x3 + b2x3 + 1 + b4x3 + b5x3);
            double alter4x4 = 1 / (b1x4 + b2x4 + b3x4 + 1 + b5x4);
            double alter4x5 = b4x5 / (b1x5 + b2x5 + b3x5 + b4x5 + 1);
            double alter5x1 = b5x1 / (1 + b2x1 + b3x1 + b4x1 + b5x1);
            double alter5x2 = b5x2 / (b1x2 + 1 + b3x2 + b4x2 + b5x2);
            double alter5x3 = b5x3 / (b1x3 + b2x3 + 1 + b4x3 + b5x3);
            double alter5x4 = b5x4 / (b1x4 + b2x4 + b3x4 + 1 + b5x4);
            double alter5x5 = 1 / (b1x5 + b2x5 + b3x5 + b4x5 + 1);

            //Alternatiflerin Kriter ağırlığını hesaplama;

            double alterkAgirlik1 = (alter1x1 + alter1x2 + alter1x3 + alter1x4 + alter1x5) / 5;
            double alterkAgirlik2 = (alter2x1 + alter2x2 + alter2x3 + alter2x4 + alter2x5) / 5;
            double alterkAgirlik3 = (alter3x1 + alter3x2 + alter3x3 + alter3x4 + alter3x5) / 5;
            double alterkAgirlik4 = (alter4x1 + alter4x2 + alter4x3 + alter4x4 + alter4x5) / 5;
            double alterkAgirlik5 = (alter5x1 + alter5x2 + alter5x3 + alter5x4 + alter5x5) / 5;

            //Alternatifler İçin Tutarlılık matrisi:
            double altertut1x1 = alterkAgirlik1 * 1;
            double altertut1x2 = alterkAgirlik2 * b1x2;
            double altertut1x3 = alterkAgirlik3 * b1x3;
            double altertut1x4 = alterkAgirlik4 * b1x4;
            double altertut1x5 = alterkAgirlik5 * b1x5;

            double altertut2x1 = alterkAgirlik1 * b2x1;
            double altertut2x2 = alterkAgirlik2 * 1;
            double altertut2x3 = alterkAgirlik3 * b2x3;
            double altertut2x4 = alterkAgirlik4 * b2x4;
            double altertut2x5 = alterkAgirlik5 * b2x5;

            double altertut3x1 = alterkAgirlik1 * b3x1;
            double altertut3x2 = alterkAgirlik2 * b3x2;
            double altertut3x3 = alterkAgirlik3 * 1;
            double altertut3x4 = alterkAgirlik4 * b3x4;
            double altertut3x5 = alterkAgirlik5 * b3x5;

            double altertut4x1 = alterkAgirlik1 * b4x1;
            double altertut4x2 = alterkAgirlik2 * b4x2;
            double altertut4x3 = alterkAgirlik3 * b4x3;
            double altertut4x4 = alterkAgirlik4 * 1;
            double altertut4x5 = alterkAgirlik5 * b4x5;

            double altertut5x1 = alterkAgirlik1 * b5x1;
            double altertut5x2 = alterkAgirlik2 * b5x2;
            double altertut5x3 = alterkAgirlik3 * b5x3;
            double altertut5x4 = alterkAgirlik4 * b5x4;
            double altertut5x5 = alterkAgirlik5 * 1;

            //Tutarlılık Toplamı:
            double alterTtop1 = (altertut1x1 + altertut1x2 + altertut1x3 + altertut1x4 + altertut1x5);
            double alterTtop2 = (altertut2x1 + altertut2x2 + altertut2x3 + altertut2x4 + altertut2x5);
            double alterTtop3 = (altertut3x1 + altertut3x2 + altertut3x3 + altertut3x4 + altertut3x5);
            double alterTtop4 = (altertut4x1 + altertut4x2 + altertut4x3 + altertut4x4 + altertut4x5);
            double alterTtop5 = (altertut5x1 + altertut5x2 + altertut5x3 + altertut5x4 + altertut5x5);

            //tutarlılık toplamı/kriter ağırlığı:
            double altertc1 = alterTtop1 / alterkAgirlik1;
            double altertc2 = alterTtop2 / alterkAgirlik2;
            double altertc3 = alterTtop3 / alterkAgirlik3;
            double altertc4 = alterTtop4 / alterkAgirlik4;
            double altertc5 = alterTtop5 / alterkAgirlik5;
            double altertcort = (altertc1 + altertc2 + altertc3 + altertc4 + altertc5) / 5; //Lambda max. Değerimiz.

            double altertindex = (altertcort - 5) / 4; //Consistency index (ci)

            double altertutarlilik = altertindex / (1.1); //Tutarlılık=CI/RI (RI=1,115)

            //Tutarlı mı ?
            if (altertutarlilik > 0.10)
            {
                MessageBox.Show("Girilen Değerler Tutarsızdır!", "Tekrar Dene");

            }
            
            //Tutarlı ise seçilen Ana kritere göre kıyaslama yapılır.
            if (radioButton2.Checked)
            {
                altAlterBaglanti1 = kAgirlik2 * alterkAgirlik1;
                altAlterBaglanti2 = kAgirlik2 * alterkAgirlik2;
                altAlterBaglanti3 = kAgirlik2 * alterkAgirlik3;
                altAlterBaglanti4 = kAgirlik2 * alterkAgirlik4;
                altAlterBaglanti5 = kAgirlik2 * alterkAgirlik5;
            }
            else if (radioButton3.Checked)
            {
                altAlterBaglanti1 = kAgirlik3 * alterkAgirlik1;
                altAlterBaglanti2 = kAgirlik3 * alterkAgirlik2;
                altAlterBaglanti3 = kAgirlik3 * alterkAgirlik3;
                altAlterBaglanti4 = kAgirlik3 * alterkAgirlik4;
                altAlterBaglanti5 = kAgirlik3 * alterkAgirlik5;

            }
            else if (radioButton4.Checked)
            {
                altAlterBaglanti1 = anaAltBaglanti3 * alterkAgirlik1;
                altAlterBaglanti2 = anaAltBaglanti3 * alterkAgirlik2;
                altAlterBaglanti3 = anaAltBaglanti3 * alterkAgirlik3;
                altAlterBaglanti4 = anaAltBaglanti3 * alterkAgirlik4;
                altAlterBaglanti5 = anaAltBaglanti3 * alterkAgirlik5;

            }
            else if (radioButton5.Checked)
            {
                altAlterBaglanti1 = anaAltBaglanti2 * alterkAgirlik1;
                altAlterBaglanti2 = anaAltBaglanti2 * alterkAgirlik2;
                altAlterBaglanti3 = anaAltBaglanti2 * alterkAgirlik3;
                altAlterBaglanti4 = anaAltBaglanti2 * alterkAgirlik4;
                altAlterBaglanti5 = anaAltBaglanti2 * alterkAgirlik5;

            }
            else if (radioButton6.Checked)
            {
                altAlterBaglanti1 = anaAltBaglanti1 * alterkAgirlik1;
                altAlterBaglanti2 = anaAltBaglanti1 * alterkAgirlik2;
                altAlterBaglanti3 = anaAltBaglanti1 * alterkAgirlik3;
                altAlterBaglanti4 = anaAltBaglanti1 * alterkAgirlik4;
                altAlterBaglanti5 = anaAltBaglanti1 * alterkAgirlik5;

            }
            else if (radioButton7.Checked)
            {
                altAlterBaglanti1 = anaAltBaglanti4 * alterkAgirlik1;
                altAlterBaglanti2 = anaAltBaglanti4 * alterkAgirlik2;
                altAlterBaglanti3 = anaAltBaglanti4 * alterkAgirlik3;
                altAlterBaglanti4 = anaAltBaglanti4 * alterkAgirlik4;
                altAlterBaglanti5 = anaAltBaglanti4 * alterkAgirlik5;

            }

            

        }

        //Üçüncü Yenile Butonu
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            comboBox16.SelectedIndex = -1;
            comboBox17.SelectedIndex = -1;
            comboBox18.SelectedIndex = -1;
            comboBox14.SelectedIndex = -1;
            comboBox15.SelectedIndex = -1;
            comboBox22.SelectedIndex = -1;
            comboBox23.SelectedIndex = -1;
            comboBox13.SelectedIndex = -1;
            comboBox32.SelectedIndex = -1;
            comboBox31.SelectedIndex = -1;
            comboBox27.SelectedIndex = -1;
            comboBox12.SelectedIndex = -1;
            comboBox33.SelectedIndex = -1;
            comboBox34.SelectedIndex = -1;
            comboBox35.SelectedIndex = -1;
            comboBox1.Enabled = true;
            comboBox6.Enabled = true;
            comboBox5.Enabled = true;
            comboBox4.Enabled = true;
            comboBox8.Enabled = true;
            comboBox16.Enabled = true;
            comboBox17.Enabled = true;
            comboBox18.Enabled = true;
            comboBox14.Enabled = true;
            comboBox15.Enabled = true;
            comboBox22.Enabled = true;
            comboBox23.Enabled = true;
            comboBox13.Enabled = true;
            comboBox32.Enabled = true;
            comboBox31.Enabled = true;
            comboBox27.Enabled = true;
            comboBox12.Enabled = true;
            comboBox33.Enabled = true;
            comboBox34.Enabled = true;
            comboBox35.Enabled = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            groupBox2.Enabled = false;
        }










        //Seçilen Kutucuğun KArşısındaki Kutucuğu Kapatma

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox8.Enabled = false;
        }

        private void comboBox8_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
        }

        private void comboBox6_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox14.Enabled = false;
        }

        private void comboBox14_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox6.Enabled = false;
        }

        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox13.Enabled = false;
        }
        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox21.Enabled = false;
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox19.Enabled = false;
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox20.Enabled = false;
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox26.Enabled = false;
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox11.Enabled = false;
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox25.Enabled = false;
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox10.Enabled = false;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = false;
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox24.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox9.Enabled = false;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox12.Enabled = false;
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox15.Enabled = false;
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox32.Enabled = false;
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox33.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox41.Text = "";
            textBox43.Text = "";
            textBox44.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //DataGridView aday silme işlemi
        private void button9_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From adayPersonel Where telefon=@telefon";
            komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@telefon", Convert.ToDouble(textBox50.Text));
            connection.Open();
            komut.ExecuteNonQuery();
            connection.Close();
            verilerimigöster("Select * From adayPersonel");

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox41.Clear();
            textBox43.Clear();
            textBox44.Clear();
            tabControl1.SelectedIndex = 0;
            comboBox1.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            comboBox16.SelectedIndex = -1;
            comboBox17.SelectedIndex = -1;
            comboBox18.SelectedIndex = -1;
            comboBox14.SelectedIndex = -1;
            comboBox15.SelectedIndex = -1;
            comboBox22.SelectedIndex = -1;
            comboBox23.SelectedIndex = -1;
            comboBox13.SelectedIndex = -1;
            comboBox32.SelectedIndex = -1;
            comboBox31.SelectedIndex = -1;
            comboBox27.SelectedIndex = -1;
            comboBox12.SelectedIndex = -1;
            comboBox33.SelectedIndex = -1;
            comboBox34.SelectedIndex = -1;
            comboBox35.SelectedIndex = -1;
            comboBox1.Enabled = true;
            comboBox6.Enabled = true;
            comboBox5.Enabled = true;
            comboBox4.Enabled = true;
            comboBox8.Enabled = true;
            comboBox16.Enabled = true;
            comboBox17.Enabled = true;
            comboBox18.Enabled = true;
            comboBox14.Enabled = true;
            comboBox15.Enabled = true;
            comboBox22.Enabled = true;
            comboBox23.Enabled = true;
            comboBox13.Enabled = true;
            comboBox32.Enabled = true;
            comboBox31.Enabled = true;
            comboBox27.Enabled = true;
            comboBox12.Enabled = true;
            comboBox33.Enabled = true;
            comboBox34.Enabled = true;
            comboBox35.Enabled = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            groupBox2.Enabled = false;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox10.SelectedIndex = -1;
            comboBox11.SelectedIndex = -1;
            comboBox20.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox19.SelectedIndex = -1;
            comboBox9.SelectedIndex = -1;
            comboBox21.SelectedIndex = -1;
            comboBox24.SelectedIndex = -1;
            comboBox25.SelectedIndex = -1;
            comboBox26.SelectedIndex = -1;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox10.Enabled = true;
            comboBox11.Enabled = true;
            comboBox20.Enabled = true;
            comboBox7.Enabled = true;
            comboBox19.Enabled = true;
            comboBox9.Enabled = true;
            comboBox21.Enabled = true;
            comboBox24.Enabled = true;
            comboBox25.Enabled = true;
            comboBox26.Enabled = true;
            comboBox57.SelectedIndex = -1;
            comboBox58.SelectedIndex = -1;
            comboBox59.SelectedIndex = -1;
            comboBox60.SelectedIndex = -1;
            comboBox61.SelectedIndex = -1;
            comboBox62.SelectedIndex = -1;
            comboBox57.Enabled = true;
            comboBox58.Enabled = true;
            comboBox59.Enabled = true;
            comboBox60.Enabled = true;
            comboBox61.Enabled = true;
            comboBox62.Enabled = true;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox53.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox52.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox51.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox50.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox44.Text == "")
            {

                MessageBox.Show("Telefon numarası boş geçilemez");
                tabControl1.SelectedIndex = 0;
                return;

            }
            sonuc = (altAlterBaglanti1 + altAlterBaglanti2 + altAlterBaglanti3 + altAlterBaglanti4 + altAlterBaglanti5) / 5;
            string ekleme = "insert into adayPersonel(ad,soyad,telefon,sonuc) values(@ad,@soyad,@telefon,@sonuc)";
            SqlCommand command2 = new SqlCommand();
            command2.Parameters.AddWithValue("@ad", textBox41.Text);
            command2.Parameters.AddWithValue("@soyad", textBox43.Text);
            command2.Parameters.AddWithValue("@telefon", textBox44.Text);
            command2.Parameters.AddWithValue("@sonuc", sonuc);
            var clssBulanikAhp = new clssBulanikAhp();
            clssBulanikAhp.ekle_sil_güncelle(command2, ekleme);
            verilerimigöster("Select * From adayPersonel Order By sonuc DESC");
            tabControl1.SelectedIndex = 4;
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox16.Enabled = false;
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox31.Enabled = false;
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox34.Enabled = false;
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.Enabled = false;
        }

        private void comboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox17.Enabled = false;
        }

        private void comboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox22.Enabled = false;
        }

        private void comboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox35.Enabled = false;
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Enabled = false;
        }

        private void comboBox33_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox18.Enabled = false;
        }

        private void comboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox23.Enabled = false;
        }

        private void comboBox35_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox27.Enabled = false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox7.Enabled = false;
        }





    }
}
