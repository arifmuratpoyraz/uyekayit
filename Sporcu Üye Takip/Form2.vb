Imports System.Data.OleDb

Public Class Form2

    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = qwe.mdb")

    Private Sub temizle()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        MaskedTextBox1.Text = ""
        MaskedTextBox2.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        ComboBox4.Text = " "
        ComboBox3.Text = " "
        TextBox10.Text = ""
        TextBox13.Text = ""
        ComboBox1.Text = " "
        ComboBox2.Text = " "
        TextBox14.Text = ""
        TextBox15.Text = ""
        RichTextBox1.Text = ""



    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then
            MsgBox("ad kısmını boş bırakamazsınız")
        ElseIf (TextBox2.Text = "") Then
            MsgBox("soyad kısmını boş bırakamazsınız")
        ElseIf (TextBox3.Text = "") Then
            MsgBox("TC kısmını boş bırakamazsınız")

        Else

            baglanti.Open()
            Dim Komut1 As New OleDbCommand("insert into kayitbilgi(adii,soyadii,tcsi,telefonii,dogumii,bransii,adresii,uyeseklii,odemeseklii,mailii,meslekii,cinsiyetii,kangrubuu,boyii,kilosii,uyebasla,uyebitis,acıklamasii) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + MaskedTextBox1.Text + "','" + MaskedTextBox2.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + ComboBox4.Text + "','" + ComboBox3.Text + "','" + TextBox10.Text + "','" + TextBox13.Text + "','" + ComboBox1.Text + "','" + ComboBox2.Text + "','" + TextBox14.Text + "','" + TextBox15.Text + "','" + DateTimePicker1.Value + "','" + DateTimePicker2.Value + "','" + RichTextBox1.Text + "' )", baglanti)
            Komut1.ExecuteNonQuery()
            MessageBox.Show("Üye Kayıt Edildi.", "Kayıt")
            temizle()
            baglanti.Close()
        End If





    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class