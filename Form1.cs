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

/***************************************************************************************************************************************
  *                                                   SAKARYA ÜNİVERSİTESİ                                                          *
  *                                        BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                                                *
  *                                             BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ                                                     *                                               
  *                                             2019-2020 BAHAR DÖNEMİ                                                              *
  *                                                ADIM:   ALİ OSMAN ÖZDEMİR                                                        *
  *                                                NUMARAM: B181200007                                                              *
***************************************************************************************************************************************/                               
namespace ödevimverim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //burada veritabanından verileri çekmek için bu işlemler yapılmaktadır.
        {
          //formun üzerine tıkladığımızda burası geliyor.
            this.kisilerTableAdapter.Fill(this.rehberkisilerDataSet.kisiler);
            //ilk defa sql server kullandığım için komutlara baktım sqlconnection kullanmamızın sebebi veritabanı ile formu birbirine bağlamak ve veritabanından bilgi çekmek
            SqlConnection baglanti=new SqlConnection("Data Source=(LocalDB)MSSQLL;Initial Catalog=rehberkisiler;Integrated Security=True;Connect Timeout=30");
            baglanti.Open();
            //sql command veritabanından çektiğimiz verilerle hangi işlemleri yapacağımızı gösterir
            SqlCommand veri = new SqlCommand("Select*from kisiler",baglanti);//burada kisiler tablonun ismi olduguna dikkat edilmelidir veritabanı ismini connection da kullanmıştık
            SqlDataReader oku = veri.ExecuteReader();//sql data reader bilgileri okumak için kullanılır burada yaptığımız işlemlerden sonra bilgileri okuması için kullandım
            DataTable dtablee = new DataTable();
            dtablee.Load(oku);
            dataGridView1.DataSource = dtablee;//datagridde görüntülenlerinin kaynağını alması için kullandım
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//kaydet butonumuza tıkladıktan sonra burası geliyor.
        { //tekrar baglantı olusturmak için kullandım 
            SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)MSSQLL;Initial Catalog=rehberkisiler;Integrated Security=True;Connect Timeout=30");
            baglanti.Open();
            //bu yöntem ile tabloya veri aktaracağımızı öğrendim ve testbox isimleri düzenleyerek sırasıyla box1,box2,box3 yaptım
            SqlCommand kaydet = new SqlCommand("insert into kisiler(AD,SOYAD,NUMARA) Values(" + box1.Text + "," + box2.Text + "," + box3.Text + ") ", baglanti);
            kaydet.ExecuteNonQuery();//çalıştırması için bunu kullanmamız gerekiyormuş.

        
            /*amacım rehber programı yapıp önceki yazılanları gösteren ve numara ekleyip kaydedebileceğimiz bir rehber yapmaktı form hakkında bilgilerim
      *yeterli düzeyde olduğunu düşünüyorum ve yaparken keyif aldım ancak 1 hafta bir süreyle uğraşmama rağmen tamamen veritabanı işini kavrayamadım
      * bir şeyler öğrendiğimi düşünüyorum eksiklerim olabilir elimden geleni yaptım ve yapamadığım yerden yardım aldım umarım beğenirsiniz*/
    }
        
    }
}
