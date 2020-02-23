<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCSanadType
    Inherits R2CoreGUI.UCGeneral

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.UcLabel = New R2CoreGUI.UCLabel()
        Me.SuspendLayout()
        '
        'UcLabel
        '
        Me.UcLabel._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcLabel.Location = New System.Drawing.Point(3, 3)
        Me.UcLabel.Name = "UcLabel"
        Me.UcLabel.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel.Size = New System.Drawing.Size(150, 29)
        Me.UcLabel.TabIndex = 0
        Me.UcLabel.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel.UCValue = ""
        '
        'UCSanadType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.UcLabel)
        Me.Name = "UCSanadType"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(156, 35)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcLabel As R2CoreGUI.UCLabel
End Class
