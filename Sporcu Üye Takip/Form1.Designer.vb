<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TcsiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdiiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoyadiiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefoniiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BransiiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UyesekliiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UyebaslaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UyebitisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KayitbilgiBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.QweDataSet1 = New Sporcu_Üye_Takipp.qweDataSet1()
        Me.KayitbilgiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QweDataSet = New Sporcu_Üye_Takipp.qweDataSet()
        Me.KayitbilgiTableAdapter = New Sporcu_Üye_Takipp.qweDataSetTableAdapters.kayitbilgiTableAdapter()
        Me.QweDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayitbilgiTableAdapter1 = New Sporcu_Üye_Takipp.qweDataSet1TableAdapters.kayitbilgiTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayitbilgiBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QweDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayitbilgiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QweDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QweDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(400, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(332, 306)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(87, 250)
        Me.TextBox19.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(229, 22)
        Me.TextBox19.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(823, 249)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Üye Kayıt"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label19.Location = New System.Drawing.Point(31, 250)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 27)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Ara"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(985, 249)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 34)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Sil"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Location = New System.Drawing.Point(4, 388)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(159, 137)
        Me.DataGridView1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightCyan
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.DataGridView2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox19)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1191, 836)
        Me.Panel1.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.PowderBlue
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button3.Location = New System.Drawing.Point(1054, 13)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 52)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Yenile"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TcsiDataGridViewTextBoxColumn, Me.AdiiDataGridViewTextBoxColumn, Me.SoyadiiDataGridViewTextBoxColumn, Me.TelefoniiDataGridViewTextBoxColumn, Me.BransiiDataGridViewTextBoxColumn, Me.UyesekliiDataGridViewTextBoxColumn, Me.UyebaslaDataGridViewTextBoxColumn, Me.UyebitisDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.KayitbilgiBindingSource1
        Me.DataGridView2.Location = New System.Drawing.Point(0, 306)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.Size = New System.Drawing.Size(1191, 529)
        Me.DataGridView2.TabIndex = 12
        '
        'TcsiDataGridViewTextBoxColumn
        '
        Me.TcsiDataGridViewTextBoxColumn.DataPropertyName = "tcsi"
        Me.TcsiDataGridViewTextBoxColumn.HeaderText = "TC NO"
        Me.TcsiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TcsiDataGridViewTextBoxColumn.Name = "TcsiDataGridViewTextBoxColumn"
        Me.TcsiDataGridViewTextBoxColumn.ReadOnly = True
        Me.TcsiDataGridViewTextBoxColumn.Width = 125
        '
        'AdiiDataGridViewTextBoxColumn
        '
        Me.AdiiDataGridViewTextBoxColumn.DataPropertyName = "adii"
        Me.AdiiDataGridViewTextBoxColumn.HeaderText = "ADI"
        Me.AdiiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AdiiDataGridViewTextBoxColumn.Name = "AdiiDataGridViewTextBoxColumn"
        Me.AdiiDataGridViewTextBoxColumn.ReadOnly = True
        Me.AdiiDataGridViewTextBoxColumn.Width = 125
        '
        'SoyadiiDataGridViewTextBoxColumn
        '
        Me.SoyadiiDataGridViewTextBoxColumn.DataPropertyName = "soyadii"
        Me.SoyadiiDataGridViewTextBoxColumn.HeaderText = "Soyadi"
        Me.SoyadiiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SoyadiiDataGridViewTextBoxColumn.Name = "SoyadiiDataGridViewTextBoxColumn"
        Me.SoyadiiDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoyadiiDataGridViewTextBoxColumn.Width = 125
        '
        'TelefoniiDataGridViewTextBoxColumn
        '
        Me.TelefoniiDataGridViewTextBoxColumn.DataPropertyName = "telefonii"
        Me.TelefoniiDataGridViewTextBoxColumn.HeaderText = "TELEFON"
        Me.TelefoniiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelefoniiDataGridViewTextBoxColumn.Name = "TelefoniiDataGridViewTextBoxColumn"
        Me.TelefoniiDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefoniiDataGridViewTextBoxColumn.Width = 125
        '
        'BransiiDataGridViewTextBoxColumn
        '
        Me.BransiiDataGridViewTextBoxColumn.DataPropertyName = "bransii"
        Me.BransiiDataGridViewTextBoxColumn.HeaderText = "BRANŞI"
        Me.BransiiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BransiiDataGridViewTextBoxColumn.Name = "BransiiDataGridViewTextBoxColumn"
        Me.BransiiDataGridViewTextBoxColumn.ReadOnly = True
        Me.BransiiDataGridViewTextBoxColumn.Width = 125
        '
        'UyesekliiDataGridViewTextBoxColumn
        '
        Me.UyesekliiDataGridViewTextBoxColumn.DataPropertyName = "uyeseklii"
        Me.UyesekliiDataGridViewTextBoxColumn.HeaderText = "ÜYELİK ŞEKLİ"
        Me.UyesekliiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UyesekliiDataGridViewTextBoxColumn.Name = "UyesekliiDataGridViewTextBoxColumn"
        Me.UyesekliiDataGridViewTextBoxColumn.ReadOnly = True
        Me.UyesekliiDataGridViewTextBoxColumn.Width = 105
        '
        'UyebaslaDataGridViewTextBoxColumn
        '
        Me.UyebaslaDataGridViewTextBoxColumn.DataPropertyName = "uyebasla"
        Me.UyebaslaDataGridViewTextBoxColumn.HeaderText = "ÜYELİK BAŞLANGIÇ"
        Me.UyebaslaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UyebaslaDataGridViewTextBoxColumn.Name = "UyebaslaDataGridViewTextBoxColumn"
        Me.UyebaslaDataGridViewTextBoxColumn.ReadOnly = True
        Me.UyebaslaDataGridViewTextBoxColumn.Width = 135
        '
        'UyebitisDataGridViewTextBoxColumn
        '
        Me.UyebitisDataGridViewTextBoxColumn.DataPropertyName = "uyebitis"
        Me.UyebitisDataGridViewTextBoxColumn.HeaderText = "ÜYELİK BİTİŞ"
        Me.UyebitisDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UyebitisDataGridViewTextBoxColumn.Name = "UyebitisDataGridViewTextBoxColumn"
        Me.UyebitisDataGridViewTextBoxColumn.ReadOnly = True
        Me.UyebitisDataGridViewTextBoxColumn.Width = 110
        '
        'KayitbilgiBindingSource1
        '
        Me.KayitbilgiBindingSource1.DataMember = "kayitbilgi"
        Me.KayitbilgiBindingSource1.DataSource = Me.QweDataSet1
        '
        'QweDataSet1
        '
        Me.QweDataSet1.DataSetName = "qweDataSet1"
        Me.QweDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KayitbilgiBindingSource
        '
        Me.KayitbilgiBindingSource.DataMember = "kayitbilgi"
        Me.KayitbilgiBindingSource.DataSource = Me.QweDataSet
        '
        'QweDataSet
        '
        Me.QweDataSet.DataSetName = "qweDataSet"
        Me.QweDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KayitbilgiTableAdapter
        '
        Me.KayitbilgiTableAdapter.ClearBeforeFill = True
        '
        'QweDataSetBindingSource
        '
        Me.QweDataSetBindingSource.DataSource = Me.QweDataSet
        Me.QweDataSetBindingSource.Position = 0
        '
        'KayitbilgiTableAdapter1
        '
        Me.KayitbilgiTableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(1188, 836)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUALİTY LİFE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayitbilgiBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QweDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayitbilgiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QweDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QweDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents QweDataSet As qweDataSet
    Friend WithEvents KayitbilgiBindingSource As BindingSource
    Friend WithEvents KayitbilgiTableAdapter As qweDataSetTableAdapters.kayitbilgiTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents QweDataSetBindingSource As BindingSource
    Friend WithEvents QweDataSet1 As qweDataSet1
    Friend WithEvents KayitbilgiBindingSource1 As BindingSource
    Friend WithEvents KayitbilgiTableAdapter1 As qweDataSet1TableAdapters.kayitbilgiTableAdapter
    Friend WithEvents TcsiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdiiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoyadiiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefoniiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BransiiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UyesekliiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UyebaslaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UyebitisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
End Class
