Imports DotSpatial.Controls
Imports DotSpatial.Data
Imports DotSpatial.Symbology
Imports System.IO
Public Class formPopUp
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
            Dim targetPath As String = Path.Combine(Form1.ResourcesPath, "NonSpatial/Foto")
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

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Try
            Form1.sedangload = True
            If cmdEdit.Text = "Edit" Then
                Dim input As String = Microsoft.VisualBasic.Interaction.InputBox(
                    "Please enter your password", "Password", "", -1, -1)

                If input = "maureen" Then
                    txtJenisKantor.ReadOnly = False
                    txtNamaKantor.ReadOnly = False
                    cmdBrowse.Enabled = True
                    cmdDelete.Visible = True
                    cmdEdit.Text = "Save"
                Else
                    txtJenisKantor.ReadOnly = True
                    txtNamaKantor.ReadOnly = True
                    cmdBrowse.Enabled = False
                    cmdDelete.Visible = False
                    cmdEdit.Text = "Edit"
                End If

            ElseIf cmdEdit.Text = "Save" Then
                'Dim featureEdited As IFeature = Form1.lyrKantorPemerintahan.FeatureSet.GetFeature(CInt(txtShapeIndex.Text))
                ' featureEdited.DataRow.BeginEdit()
                'featureEdited.DataRow("jenis_kantor") = txtJenisKantor.Text
                'featureEdited.DataRow("nama_kantor") = txtNamaKantor.Text
                'featureEdited.DataRow("foto") = txtFoto.Text

                cmdEdit.Text = "Edit"
                txtJenisKantor.ReadOnly = True
                txtNamaKantor.ReadOnly = True
                cmdBrowse.Enabled = False
                Map1.Refresh()
                Me.Hide()
                MessageBox.Show("Data Save")
            End If
            Form1.sedangload = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Form1.sedangload = True
        Form1.lyrKantorPemerintahan.ClearSelection()
        Form1.lyrKantorPemerintahan.Select(CInt(txtShapeIndex.Text))
        Form1.lyrKantorPemerintahan.RemoveSelectedFeatures()
        Form1.sedangload = False
        Form1.Map1.Refresh()
        Me.Close()
        MessageBox.Show("EAAAAA, DATAMU DI HAPUS TAPI KENANGANMU TETEP ADA")
    End Sub
End Class