Public Class Resources
    Public Shared DiskTable As DataTable
    Public Shared ComboTable As DataTable
    Public Shared SpaceDisplayType As String = String.Empty
    Public Shared WebPath As String = String.Empty
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
        DiskTable.Columns.Add("Drive Type")
        DiskTable.Columns.Add("Available")
        DiskTable.Columns.Add("Used Space")
        DiskTable.Columns.Add("Free Space")
        DiskTable.Columns.Add("Total Space")
        Dim Name As String = ""
        Dim Type As String = ""
        Dim Ready As String = ""
        Dim Used As String = ""
        Dim Free As String = ""
        Dim Total As String = ""
        For Each Drive In My.Computer.FileSystem.Drives
            Name = Drive.Name
            Type = GetDriveType(Drive)
            Ready = GetDriveAvailability(Drive)
            Try
                Dim UsedSpace As Double = 0.0
                Dim FreeSpace As Double = Drive.TotalFreeSpace
                Dim TotalSpace As Double = Drive.TotalSize
                UsedSpace = TotalSpace - FreeSpace
                Used = StringBytes(UsedSpace, DisplaySize)
                Free = StringBytes(FreeSpace, DisplaySize)
                Total = StringBytes(TotalSpace, DisplaySize)
                Resources.DiskTable.Rows.Add(Name, Type, Ready, Used, Free, Total)
            Catch ex As Exception
                Used = "Unavailable"
                Free = "Unavailable"
                Total = "Unavailable"
                Resources.DiskTable.Rows.Add(Name, Type, Ready, Used, Free, Total)
            End Try
        Next
    End Sub
    Private Shared Function GetDriveAvailability(ByVal Drive As System.IO.DriveInfo) As String
        Dim result As String = ""
        Select Case Drive.IsReady
            Case True : result = "Yes"
            Case False : result = "No"
        End Select
        Return result
    End Function
    Private Shared Function GetDriveType(ByVal Drive As System.IO.DriveInfo) As String
        Dim result As String = ""
        Select Case Drive.DriveType
            Case IO.DriveType.CDRom : result = "CD/DVD Drive"
            Case IO.DriveType.Fixed : result = "Fixed Hard Drive"
            Case IO.DriveType.Network : result = "Network Drive"
            Case IO.DriveType.NoRootDirectory : result = "Drive Without Root Directory"
            Case IO.DriveType.Ram : result = "RAM Drive"
            Case IO.DriveType.Removable : result = "Removable Drive"
            Case IO.DriveType.Unknown : result = "Unknown Drive Type"
        End Select
        Return result
    End Function
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
        Dim result As String = ""
        If NewSize > 0 Then
            result = "" + Format(NewSize, "###,###,###.##") + " " + DisplaySize + ""
        Else
            result = "0.00 " + DisplaySize + ""
        End If
        Return result
    End Function
End Class
