Imports System.IO
Imports DotSpatial.Controls
Imports DotSpatial.Data
Imports DotSpatial.Symbology
Imports DotSpatial.Topology


Public Class Form1
    Public AppPath As String = Application.ExecutablePath
    Public ResourcesPath As String = Directory.GetParent(AppPath).ToString
    Public lyrKantorPemerintahan As MapPointLayer
    Public lyrJalan As MapLineLayer
    Public lyrAdmin As MapPolygonLayer
    Public iselect(,) As String
    Public iselectnumd As Integer = 0
    Public totalselected As Integer
    Public selectnext As String = "salah"
    Public fullextentclick As String = "salah"
    Public sedangload As Boolean = False
    Public pointLayerTemplate As MapPointLayer
    Public pointFeatureTemplate As New FeatureSet(FeatureType.Point)
    Public Property KryptonRibbonGroupButton_MeasureLength As Object
    Public Property KryptonRibbonGroupButton_MeasureArea As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sedangload = True

        'ADD LAYER BATAS ADMIN
        lyrAdmin = Map1.Layers.Add(ResourcesPath & "\Database\Spatial\ADMINISTRASIDESA_AR_25K.shp")
        lyrAdmin.LegendText = "Batas Administrasi"
        'lyrAdmin.FeatureSet.AddFid()
        'lyrAdmin.FeatureSet.Save()
        lyrAdmin.SelectionEnabled = False

        Dim schemeAdmin As New PolygonScheme
        schemeAdmin.EditorSettings.ClassificationType = ClassificationType.UniqueValues
        schemeAdmin.EditorSettings.UseGradient = False
        schemeAdmin.EditorSettings.FieldName = "Kabupaten"
        'schemeAdmin.CreateCategories(lyrAdmin.DataSet.DataTable)

        For Each ifc As IFeatureCategory In schemeAdmin.GetCategories
            ifc.SetColor(Color.FromArgb(255, ifc.GetColor))
        Next

        lyrAdmin.Symbology = schemeAdmin

        'ADD LAYER JALAN
        lyrJalan = Map1.Layers.Add(ResourcesPath & "\Database\Spatial\JALAN_LN_25K.shp")
        lyrJalan.LegendText = "Jaringan Jalan"
        'lyrJalan.FeatureSet.AddFid()
        'lyrJalan.FeatureSet.Save()
        lyrJalan.SelectionEnabled = False

        Dim schemeJalan As New LineScheme
        schemeJalan.ClearCategories()

        Dim symbolizerJalanArteri As New LineSymbolizer(Color.FromArgb(255, 127, 0), Color.Gray, 3, Drawing2D.DashStyle.Solid, Drawing2D.LineCap.Flat)
        symbolizerJalanArteri.ScaleMode = ScaleMode.Simple
        Dim categoryJalanArteri As New LineCategory(symbolizerJalanArteri)
        categoryJalanArteri.FilterExpression = "[REMARK] = 'Jalan_Arteri'"
        categoryJalanArteri.LegendText = "Jalan_Arteri"
        schemeJalan.AddCategory(categoryJalanArteri)

        Dim symbolizerLokal As New LineSymbolizer(Color.FromArgb(178, 178, 255), Color.Transparent, 2, Drawing2D.DashStyle.Solid, Drawing2D.LineCap.Flat)
        symbolizerLokal.ScaleMode = ScaleMode.Simple
        Dim categoryLokal As New LineCategory(symbolizerLokal)
        categoryLokal.FilterExpression = "[REMARK] = 'Jalan_Lokal'"
        categoryLokal.LegendText = "Jalan_Lokal"
        schemeJalan.AddCategory(categoryLokal)

        Dim symbolizerLain As New LineSymbolizer(Color.FromArgb(232, 190, 255), Color.Transparent, 1.5, Drawing2D.DashStyle.Solid, Drawing2D.LineCap.Flat)
        symbolizerLain.ScaleMode = ScaleMode.Simple
        Dim categoryLain As New LineCategory(symbolizerLain)
        categoryLain.FilterExpression = "[REMARK] = 'Jalan_Lain'"
        categoryLain.LegendText = "Jalan_Lain"
        schemeJalan.AddCategory(categoryLain)

        For Each ifc As IFeatureCategory In schemeJalan.GetCategories
            ifc.SetColor(Color.FromArgb(255, ifc.GetColor))
        Next

        lyrJalan.Symbology = schemeJalan

        'ADD LAYER KANTOR PEMERINTAHAN
        lyrKantorPemerintahan = Map1.Layers.Add(ResourcesPath & "\Database\Spatial\PEMERINTAHAN_PT_25K.shp")
        lyrKantorPemerintahan.LegendText = "Kantor_Pemerintahan"
        'lyrKantorPemerintahan.FeatureSet.AddFid()
        'lyrKantorPemerintahan.FeatureSet.Save()

        Dim schemeKantorPemerintahan As New PointScheme
        schemeKantorPemerintahan.ClearCategories()

        Dim imageKantorGubernur As Image = Image.FromFile(ResourcesPath & "\Database\NonSpatial\Icon\IconKantorGubernur.png", False)
        Dim symbolizerKantorGubernur As New PointSymbolizer(imageKantorGubernur, 20)
        symbolizerKantorGubernur.ScaleMode = ScaleMode.Simple
        Dim categoryKantorGubernur As New PointCategory(symbolizerKantorGubernur)
        categoryKantorGubernur.FilterExpression = "[REMARK] = 'Kantor_Gubernur'"
        categoryKantorGubernur.LegendText = "Kantor_Gubernur"
        schemeKantorPemerintahan.AddCategory(categoryKantorGubernur)

        Dim imageKantorWalikota As Image = Image.FromFile(ResourcesPath & "\Database\NonSpatial\Icon\IconKantorWaliKota.jpg", False)
        Dim symbolizerKantorWalikota As New PointSymbolizer(imageKantorWalikota, 20)
        symbolizerKantorWalikota.ScaleMode = ScaleMode.Simple
        Dim categoryKantorWalikota As New PointCategory(symbolizerKantorWalikota)
        categoryKantorWalikota.FilterExpression = "[REMARK] = 'Kantor_WaliKota'"
        categoryKantorWalikota.LegendText = "Kantor_WaliKota"
        schemeKantorPemerintahan.AddCategory(categoryKantorWalikota)

        Dim imageKantorLurah As Image = Image.FromFile(ResourcesPath & "\Database\NonSpatial\Icon\IconKantorLurah.jpg", False)
        Dim symbolizerKantorLurah As New PointSymbolizer(imageKantorLurah, 20)
        symbolizerKantorLurah.ScaleMode = ScaleMode.Simple
        Dim categoryKantorLurah As New PointCategory(symbolizerKantorLurah)
        categoryKantorLurah.FilterExpression = "[REMARK] = 'Kantor_Lurah'"
        categoryKantorLurah.LegendText = "Kantor_Lurah"
        schemeKantorPemerintahan.AddCategory(categoryKantorLurah)

        Dim imageKantorCamat As Image = Image.FromFile(ResourcesPath & "\Database\NonSpatial\Icon\IconKantorCamat.jpg", False)
        Dim symbolizerKantorCamat As New PointSymbolizer(imageKantorCamat, 20)
        symbolizerKantorCamat.ScaleMode = ScaleMode.Simple
        Dim categoryKantorCamat As New PointCategory(symbolizerKantorCamat)
        categoryKantorCamat.FilterExpression = "[REMARK] = 'Kantor_Camat'"
        categoryKantorCamat.LegendText = "Kantor_Camat"
        schemeKantorPemerintahan.AddCategory(categoryKantorCamat)

        'lyrKantorPemerintahan.Symbology = schemeKantorPemerintahan

        'ADD LAYER TEMPLATE
        pointLayerTemplate = Map1.Layers.Add(pointFeatureTemplate)
        Dim pointttsymbol As New PointSymbolizer(Color.FromArgb(175, 75, 230, 0), DotSpatial.Symbology.PointShape.Star, 12)
        pointLayerTemplate.Symbolizer = pointttsymbol
        pointLayerTemplate.LegendText = "point template"
        pointLayerTemplate.LegendItemVisible = False

        'LOAD ATTRIBUTE
        Dim dt As DataTable
        dt = lyrKantorPemerintahan.DataSet.DataTable
        DataGridView1.DataSource = dt

        'LOAD DATA QUERY
        lyrAdmin.SelectAll()

        Dim ls1 As List(Of IFeature) = New List(Of IFeature)
        Dim il1 As ISelection = lyrAdmin.Selection

        ls1 = il1.ToFeatureList

        KryptonRibbonGroupComboBoxQueryKecamatan.Items.Clear()
        Dim i As Integer = 0
        Do While (i < il1.Count)
            Dim Name As String = (ls1(i).DataRow.ItemArray.GetValue(18).ToString)
            KryptonRibbonGroupComboBoxQueryKecamatan.Items.Insert(i, Name)
            i = (i + 1)
        Loop

        KryptonRibbonGroupComboBoxQueryKecamatan.Sorted = True
        Dim cboNumber As Integer = KryptonRibbonGroupComboBoxQueryKecamatan.Items.Count - 1
        Try
            For j = 1 To cboNumber
                If j > (KryptonRibbonGroupComboBoxQueryKecamatan.Items.Count - 1) Then Exit For
                If KryptonRibbonGroupComboBoxQueryKecamatan.Items(j) = KryptonRibbonGroupComboBoxQueryKecamatan.Items(j - 1) Then
                    KryptonRibbonGroupComboBoxQueryKecamatan.Items.RemoveAt(j)
                    j = j - 1
                    cboNumber = cboNumber - 1
                End If
            Next
        Catch ex As Exception

        End Try

        KryptonRibbonGroupComboBoxQueryKecamatan.Sorted = True

        lyrAdmin.UnSelectAll()

        sedangload = False

    End Sub

    Private Sub Map1_SelectionChanged(sender As Object, e As EventArgs) Handles Map1.SelectionChanged
        Try
            If sedangload = True Then Exit Sub
            If KryptonRibbonGroupButton_Identify.Checked = True Then
                If lyrKantorPemerintahan.Selection.Count = 0 Then
                    Call RemoveSelection()
                    Exit Sub
                Else
                    formPopUp.Show()
                    Call ShowPhoto()
                    formPopUp.BringToFront()
                    formPopUp.Activate()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Map1_MouseMove(sender As Object, e As MouseEventArgs) Handles TabControl2.MouseMove
        Try
            Dim coord As Coordinate = Map1.PixelToProj(e.Location)
            lblXY.Text = String.Format("X: {0} Y: {1}", coord.X, coord.Y)
        Catch ex As Exception
            MsgBox("Mohon maaf, sedang terjadi kesalahan. " & ex.ToString & ". Error Number (" & Err.Number & ")
            : " & vbCrLf & Err.Description, MsgBoxStyle.Critical, "SIM Kantor Pemerintahan Kota Yogyakarta")
        End Try
    End Sub

    Private Sub Map1_MouseUp(sender As Object, e As MouseEventArgs) Handles TabControl2.MouseUp
        If KryptonRibbonGroupButton_AddPoint.Checked = True And Map1.Cursor = Cursors.Cross Then
            If formAddPoint.rdoTitik_Cursor.Checked = True Then
                If e.Button = MouseButtons.Left Then
                    sedangload = True
                    pointLayerTemplate.SelectAll()
                    pointLayerTemplate.RemoveSelectedFeatures()
                    Dim coord As Coordinate = Map1.PixelToProj(e.Location)
                    Dim point As New DotSpatial.Topology.Point(coord)
                    Dim currentFeature As IFeature = pointFeatureTemplate.AddFeature(point)
                    formAddPoint.txtTitik_X.Text = coord.X
                    formAddPoint.txtTitik_Y.Text = coord.Y
                    sedangload = False
                End If
                pointFeatureTemplate.InitializeVertices()
                pointLayerTemplate.DataSet.InitializeVertices()
                pointLayerTemplate.AssignFastDrawnStates()
                pointFeatureTemplate.UpdateExtent()
                pointLayerTemplate.DataSet.UpdateExtent()
                Map1.Refresh()
                Map1.ResetBuffer()
            End If
        End If
    End Sub

    'CURSOR MODE
    Private Sub KryptonRibbonGroupButton_NormalMode_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_NormalMode.Click
        If KryptonRibbonGroupButton_NormalMode.Checked = True Then
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
            KryptonRibbonGroupButton_ZoomInMode.Checked = False
            KryptonRibbonGroupButton_ZoomOutMode.Checked = False
            KryptonRibbonGroupButton_PanMode.Checked = False
            'KryptonRibbonGroupButton_MeasureLength.Checked = False
            'KryptonRibbonGroupButton_MeasureArea.Checked = False
            KryptonRibbonGroupButton_AddPoint.Checked = False
            KryptonRibbonGroupButton_Identify.Checked = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        End If
    End Sub

    Private Sub KryptonRibbonGroupButton_ZoomInMode_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_ZoomInMode.Click
        If KryptonRibbonGroupButton_ZoomInMode.Checked = True Then
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomIn
            KryptonRibbonGroupButton_NormalMode.Checked = False
            KryptonRibbonGroupButton_ZoomOutMode.Checked = False
            KryptonRibbonGroupButton_PanMode.Checked = False
            'KryptonRibbonGroupButton_MeasureLength.Checked = False
            'KryptonRibbonGroupButton_MeasureArea.Checked = False
            KryptonRibbonGroupButton_AddPoint.Checked = False
            KryptonRibbonGroupButton_Identify.Checked = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        End If
    End Sub

    Private Sub KryptonRibbonGroupButton_ZoomOutMode_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_ZoomOutMode.Click
        If KryptonRibbonGroupButton_ZoomOutMode.Checked = True Then
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomOut
            KryptonRibbonGroupButton_NormalMode.Checked = False
            KryptonRibbonGroupButton_ZoomInMode.Checked = False
            KryptonRibbonGroupButton_PanMode.Checked = False
            'KryptonRibbonGroupButton_MeasureLength.Checked = False
            'KryptonRibbonGroupButton_MeasureArea.Checked = False
            KryptonRibbonGroupButton_AddPoint.Checked = False
            KryptonRibbonGroupButton_Identify.Checked = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        End If
    End Sub

    Private Sub KryptonRibbonGroupButton_PanMode_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_PanMode.Click
        If KryptonRibbonGroupButton_PanMode.Checked = True Then
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.Pan
            KryptonRibbonGroupButton_NormalMode.Checked = False
            KryptonRibbonGroupButton_ZoomInMode.Checked = False
            KryptonRibbonGroupButton_ZoomOutMode.Checked = False
            'KryptonRibbonGroupButton_MeasureLength.Checked = False
            'KryptonRibbonGroupButton_MeasureArea.Checked = False
            KryptonRibbonGroupButton_AddPoint.Checked = False
            KryptonRibbonGroupButton_Identify.Checked = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        End If
    End Sub

    'IDENTIFY
    Private Sub KryptonRibbonGroupButton_Identify_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_Identify.Click
        If KryptonRibbonGroupButton_Identify.Checked = True Then
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.Select
            KryptonRibbonGroupButton_NormalMode.Checked = False
            KryptonRibbonGroupButton_ZoomInMode.Checked = False
            KryptonRibbonGroupButton_ZoomOutMode.Checked = False
            KryptonRibbonGroupButton_PanMode.Checked = False
            'KryptonRibbonGroupButton_MeasureLength.Checked = False
            'KryptonRibbonGroupButton_MeasureArea.Checked = False
            KryptonRibbonGroupButton_AddPoint.Checked = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        End If
    End Sub

    'EDIT
    Private Sub KryptonRibbonGroupButton_AddPoint_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_AddPoint.Click

        KryptonRibbonGroupButton_AddPoint.Checked = True

        If KryptonRibbonGroupButton_AddPoint.Checked = True Then

            Map1.Cursor = Cursors.Cross
            formAddPoint.Show()
            formAddPoint.BringToFront()
            formAddPoint.Activate()
            KryptonRibbonGroupButton_NormalMode.Checked = False
            KryptonRibbonGroupButton_ZoomInMode.Checked = False
            KryptonRibbonGroupButton_ZoomOutMode.Checked = False
            KryptonRibbonGroupButton_PanMode.Checked = False
            'KryptonRibbonGroupButton_MeasureLength.Checked = False
            'KryptonRibbonGroupButton_MeasureArea.Checked = False
            KryptonRibbonGroupButton_Identify.Checked = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        End If
    End Sub

    'ZOOMING
    Private Sub KryptonRibbonGroupButton_ZoomIn_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_ZoomIn.Click
        Map1.ZoomIn()
    End Sub

    Private Sub KryptonRibbonGroupButton_ZoomOut_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_ZoomOut.Click
        Map1.ZoomOut()
    End Sub

    Private Sub KryptonRibbonGroupButton_FullExtent_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_FullExtent.Click
        Map1.ZoomToMaxExtent()
    End Sub

    Private Sub KryptonRibbonGroupButton_Preview_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_Preview.Click
        Map1.ZoomToPrevious()
    End Sub

    Private Sub KryptonRibbonGroupButton_Next_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_Next.Click
        Map1.ZoomToNext()
    End Sub

    'QUERY
    Private Sub KryptonRibbonGroupComboBoxQueryKecamatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KryptonRibbonGroupComboBoxQueryKecamatan.SelectedIndexChanged
        If KryptonRibbonGroupComboBoxQueryKecamatan.Text = "Cari Kecamatan" Then Exit Sub

        sedangload = True

        Dim StrKecamatan As String = KryptonRibbonGroupComboBoxQueryKecamatan.Text
        lyrAdmin.SelectByAttribute("[WADMKC] = '" & StrKecamatan & "'")
        lyrAdmin.ZoomToSelectedFeatures(0.01, 0.01)
        Map1.Refresh()

        Dim ls1 As List(Of IFeature) = New List(Of IFeature)
        Dim il1 As ISelection = lyrAdmin.Selection

        ls1 = il1.ToFeatureList

        KryptonRibbonGroupComboBoxQueryKelurahan.Items.Clear()
        Dim i As Integer = 0
        Do While (i < il1.Count)
            Dim Name As String = (ls1(i).DataRow.ItemArray.GetValue(1).ToString)
            KryptonRibbonGroupComboBoxQueryKelurahan.Items.Insert(i, Name)
            i = (i + 1)
        Loop

        KryptonRibbonGroupComboBoxQueryKelurahan.Sorted = True
        Dim cboNumber As Integer = KryptonRibbonGroupComboBoxQueryKelurahan.Items.Count - 1
        Try
            For j = 1 To cboNumber
                If j > (KryptonRibbonGroupComboBoxQueryKelurahan.Items.Count - 1) Then Exit For
                If KryptonRibbonGroupComboBoxQueryKelurahan.Items(j) = KryptonRibbonGroupComboBoxQueryKelurahan.Items(j - 1) Then
                    KryptonRibbonGroupComboBoxQueryKelurahan.Items.RemoveAt(j)
                    j = j - 1
                    cboNumber = cboNumber - 1
                End If
            Next
        Catch ex As Exception
        End Try

        KryptonRibbonGroupComboBoxQueryKelurahan.Sorted = True
        'lyrAdmin.UnSelectAll()
        sedangload = False

    End Sub

    Private Sub KryptonRibbonGroupComboBoxQueryKelurahan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KryptonRibbonGroupComboBoxQueryKelurahan.SelectedIndexChanged
        If KryptonRibbonGroupComboBoxQueryKecamatan.Text = "Cari Kecamatan" Then Exit Sub
        If KryptonRibbonGroupComboBoxQueryKelurahan.Text = "Cari Kelurahan" Then Exit Sub


        sedangload = True

        Dim StrKecamatan As String = KryptonRibbonGroupComboBoxQueryKecamatan.Text
        Dim StrKelurahan As String = KryptonRibbonGroupComboBoxQueryKelurahan.Text
        Dim StrKantorPemerintahan As String = KryptonRibbonGroupComboBoxQueryCariPemerintahan.Text
        'lyrAdmin.SelectByAttribute("[WADMKC] = '" & StrKecamatan & "' AND [NAMOBJ] = '" & StrKelurahan & "'")
        lyrAdmin.ZoomToSelectedFeatures(0.01, 0.01)
        Map1.Refresh()


        lyrKantorPemerintahan.SelectByAttribute("[WADMKC] = '" & StrKecamatan & "' ")'AND [kelurahan] = '" & StrKelurahan & "'  AND [REMARK] = '" & StrKantorPemerintahan & "' ")
        'MessageBox.Show(lyrKantorPemerintahan.ToString                   )
        Dim ls1 As List(Of IFeature) = New List(Of IFeature)
        Dim il1 As ISelection = lyrKantorPemerintahan.Selection

        ls1 = il1.ToFeatureList




        KryptonRibbonGroupComboBoxQueryCariPemerintahan.Items.Clear()
        Dim i As Integer = 0
        Do While (i < il1.Count)
            Dim Name As String = (ls1(i).DataRow.ItemArray.GetValue(2).ToString)
            MessageBox.Show(
        ls1(i).DataRow.ItemArray.ToString
        )
            KryptonRibbonGroupComboBoxQueryCariPemerintahan.Items.Insert(i, Name)
            i = (i + 1)
        Loop

        KryptonRibbonGroupComboBoxQueryCariPemerintahan.Sorted = True
        Dim cboNumber As Integer = KryptonRibbonGroupComboBoxQueryCariPemerintahan.Items.Count - 1
        Try
            For j = 1 To cboNumber
                If j > (KryptonRibbonGroupComboBoxQueryCariPemerintahan.Items.Count - 1) Then Exit For
                If KryptonRibbonGroupComboBoxQueryCariPemerintahan.Items(j) = KryptonRibbonGroupComboBoxQueryCariPemerintahan.Items(j - 1) Then
                    KryptonRibbonGroupComboBoxQueryCariPemerintahan.Items.RemoveAt(j)
                    j = j - 1
                    cboNumber = cboNumber - 1
                End If
            Next
        Catch ex As Exception
        End Try

        KryptonRibbonGroupComboBoxQueryCariPemerintahan.Sorted = True
        'lyrAdmin.UnSelectAll()
        sedangload = False
    End Sub

    Private Sub KryptonRibbonGroupComboBoxQueryCariPemerintahan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KryptonRibbonGroupComboBoxQueryCariPemerintahan.SelectedIndexChanged
        If KryptonRibbonGroupComboBoxQueryKecamatan.Text = "Cari Kecamatan" Then Exit Sub
        If KryptonRibbonGroupComboBoxQueryKelurahan.Text = "Cari Kelurahan" Then Exit Sub
        If KryptonRibbonGroupComboBoxQueryCariPemerintahan.Text = "Cari Pemerintahan" Then Exit Sub

        sedangload = True

        Dim StrKecamatan As String = KryptonRibbonGroupComboBoxQueryKecamatan.Text
        Dim StrKelurahan As String = KryptonRibbonGroupComboBoxQueryKelurahan.Text
        Dim StrPemerintahan As String = KryptonRibbonGroupComboBoxQueryCariPemerintahan.Text
        lyrKantorPemerintahan.SelectByAttribute("[WADMKC] = '" & StrKecamatan & "' AND [kelurahan] = '" & StrKelurahan & "' AND [REMARK] = '" & StrPemerintahan & "'")
        lyrKantorPemerintahan.ZoomToSelectedFeatures(0.01, 0.01)
        Map1.Refresh()

        lyrAdmin.UnSelectAll()

        sedangload = False
    End Sub

    'ATTRIBUTE
    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        sedangload = True
        If DataGridView1.SelectedRows.Count = 0 Then Exit Sub
        Map1.ClearSelection()
        lyrKantorPemerintahan.Select(CInt(DataGridView1.SelectedRows.Item(0).Cells.Item("FID").Value))
        lyrKantorPemerintahan.ZoomToSelectedFeatures(0.01, 0.01)
        Map1.Refresh()
        sedangload = False
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        sedangload = True
        If DataGridView1.SelectedRows.Count = 0 Then Exit Sub
        Map1.ClearSelection()
        For i = 0 To DataGridView1.SelectedRows.Count - 1
            lyrKantorPemerintahan.SelectByAttribute("[FID] =" & DataGridView1.SelectedRows.Item(i).Cells.Item("FID").Value)
            'lyrKantorPemerintahan.Select(CInt(DataGridView1.SelectedRows.Item(i).Cells.Item("FID").Value))
        Next
        lyrKantorPemerintahan.ZoomToSelectedFeatures(0.01, 0.01)
        Map1.Refresh()
        sedangload = True
    End Sub

    'POP UP
    Public Sub ShowPhoto()
        Try
            Dim ls1 As List(Of IFeature) = New List(Of IFeature)
            Dim il1 As ISelection = lyrKantorPemerintahan.Selection

            Dim dt As DataTable
            dt = lyrKantorPemerintahan.DataSet.DataTable

            Dim kode As String = ""
            Dim namakantor As String = ""
            Dim jeniskantor As String = ""
            Dim lokasi As String = ""
            Dim foto As String = ""
            Dim shapeindex As Integer = 0

            ls1 = il1.ToFeatureList

            kode = (ls1(0).DataRow.ItemArray.GetValue(1).ToString)
            namakantor = (ls1(0).DataRow.ItemArray.GetValue(5).ToString)
            jeniskantor = (ls1(0).DataRow.ItemArray.GetValue(8).ToString)
            lokasi = (ls1(0).DataRow.ItemArray.GetValue(10).ToString)
            foto = (ls1(0).DataRow.ItemArray.GetValue(40).ToString)
            shapeindex = (ls1(0).DataRow.ItemArray.GetValue(dt.Columns.Count - 1))
            formPopUp.txtKode.Text = kode
            formPopUp.txtNamaKantor.Text = namakantor
            formPopUp.txtJenisKantor.Text = jeniskantor
            formPopUp.txtLokasi.Text = lokasi
            formPopUp.txtFoto.Text = foto
            formPopUp.txtShapeIndex.Text = shapeindex

            Dim alamatfoto As String = ResourcesPath & "\Database\NonSpatial\Foto" & foto
            formPopUp.Map1.AddLayer(alamatfoto)

            If namakantor = "" Then
                Call RemoveSelection()
                Exit Sub
            End If

            Map1.Refresh()
            Me.Refresh()
            formPopUp.Refresh()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub RemoveSelection()
        Try
            formPopUp.txtKode.Text = ""
            formPopUp.txtNamaKantor.Text = ""
            formPopUp.txtJenisKantor.Text = ""
            formPopUp.txtLokasi.Text = ""
            formPopUp.txtFoto.Text = ""
            formPopUp.txtShapeIndex.Text = ""

            lyrAdmin.UnSelectAll()
            lyrKantorPemerintahan.UnSelectAll()

            formPopUp.Map1.ClearLayers()
            'DataAttribute.SelectedRow(0).Selected = False

            Me.Refresh()
            formPopUp.Refresh()

            sedangload = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub KryptonRibbon1_SelectedTabChanged(sender As Object, e As EventArgs) Handles KryptonRibbon1.SelectedTabChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
