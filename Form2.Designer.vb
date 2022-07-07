<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBank = New System.Windows.Forms.TextBox()
        Me.txtDebitur = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtJenisAgunan = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtDokumen = New System.Windows.Forms.TextBox()
        Me.txtLokasi = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(932, 58)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Aset"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtBank
        '
        Me.txtBank.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBank.Location = New System.Drawing.Point(195, 92)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.ReadOnly = True
        Me.txtBank.Size = New System.Drawing.Size(265, 20)
        Me.txtBank.TabIndex = 2
        '
        'txtDebitur
        '
        Me.txtDebitur.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDebitur.Location = New System.Drawing.Point(195, 136)
        Me.txtDebitur.Name = "txtDebitur"
        Me.txtDebitur.ReadOnly = True
        Me.txtDebitur.Size = New System.Drawing.Size(265, 20)
        Me.txtDebitur.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(21, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 28)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Bank"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(21, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Debitur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(21, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 28)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Jenis Agunan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(21, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 28)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Dokumen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(21, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 28)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Lokasi"
        '
        'txtJenisAgunan
        '
        Me.txtJenisAgunan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJenisAgunan.Location = New System.Drawing.Point(195, 180)
        Me.txtJenisAgunan.Name = "txtJenisAgunan"
        Me.txtJenisAgunan.ReadOnly = True
        Me.txtJenisAgunan.Size = New System.Drawing.Size(265, 20)
        Me.txtJenisAgunan.TabIndex = 10
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtDokumen
        '
        Me.txtDokumen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDokumen.Location = New System.Drawing.Point(195, 268)
        Me.txtDokumen.Multiline = True
        Me.txtDokumen.Name = "txtDokumen"
        Me.txtDokumen.ReadOnly = True
        Me.txtDokumen.Size = New System.Drawing.Size(265, 114)
        Me.txtDokumen.TabIndex = 12
        '
        'txtLokasi
        '
        Me.txtLokasi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLokasi.Location = New System.Drawing.Point(195, 224)
        Me.txtLokasi.Name = "txtLokasi"
        Me.txtLokasi.ReadOnly = True
        Me.txtLokasi.Size = New System.Drawing.Size(265, 20)
        Me.txtLokasi.TabIndex = 13
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(932, 552)
        Me.Controls.Add(Me.txtLokasi)
        Me.Controls.Add(Me.txtDokumen)
        Me.Controls.Add(Me.txtJenisAgunan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDebitur)
        Me.Controls.Add(Me.txtBank)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBank As TextBox
    Friend WithEvents txtDebitur As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtJenisAgunan As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtDokumen As TextBox
    Friend WithEvents txtLokasi As TextBox
End Class
