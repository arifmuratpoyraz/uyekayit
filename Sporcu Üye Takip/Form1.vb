Imports System.Data.OleDb


Public Class Form1

    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = qwe.mdb")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form2.Show()


    End Sub

    Dim tablo As New DataTable



    Private Sub listele()

        baglanti.Open()
        Dim Adıtr As New OleDbDataAdapter("select *from kayitbilgi", baglanti)
        Adıtr.Fill(tablo)
        DataGridView1.DataSource = tablo
        DataGridView2.DataSource = tablo
        baglanti.Close()


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        listele()

    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        baglanti.Open()
        Dim komut As New OleDbCommand("delete *from kayitbilgi where soyadii = '" + DataGridView1.CurrentRow.Cells("soyadii").Value.ToString() + "'", baglanti)
        komut.ExecuteNonQuery()
        baglanti.Close()
        tablo.Clear()
        listele()

    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.TextChanged

        baglanti.Open()
        Dim adiitr As New OleDbDataAdapter("select *from kayitbilgi where adii like '" + TextBox19.Text + "%'  ", baglanti)
        Dim tablo2 As New DataTable
        adiitr.Fill(tablo2)
        DataGridView2.DataSource = tablo2
        baglanti.Close()

    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Form3.Show()
        Form3.TextBox1.Text = DataGridView1.CurrentRow.Cells("adii").Value.ToString
        Form3.TextBox2.Text = DataGridView1.CurrentRow.Cells("soyadii").Value.ToString
        Form3.TextBox3.Text = DataGridView1.CurrentRow.Cells("tcsi").Value.ToString
        Form3.MaskedTextBox1.Text = DataGridView1.CurrentRow.Cells("telefonii").Value.ToString
        Form3.MaskedTextBox2.Text = DataGridView1.CurrentRow.Cells("dogumii").Value.ToString
        Form3.TextBox6.Text = DataGridView1.CurrentRow.Cells("bransii").Value.ToString
        Form3.TextBox7.Text = DataGridView1.CurrentRow.Cells("adresii").Value.ToString
        Form3.ComboBox4.Text = DataGridView1.CurrentRow.Cells("uyeseklii").Value.ToString
        Form3.ComboBox3.Text = DataGridView1.CurrentRow.Cells("odemeseklii").Value.ToString
        Form3.TextBox10.Text = DataGridView1.CurrentRow.Cells("mailii").Value.ToString
        Form3.TextBox13.Text = DataGridView1.CurrentRow.Cells("meslekii").Value.ToString
        Form3.ComboBox1.Text = DataGridView1.CurrentRow.Cells("cinsiyetii").Value.ToString
        Form3.ComboBox2.Text = DataGridView1.CurrentRow.Cells("kangrubuu").Value.ToString
        Form3.TextBox14.Text = DataGridView1.CurrentRow.Cells("boyii").Value.ToString
        Form3.TextBox15.Text = DataGridView1.CurrentRow.Cells("kilosii").Value.ToString
        Form3.DateTimePicker1.Text = DataGridView1.CurrentRow.Cells("uyebasla").Value.ToString
        Form3.DateTimePicker2.Text = DataGridView1.CurrentRow.Cells("uyebitis").Value.ToString
        Form3.RichTextBox1.Text = DataGridView1.CurrentRow.Cells("acıklamasii").Value.ToString

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tablo.Clear()
        listele()

    End Sub


    Private Sub QweDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles QweDataSetBindingSource.CurrentChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub
End Class
