using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace ozelizmirhastanesii
{
    public partial class Bölüm : Form
    {
        public Bölüm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "insert into BolumTbl values('" + BAdSoyadTb.Text + "', '" + BUcretTb.Text + "', '" + BAciklamaTb.Text + "' )";
            Hastalar Hs = new Hastalar();
            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Hasta Başarıyla Eklendi");
                uyeler();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int key;
        private void button1_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Güncellenecek Hastayı Seçiniz");
            }
            else
            {
                try
                {
                    string query = "update BolumTb set BAd='" + BAdSoyadTb.Text + "', BUcret='" + BUcretTb.Text + "' , BAciklama='" + BAciklamaTb.Text + "' , where BId=" + key + "";
                    Hs.HastaSil(query);
                    MessageBox.Show("Hasta başarıyla güncellendi");
                    uyeler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Silinecek Hastayı Seçiniz");
            }
            else
            {
                try
                {
                    string query = "delete from BolumTb where BId=" + key + "";
                    Hs.HastaSil(query);
                    MessageBox.Show("Hasta başarıyla silindi");
                    uyeler();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
        void uyeler()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from HastaTb";
            DataSet ds = Hs.ShowHasta(query);
            BolumDGV.DataSource = ds.Tables[0];
        }
        void Reset()
        {
            BAdSoyadTb.Text = "";
            BUcretTb.Text = "";
            BAciklamaTb.Text = "";


        }
        private void Bölüm_Load(object sender, EventArgs e)
        {

        }

        private void BolumDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BAdSoyadTb.Text = BolumDGV.SelectedRows[0].Cells[1].Value.ToString();
            BUcretTb.Text = BolumDGV.SelectedRows[0].Cells[2].Value.ToString();
            BAciklamaTb.Text = BolumDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (BAdSoyadTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BolumDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void BAciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BUcret_TextChanged(object sender, EventArgs e)
        {

        }

        private void BAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}