<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUCAccountCodingCollectionAdvanced
    Inherits R2CoreGUI.UCGeneral

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCUCAccountCodingCollectionAdvanced))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PictureBoxRefresh = New System.Windows.Forms.PictureBox()
        Me.UcSortAlphabetic = New R2CoreGUI.UCSortAlphabetic()
        Me.UcPersianTextBox = New R2CoreGUI.UCPersianTextBox()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.UcucAccountCodingCollection = New R2CoreFinancialSystem.UCUCAccountCodingCollection()
        Me.PnlMain.SuspendLayout()
        CType(Me.PictureBoxRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PictureBoxRefresh)
        Me.PnlMain.Controls.Add(Me.UcSortAlphabetic)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBox)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Controls.Add(Me.UcucAccountCodingCollection)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(5, 5)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(364, 346)
        Me.PnlMain.TabIndex = 0
        '
        'PictureBoxRefresh
        '
        Me.PictureBoxRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxRefresh.Image = CType(resources.GetObject("PictureBoxRefresh.Image"), System.Drawing.Image)
        Me.PictureBoxRefresh.Location = New System.Drawing.Point(340, 39)
        Me.PictureBoxRefresh.Name = "PictureBoxRefresh"
        Me.PictureBoxRefresh.Size = New System.Drawing.Size(20, 17)
        Me.PictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxRefresh.TabIndex = 14
        Me.PictureBoxRefresh.TabStop = False
        '
        'UcSortAlphabetic
        '
        Me.UcSortAlphabetic.BackColor = System.Drawing.Color.White
        Me.UcSortAlphabetic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcSortAlphabetic.Location = New System.Drawing.Point(3, 39)
        Me.UcSortAlphabetic.Name = "UcSortAlphabetic"
        Me.UcSortAlphabetic.Padding = New System.Windows.Forms.Padding(2)
        Me.UcSortAlphabetic.Size = New System.Drawing.Size(27, 17)
        Me.UcSortAlphabetic.TabIndex = 13
        Me.UcSortAlphabetic.UCSortOrder = R2Core.R2Enums.SortOrder.Code
        '
        'UcPersianTextBox
        '
        Me.UcPersianTextBox.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcPersianTextBox.Location = New System.Drawing.Point(0, 34)
        Me.UcPersianTextBox.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBox.Name = "UcPersianTextBox"
        Me.UcPersianTextBox.Size = New System.Drawing.Size(364, 27)
        Me.UcPersianTextBox.TabIndex = 11
        Me.UcPersianTextBox.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBox.UCBorder = False
        Me.UcPersianTextBox.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBox.UCEnable = True
        Me.UcPersianTextBox.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBox.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBox.UCMultiLine = False
        Me.UcPersianTextBox.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBox.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBox.UCValue = ""
        '
        'UcLabelTop
        '
        Me.UcLabelTop._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTop._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTop.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelTop.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelTop.Name = "UcLabelTop"
        Me.UcLabelTop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTop.Size = New System.Drawing.Size(364, 34)
        Me.UcLabelTop.TabIndex = 10
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "حساب ها"
        '
        'UcucAccountCodingCollection
        '
        Me.UcucAccountCodingCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcucAccountCodingCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucAccountCodingCollection.Location = New System.Drawing.Point(3, 58)
        Me.UcucAccountCodingCollection.Name = "UcucAccountCodingCollection"
        Me.UcucAccountCodingCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcucAccountCodingCollection.Size = New System.Drawing.Size(358, 285)
        Me.UcucAccountCodingCollection.TabIndex = 12
        '
        'UCUCAccountCodingCollectionAdvanced
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCUCAccountCodingCollectionAdvanced"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(374, 356)
        Me.PnlMain.ResumeLayout(False)
        CType(Me.PictureBoxRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents UcPersianTextBox As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents UcucAccountCodingCollection As UCUCAccountCodingCollection
    Friend WithEvents UcSortAlphabetic As R2CoreGUI.UCSortAlphabetic
    Friend WithEvents PictureBoxRefresh As Windows.Forms.PictureBox
End Class
