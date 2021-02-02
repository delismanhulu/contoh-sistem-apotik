Public Class frmobat
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call nopro()
        listdelisman.GridLines = True
        listdelisman.View = View.Details
        listdelisman.Columns.Add("NO")
        listdelisman.Columns.Add("NAMA OBAT", 115)
        listdelisman.Columns.Add("JENIS OBAT", 110)
        listdelisman.Columns.Add("HARGA", 110)
        listdelisman.Columns.Add("BAYAR", 110)
        listdelisman.Columns.Add("JUMLAH", 100)
        listdelisman.Columns.Add("KEMBALI", 110)
        listdelisman.Columns.Add("TOTAL", 110)
        txtnomor.Text = txtnomor.Text
        cbobat.Focus()

        cbobat.Items.Add("PARACETAMOL")
        cbobat.Items.Add("NOVALGIN")
        cbobat.Items.Add("PARACETAMOL")
        cbobat.Items.Add("BODREX")
        cbobat.Items.Add("PARAMEX")
        cbobat.Items.Add("ANTALGIN")
        cbobat.Items.Add("BUPAVUKAIN")
        cbobat.Items.Add("GRISEOVOLVIN")
        cbobat.Items.Add("FKS TAB")
        cbobat.Items.Add("ALKOHOL")
        cbobat.Items.Add("BETADIN SOL")
        cbobat.Items.Add("BETADIN CLEASER")
        cbobat.Items.Add("PARADOL")
        cbobat.Items.Add("SPUIT 5 CC")
        cbobat.Items.Add("SPUIT1 CC")
        cbobat.Items.Add("SPUIT 60 CC")
        cbobat.Items.Add("ATS")
        cbobat.Items.Add("BURNI ZALF")
        cbobat.Items.Add("SALEP")
        cbobat.Items.Add("HUFAXIZZE")
        cbobat.Items.Add("ANTIMON")
        cbobat.Items.Add("PARDOMAZODEL")
        cbobat.Items.Add("LEVOLIXAXIN")
        cbobat.Items.Add("HUVABION")

    End Sub
    Sub nopro()
        txtnomor.Enabled = False
        txtjembali.Enabled = False
        txtdiscount.Enabled = False
    End Sub
    Sub atpro()
        txtnomor.Enabled = True
        txtjembali.Enabled = True
        txtdiscount.Enabled = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtotal.Text = Val(txtjumlah.Text) * Val(txtharga.Text) - Val(txtdiscount.Text)
        txtjembali.Text = Val(txtotal.Text) - Val(txtbayar.Text)

        Dim Arr(7) As String
        Arr(0) = txtnomor.Text
        Arr(1) = cbobat.Text
        Arr(2) = cbjenis.Text
        Arr(3) = txtharga.Text
        Arr(4) = txtbayar.Text
        Arr(5) = txtjumlah.Text
        Arr(6) = txtjembali.Text
        Arr(7) = txtotal.Text

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = listdelisman.Items.Add(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))
        listitem.SubItems.Add(Arr(3))
        listitem.SubItems.Add(Arr(4))
        listitem.SubItems.Add(Arr(5))
        listitem.SubItems.Add(Arr(6))
        listitem.SubItems.Add(Arr(7))

        txtnomor.Text = txtnomor.Text + 1

        cbobat.ResetText()
        cbobat.ResetText()
        txtharga.Text = ""
        txtbayar.Text = ""
        txtjumlah.Text = ""
        txtjembali.Text = ""
        txtdiscount.Clear()
        cbobat.Focus()

        txtqty.Text = listdelisman.Items.Count
        txtjumlaht.Text = Val(txtotal.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub cbobat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbobat.SelectedIndexChanged
        If cbobat.SelectedIndex = 0 Then
            txtharga.Text = "5000"
        ElseIf cbobat.SelectedIndex = 1 Then
            txtharga.Text = "8000"
        ElseIf cbobat.SelectedIndex = 2 Then
            txtharga.Text = "15000"
        ElseIf cbobat.SelectedIndex = 3 Then
            txtharga.Text = "20000"
        ElseIf cbobat.SelectedIndex = 4 Then
            txtharga.Text = "15000"
        ElseIf cbobat.SelectedIndex = 5 Then
            txtharga.Text = "10000"
        ElseIf cbobat.SelectedIndex = 6 Then
            txtharga.Text = "35000"
        ElseIf cbobat.SelectedIndex = 7 Then
            txtharga.Text = "40000"
        ElseIf cbobat.SelectedIndex = 8 Then
            txtharga.Text = "45000"
        ElseIf cbobat.SelectedIndex = 9 Then
            txtharga.Text = "50000"
        ElseIf cbobat.SelectedIndex = 10 Then
            txtharga.Text = "5000"
        ElseIf cbobat.SelectedIndex = 11 Then
            txtharga.Text = "60000"
        ElseIf cbobat.SelectedIndex = 12 Then
            txtharga.Text = "1000"
        ElseIf cbobat.SelectedIndex = 13 Then
            txtharga.Text = "3000"
        ElseIf cbobat.SelectedIndex = 14 Then
            txtharga.Text = "7500"
        ElseIf cbobat.SelectedIndex = 15 Then
            txtharga.Text = "63000"
        ElseIf cbobat.SelectedIndex = 16 Then
            txtharga.Text = "6300"
        ElseIf cbobat.SelectedIndex = 17 Then
            txtharga.Text = "34000"
        ElseIf cbobat.SelectedIndex = 18 Then
            txtharga.Text = "12000"
        ElseIf cbobat.SelectedIndex = 20 Then
            txtharga.Text = "12000"
        ElseIf cbobat.SelectedIndex = 21 Then
            txtharga.Text = "6200"
        ElseIf cbobat.SelectedIndex = 22 Then
            txtharga.Text = "2300"
        ElseIf cbobat.SelectedIndex = 23 Then
            txtharga.Text = "1400"
        ElseIf cbobat.SelectedIndex = 24 Then
            txtharga.Text = "7300"
        ElseIf cbobat.SelectedIndex = 25 Then
            txtharga.Text = "0"
        Else
            txtharga.Text = ""
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If txtbayar.Text < lbldelis.Text Then
            MsgBox("Pembayaran Anda Kurang")
        ElseIf txtbayar.Text > lbldelis.Text Then
            MsgBox("Pembayaran Anda Cukup")
        Else
            MsgBox("SEGERA LUNASI")
        End If
        lbldelis.Text = Val(txtjumlah.Text) * Val(txtharga.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtotal.Text = ""
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Button5.Text = "Aktif" Then
            Button5.Text = "Tidak Akif"
        End If
        Call atpro()
    End Sub
    Sub tentangku()
        'Belajar Komputer
        'By : Delisman Hulu
        'http://pengetahuanlocal.blogspot.com
    End Sub

End Class
