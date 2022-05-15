Imports System.Data.OleDb

Public Class Form3

    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = qwe.mdb")


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        baglanti.Open()

        Dim Komut2 As New OleDbCommand("update kayitbilgi set adii='" + TextBox1.Text + "' ,tcsi='" + TextBox3.Text + "' ,telefonii='" + MaskedTextBox1.Text + "' ,dogumii='" + MaskedTextBox2.Text + "' ,bransii='" + TextBox6.Text + "' ,adresii='" + TextBox7.Text + "' ,uyeseklii='" + ComboBox4.Text + "' ,odemeseklii='" + ComboBox3.Text + "' ,mailii='" + TextBox10.Text + "' ,meslekii='" + TextBox13.Text + "' ,cinsiyetii='" + ComboBox1.Text + "' ,kangrubuu='" + ComboBox2.Text + "' ,boyii='" + TextBox14.Text + "' ,kilosii='" + TextBox15.Text + "' ,uyebasla='" + DateTimePicker1.Value + "' ,uyebitis='" + DateTimePicker2.Value + "' ,acıklamasii='" + RichTextBox1.Text + "'where soyadii='" + TextBox2.Text + "'    ", baglanti)

        Komut2.ExecuteNonQuery()
        baglanti.Close()
        MessageBox.Show("Üye Kaydı Güncellendi.", "Kayıt")

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


