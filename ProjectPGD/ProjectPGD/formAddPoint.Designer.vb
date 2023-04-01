<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddPoint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAddPoint))
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.txtShapeIndex = New System.Windows.Forms.TextBox()
        Me.txtFoto = New System.Windows.Forms.TextBox()
        Me.txtLokasi = New System.Windows.Forms.TextBox()
        Me.txtJenisKantor = New System.Windows.Forms.TextBox()
        Me.txtNamaKantor = New System.Windows.Forms.TextBox()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.cmdFullExtent = New System.Windows.Forms.Button()
        Me.cmdPan = New System.Windows.Forms.Button()
        Me.cmdZoomOut = New System.Windows.Forms.Button()
        Me.cmdZoomIn = New System.Windows.Forms.Button()
        Me.lblFoto = New System.Windows.Forms.Label()
        Me.lblJenisKantor = New System.Windows.Forms.Label()
        Me.lblLokasi = New System.Windows.Forms.Label()
        Me.lblNamaKantor = New System.Windows.Forms.Label()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.Map1 = New DotSpatial.Controls.Map()
        Me.rdoTitik_Cursor = New System.Windows.Forms.RadioButton()
        Me.rdoTitik_Keyboard = New System.Windows.Forms.RadioButton()
        Me.lblTitik_X = New System.Windows.Forms.Label()
        Me.lblTitik_Y = New System.Windows.Forms.Label()
        Me.txtTitik_X = New System.Windows.Forms.TextBox()
        Me.txtTitik_Y = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(423, 420)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(63, 21)
        Me.cmdCancel.TabIndex = 42
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(339, 420)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(63, 21)
        Me.cmdSave.TabIndex = 41
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(414, 389)
        Me.cmdBrowse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(72, 21)
        Me.cmdBrowse.TabIndex = 39
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'txtShapeIndex
        '
        Me.txtShapeIndex.Location = New System.Drawing.Point(27, 424)
        Me.txtShapeIndex.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtShapeIndex.Name = "txtShapeIndex"
        Me.txtShapeIndex.Size = New System.Drawing.Size(93, 20)
        Me.txtShapeIndex.TabIndex = 38
        '
        'txtFoto
        '
        Me.txtFoto.Location = New System.Drawing.Point(171, 389)
        Me.txtFoto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFoto.Name = "txtFoto"
        Me.txtFoto.Size = New System.Drawing.Size(232, 20)
        Me.txtFoto.TabIndex = 37
        '
        'txtLokasi
        '
        Me.txtLokasi.Location = New System.Drawing.Point(171, 354)
        Me.txtLokasi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLokasi.Name = "txtLokasi"
        Me.txtLokasi.Size = New System.Drawing.Size(316, 20)
        Me.txtLokasi.TabIndex = 36
        '
        'txtJenisKantor
        '
        Me.txtJenisKantor.Location = New System.Drawing.Point(171, 317)
        Me.txtJenisKantor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtJenisKantor.Name = "txtJenisKantor"
        Me.txtJenisKantor.Size = New System.Drawing.Size(316, 20)
        Me.txtJenisKantor.TabIndex = 35
        '
        'txtNamaKantor
        '
        Me.txtNamaKantor.Location = New System.Drawing.Point(171, 280)
        Me.txtNamaKantor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNamaKantor.Name = "txtNamaKantor"
        Me.txtNamaKantor.Size = New System.Drawing.Size(316, 20)
        Me.txtNamaKantor.TabIndex = 34
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(171, 245)
        Me.txtKode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(316, 20)
        Me.txtKode.TabIndex = 33
        '
        'cmdFullExtent
        '
        Me.cmdFullExtent.Location = New System.Drawing.Point(422, 198)
        Me.cmdFullExtent.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdFullExtent.Name = "cmdFullExtent"
        Me.cmdFullExtent.Size = New System.Drawing.Size(64, 23)
        Me.cmdFullExtent.TabIndex = 32
        Me.cmdFullExtent.Text = "Full Extent"
        Me.cmdFullExtent.UseVisualStyleBackColor = True
        '
        'cmdPan
        '
        Me.cmdPan.Location = New System.Drawing.Point(422, 159)
        Me.cmdPan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdPan.Name = "cmdPan"
        Me.cmdPan.Size = New System.Drawing.Size(64, 25)
        Me.cmdPan.TabIndex = 31
        Me.cmdPan.Text = "Pan"
        Me.cmdPan.UseVisualStyleBackColor = True
        '
        'cmdZoomOut
        '
        Me.cmdZoomOut.Location = New System.Drawing.Point(422, 114)
        Me.cmdZoomOut.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdZoomOut.Name = "cmdZoomOut"
        Me.cmdZoomOut.Size = New System.Drawing.Size(64, 23)
        Me.cmdZoomOut.TabIndex = 30
        Me.cmdZoomOut.Text = "Zoom Out"
        Me.cmdZoomOut.UseVisualStyleBackColor = True
        '
        'cmdZoomIn
        '
        Me.cmdZoomIn.Location = New System.Drawing.Point(422, 74)
        Me.cmdZoomIn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdZoomIn.Name = "cmdZoomIn"
        Me.cmdZoomIn.Size = New System.Drawing.Size(64, 21)
        Me.cmdZoomIn.TabIndex = 29
        Me.cmdZoomIn.Text = "Zoom In"
        Me.cmdZoomIn.UseVisualStyleBackColor = True
        '
        'lblFoto
        '
        Me.lblFoto.AutoSize = True
        Me.lblFoto.Location = New System.Drawing.Point(35, 389)
        Me.lblFoto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFoto.Name = "lblFoto"
        Me.lblFoto.Size = New System.Drawing.Size(28, 13)
        Me.lblFoto.TabIndex = 28
        Me.lblFoto.Text = "Foto"
        '
        'lblJenisKantor
        '
        Me.lblJenisKantor.AutoSize = True
        Me.lblJenisKantor.Location = New System.Drawing.Point(31, 317)
        Me.lblJenisKantor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblJenisKantor.Name = "lblJenisKantor"
        Me.lblJenisKantor.Size = New System.Drawing.Size(65, 13)
        Me.lblJenisKantor.TabIndex = 27
        Me.lblJenisKantor.Text = "Jenis Kantor"
        '
        'lblLokasi
        '
        Me.lblLokasi.AutoSize = True
        Me.lblLokasi.Location = New System.Drawing.Point(35, 354)
        Me.lblLokasi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLokasi.Name = "lblLokasi"
        Me.lblLokasi.Size = New System.Drawing.Size(38, 13)
        Me.lblLokasi.TabIndex = 26
        Me.lblLokasi.Text = "Lokasi"
        '
        'lblNamaKantor
        '
        Me.lblNamaKantor.AutoSize = True
        Me.lblNamaKantor.Location = New System.Drawing.Point(31, 280)
        Me.lblNamaKantor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNamaKantor.Name = "lblNamaKantor"
        Me.lblNamaKantor.Size = New System.Drawing.Size(69, 13)
        Me.lblNamaKantor.TabIndex = 25
        Me.lblNamaKantor.Text = "Nama Kantor"
        '
        'lblKode
        '
        Me.lblKode.AutoSize = True
        Me.lblKode.Location = New System.Drawing.Point(35, 245)
        Me.lblKode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(32, 13)
        Me.lblKode.TabIndex = 24
        Me.lblKode.Text = "Kode"
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
        Me.Map1.Location = New System.Drawing.Point(27, 74)
        Me.Map1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Map1.Name = "Map1"
        Me.Map1.ProgressHandler = Nothing
        Me.Map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt
        Me.Map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt
        Me.Map1.RedrawLayersWhileResizing = False
        Me.Map1.SelectionEnabled = True
        Me.Map1.Size = New System.Drawing.Size(348, 159)
        Me.Map1.TabIndex = 23
        '
        'rdoTitik_Cursor
        '
        Me.rdoTitik_Cursor.AutoSize = True
        Me.rdoTitik_Cursor.Location = New System.Drawing.Point(27, 18)
        Me.rdoTitik_Cursor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoTitik_Cursor.Name = "rdoTitik_Cursor"
        Me.rdoTitik_Cursor.Size = New System.Drawing.Size(212, 17)
        Me.rdoTitik_Cursor.TabIndex = 43
        Me.rdoTitik_Cursor.TabStop = True
        Me.rdoTitik_Cursor.Text = "Digitasi on screen menggunakan cursor"
        Me.rdoTitik_Cursor.UseVisualStyleBackColor = True
        '
        'rdoTitik_Keyboard
        '
        Me.rdoTitik_Keyboard.AutoSize = True
        Me.rdoTitik_Keyboard.Location = New System.Drawing.Point(27, 46)
        Me.rdoTitik_Keyboard.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoTitik_Keyboard.Name = "rdoTitik_Keyboard"
        Me.rdoTitik_Keyboard.Size = New System.Drawing.Size(167, 17)
        Me.rdoTitik_Keyboard.TabIndex = 44
        Me.rdoTitik_Keyboard.TabStop = True
        Me.rdoTitik_Keyboard.Text = "Input menggunakan keyboard"
        Me.rdoTitik_Keyboard.UseVisualStyleBackColor = True
        '
        'lblTitik_X
        '
        Me.lblTitik_X.AutoSize = True
        Me.lblTitik_X.Location = New System.Drawing.Point(248, 49)
        Me.lblTitik_X.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitik_X.Name = "lblTitik_X"
        Me.lblTitik_X.Size = New System.Drawing.Size(14, 13)
        Me.lblTitik_X.TabIndex = 45
        Me.lblTitik_X.Text = "X"
        '
        'lblTitik_Y
        '
        Me.lblTitik_Y.AutoSize = True
        Me.lblTitik_Y.Location = New System.Drawing.Point(377, 49)
        Me.lblTitik_Y.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitik_Y.Name = "lblTitik_Y"
        Me.lblTitik_Y.Size = New System.Drawing.Size(14, 13)
        Me.lblTitik_Y.TabIndex = 46
        Me.lblTitik_Y.Text = "Y"
        '
        'txtTitik_X
        '
        Me.txtTitik_X.Location = New System.Drawing.Point(265, 47)
        Me.txtTitik_X.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTitik_X.Name = "txtTitik_X"
        Me.txtTitik_X.Size = New System.Drawing.Size(93, 20)
        Me.txtTitik_X.TabIndex = 47
        '
        'txtTitik_Y
        '
        Me.txtTitik_Y.Location = New System.Drawing.Point(394, 45)
        Me.txtTitik_Y.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTitik_Y.Name = "txtTitik_Y"
        Me.txtTitik_Y.Size = New System.Drawing.Size(93, 20)
        Me.txtTitik_Y.TabIndex = 48
        '
        'formAddPoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 460)
        Me.Controls.Add(Me.txtTitik_Y)
        Me.Controls.Add(Me.txtTitik_X)
        Me.Controls.Add(Me.lblTitik_Y)
        Me.Controls.Add(Me.lblTitik_X)
        Me.Controls.Add(Me.rdoTitik_Keyboard)
        Me.Controls.Add(Me.rdoTitik_Cursor)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "formAddPoint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Data Kantor Pemerintahan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents txtShapeIndex As TextBox
    Friend WithEvents txtFoto As TextBox
    Friend WithEvents txtLokasi As TextBox
    Friend WithEvents txtJenisKantor As TextBox
    Friend WithEvents txtNamaKantor As TextBox
    Friend WithEvents txtKode As TextBox
    Friend WithEvents cmdFullExtent As Button
    Friend WithEvents cmdPan As Button
    Friend WithEvents cmdZoomOut As Button
    Friend WithEvents cmdZoomIn As Button
    Friend WithEvents lblFoto As Label
    Friend WithEvents lblJenisKantor As Label
    Friend WithEvents lblLokasi As Label
    Friend WithEvents lblNamaKantor As Label
    Friend WithEvents lblKode As Label
    Friend WithEvents Map1 As DotSpatial.Controls.Map
    Friend WithEvents rdoTitik_Cursor As RadioButton
    Friend WithEvents rdoTitik_Keyboard As RadioButton
    Friend WithEvents lblTitik_X As Label
    Friend WithEvents lblTitik_Y As Label
    Friend WithEvents txtTitik_X As TextBox
    Friend WithEvents txtTitik_Y As TextBox
End Class
