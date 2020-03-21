
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core
Imports R2CoreFinancialSystem.AccountsCoding.AccountsCoding
Imports R2CoreFinancialSystem.AccountsCoding.AccountsCodingLevels
Imports R2CoreGUI


Public Class UCUCAccountCodingCollectionAdvanced
    Inherits UCGeneral

    Public Event UCSelectedNSSChangedEvent(NSS As R2CoreFinancialSystemAccountCodingStructure)
    Public Event UCRequestHighLevelsEvent(NSS As R2CoreFinancialSystemAccountCodingStructure)
    Public Event UCRequestLowLevelsEvent(NSS As R2CoreFinancialSystemAccountCodingStructure)

#Region "General Properties"

    Private Property UCLastKeyActivated As Keys = Keys.Enter + Keys.ControlKey

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCRefreshCollection()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub UCRefreshCollection()
        Try
            UcucAccountCodingCollection.UCViewAccounts(R2CoreFinancialSystemMClassAccountsCodingManagement.GetAccountsCodingCollection_ByAClPriority(R2CoreFinancialSystemMClassAccountsCodingLevelsManagement.GetNSSAccountsCodingLevel(R2CoreFinancialSystemAccountsCodingLevels.Group).AClPriority, UcSortAlphabetic.UCSortOrder))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcPersianTextBox_UCEnterControlPressedEvent(PersianText As String) Handles UcPersianTextBox.UCEnterControlPressedEvent
        Try
            UCLastKeyActivated = Keys.ControlKey + Keys.Enter
            UcucAccountCodingCollection.UCViewAccounts(R2CoreFinancialSystemMClassAccountsCodingManagement.GetAccountsCodingCollection_SearchIntroCharacters(PersianText, UcSortAlphabetic.UCSortOrder))
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianTextBox_UC13PressedEvent(PersianText As String) Handles UcPersianTextBox.UC13PressedEvent
        Try
            UCLastKeyActivated = Keys.Enter
            UcucAccountCodingCollection.UCViewAccounts(R2CoreFinancialSystemMClassAccountsCodingManagement.GetAccountsCodingCollection_SearchforLeftCharacters(PersianText, UcSortAlphabetic.UCSortOrder))
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcSortAlphabetic_SortOrderChanged(SortOrder As R2Enums.SortOrder) Handles UcSortAlphabetic.SortOrderChanged
        Try

        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub PictureBoxRefresh_Click(sender As Object, e As EventArgs) Handles PictureBoxRefresh.Click
        Try
            UCRefreshCollection()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucAccountCodingCollection_UCViewCollectionCompeletedEvent() Handles UcucAccountCodingCollection.UCViewCollectionCompeletedEvent

    End Sub

    Private Sub UcucAccountCodingCollection_UCRequestLowLevelsEvent(NSS As R2CoreFinancialSystemAccountCodingStructure) Handles UcucAccountCodingCollection.UCRequestLowLevelsEvent
        Try
            Dim LstLowLevels As List(Of R2CoreFinancialSystemAccountCodingExtendedStructure)
            LstLowLevels = R2CoreFinancialSystemMClassAccountsCodingManagement.GetAccountsCodingCollection_LowLevels(NSS, UcSortAlphabetic.UCSortOrder)
            If LstLowLevels.Count <> 0 Then
                UcucAccountCodingCollection.UCViewAccounts(LstLowLevels)
                RaiseEvent UCRequestLowLevelsEvent(NSS)
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucAccountCodingCollection_UCSelectedNSSChangedEvent(NSS As R2CoreFinancialSystemAccountCodingStructure) Handles UcucAccountCodingCollection.UCSelectedNSSChangedEvent
        Try
            RaiseEvent UCSelectedNSSChangedEvent(NSS)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucAccountCodingCollection_UCRequestHighLevelsEvent(NSS As R2CoreFinancialSystemAccountCodingStructure) Handles UcucAccountCodingCollection.UCRequestHighLevelsEvent
        Try
            Dim LstHighLevels As List(Of R2CoreFinancialSystemAccountCodingExtendedStructure)
            LstHighLevels = R2CoreFinancialSystemMClassAccountsCodingManagement.GetAccountsCodingCollection_HighLevels(NSS, UcSortAlphabetic.UCSortOrder)
            If LstHighLevels.Count <> 0 Then
                UcucAccountCodingCollection.UCViewAccounts(LstHighLevels)
                RaiseEvent UCRequestHighLevelsEvent(NSS)
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region


End Class
