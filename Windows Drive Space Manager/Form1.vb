Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCSharp_Click(sender As System.Object, e As System.EventArgs) Handles btnCSharp.Click
        System.Diagnostics.Process.Start("C:\Windows Drive Space Manager\C#\Windows Drive Space Manager CSharp.exe")
    End Sub

    Private Sub btnVB_Click(sender As System.Object, e As System.EventArgs) Handles btnVB.Click
        System.Diagnostics.Process.Start("C:\Windows Drive Space Manager\VB\Windows Drive Space Manager VB.exe")
    End Sub

    Private Sub btnWeb_Click(sender As System.Object, e As System.EventArgs) Handles btnWeb.Click
        System.Diagnostics.Process.Start("http://localhost/WindowsDriveSpaceManager/Default.aspx")
    End Sub
End Class
