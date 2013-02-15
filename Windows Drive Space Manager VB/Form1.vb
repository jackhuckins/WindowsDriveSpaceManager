Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DiskSpaceResources.Resources.PrepareComboTable()
        cmbDisplaySize.DataSource = DiskSpaceResources.Resources.ComboTable
        cmbDisplaySize.DisplayMember = "DisplayLong"
        cmbDisplaySize.ValueMember = "DisplayShort"
        cmbDisplaySize.SelectedIndex = 2
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        DiskSpaceResources.Resources.PrepareDiskTable(cmbDisplaySize.SelectedValue)
        dgvResults.DataSource = DiskSpaceResources.Resources.DiskTable
    End Sub
End Class
