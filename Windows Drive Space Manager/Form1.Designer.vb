<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVB = New System.Windows.Forms.Button()
        Me.btnCSharp = New System.Windows.Forms.Button()
        Me.btnWeb = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 49)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Windows Disk Space Manager"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnVB
        '
        Me.btnVB.Location = New System.Drawing.Point(12, 61)
        Me.btnVB.Name = "btnVB"
        Me.btnVB.Size = New System.Drawing.Size(293, 23)
        Me.btnVB.TabIndex = 2
        Me.btnVB.Text = "Visual Basic Application"
        Me.btnVB.UseVisualStyleBackColor = True
        '
        'btnCSharp
        '
        Me.btnCSharp.Location = New System.Drawing.Point(12, 90)
        Me.btnCSharp.Name = "btnCSharp"
        Me.btnCSharp.Size = New System.Drawing.Size(293, 23)
        Me.btnCSharp.TabIndex = 3
        Me.btnCSharp.Text = "C# Application"
        Me.btnCSharp.UseVisualStyleBackColor = True
        '
        'btnWeb
        '
        Me.btnWeb.Location = New System.Drawing.Point(12, 119)
        Me.btnWeb.Name = "btnWeb"
        Me.btnWeb.Size = New System.Drawing.Size(293, 23)
        Me.btnWeb.TabIndex = 4
        Me.btnWeb.Text = ".NET Web Application"
        Me.btnWeb.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 153)
        Me.Controls.Add(Me.btnWeb)
        Me.Controls.Add(Me.btnCSharp)
        Me.Controls.Add(Me.btnVB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVB As System.Windows.Forms.Button
    Friend WithEvents btnCSharp As System.Windows.Forms.Button
    Friend WithEvents btnWeb As System.Windows.Forms.Button

End Class
