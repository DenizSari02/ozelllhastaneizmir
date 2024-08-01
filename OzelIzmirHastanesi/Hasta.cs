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

namespace ozelizmirhastanesii
{
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "insert into HastaTbl values('" + HAdSoyadTb.Text + "', '" + HTelTb.Text + "', '" + HDogumTarihi.Text + "', '" + HCinsiyetCb.SelectedItem.ToString() + "' , '" + HEpostaTb.Text + "', '" + HAdresTb.Text + "' )";
            Hastalar Hs = new Hastalar();
            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Hasta Başarıyla Eklendi");
                uyeler();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
        void uyeler()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from HastaTbl";
            DataSet ds = Hs.ShowHasta(query);
            HastaDGV.DataSource = ds.Tables[0];
        }
        void Reset()
        {
            HAdSoyadTb.Text = "";
            HTelTb.Text = "";
            HAdresTb.Text = "";
            HEpostaTb.Text = "";
            HCinsiyetCb.SelectedItem = "";
            HDogumTarihi.Text = "";
            ;
        }
        private void Hasta_Load(object sender, EventArgs e)
        {
            uyeler();
            Reset();
        }
        int key = 0;
        private void HastaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HAdSoyadTb.Text = HastaDGV.SelectedRows[0].Cells[1].Value.ToString();
            HTelTb.Text = HastaDGV.SelectedRows[0].Cells[2].Value.ToString();
            HAdresTb.Text = HastaDGV.SelectedRows[0].Cells[3].Value.ToString();
            HEpostaTb.Text = HastaDGV.SelectedRows[0].Cells[4].Value.ToString();
            HCinsiyetCb.SelectedItem = HastaDGV.SelectedRows[1].Cells[5].Value.ToString();
            HDogumTarihi.Text = HastaDGV.SelectedRows[0].Cells[0].Value.ToString();
            if (HAdSoyadTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(HastaDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
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
                        string query = "delete from HastaTbl where HId=" + key + "";
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
        }

        private void button7_Click(object sender, EventArgs e)
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
                    string query = "update HastaTbl set HAdSoyad='" + HAdSoyadTb.Text + "', HTel='" + HTelTb.Text + "' , HAdres='" + HAdresTb.Text + "', HDTarih= '" + HDogumTarihi.Text + "' , HCinsiyet= '" + HCinsiyetCb.SelectedItem.ToString() + "' , HEposta= '" + HEpostaTb.Text + "'  , where HId=" + key + "";
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
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void HTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void HAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}