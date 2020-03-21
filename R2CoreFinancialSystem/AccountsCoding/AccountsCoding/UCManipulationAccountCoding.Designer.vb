<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCManipulationAccountCoding
    Inherits UCAccountCoding

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
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CornersProperty1 As CButtonLib.CornersProperty = New CButtonLib.CornersProperty()
        Dim CBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CornersProperty2 As CButtonLib.CornersProperty = New CButtonLib.CornersProperty()
        Dim CBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CornersProperty3 As CButtonLib.CornersProperty = New CButtonLib.CornersProperty()
        Dim CBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CornersProperty4 As CButtonLib.CornersProperty = New CButtonLib.CornersProperty()
        Me.PnlMain = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcButtonCButtonDeleteAccount = New R2CoreGUI.UCButtonCButton()
        Me.UcButtonCButtonEditAccount = New R2CoreGUI.UCButtonCButton()
        Me.UcButtonCButtonRegisterAccount = New R2CoreGUI.UCButtonCButton()
        Me.UcButtonCButtonNewAccount = New R2CoreGUI.UCButtonCButton()
        Me.UcNumberAccountId = New R2CoreGUI.UCNumber()
        Me.AlphaGradientPanel1 = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcSearcherCostBenefitAccountTypes = New R2CoreFinancialSystem.UCSearcherCostBenefitAccountTypes()
        Me.UcSearcherBalanceSheetAccountTypes = New R2CoreFinancialSystem.UCSearcherBalanceSheetAccountTypes()
        Me.UcSearcherAccountsCodingLevels = New R2CoreFinancialSystem.UCSearcherAccountsCodingLevels()
        Me.UcTextBoxAccountCode = New R2CoreGUI.UCTextBox()
        Me.UcPersianTextBoxAccountCodeTitle = New R2CoreGUI.UCPersianTextBox()
        Me.UcLabelAccountCodeTitle1 = New R2CoreFinancialSystem.UCLabelAccountCodeTitle()
        Me.UcLabelCostBenefitAccountTypes1 = New R2CoreFinancialSystem.UCLabelCostBenefitAccountTypes()
        Me.UcLableBalanceSheetAccountTypes1 = New R2CoreFinancialSystem.UCLableBalanceSheetAccountTypes()
        Me.UcLabelAccountCodeId1 = New R2CoreFinancialSystem.UCLabelAccountCodeId()
        Me.UcLabelAccountsCodingLevels1 = New R2CoreFinancialSystem.UCLabelAccountsCodingLevels()
        Me.PnlMain.SuspendLayout()
        Me.AlphaGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Transparent
        Me.PnlMain.Border = False
        Me.PnlMain.BorderColor = System.Drawing.Color.Black
        Me.PnlMain.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlMain.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlMain.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlMain.Controls.Add(Me.UcButtonCButtonDeleteAccount)
        Me.PnlMain.Controls.Add(Me.UcButtonCButtonEditAccount)
        Me.PnlMain.Controls.Add(Me.UcButtonCButtonRegisterAccount)
        Me.PnlMain.Controls.Add(Me.UcButtonCButtonNewAccount)
        Me.PnlMain.Controls.Add(Me.UcNumberAccountId)
        Me.PnlMain.Controls.Add(Me.AlphaGradientPanel1)
        Me.PnlMain.CornerRadius = 20
        Me.PnlMain.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
            Or BlueActivity.Controls.Corner.BottomLeft) _
            Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Gradient = True
        Me.PnlMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlMain.GradientOffset = 1.0!
        Me.PnlMain.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlMain.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlMain.Grayscale = False
        Me.PnlMain.Image = Nothing
        Me.PnlMain.ImageAlpha = 75
        Me.PnlMain.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlMain.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlMain.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Rounded = True
        Me.PnlMain.Size = New System.Drawing.Size(534, 226)
        Me.PnlMain.TabIndex = 0
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlMain
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlMain
        '
        'UcButtonCButtonDeleteAccount
        '
        Me.UcButtonCButtonDeleteAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcButtonCButtonDeleteAccount.Location = New System.Drawing.Point(213, 190)
        Me.UcButtonCButtonDeleteAccount.Name = "UcButtonCButtonDeleteAccount"
        Me.UcButtonCButtonDeleteAccount.Size = New System.Drawing.Size(85, 25)
        Me.UcButtonCButtonDeleteAccount.TabIndex = 18
        Me.UcButtonCButtonDeleteAccount.UCBorderColor = System.Drawing.Color.Blue
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Yellow, System.Drawing.Color.Gold}
        CBlendItems1.iPoint = New Single() {0!, 1.0!}
        Me.UcButtonCButtonDeleteAccount.UCColorFillBlend = CBlendItems1
        Me.UcButtonCButtonDeleteAccount.UCColorFillSolid = System.Drawing.Color.Transparent
        CornersProperty1.LowerLeft = 16
        CornersProperty1.UpperRight = 16
        Me.UcButtonCButtonDeleteAccount.UCCorners = CornersProperty1
        Me.UcButtonCButtonDeleteAccount.UCCursor = System.Windows.Forms.Cursors.Hand
        Me.UcButtonCButtonDeleteAccount.UCFont = New System.Drawing.Font("B Homa", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonCButtonDeleteAccount.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonCButtonDeleteAccount.UCText = "حذف حساب"
        '
        'UcButtonCButtonEditAccount
        '
        Me.UcButtonCButtonEditAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcButtonCButtonEditAccount.Location = New System.Drawing.Point(121, 190)
        Me.UcButtonCButtonEditAccount.Name = "UcButtonCButtonEditAccount"
        Me.UcButtonCButtonEditAccount.Size = New System.Drawing.Size(85, 25)
        Me.UcButtonCButtonEditAccount.TabIndex = 17
        Me.UcButtonCButtonEditAccount.UCBorderColor = System.Drawing.Color.Blue
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.Blue, System.Drawing.Color.RoyalBlue}
        CBlendItems2.iPoint = New Single() {0!, 1.0!}
        Me.UcButtonCButtonEditAccount.UCColorFillBlend = CBlendItems2
        Me.UcButtonCButtonEditAccount.UCColorFillSolid = System.Drawing.Color.Transparent
        CornersProperty2.LowerLeft = 16
        CornersProperty2.UpperRight = 16
        Me.UcButtonCButtonEditAccount.UCCorners = CornersProperty2
        Me.UcButtonCButtonEditAccount.UCCursor = System.Windows.Forms.Cursors.Hand
        Me.UcButtonCButtonEditAccount.UCFont = New System.Drawing.Font("B Homa", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonCButtonEditAccount.UCForeColor = System.Drawing.Color.White
        Me.UcButtonCButtonEditAccount.UCText = "ویرایش حساب"
        '
        'UcButtonCButtonRegisterAccount
        '
        Me.UcButtonCButtonRegisterAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcButtonCButtonRegisterAccount.Location = New System.Drawing.Point(29, 190)
        Me.UcButtonCButtonRegisterAccount.Name = "UcButtonCButtonRegisterAccount"
        Me.UcButtonCButtonRegisterAccount.Size = New System.Drawing.Size(85, 25)
        Me.UcButtonCButtonRegisterAccount.TabIndex = 16
        Me.UcButtonCButtonRegisterAccount.UCBorderColor = System.Drawing.Color.Blue
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.IndianRed, System.Drawing.Color.Red}
        CBlendItems3.iPoint = New Single() {0!, 1.0!}
        Me.UcButtonCButtonRegisterAccount.UCColorFillBlend = CBlendItems3
        Me.UcButtonCButtonRegisterAccount.UCColorFillSolid = System.Drawing.Color.Transparent
        CornersProperty3.LowerLeft = 16
        CornersProperty3.UpperRight = 16
        Me.UcButtonCButtonRegisterAccount.UCCorners = CornersProperty3
        Me.UcButtonCButtonRegisterAccount.UCCursor = System.Windows.Forms.Cursors.Hand
        Me.UcButtonCButtonRegisterAccount.UCFont = New System.Drawing.Font("B Homa", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonCButtonRegisterAccount.UCForeColor = System.Drawing.Color.White
        Me.UcButtonCButtonRegisterAccount.UCText = "ثبت حساب"
        '
        'UcButtonCButtonNewAccount
        '
        Me.UcButtonCButtonNewAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcButtonCButtonNewAccount.Location = New System.Drawing.Point(305, 190)
        Me.UcButtonCButtonNewAccount.Name = "UcButtonCButtonNewAccount"
        Me.UcButtonCButtonNewAccount.Size = New System.Drawing.Size(85, 25)
        Me.UcButtonCButtonNewAccount.TabIndex = 15
        Me.UcButtonCButtonNewAccount.UCBorderColor = System.Drawing.Color.Blue
        CBlendItems4.iColor = New System.Drawing.Color() {System.Drawing.Color.ForestGreen, System.Drawing.Color.DarkOliveGreen}
        CBlendItems4.iPoint = New Single() {0!, 1.0!}
        Me.UcButtonCButtonNewAccount.UCColorFillBlend = CBlendItems4
        Me.UcButtonCButtonNewAccount.UCColorFillSolid = System.Drawing.Color.Transparent
        CornersProperty4.LowerLeft = 16
        CornersProperty4.UpperRight = 16
        Me.UcButtonCButtonNewAccount.UCCorners = CornersProperty4
        Me.UcButtonCButtonNewAccount.UCCursor = System.Windows.Forms.Cursors.Hand
        Me.UcButtonCButtonNewAccount.UCFont = New System.Drawing.Font("B Homa", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonCButtonNewAccount.UCForeColor = System.Drawing.Color.White
        Me.UcButtonCButtonNewAccount.UCText = "حساب جدید"
        '
        'UcNumberAccountId
        '
        Me.UcNumberAccountId.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberAccountId.Location = New System.Drawing.Point(426, 14)
        Me.UcNumberAccountId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberAccountId.Name = "UcNumberAccountId"
        Me.UcNumberAccountId.Size = New System.Drawing.Size(80, 19)
        Me.UcNumberAccountId.TabIndex = 6
        Me.UcNumberAccountId.UCBackColor = System.Drawing.Color.White
        Me.UcNumberAccountId.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberAccountId.UCBorder = True
        Me.UcNumberAccountId.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcNumberAccountId.UCEnable = False
        Me.UcNumberAccountId.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberAccountId.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberAccountId.UCMultiLine = False
        Me.UcNumberAccountId.UCValue = CType(0, Long)
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlphaGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.AlphaGradientPanel1.Border = True
        Me.AlphaGradientPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha3)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha4)
        Me.AlphaGradientPanel1.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcSearcherCostBenefitAccountTypes)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcSearcherBalanceSheetAccountTypes)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcSearcherAccountsCodingLevels)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcTextBoxAccountCode)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcPersianTextBoxAccountCodeTitle)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabelAccountCodeTitle1)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabelAccountCodeId1)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabelCostBenefitAccountTypes1)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLableBalanceSheetAccountTypes1)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabelAccountsCodingLevels1)
        Me.AlphaGradientPanel1.CornerRadius = 20
        Me.AlphaGradientPanel1.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
            Or BlueActivity.Controls.Corner.BottomLeft) _
            Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.AlphaGradientPanel1.Gradient = True
        Me.AlphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.AlphaGradientPanel1.GradientOffset = 1.0!
        Me.AlphaGradientPanel1.GradientSize = New System.Drawing.Size(0, 0)
        Me.AlphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.AlphaGradientPanel1.Grayscale = False
        Me.AlphaGradientPanel1.Image = Nothing
        Me.AlphaGradientPanel1.ImageAlpha = 75
        Me.AlphaGradientPanel1.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.AlphaGradientPanel1.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.AlphaGradientPanel1.ImageSize = New System.Drawing.Size(48, 48)
        Me.AlphaGradientPanel1.Location = New System.Drawing.Point(3, 24)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = True
        Me.AlphaGradientPanel1.Size = New System.Drawing.Size(528, 180)
        Me.AlphaGradientPanel1.TabIndex = 0
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha3.Parent = Me.AlphaGradientPanel1
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha4.Parent = Me.AlphaGradientPanel1
        '
        'UcSearcherCostBenefitAccountTypes
        '
        Me.UcSearcherCostBenefitAccountTypes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcSearcherCostBenefitAccountTypes.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherCostBenefitAccountTypes.Location = New System.Drawing.Point(11, 30)
        Me.UcSearcherCostBenefitAccountTypes.Name = "UcSearcherCostBenefitAccountTypes"
        Me.UcSearcherCostBenefitAccountTypes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherCostBenefitAccountTypes.Size = New System.Drawing.Size(130, 31)
        Me.UcSearcherCostBenefitAccountTypes.TabIndex = 12
        Me.UcSearcherCostBenefitAccountTypes.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherCostBenefitAccountTypes.UCFontList = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherCostBenefitAccountTypes.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherCostBenefitAccountTypes.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherCostBenefitAccountTypes.UCIcon = Nothing
        Me.UcSearcherCostBenefitAccountTypes.UCMaximizeHight = CType(150, Long)
        Me.UcSearcherCostBenefitAccountTypes.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherCostBenefitAccountTypes.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherCostBenefitAccountTypes.UCShowDomainIcon = False
        '
        'UcSearcherBalanceSheetAccountTypes
        '
        Me.UcSearcherBalanceSheetAccountTypes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcSearcherBalanceSheetAccountTypes.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherBalanceSheetAccountTypes.Location = New System.Drawing.Point(154, 30)
        Me.UcSearcherBalanceSheetAccountTypes.Name = "UcSearcherBalanceSheetAccountTypes"
        Me.UcSearcherBalanceSheetAccountTypes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherBalanceSheetAccountTypes.Size = New System.Drawing.Size(130, 31)
        Me.UcSearcherBalanceSheetAccountTypes.TabIndex = 11
        Me.UcSearcherBalanceSheetAccountTypes.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherBalanceSheetAccountTypes.UCFontList = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherBalanceSheetAccountTypes.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherBalanceSheetAccountTypes.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherBalanceSheetAccountTypes.UCIcon = Nothing
        Me.UcSearcherBalanceSheetAccountTypes.UCMaximizeHight = CType(150, Long)
        Me.UcSearcherBalanceSheetAccountTypes.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherBalanceSheetAccountTypes.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherBalanceSheetAccountTypes.UCShowDomainIcon = False
        '
        'UcSearcherAccountsCodingLevels
        '
        Me.UcSearcherAccountsCodingLevels.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcSearcherAccountsCodingLevels.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherAccountsCodingLevels.Location = New System.Drawing.Point(297, 30)
        Me.UcSearcherAccountsCodingLevels.Name = "UcSearcherAccountsCodingLevels"
        Me.UcSearcherAccountsCodingLevels.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherAccountsCodingLevels.Size = New System.Drawing.Size(130, 31)
        Me.UcSearcherAccountsCodingLevels.TabIndex = 6
        Me.UcSearcherAccountsCodingLevels.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherAccountsCodingLevels.UCFontList = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherAccountsCodingLevels.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherAccountsCodingLevels.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherAccountsCodingLevels.UCIcon = Nothing
        Me.UcSearcherAccountsCodingLevels.UCMaximizeHight = CType(150, Long)
        Me.UcSearcherAccountsCodingLevels.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherAccountsCodingLevels.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherAccountsCodingLevels.UCShowDomainIcon = False
        '
        'UcTextBoxAccountCode
        '
        Me.UcTextBoxAccountCode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcTextBoxAccountCode.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxAccountCode.Location = New System.Drawing.Point(274, 93)
        Me.UcTextBoxAccountCode.Name = "UcTextBoxAccountCode"
        Me.UcTextBoxAccountCode.Size = New System.Drawing.Size(153, 28)
        Me.UcTextBoxAccountCode.TabIndex = 14
        Me.UcTextBoxAccountCode.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxAccountCode.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxAccountCode.UCBorder = True
        Me.UcTextBoxAccountCode.UCBorderColor = System.Drawing.Color.OrangeRed
        Me.UcTextBoxAccountCode.UCEnable = True
        Me.UcTextBoxAccountCode.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcTextBoxAccountCode.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxAccountCode.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.None
        Me.UcTextBoxAccountCode.UCMaxCharacterReached = CType(50, Short)
        Me.UcTextBoxAccountCode.UCMaxNumber = CType(99999, Long)
        Me.UcTextBoxAccountCode.UCMultiLine = False
        Me.UcTextBoxAccountCode.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.OnlyDigit
        Me.UcTextBoxAccountCode.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxAccountCode.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxAccountCode.UCValue = ""
        '
        'UcPersianTextBoxAccountCodeTitle
        '
        Me.UcPersianTextBoxAccountCodeTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcPersianTextBoxAccountCodeTitle.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxAccountCodeTitle.Location = New System.Drawing.Point(146, 126)
        Me.UcPersianTextBoxAccountCodeTitle.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxAccountCodeTitle.Name = "UcPersianTextBoxAccountCodeTitle"
        Me.UcPersianTextBoxAccountCodeTitle.Size = New System.Drawing.Size(281, 27)
        Me.UcPersianTextBoxAccountCodeTitle.TabIndex = 9
        Me.UcPersianTextBoxAccountCodeTitle.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxAccountCodeTitle.UCBorder = True
        Me.UcPersianTextBoxAccountCodeTitle.UCBorderColor = System.Drawing.Color.Blue
        Me.UcPersianTextBoxAccountCodeTitle.UCEnable = True
        Me.UcPersianTextBoxAccountCodeTitle.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxAccountCodeTitle.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxAccountCodeTitle.UCMultiLine = False
        Me.UcPersianTextBoxAccountCodeTitle.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxAccountCodeTitle.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxAccountCodeTitle.UCValue = ""
        '
        'UcLabelAccountCodeTitle1
        '
        Me.UcLabelAccountCodeTitle1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelAccountCodeTitle1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelAccountCodeTitle1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabelAccountCodeTitle1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelAccountCodeTitle1.Location = New System.Drawing.Point(429, 125)
        Me.UcLabelAccountCodeTitle1.Name = "UcLabelAccountCodeTitle1"
        Me.UcLabelAccountCodeTitle1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelAccountCodeTitle1.Size = New System.Drawing.Size(88, 27)
        Me.UcLabelAccountCodeTitle1.TabIndex = 8
        Me.UcLabelAccountCodeTitle1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelAccountCodeTitle1.UCFont = New System.Drawing.Font("IRMehr", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelAccountCodeTitle1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelAccountCodeTitle1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelAccountCodeTitle1.UCValue = "عنوان حساب"
        '
        'UcLabelCostBenefitAccountTypes1
        '
        Me.UcLabelCostBenefitAccountTypes1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelCostBenefitAccountTypes1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelCostBenefitAccountTypes1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabelCostBenefitAccountTypes1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelCostBenefitAccountTypes1.Location = New System.Drawing.Point(21, 2)
        Me.UcLabelCostBenefitAccountTypes1.Name = "UcLabelCostBenefitAccountTypes1"
        Me.UcLabelCostBenefitAccountTypes1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelCostBenefitAccountTypes1.Size = New System.Drawing.Size(120, 26)
        Me.UcLabelCostBenefitAccountTypes1.TabIndex = 13
        Me.UcLabelCostBenefitAccountTypes1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelCostBenefitAccountTypes1.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelCostBenefitAccountTypes1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelCostBenefitAccountTypes1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelCostBenefitAccountTypes1.UCValue = "حساب سود و زیان"
        '
        'UcLableBalanceSheetAccountTypes1
        '
        Me.UcLableBalanceSheetAccountTypes1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLableBalanceSheetAccountTypes1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLableBalanceSheetAccountTypes1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLableBalanceSheetAccountTypes1.BackColor = System.Drawing.Color.Transparent
        Me.UcLableBalanceSheetAccountTypes1.Location = New System.Drawing.Point(154, 1)
        Me.UcLableBalanceSheetAccountTypes1.Name = "UcLableBalanceSheetAccountTypes1"
        Me.UcLableBalanceSheetAccountTypes1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLableBalanceSheetAccountTypes1.Size = New System.Drawing.Size(130, 29)
        Me.UcLableBalanceSheetAccountTypes1.TabIndex = 10
        Me.UcLableBalanceSheetAccountTypes1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLableBalanceSheetAccountTypes1.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLableBalanceSheetAccountTypes1.UCForeColor = System.Drawing.Color.Black
        Me.UcLableBalanceSheetAccountTypes1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLableBalanceSheetAccountTypes1.UCValue = "نوع حساب در ترازنامه"
        '
        'UcLabelAccountCodeId1
        '
        Me.UcLabelAccountCodeId1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelAccountCodeId1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelAccountCodeId1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabelAccountCodeId1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelAccountCodeId1.Location = New System.Drawing.Point(429, 91)
        Me.UcLabelAccountCodeId1.Name = "UcLabelAccountCodeId1"
        Me.UcLabelAccountCodeId1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelAccountCodeId1.Size = New System.Drawing.Size(65, 27)
        Me.UcLabelAccountCodeId1.TabIndex = 7
        Me.UcLabelAccountCodeId1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelAccountCodeId1.UCFont = New System.Drawing.Font("IRMehr", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelAccountCodeId1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelAccountCodeId1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelAccountCodeId1.UCValue = "کدحساب"
        '
        'UcLabelAccountsCodingLevels1
        '
        Me.UcLabelAccountsCodingLevels1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelAccountsCodingLevels1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelAccountsCodingLevels1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabelAccountsCodingLevels1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelAccountsCodingLevels1.Location = New System.Drawing.Point(297, 2)
        Me.UcLabelAccountsCodingLevels1.Name = "UcLabelAccountsCodingLevels1"
        Me.UcLabelAccountsCodingLevels1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelAccountsCodingLevels1.Size = New System.Drawing.Size(130, 28)
        Me.UcLabelAccountsCodingLevels1.TabIndex = 5
        Me.UcLabelAccountsCodingLevels1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelAccountsCodingLevels1.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcLabelAccountsCodingLevels1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelAccountsCodingLevels1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelAccountsCodingLevels1.UCValue = "سطح حساب"
        '
        'UCManipulationAccountCoding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCManipulationAccountCoding"
        Me.Size = New System.Drawing.Size(534, 226)
        Me.PnlMain.ResumeLayout(False)
        Me.AlphaGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents AlphaGradientPanel1 As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcLabelCostBenefitAccountTypes1 As UCLabelCostBenefitAccountTypes
    Friend WithEvents UcSearcherCostBenefitAccountTypes As UCSearcherCostBenefitAccountTypes
    Friend WithEvents UcSearcherBalanceSheetAccountTypes As UCSearcherBalanceSheetAccountTypes
    Friend WithEvents UcLableBalanceSheetAccountTypes1 As UCLableBalanceSheetAccountTypes
    Friend WithEvents UcPersianTextBoxAccountCodeTitle As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcLabelAccountCodeTitle1 As UCLabelAccountCodeTitle
    Friend WithEvents UcLabelAccountCodeId1 As UCLabelAccountCodeId
    Friend WithEvents UcSearcherAccountsCodingLevels As UCSearcherAccountsCodingLevels
    Friend WithEvents UcLabelAccountsCodingLevels1 As UCLabelAccountsCodingLevels
    Friend WithEvents UcNumberAccountId As R2CoreGUI.UCNumber
    Friend WithEvents UcTextBoxAccountCode As R2CoreGUI.UCTextBox
    Friend WithEvents UcButtonCButtonNewAccount As R2CoreGUI.UCButtonCButton
    Friend WithEvents UcButtonCButtonRegisterAccount As R2CoreGUI.UCButtonCButton
    Friend WithEvents UcButtonCButtonDeleteAccount As R2CoreGUI.UCButtonCButton
    Friend WithEvents UcButtonCButtonEditAccount As R2CoreGUI.UCButtonCButton
End Class
