
Imports System.Reflection

Imports R2CoreGUI
Imports R2Core.ExceptionManagement
Imports R2CoreFinancialSystem.AccountsCoding.AccountsCoding
Imports R2CoreFinancialSystem.AccountsCoding.Exceptions
Imports R2CoreFinancialSystem.AccountingDocuments.Exceptions
Imports R2CoreFinancialSystem.AccountsCoding.AccountsCodingLevels
Imports R2CoreFinancialSystem.AccountsCoding.BalanceSheetAccountTypes
Imports R2CoreFinancialSystem.AccountsCoding.CostBenefitAccountTypes


Public Class UCManipulationAccountCoding
    Inherits UCAccountCoding


    Public Event UCDataChangedEvent()


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub UCRefreshInformation()
        Try
            UcTextBoxAccountCode.UCRefresh()
            UcPersianTextBoxAccountCodeTitle.UCRefresh()
            UcSearcherAccountsCodingLevels.UCRefreshInformation()
            UcSearcherBalanceSheetAccountTypes.UCRefreshInformation()
            UcSearcherCostBenefitAccountTypes.UCRefreshInformation()
            UcNumberAccountId.UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCViewAccount(YourNSS As R2CoreFinancialSystemAccountCodingStructure)
        Try
            UcNumberAccountId.UCValue = YourNSS.ACId
            UcTextBoxAccountCode.UCValue = YourNSS.ACCode.Trim
            UcPersianTextBoxAccountCodeTitle.UCValue = YourNSS.ACTitle.Trim
            UcSearcherAccountsCodingLevels.UCViewNSS(New R2Core.BaseStandardClass.R2StandardStructure(R2CoreFinancialSystemMClassAccountsCodingLevelsManagement.GetNSSAccountsCodingLevel(YourNSS.AClId).AClId, R2CoreFinancialSystemMClassAccountsCodingLevelsManagement.GetNSSAccountsCodingLevel(YourNSS.AClId).AClTitle))
            UcSearcherBalanceSheetAccountTypes.UCViewNSS(New R2Core.BaseStandardClass.R2StandardStructure(R2CoreFinancialSystemMClassBalanceSheetAccountTypesManagement.GetNSSBalanceSheetAccountType(YourNSS.BSId).BSId, R2CoreFinancialSystemMClassBalanceSheetAccountTypesManagement.GetNSSBalanceSheetAccountType(YourNSS.BSId).BSTitle))
            UcSearcherCostBenefitAccountTypes.UCViewNSS(New R2Core.BaseStandardClass.R2StandardStructure(R2CoreFinancialSystemMClassCostBenefitAccountTypesManagement.GetNSSCostBenefitAccountType(YourNSS.CBId).CBId, R2CoreFinancialSystemMClassCostBenefitAccountTypesManagement.GetNSSCostBenefitAccountType(YourNSS.CBId).CBTitle))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCManipulationAccountCoding_UCViewNSSNothingRequested() Handles Me.UCViewNSSNothingRequested
        Try
            UCRefreshInformation()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCManipulationAccountCoding_UCViewNSSRequested(NSSCurrent As R2CoreFinancialSystemAccountCodingStructure) Handles Me.UCViewNSSRequested
        Try
            UCViewAccount(NSSCurrent)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCManipulationAccountCoding_UCGotFocusedEvent() Handles Me.UCGotFocusedEvent
        Try
            UcTextBoxAccountCode.UCFocus()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonCButtonNewAccount_UCClickedEvent() Handles UcButtonCButtonNewAccount.UCClickedEvent
        Try
            UCNSSCurrent = Nothing
            UcTextBoxAccountCode.UCFocus()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonCButtonRegisterAccount_UCClickedEvent() Handles UcButtonCButtonRegisterAccount.UCClickedEvent
        Try
            If UCNSSCurrent IsNot Nothing Then Throw New Exception("از کلید حساب جدید استفاده نمایید")
            Dim NSS As R2CoreFinancialSystemAccountCodingStructure
            NSS = New R2CoreFinancialSystemAccountCodingStructure(Nothing, UcTextBoxAccountCode.UCValue, UcPersianTextBoxAccountCodeTitle.UCValue, String.Empty, UcSearcherAccountsCodingLevels.UCGetSelectedNSS.OCode, UcSearcherBalanceSheetAccountTypes.UCGetSelectedNSS.OCode, UcSearcherCostBenefitAccountTypes.UCGetSelectedNSS.OCode, Nothing, Nothing, Nothing, Nothing, Nothing)
            UcNumberAccountId.UCValue = R2CoreFinancialSystemMClassAccountsCodingManagement.RegisterAccount(NSS)
            UCViewNSS(UcNumberAccountId.UCValue)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "ثبت حساب با موفقیت انجام گرفت", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            RaiseEvent UCDataChangedEvent()
        Catch ex As CascadingAccountingCodingIllegalException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorInDataEntry, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As IllegalAccountLengthTotalException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorInDataEntry, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As DataEntryException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorInDataEntry, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As AccountStructureDeclinedException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorInDataEntry, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As AccountDeclineforRegisteringException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorInDataEntry, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As AccountAlreadyExistException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorInDataEntry, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonCButtonEditAccount_UCClickedEvent() Handles UcButtonCButtonEditAccount.UCClickedEvent
        Try
            If UCNSSCurrent Is Nothing Then Throw New NotSelectedAccountException
            Dim NSS As R2CoreFinancialSystemAccountCodingStructure
            NSS = New R2CoreFinancialSystemAccountCodingStructure(UcNumberAccountId.UCValue, UcTextBoxAccountCode.UCValue, UcPersianTextBoxAccountCodeTitle.UCValue, String.Empty, UcSearcherAccountsCodingLevels.UCGetSelectedNSS.OCode, UcSearcherBalanceSheetAccountTypes.UCGetSelectedNSS.OCode, UcSearcherCostBenefitAccountTypes.UCGetSelectedNSS.OCode, Nothing, Nothing, Nothing, Nothing, Nothing)
            UcNumberAccountId.UCValue = R2CoreFinancialSystemMClassAccountsCodingManagement.EditAccount(NSS)
            UCViewNSS(UcNumberAccountId.UCValue)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "ویرایش حساب با موفقیت انجام گرفت", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            RaiseEvent UCDataChangedEvent()
        Catch ex As CascadingAccountingCodingIllegalException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorInDataEntry, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As NotSelectedAccountException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As IllegalAccountLengthTotalException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorInDataEntry, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As AccountStructureDeclinedException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorInDataEntry, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As AccountDeclineforEditingException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As AccountAlreadyDosNotExistException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As AccountDeclineforRegisteringException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As AccountAlreadyExistException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonCButtonDeleteAccount_UCClickedEvent() Handles UcButtonCButtonDeleteAccount.UCClickedEvent
        Try
            If UCNSSCurrent Is Nothing Then Throw New NotSelectedAccountException
            Dim NSS As R2CoreFinancialSystemAccountCodingStructure
            NSS = New R2CoreFinancialSystemAccountCodingStructure(UcNumberAccountId.UCValue, UcTextBoxAccountCode.UCValue, UcPersianTextBoxAccountCodeTitle.UCValue, String.Empty, UcSearcherAccountsCodingLevels.UCGetSelectedNSS.OCode, UcSearcherBalanceSheetAccountTypes.UCGetSelectedNSS.OCode, UcSearcherCostBenefitAccountTypes.UCGetSelectedNSS.OCode, Nothing, Nothing, Nothing, Nothing, Nothing)
            R2CoreFinancialSystemMClassAccountsCodingManagement.DeleteAccount(NSS)
            UCRefreshGeneral()
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "حذف حساب با موفقیت انجام گرفت", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            RaiseEvent UCDataChangedEvent()

        Catch ex As AccountHasLowLevelsException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As NotSelectedAccountException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As AccountNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As AccountHasTurnOverinAccountingDocumentsException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
