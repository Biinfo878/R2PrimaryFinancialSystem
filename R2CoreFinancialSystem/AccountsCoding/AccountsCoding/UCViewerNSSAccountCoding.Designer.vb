<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCViewerNSSAccountCoding
    Inherits UCAccountCoding

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCViewerNSSAccountCoding))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.PicLowLevels = New System.Windows.Forms.PictureBox()
        Me.PicHighLevels = New System.Windows.Forms.PictureBox()
        Me.PicUpDown = New System.Windows.Forms.PictureBox()
        Me.LblAccountDetails = New System.Windows.Forms.Label()
        Me.LblAccount = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout()
        Me.PnlInner.SuspendLayout()
        CType(Me.PicLowLevels, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicHighLevels, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Black
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.PnlInner)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(5, 5)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlMain.Size = New System.Drawing.Size(387, 29)
        Me.PnlMain.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.PicLowLevels)
        Me.PnlInner.Controls.Add(Me.PicHighLevels)
        Me.PnlInner.Controls.Add(Me.PicUpDown)
        Me.PnlInner.Controls.Add(Me.LblAccountDetails)
        Me.PnlInner.Controls.Add(Me.LblAccount)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(2, 2)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(381, 23)
        Me.PnlInner.TabIndex = 2
        '
        'PicLowLevels
        '
        Me.PicLowLevels.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicLowLevels.Image = CType(resources.GetObject("PicLowLevels.Image"), System.Drawing.Image)
        Me.PicLowLevels.Location = New System.Drawing.Point(61, 3)
        Me.PicLowLevels.Name = "PicLowLevels"
        Me.PicLowLevels.Size = New System.Drawing.Size(24, 17)
        Me.PicLowLevels.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLowLevels.TabIndex = 3
        Me.PicLowLevels.TabStop = False
        '
        'PicHighLevels
        '
        Me.PicHighLevels.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicHighLevels.Image = CType(resources.GetObject("PicHighLevels.Image"), System.Drawing.Image)
        Me.PicHighLevels.Location = New System.Drawing.Point(32, 3)
        Me.PicHighLevels.Name = "PicHighLevels"
        Me.PicHighLevels.Size = New System.Drawing.Size(24, 17)
        Me.PicHighLevels.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicHighLevels.TabIndex = 2
        Me.PicHighLevels.TabStop = False
        '
        'PicUpDown
        '
        Me.PicUpDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicUpDown.Image = CType(resources.GetObject("PicUpDown.Image"), System.Drawing.Image)
        Me.PicUpDown.Location = New System.Drawing.Point(3, 3)
        Me.PicUpDown.Name = "PicUpDown"
        Me.PicUpDown.Size = New System.Drawing.Size(24, 17)
        Me.PicUpDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicUpDown.TabIndex = 1
        Me.PicUpDown.TabStop = False
        '
        'LblAccountDetails
        '
        Me.LblAccountDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAccountDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblAccountDetails.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblAccountDetails.Location = New System.Drawing.Point(1, 1)
        Me.LblAccountDetails.Name = "LblAccountDetails"
        Me.LblAccountDetails.Size = New System.Drawing.Size(379, 21)
        Me.LblAccountDetails.TabIndex = 1
        Me.LblAccountDetails.Text = "موقت"
        Me.LblAccountDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblAccountDetails.Visible = False
        '
        'LblAccount
        '
        Me.LblAccount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblAccount.Font = New System.Drawing.Font("B Zar", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblAccount.Location = New System.Drawing.Point(0, 0)
        Me.LblAccount.Name = "LblAccount"
        Me.LblAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblAccount.Size = New System.Drawing.Size(381, 23)
        Me.LblAccount.TabIndex = 0
        Me.LblAccount.Text = "حساب دارایی های جاری"
        '
        'UCViewerNSSAccountCoding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCViewerNSSAccountCoding"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(397, 39)
        Me.PnlMain.ResumeLayout(False)
        Me.PnlInner.ResumeLayout(False)
        CType(Me.PicLowLevels, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicHighLevels, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents LblAccount As Windows.Forms.Label
    Friend WithEvents LblAccountDetails As Windows.Forms.Label
    Friend WithEvents PicUpDown As Windows.Forms.PictureBox
    Friend WithEvents PnlInner As Windows.Forms.Panel
    Friend WithEvents PicHighLevels As Windows.Forms.PictureBox
    Friend WithEvents PicLowLevels As Windows.Forms.PictureBox
End Class
