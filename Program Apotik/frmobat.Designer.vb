<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmobat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.listdelisman = New System.Windows.Forms.ListView()
        Me.txtnomor = New System.Windows.Forms.TextBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbjenis = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbobat = New System.Windows.Forms.ComboBox()
        Me.txtjembali = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtotal = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lbldelis = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtjumlaht = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(35, 363)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SIMPAN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(144, 363)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 40)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "HAPUS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(253, 363)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 40)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'listdelisman
        '
        Me.listdelisman.Location = New System.Drawing.Point(12, 134)
        Me.listdelisman.Name = "listdelisman"
        Me.listdelisman.Size = New System.Drawing.Size(783, 223)
        Me.listdelisman.TabIndex = 1
        Me.listdelisman.UseCompatibleStateImageBehavior = False
        '
        'txtnomor
        '
        Me.txtnomor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnomor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomor.Location = New System.Drawing.Point(110, 12)
        Me.txtnomor.Name = "txtnomor"
        Me.txtnomor.Size = New System.Drawing.Size(115, 26)
        Me.txtnomor.TabIndex = 2
        Me.txtnomor.Text = "0"
        '
        'txtjumlah
        '
        Me.txtjumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtjumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjumlah.Location = New System.Drawing.Point(110, 71)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(115, 26)
        Me.txtjumlah.TabIndex = 2
        '
        'txtharga
        '
        Me.txtharga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtharga.Location = New System.Drawing.Point(285, 41)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(287, 26)
        Me.txtharga.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nomor Obat"
        '
        'txtqty
        '
        Me.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(628, 363)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(167, 26)
        Me.txtqty.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Jenis Obat"
        '
        'cbjenis
        '
        Me.cbjenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbjenis.FormattingEnabled = True
        Me.cbjenis.Items.AddRange(New Object() {"TABLET", "INJ", "SIRUP"})
        Me.cbjenis.Location = New System.Drawing.Point(110, 41)
        Me.cbjenis.Name = "cbjenis"
        Me.cbjenis.Size = New System.Drawing.Size(115, 24)
        Me.cbjenis.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(231, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga"
        '
        'txtbayar
        '
        Me.txtbayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbayar.Location = New System.Drawing.Point(285, 71)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(287, 26)
        Me.txtbayar.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(231, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Bayar"
        '
        'txtdiscount
        '
        Me.txtdiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscount.Location = New System.Drawing.Point(472, 102)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(100, 26)
        Me.txtdiscount.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(399, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Discount"
        '
        'cbobat
        '
        Me.cbobat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbobat.FormattingEnabled = True
        Me.cbobat.Items.AddRange(New Object() {"TABLET", "INJ", "SIRUP"})
        Me.cbobat.Location = New System.Drawing.Point(231, 12)
        Me.cbobat.Name = "cbobat"
        Me.cbobat.Size = New System.Drawing.Size(341, 24)
        Me.cbobat.TabIndex = 4
        '
        'txtjembali
        '
        Me.txtjembali.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtjembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjembali.Location = New System.Drawing.Point(110, 102)
        Me.txtjembali.Name = "txtjembali"
        Me.txtjembali.Size = New System.Drawing.Size(285, 26)
        Me.txtjembali.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Kembali"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(649, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 18)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "TOTAL"
        '
        'txtotal
        '
        Me.txtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtotal.Location = New System.Drawing.Point(578, 71)
        Me.txtotal.Multiline = True
        Me.txtotal.Name = "txtotal"
        Me.txtotal.Size = New System.Drawing.Size(217, 57)
        Me.txtotal.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(362, 363)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 40)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "CEK PEMBAYARAN"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'lbldelis
        '
        Me.lbldelis.AutoSize = True
        Me.lbldelis.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldelis.Location = New System.Drawing.Point(609, 20)
        Me.lbldelis.Name = "lbldelis"
        Me.lbldelis.Size = New System.Drawing.Size(0, 18)
        Me.lbldelis.TabIndex = 3
        Me.lbldelis.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(486, 363)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(103, 40)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "DISCOUNT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtjumlaht
        '
        Me.txtjumlaht.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtjumlaht.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjumlaht.Location = New System.Drawing.Point(628, 395)
        Me.txtjumlaht.Name = "txtjumlaht"
        Me.txtjumlaht.Size = New System.Drawing.Size(167, 26)
        Me.txtjumlaht.TabIndex = 2
        '
        'frmobat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 461)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cbobat)
        Me.Controls.Add(Me.cbjenis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbldelis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtjembali)
        Me.Controls.Add(Me.txtotal)
        Me.Controls.Add(Me.txtdiscount)
        Me.Controls.Add(Me.txtbayar)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtjumlaht)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.txtnomor)
        Me.Controls.Add(Me.listdelisman)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmobat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DAFTA HARGA OBAT DAN NAMA OBAT APOTIK"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents listdelisman As System.Windows.Forms.ListView
    Friend WithEvents txtnomor As System.Windows.Forms.TextBox
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbjenis As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtbayar As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbobat As System.Windows.Forms.ComboBox
    Friend WithEvents txtjembali As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtotal As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lbldelis As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtjumlaht As System.Windows.Forms.TextBox

End Class
