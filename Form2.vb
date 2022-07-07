Imports System.Data.OleDb
Imports LelangAgunan.Class1
Public Class Form2
    Dim Conn As OleDbConnection
    Dim Da As OleDbDataAdapter
    Dim Ds As DataSet
    Dim Dr As OleDbDataReader
    Dim LokasiDB As String
    Dim DataSet As New DataTable

    Sub Koneksi()
        LokasiDB = "provider=Microsoft.ACE.OLEDB.12.0; data source=DBLelangAgunan.mdb"
        Conn = New OleDbConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Dim queryDetil As New OleDbCommand
        queryDetil.CommandText = "SELECT * FROM table_fotoLokasi Where ID like '%" + NoID + "%'"
        queryDetil.Connection = Conn
        Dr = queryDetil.ExecuteReader
        Dr.Read()

        txtBank.Text = Dr("Bank")
        txtDebitur.Text = Dr("Debitur")
        txtLokasi.Text = Dr("Lokasi")
        txtJenisAgunan.Text = Dr("JenisAgunan")
        txtDokumen.Text = Dr("Dokumen")

    End Sub
End Class
