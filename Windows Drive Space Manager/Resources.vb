Public Class Resources
    Public Shared DiskTable As DataTable
    Public Shared ComboTable As DataTable
    Public Shared SpaceDisplayType As String = String.Empty
    Public Shared Sub PrepareComboTable()
        ComboTable = Nothing
        ComboTable = New DataTable()
        ComboTable.Columns.Add("DisplayLong")
        ComboTable.Columns.Add("DisplayShort")
        ComboTable.Rows.Add("Bytes", "B")
        ComboTable.Rows.Add("KiloBytes", "KB")
        ComboTable.Rows.Add("MegaBytes", "MB")
        ComboTable.Rows.Add("GigaBytes", "GB")
    End Sub
    Public Shared Sub PrepareDiskTable(ByVal DisplaySize As String)
        DiskTable = Nothing
        DiskTable = New DataTable()
        DiskTable.Columns.Add("Drive Name")
        DiskTable.Columns.Add("Volume Label")
        DiskTable.Columns.Add("Drive Format")
        DiskTable.Columns.Add("Drive Type")
        DiskTable.Columns.Add("Ready")
        DiskTable.Columns.Add("Used Space")
        DiskTable.Columns.Add("Free Space")
        DiskTable.Columns.Add("Total Space")
        For Each Drive In My.Computer.FileSystem.Drives
            Try
                Dim UsedSpace As Double = 0.0
                Dim FreeSpace As Double = Drive.TotalFreeSpace
                Dim TotalSpace As Double = Drive.TotalSize
                UsedSpace = TotalSpace - FreeSpace
                Resources.DiskTable.Rows.Add(Drive.Name, Drive.VolumeLabel, Drive.DriveFormat, Drive.DriveType, Drive.IsReady, StringBytes(UsedSpace, DisplaySize), StringBytes(FreeSpace, DisplaySize), StringBytes(TotalSpace, DisplaySize))
            Catch ex As Exception
                Resources.DiskTable.Rows.Add(Drive.Name, "", "", Drive.DriveType, Drive.IsReady, "", "", "")
            End Try
        Next
    End Sub
    Private Shared Function StringBytes(ByVal Size As Double, ByVal DisplaySize As String) As String
        Dim DivideBy As Double = 1.0
        If DisplaySize = "KB" Then
            DivideBy = 1024.0
        ElseIf DisplaySize = "MB" Then
            DivideBy = 1048576.0
        ElseIf DisplaySize = "GB" Then
            DivideBy = 1073741824.0
        Else
            DivideBy = 1.0
        End If
        Dim NewSize As Double = (Size / DivideBy)
        Return "" + Format(NewSize, "###,###,###.##") + " " + DisplaySize + ""
    End Function
End Class
