<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UcViewerNSSAccountCoding1 = New R2CoreFinancialSystem.UCViewerNSSAccountCoding()
        Me.UcucAccountCodingCollectionAdvanced1 = New R2CoreFinancialSystem.UCUCAccountCodingCollectionAdvanced()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(325, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UcViewerNSSAccountCoding1
        '
        Me.UcViewerNSSAccountCoding1.BackColor = System.Drawing.Color.Transparent
        Me.UcViewerNSSAccountCoding1.Location = New System.Drawing.Point(336, 129)
        Me.UcViewerNSSAccountCoding1.Name = "UcViewerNSSAccountCoding1"
        Me.UcViewerNSSAccountCoding1.Padding = New System.Windows.Forms.Padding(5)
        Me.UcViewerNSSAccountCoding1.Size = New System.Drawing.Size(397, 39)
        Me.UcViewerNSSAccountCoding1.TabIndex = 4
        Me.UcViewerNSSAccountCoding1.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcViewerNSSAccountCoding1.UCMaxMinStatus = R2Core.R2Enums.MaxMin.Min
        Me.UcViewerNSSAccountCoding1.UCNSSCurrent = Nothing
        Me.UcViewerNSSAccountCoding1.UCPadding = New System.Windows.Forms.Padding(5)
        '
        'UcucAccountCodingCollectionAdvanced1
        '
        Me.UcucAccountCodingCollectionAdvanced1.BackColor = System.Drawing.Color.White
        Me.UcucAccountCodingCollectionAdvanced1.Location = New System.Drawing.Point(275, 12)
        Me.UcucAccountCodingCollectionAdvanced1.Name = "UcucAccountCodingCollectionAdvanced1"
        Me.UcucAccountCodingCollectionAdvanced1.Padding = New System.Windows.Forms.Padding(5)
        Me.UcucAccountCodingCollectionAdvanced1.Size = New System.Drawing.Size(326, 406)
        Me.UcucAccountCodingCollectionAdvanced1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UcucAccountCodingCollectionAdvanced1)
        Me.Controls.Add(Me.UcViewerNSSAccountCoding1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents UcViewerNSSAccountCoding1 As R2CoreFinancialSystem.UCViewerNSSAccountCoding
    Friend WithEvents UcucAccountCodingCollectionAdvanced1 As R2CoreFinancialSystem.UCUCAccountCodingCollectionAdvanced
End Class
