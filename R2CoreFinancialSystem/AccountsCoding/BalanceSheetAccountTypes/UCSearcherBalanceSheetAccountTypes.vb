
Imports System.Drawing
Imports System.Reflection

Imports R2CoreGUI
Imports R2Core.BaseStandardClass
Imports R2CoreFinancialSystem.R2CoreFinancialSystem.AccountsCoding.BalanceSheetAccountTypes




Public Class UCSearcherBalanceSheetAccountTypes
    Inherits UCSearcherAdvance



#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCMaximizeHight = 200
            UCBackColor = Color.OrangeRed
            UCRefreshInformation()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefreshInformation()
        Try
            UCFillListBox(R2CoreFinancialSystemMClassBalanceSheetAccountTypesManagement.GetBalanceSheetAccountTypes_SearchforLeftCharacters(String.Empty).Select(Function(X) New R2StandardStructure(X.OCode, X.OName)).ToList())
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCSearcherBalanceSheetAccountTypes_UCIconClicked() Handles Me.UCIconRefreshRequestClicked
        Try
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCSearcherBalanceSheetAccountTypes_UCSearchOptional1RequestEvent(SearchString As String) Handles Me.UCSearchOptional1RequestEvent
        Try
            UCFillListBox(R2CoreFinancialSystemMClassBalanceSheetAccountTypesManagement.GetBalanceSheetAccountTypes_SearchforLeftCharacters(SearchString).Select(Function(X) New R2StandardStructure(X.OCode, X.OName)).ToList())
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCSearcherBalanceSheetAccountTypes_UCSearchOptional2RequestEvent(SearchString As String) Handles Me.UCSearchOptional2RequestEvent
        Try
            UCFillListBox(R2CoreFinancialSystemMClassBalanceSheetAccountTypesManagement.GetBalanceSheetAccountTypes_SearchIntroCharacters(SearchString).Select(Function(X) New R2StandardStructure(X.OCode, X.OName)).ToList())
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
