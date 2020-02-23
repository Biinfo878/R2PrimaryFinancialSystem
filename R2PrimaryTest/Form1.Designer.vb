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
        Dim R2CoreFinancialSystemStandardAccountingDocumentTypeStructure1 As R2CoreFinancialSystem.R2CoreFinancialSystem.AccountingDocumentTypes.R2CoreFinancialSystemStandardAccountingDocumentTypeStructure = New R2CoreFinancialSystem.R2CoreFinancialSystem.AccountingDocumentTypes.R2CoreFinancialSystemStandardAccountingDocumentTypeStructure()
        Me.UcSanadType1 = New R2CoreFinancialSystem.UCSanadType()
        Me.SuspendLayout()
        '
        'UcSanadType1
        '
        Me.UcSanadType1.BackColor = System.Drawing.Color.Transparent
        Me.UcSanadType1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcSanadType1.Location = New System.Drawing.Point(291, 205)
        Me.UcSanadType1.Name = "UcSanadType1"
        Me.UcSanadType1.Padding = New System.Windows.Forms.Padding(3)
        Me.UcSanadType1.Size = New System.Drawing.Size(156, 35)
        Me.UcSanadType1.TabIndex = 0
        R2CoreFinancialSystemStandardAccountingDocumentTypeStructure1.Active = False
        R2CoreFinancialSystemStandardAccountingDocumentTypeStructure1.ADTypeColor = System.Drawing.Color.Black
        R2CoreFinancialSystemStandardAccountingDocumentTypeStructure1.ADTypeId = CType(0, Long)
        R2CoreFinancialSystemStandardAccountingDocumentTypeStructure1.ADTypeName = "None"
        R2CoreFinancialSystemStandardAccountingDocumentTypeStructure1.ADTypeTitle = "نامعلوم"
        R2CoreFinancialSystemStandardAccountingDocumentTypeStructure1.DateShamsi = "1398/12/02"
        R2CoreFinancialSystemStandardAccountingDocumentTypeStructure1.DateTimeMilladi = New Date(2020, 2, 21, 0, 0, 0, 0)
        R2CoreFinancialSystemStandardAccountingDocumentTypeStructure1.Deleted = False
        R2CoreFinancialSystemStandardAccountingDocumentTypeStructure1.OCode = "0"
        R2CoreFinancialSystemStandardAccountingDocumentTypeStructure1.OId = CType(1, Long)
        R2CoreFinancialSystemStandardAccountingDocumentTypeStructure1.OName = "None"
        R2CoreFinancialSystemStandardAccountingDocumentTypeStructure1.ViewFlag = False
        Me.UcSanadType1.UCCurrentNSS = R2CoreFinancialSystemStandardAccountingDocumentTypeStructure1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UcSanadType1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcSanadType1 As R2CoreFinancialSystem.UCSanadType
End Class
