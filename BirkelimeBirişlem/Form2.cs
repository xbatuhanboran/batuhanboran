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

namespace BirkelimeBirişlem
{
    public partial class Form2 : Form
    {   
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\antuan\\Desktop\\BkBidatabase.mdb");
        int katılımcısayısı=0;
        private void puanGörüntüle()
        {
            
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From puan");
            OleDbDataReader oku = komut.ExecuteReader();
             while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ad"].ToString();        
                ekle.SubItems.Add(oku["puan"].ToString());
                listView1.Items.Add(ekle);
                katılımcısayısı++;
            }
            
            baglanti.Close();
            label3.Text = katılımcısayısı.ToString();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            puanGörüntüle();

        }
    }
}
