using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Istatistikler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.DataTable1TableAdapter dt = new DataSetTableAdapters.DataTable1TableAdapter();
        textbox1.Text="Toplam Öğrenci Sayısı : "+dt.Istatistik1().ToString();
        textbox2.Text="Toplam Öğretmen Sayısı : "+dt.Istatistik2().ToString();
        textbox3.Text = "Toplam Ders Sayısı : " + dt.Istatistik3().ToString();
        textbox4.Text="Matematikte dersinde en başarılı öğrenci : "+dt.Istatistik4().ToString();
        textbox5.Text = "Türkçe dersinde en başarılı öğrenci : " + dt.Istatistik5().ToString();
        textbox6.Text = "Matematik dersi 1.sınavın sınıf ortalaması : " + dt.Istatistik6().ToString();
        textbox7.Text="Türkçe dersi 1.sınavın sınıf ortalaması : "+dt.Istatistik7().ToString();
        textbox8.Text = "Fizik dersi 1.sınavın sınıf ortalaması : " + dt.Istatistik8().ToString();
        textbox9.Text = "Sistem veritabanında kayıdı tutulan toplam mesaj sayısı : " + dt.Istatistik9().ToString();
        textbox10.Text="Sistem veritabanında kayıdı tutulan toplam duyuru sayısı : "+dt.Istatistikler10().ToString();
        textbox11.Text="Matematik dersinden geçen öğrenci sayısı : "+dt.Istatistikler11().ToString();
        textbox12.Text = "Türkçe dersinden geçen öğrenci sayısı : " + dt.Istatistikler12().ToString();
        textbox13.Text = "Fizik dersinden geçen öğrenci sayısı : " + dt.Istatistikler13().ToString();
    }
}