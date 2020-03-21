<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcManipulationAccountsCoding
    Inherits R2CoreGUI.FrmcGeneral

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
        Me.PnlManipulationAccountsCoding = New System.Windows.Forms.Panel()
        Me.UcManipulationAccountCoding = New R2CoreFinancialSystem.UCManipulationAccountCoding()
        Me.UcucAccountCodingCollectionAdvanced = New R2CoreFinancialSystem.UCUCAccountCodingCollectionAdvanced()
        Me.ChkRefresh = New System.Windows.Forms.CheckBox()
        Me.PnlManipulationAccountsCoding.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(339, 178)
        '
        'PnlManipulationAccountsCoding
        '
        Me.PnlManipulationAccountsCoding.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlManipulationAccountsCoding.BackColor = System.Drawing.Color.Transparent
        Me.PnlManipulationAccountsCoding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlManipulationAccountsCoding.Controls.Add(Me.ChkRefresh)
        Me.PnlManipulationAccountsCoding.Controls.Add(Me.UcManipulationAccountCoding)
        Me.PnlManipulationAccountsCoding.Controls.Add(Me.UcucAccountCodingCollectionAdvanced)
        Me.PnlManipulationAccountsCoding.Location = New System.Drawing.Point(5, 50)
        Me.PnlManipulationAccountsCoding.Name = "PnlManipulationAccountsCoding"
        Me.PnlManipulationAccountsCoding.Size = New System.Drawing.Size(995, 512)
        Me.PnlManipulationAccountsCoding.TabIndex = 49
        '
        'UcManipulationAccountCoding
        '
        Me.UcManipulationAccountCoding.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.UcManipulationAccountCoding.BackColor = System.Drawing.Color.Transparent
        Me.UcManipulationAccountCoding.Location = New System.Drawing.Point(52, 142)
        Me.UcManipulationAccountCoding.Name = "UcManipulationAccountCoding"
        Me.UcManipulationAccountCoding.Size = New System.Drawing.Size(534, 226)
        Me.UcManipulationAccountCoding.TabIndex = 1
        Me.UcManipulationAccountCoding.UCNSSCurrent = Nothing
        '
        'UcucAccountCodingCollectionAdvanced
        '
        Me.UcucAccountCodingCollectionAdvanced.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcucAccountCodingCollectionAdvanced.BackColor = System.Drawing.Color.White
        Me.UcucAccountCodingCollectionAdvanced.Location = New System.Drawing.Point(609, 19)
        Me.UcucAccountCodingCollectionAdvanced.Name = "UcucAccountCodingCollectionAdvanced"
        Me.UcucAccountCodingCollectionAdvanced.Padding = New System.Windows.Forms.Padding(5)
        Me.UcucAccountCodingCollectionAdvanced.Size = New System.Drawing.Size(374, 474)
        Me.UcucAccountCodingCollectionAdvanced.TabIndex = 0
        '
        'ChkRefresh
        '
        Me.ChkRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ChkRefresh.AutoSize = True
        Me.ChkRefresh.Checked = True
        Me.ChkRefresh.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkRefresh.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkRefresh.Location = New System.Drawing.Point(478, 373)
        Me.ChkRefresh.Name = "ChkRefresh"
        Me.ChkRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkRefresh.Size = New System.Drawing.Size(125, 33)
        Me.ChkRefresh.TabIndex = 2
        Me.ChkRefresh.Text = "بروز رسانی لیست"
        Me.ChkRefresh.UseVisualStyleBackColor = True
        '
        'FrmcManipulationAccountsCoding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlManipulationAccountsCoding)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcManipulationAccountsCoding"
        Me.Text = "FrmcManipulationAccountsCoding"
        Me.Controls.SetChildIndex(Me.PnlManipulationAccountsCoding, 0)
        Me.PnlManipulationAccountsCoding.ResumeLayout(False)
        Me.PnlManipulationAccountsCoding.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlManipulationAccountsCoding As Windows.Forms.Panel
    Friend WithEvents UcManipulationAccountCoding As UCManipulationAccountCoding
    Friend WithEvents UcucAccountCodingCollectionAdvanced As UCUCAccountCodingCollectionAdvanced
    Friend WithEvents ChkRefresh As Windows.Forms.CheckBox
End Class
