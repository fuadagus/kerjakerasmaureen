<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPopUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPopUp))
        Me.lblInformasi = New System.Windows.Forms.Label()
        Me.Map1 = New DotSpatial.Controls.Map()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.lblNamaKantor = New System.Windows.Forms.Label()
        Me.lblLokasi = New System.Windows.Forms.Label()
        Me.lblJenisKantor = New System.Windows.Forms.Label()
        Me.lblFoto = New System.Windows.Forms.Label()
        Me.cmdZoomIn = New System.Windows.Forms.Button()
        Me.cmdZoomOut = New System.Windows.Forms.Button()
        Me.cmdPan = New System.Windows.Forms.Button()
        Me.cmdFullExtent = New System.Windows.Forms.Button()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.txtNamaKantor = New System.Windows.Forms.TextBox()
        Me.txtJenisKantor = New System.Windows.Forms.TextBox()
        Me.txtLokasi = New System.Windows.Forms.TextBox()
        Me.txtFoto = New System.Windows.Forms.TextBox()
        Me.txtShapeIndex = New System.Windows.Forms.TextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInformasi
        '
        Me.lblInformasi.AutoSize = True
        Me.lblInformasi.Location = New System.Drawing.Point(220, 19)
        Me.lblInformasi.Name = "lblInformasi"
        Me.lblInformasi.Size = New System.Drawing.Size(99, 20)
        Me.lblInformasi.TabIndex = 0
        Me.lblInformasi.Text = "INFORMASI"
        '
        'Map1
        '
        Me.Map1.AllowDrop = True
        Me.Map1.BackColor = System.Drawing.Color.White
        Me.Map1.CollectAfterDraw = False
        Me.Map1.CollisionDetection = False
        Me.Map1.ExtendBuffer = False
        Me.Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        Me.Map1.IsBusy = False
        Me.Map1.Legend = Nothing
        Me.Map1.Location = New System.Drawing.Point(63, 58)
        Me.Map1.Name = "Map1"
        Me.Map1.ProgressHandler = Nothing
        Me.Map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt
        Me.Map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt
        Me.Map1.RedrawLayersWhileResizing = False
        Me.Map1.SelectionEnabled = True
        Me.Map1.Size = New System.Drawing.Size(402, 249)
        Me.Map1.TabIndex = 1
        '
        'lblKode
        '
        Me.lblKode.AutoSize = True
        Me.lblKode.Location = New System.Drawing.Point(31, 341)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(46, 20)
        Me.lblKode.TabIndex = 2
        Me.lblKode.Text = "Kode"
        '
        'lblNamaKantor
        '
        Me.lblNamaKantor.AutoSize = True
        Me.lblNamaKantor.Location = New System.Drawing.Point(31, 392)
        Me.lblNamaKantor.Name = "lblNamaKantor"
        Me.lblNamaKantor.Size = New System.Drawing.Size(102, 20)
        Me.lblNamaKantor.TabIndex = 3
        Me.lblNamaKantor.Text = "Nama Kantor"
        '
        'lblLokasi
        '
        Me.lblLokasi.AutoSize = True
        Me.lblLokasi.Location = New System.Drawing.Point(31, 498)
        Me.lblLokasi.Name = "lblLokasi"
        Me.lblLokasi.Size = New System.Drawing.Size(55, 20)
        Me.lblLokasi.TabIndex = 4
        Me.lblLokasi.Text = "Lokasi"
        '
        'lblJenisKantor
        '
        Me.lblJenisKantor.AutoSize = True
        Me.lblJenisKantor.Location = New System.Drawing.Point(31, 446)
        Me.lblJenisKantor.Name = "lblJenisKantor"
        Me.lblJenisKantor.Size = New System.Drawing.Size(97, 20)
        Me.lblJenisKantor.TabIndex = 5
        Me.lblJenisKantor.Text = "Jenis Kantor"
        '
        'lblFoto
        '
        Me.lblFoto.AutoSize = True
        Me.lblFoto.Location = New System.Drawing.Point(31, 557)
        Me.lblFoto.Name = "lblFoto"
        Me.lblFoto.Size = New System.Drawing.Size(42, 20)
        Me.lblFoto.TabIndex = 6
        Me.lblFoto.Text = "Foto"
        '
        'cmdZoomIn
        '
        Me.cmdZoomIn.Location = New System.Drawing.Point(487, 58)
        Me.cmdZoomIn.Name = "cmdZoomIn"
        Me.cmdZoomIn.Size = New System.Drawing.Size(96, 33)
        Me.cmdZoomIn.TabIndex = 7
        Me.cmdZoomIn.Text = "Zoom In"
        Me.cmdZoomIn.UseVisualStyleBackColor = True
        '
        'cmdZoomOut
        '
        Me.cmdZoomOut.Location = New System.Drawing.Point(487, 108)
        Me.cmdZoomOut.Name = "cmdZoomOut"
        Me.cmdZoomOut.Size = New System.Drawing.Size(96, 36)
        Me.cmdZoomOut.TabIndex = 8
        Me.cmdZoomOut.Text = "Zoom Out"
        Me.cmdZoomOut.UseVisualStyleBackColor = True
        '
        'cmdPan
        '
        Me.cmdPan.Location = New System.Drawing.Point(487, 162)
        Me.cmdPan.Name = "cmdPan"
        Me.cmdPan.Size = New System.Drawing.Size(96, 39)
        Me.cmdPan.TabIndex = 9
        Me.cmdPan.Text = "Pan"
        Me.cmdPan.UseVisualStyleBackColor = True
        '
        'cmdFullExtent
        '
        Me.cmdFullExtent.Location = New System.Drawing.Point(487, 220)
        Me.cmdFullExtent.Name = "cmdFullExtent"
        Me.cmdFullExtent.Size = New System.Drawing.Size(96, 36)
        Me.cmdFullExtent.TabIndex = 10
        Me.cmdFullExtent.Text = "Full Extent"
        Me.cmdFullExtent.UseVisualStyleBackColor = True
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(154, 335)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(382, 26)
        Me.txtKode.TabIndex = 12
        '
        'txtNamaKantor
        '
        Me.txtNamaKantor.Location = New System.Drawing.Point(154, 389)
        Me.txtNamaKantor.Name = "txtNamaKantor"
        Me.txtNamaKantor.Size = New System.Drawing.Size(382, 26)
        Me.txtNamaKantor.TabIndex = 13
        '
        'txtJenisKantor
        '
        Me.txtJenisKantor.Location = New System.Drawing.Point(154, 446)
        Me.txtJenisKantor.Name = "txtJenisKantor"
        Me.txtJenisKantor.Size = New System.Drawing.Size(382, 26)
        Me.txtJenisKantor.TabIndex = 14
        '
        'txtLokasi
        '
        Me.txtLokasi.Location = New System.Drawing.Point(154, 498)
        Me.txtLokasi.Name = "txtLokasi"
        Me.txtLokasi.Size = New System.Drawing.Size(382, 26)
        Me.txtLokasi.TabIndex = 15
        '
        'txtFoto
        '
        Me.txtFoto.Location = New System.Drawing.Point(154, 554)
        Me.txtFoto.Name = "txtFoto"
        Me.txtFoto.Size = New System.Drawing.Size(268, 26)
        Me.txtFoto.TabIndex = 16
        '
        'txtShapeIndex
        '
        Me.txtShapeIndex.Location = New System.Drawing.Point(12, 646)
        Me.txtShapeIndex.Name = "txtShapeIndex"
        Me.txtShapeIndex.Size = New System.Drawing.Size(104, 26)
        Me.txtShapeIndex.TabIndex = 17
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(428, 551)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(108, 33)
        Me.cmdBrowse.TabIndex = 18
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(154, 643)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(95, 32)
        Me.cmdDelete.TabIndex = 19
        Me.cmdDelete.Text = "Hapus"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(277, 643)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(95, 32)
        Me.cmdEdit.TabIndex = 20
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(405, 643)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(95, 32)
        Me.cmdCancel.TabIndex = 21
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'formPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 694)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtShapeIndex)
        Me.Controls.Add(Me.txtFoto)
        Me.Controls.Add(Me.txtLokasi)
        Me.Controls.Add(Me.txtJenisKantor)
        Me.Controls.Add(Me.txtNamaKantor)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.cmdFullExtent)
        Me.Controls.Add(Me.cmdPan)
        Me.Controls.Add(Me.cmdZoomOut)
        Me.Controls.Add(Me.cmdZoomIn)
        Me.Controls.Add(Me.lblFoto)
        Me.Controls.Add(Me.lblJenisKantor)
        Me.Controls.Add(Me.lblLokasi)
        Me.Controls.Add(Me.lblNamaKantor)
        Me.Controls.Add(Me.lblKode)
        Me.Controls.Add(Me.Map1)
        Me.Controls.Add(Me.lblInformasi)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formPopUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informasi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInformasi As Label
    Friend WithEvents Map1 As DotSpatial.Controls.Map
    Friend WithEvents lblKode As Label
    Friend WithEvents lblNamaKantor As Label
    Friend WithEvents lblLokasi As Label
    Friend WithEvents lblJenisKantor As Label
    Friend WithEvents lblFoto As Label
    Friend WithEvents cmdZoomIn As Button
    Friend WithEvents cmdZoomOut As Button
    Friend WithEvents cmdPan As Button
    Friend WithEvents cmdFullExtent As Button
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtNamaKantor As TextBox
    Friend WithEvents txtJenisKantor As TextBox
    Friend WithEvents txtLokasi As TextBox
    Friend WithEvents txtFoto As TextBox
    Friend WithEvents txtShapeIndex As TextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdCancel As Button
End Class
