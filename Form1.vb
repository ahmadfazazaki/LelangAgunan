Imports System.Data.OleDb
Imports LelangAgunan.Class1
Public Class Form1
    Dim Conn As OleDbConnection
    Dim Da As OleDbDataAdapter
    Dim Ds As DataSet
    Dim Dr As OleDbDataReader
    Dim LokasiDB As String
    Dim DataSet As New DataTable
    Dim FormDetil As New Form2
    Sub Koneksi()
        LokasiDB = "provider=Microsoft.ACE.OLEDB.12.0; data source=DBLelangAgunan.mdb"
        Conn = New OleDbConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

    Sub ButtonDetail()
        Dim buttonDetail As New DataGridViewButtonColumn
        buttonDetail.Text = "Detail"
        buttonDetail.HeaderText = "Detail"
        buttonDetail.UseColumnTextForButtonValue = True
        buttonDetail.FlatStyle = FlatStyle.Popup
        buttonDetail.Width = 100
        dgvDataAset.Columns.Add(buttonDetail)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call ButtonDetail()
        Dim query As New OleDbCommand
        query.CommandText = "SELECT DISTINCT Bank FROM table_lelangagunan"
        query.Connection = Conn
        Dr = query.ExecuteReader
        While Dr.Read
            cbxBank.Items.Add(Dr.GetString(0))
        End While
        Da = New OleDbDataAdapter("select * from table_lelangagunan", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "table_lelangagunan")
        dgvDataAset.DataSource = (Ds.Tables("table_lelangagunan"))
        dgvDataAset.Columns("No").Visible = False
        dgvDataAset.Columns("Tautan lokasi").Visible = False
        Dr.Close()
    End Sub

    Private Sub cbxBank_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxBank.SelectionChangeCommitted
        Call Koneksi()
        Call ButtonDetail()
        Dim k As New DataView
        Dim kodeBank As String = cbxBank.SelectedItem
        Dim queryFilter As New OleDbCommand("SELECT * FROM table_lelangagunan Where Bank like '%" + kodeBank + "%'", Conn)
        Dim queryRekening As New OleDbCommand("SELECT COUNT(*) FROM table_lelangagunan Where Bank like '%" + kodeBank + "%'", Conn)
        Dim queryNilaiPokok As New OleDbCommand("SELECT SUM(table_lelangagunan.NilaiLimit) AS nilaiLimit FROM table_lelangagunan Where Bank like '%" + kodeBank + "%'", Conn)
        Da.SelectCommand = queryFilter
        DataSet.Clear()
        Da.Fill(DataSet)
        dgvDataAset.DataSource = DataSet
        Dim jumlahRekening As Integer = queryRekening.ExecuteScalar()
        Dim nilaiPokok As Int64 = queryNilaiPokok.ExecuteScalar()
        Dim formattedValue As String = String.Format("{0:n}", nilaiPokok)
        txtJumlahRekening.Text = jumlahRekening
        txtNilaiPokok.Text = "Rp. " + formattedValue
        dgvDataAset.Columns("No").Visible = False
        dgvDataAset.Columns("Tautan lokasi").Visible = False
        Conn.Close()
    End Sub

    Public Sub dgvDataAset_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDataAset.CellClick
        NoID = dgvDataAset.CurrentRow.Cells("No").Value
        If dgvDataAset.Columns(e.ColumnIndex).HeaderText = "Detail" Then
            FormDetil.Show()
        End If
    End Sub
End Class
