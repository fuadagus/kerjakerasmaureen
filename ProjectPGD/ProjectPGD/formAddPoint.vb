Imports DotSpatial.Data
Imports DotSpatial.Topology
Imports DotSpatial.Symbology
Imports System.IO
Public Class formAddPoint

    Private Sub cmdZoomIn_Click(sender As Object, e As EventArgs) Handles cmdZoomIn.Click
        Map1.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomIn
    End Sub

    Private Sub cmdZoomOut_Click(sender As Object, e As EventArgs) Handles cmdZoomOut.Click
        Map1.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomOut
    End Sub

    Private Sub cmdPan_Click(sender As Object, e As EventArgs) Handles cmdPan.Click
        Map1.FunctionMode = DotSpatial.Controls.FunctionMode.Pan
    End Sub

    Private Sub cmdFullExtent_Click(sender As Object, e As EventArgs) Handles cmdFullExtent.Click
        Map1.ZoomToMaxExtent()
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.Title = "Browse Photo"
        ofd.InitialDirectory = "C:\"
        ofd.Filter = "JPG (*.jpg)|*.jpg|JPEG (*.jpeg)|*.jpeg|PNG (*.png)|*.png|All fiels (*.*)|*.*"
        ofd.FilterIndex = 1
        ofd.RestoreDirectory = True

        If (ofd.ShowDialog() = DialogResult.OK) Then
            Dim fileName As String = Path.GetFileName(ofd.FileName)
            Dim sourcePath As String = Path.GetDirectoryName(ofd.FileName)
            Dim targetPath As String = Path.Combine(Form1.ResourcesPath, "Database/NonSpatial/Foto")
            Dim sourceFile As String = Path.Combine(sourcePath, fileName)
            Dim destFile As String = Path.Combine(targetPath, fileName)
            File.Copy(sourceFile, destFile, True)
            txtFoto.Text = fileName
            Map1.ClearLayers()
            Map1.AddLayer(destFile)
        Else
            MessageBox.Show("PILIH FOTO DULU YANG CAKEP YAK!", "Report", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        'Dim KantorPemerintahanFeatureSet As FeatureSet = Form1.lyrKantorPemerintahan.FeatureSet
        Dim KantorPemerintahanPoint As New DotSpatial.Topology.Point(CDbl(txtTitik_X.Text), CDbl(txtTitik_Y.Text))
        'Dim featureInserted As IFeature = KantorPemerintahanFeatureSet.AddFeature(KantorPemerintahanPoint)

        'featureInserted.DataRow.BeginEdit()
        'featureInserted.DataRow("nama_kantor") = txtNamaKantor.Text
        'featureInserted.DataRow("jenis_kantor") = txtJenisKantor.Text
        'featureInserted.DataRow("lokasi") = txtLokasi.Text
        'featureInserted.DataRow("foto") = txtFoto.Text

        'featureInserted.DataRow.EndEdit()
        'KantorPemerintahanFeatureSet.InitializeVertices()
        'KantorPemerintahanFeatureSet.UpdateExtent()
        'KantorPemerintahanFeatureSet.Save()

        Form1.lyrKantorPemerintahan.DataSet.InitializeVertices()
        Form1.lyrKantorPemerintahan.AssignFastDrawnStates()
        Form1.lyrKantorPemerintahan.DataSet.UpdateExtent()

        Dim dt As DataTable
        dt = Form1.lyrKantorPemerintahan.DataSet.DataTable
        dt.Columns.RemoveAt((dt.Columns.Count - 1))
        dt.AcceptChanges()
        Form1.lyrKantorPemerintahan.DataSet.Save()
        'Form1.lyrKantorPemerintahan.FeatureSet.AddFid()
        'Form1.lyrKantorPemerintahan.FetureSet.Save()

        Form1.pointLayerTemplate.SelectAll()
        Form1.pointLayerTemplate.RemoveSelectedFeatures()

        'Form1.pointLayerTemplate.InitializeVertices()
        'Form1.pointLayerTemplate.UpdateExtent()
        Form1.pointLayerTemplate.DataSet.InitializeVertices()
        Form1.pointLayerTemplate.AssignFastDrawnStates()
        Form1.pointLayerTemplate.DataSet.UpdateExtent()

    End Sub

    Private Sub formAddPoint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class