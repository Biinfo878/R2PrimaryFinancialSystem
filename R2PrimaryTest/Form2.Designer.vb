<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.UcManipulationAccountCoding1 = New R2CoreFinancialSystem.UCManipulationAccountCoding()
        Me.UcViewNSSAccountCoding1 = New R2CoreFinancialSystem.UCViewerNSSAccountCoding()
        Me.SuspendLayout()
        '
        'UcManipulationAccountCoding1
        '
        Me.UcManipulationAccountCoding1.BackColor = System.Drawing.Color.Transparent
        Me.UcManipulationAccountCoding1.Location = New System.Drawing.Point(249, 12)
        Me.UcManipulationAccountCoding1.Name = "UcManipulationAccountCoding1"
        Me.UcManipulationAccountCoding1.Size = New System.Drawing.Size(525, 226)
        Me.UcManipulationAccountCoding1.TabIndex = 0
        Me.UcManipulationAccountCoding1.UCNSSCurrent = Nothing
        '
        'UcViewNSSAccountCoding1
        '
        Me.UcViewNSSAccountCoding1.BackColor = System.Drawing.Color.Transparent
        Me.UcViewNSSAccountCoding1.Location = New System.Drawing.Point(109, 140)
        Me.UcViewNSSAccountCoding1.Name = "UcViewNSSAccountCoding1"
        Me.UcViewNSSAccountCoding1.Padding = New System.Windows.Forms.Padding(5)
        Me.UcViewNSSAccountCoding1.Size = New System.Drawing.Size(226, 37)
        Me.UcViewNSSAccountCoding1.TabIndex = 1
        Me.UcViewNSSAccountCoding1.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcViewNSSAccountCoding1.UCMaxMinStatus = R2Core.R2Enums.MaxMin.Min
        Me.UcViewNSSAccountCoding1.UCNSSCurrent = Nothing
        Me.UcViewNSSAccountCoding1.UCPadding = New System.Windows.Forms.Padding(5)
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 408)
        Me.Controls.Add(Me.UcViewNSSAccountCoding1)
        Me.Controls.Add(Me.UcManipulationAccountCoding1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcManipulationAccountCoding1 As R2CoreFinancialSystem.UCManipulationAccountCoding
    Friend WithEvents UcViewNSSAccountCoding1 As R2CoreFinancialSystem.UCViewerNSSAccountCoding
End Class
