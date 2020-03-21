
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Reflection

Imports R2CoreGUI
Imports R2Core.DatabaseManagement
Imports R2CoreFinancialSystem.AccountsCoding.AccountsCoding
Imports R2CoreFinancialSystem.AccountsCoding





Public Class UCViewerNSSAccountCoding
    Inherits UCAccountCoding

    Public Event UCClickedEvent(UC As UCViewerNSSAccountCoding)
    Public Event UCRequestLowLevelsEvent(UC As UCViewerNSSAccountCoding)
    Public Event UCRequestHighLevelsEvent(UC As UCViewerNSSAccountCoding)
    Public Event UCSelectEvent(ByVal UC As UCViewerNSSAccountCoding)
    Public Event UCUnSelectEvent(ByVal UC As UCViewerNSSAccountCoding)
    Public Event UCDownArrowPressedEvent(ByVal UC As UCViewerNSSAccountCoding)
    Public Event UCUPArrowPressedEvent(ByVal UC As UCViewerNSSAccountCoding)



#Region "General Properties"

    Private _UCPadding As Padding = New Padding(5)
    <Browsable(True)>
    Public Property UCPadding As Padding
        Get
            Return _UCPadding
        End Get
        Set(value As Padding)
            _UCPadding = value
            Me.Padding = value
        End Set
    End Property

    Private _UCFont As Font = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    <Browsable(True)>
    Public Property UCFont As Font
        Get
            Return _UCFont
        End Get
        Set(value As Font)
            _UCFont = value
            LblAccount.Font = value
            LblAccountDetails.Font = value
        End Set
    End Property

    Public Property UCMaxMinStatus As R2Core.R2Enums.MaxMin = R2Core.R2Enums.MaxMin.Min


#End Region

#Region "Subroutins And Functions"

    Public Sub New()
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCRefreshInformation()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefreshInformation()
        Try
            LblAccount.Text = String.Empty
            LblAccountDetails.Text = String.Empty
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCSwitcheMaxMinStatus()
        Try
            If UCMaxMinStatus = R2Core.R2Enums.MaxMin.Max Then
                Me.Size = New Size(Me.Width, Me.Height - LblAccountDetails.Height)
                UCMaxMinStatus = R2Core.R2Enums.MaxMin.Min
                LblAccountDetails.Visible = False
            Else
                Me.Size = New Size(Me.Width, Me.Height + LblAccountDetails.Height)
                UCMaxMinStatus = R2Core.R2Enums.MaxMin.Max
                LblAccountDetails.Visible = True
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCViewInformation(YourNSS As R2CoreFinancialSystemAccountCodingExtendedStructure)
        Try
            UCRefreshInformation()
            LblAccount.Text = R2CoreFinancialSystemMClassAccountsCodingManagement.GetAccountHighLevelsString(YourNSS) + YourNSS.ACCode.Trim + "  " + YourNSS.ACTitle.Trim
            LblAccountDetails.Text = YourNSS.AClTitle + "    " + YourNSS.BSTitle + "    " + YourNSS.CBTitle
            PnlInner.BackColor = YourNSS.AClColor
            Me.Size = New Size(Me.Width, TextRenderer.MeasureText(LblAccount.Text, LblAccount.Font).Height + Me.Padding.Bottom * 2 + PnlMain.Padding.Bottom * 2)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub Labels_ClickHandler(sender As Object, e As EventArgs) Handles LblAccount.Click, LblAccountDetails.Click
        Try
            RaiseEvent UCClickedEvent(Me)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub PicLowLevels_Click(sender As Object, e As EventArgs) Handles PicLowLevels.Click
        Try
            RaiseEvent UCRequestLowLevelsEvent(Me)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Private Sub PicHighLevels_Click(sender As Object, e As EventArgs) Handles PicHighLevels.Click
        Try
            RaiseEvent UCRequestHighLevelsEvent(Me)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCViewNSSAccountCoding_UCViewNSSRequested(NSSCurrent As R2CoreFinancialSystemAccountCodingStructure) Handles Me.UCViewNSSRequested
        Try
            UCViewInformation(NSSCurrent)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub PicUpDown_Click(sender As Object, e As EventArgs) Handles PicUpDown.Click
        Try
            UCSwitcheMaxMinStatus()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCViewerNSSAccountCoding_UCGotFocusedEvent() Handles Me.UCGotFocusedEvent
    End Sub

    Private Sub PicLowLevels_MouseLeave(sender As Object, e As EventArgs) Handles PicLowLevels.MouseLeave
        PicLowLevels.BorderStyle = BorderStyle.None
    End Sub

    Private Sub PicHighLevels_MouseLeave(sender As Object, e As EventArgs) Handles PicHighLevels.MouseLeave
        PicHighLevels.BorderStyle = BorderStyle.None
    End Sub

    Private Sub PicLowLevels_MouseHover(sender As Object, e As EventArgs) Handles PicLowLevels.MouseHover
        PicLowLevels.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PicHighLevels_MouseHover(sender As Object, e As EventArgs) Handles PicHighLevels.MouseHover
        PicHighLevels.BorderStyle = BorderStyle.FixedSingle
    End Sub





#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region


End Class
