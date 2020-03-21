
Imports System.Reflection


Imports R2CoreGUI
Imports R2Core.ProcessesManagement
Imports R2CoreFinancialSystem.ProcessesManagement
Imports R2CoreFinancialSystem.AccountsCoding.AccountsCoding

Public Class FrmcManipulationAccountsCoding
    Inherits FrmcGeneral


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            InitializeSpecial()
            FrmRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassProcessesManagement.GetNSSProcess(R2CoreFinancialSystemProcesses.FrmcManipulationAccountsCoding))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub FrmRefresh()
        Try

        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcucAccountCodingCollectionAdvanced_UCSelectedNSSChangedEvent(NSS As R2CoreFinancialSystemAccountCodingStructure) Handles UcucAccountCodingCollectionAdvanced.UCSelectedNSSChangedEvent
        Try
            UcManipulationAccountCoding.UCViewNSS(NSS)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucAccountCodingCollectionAdvanced_UCRequestHighLevelsEvent(NSS As R2CoreFinancialSystemAccountCodingStructure) Handles UcucAccountCodingCollectionAdvanced.UCRequestHighLevelsEvent

    End Sub

    Private Sub UcucAccountCodingCollectionAdvanced_UCRequestLowLevelsEvent(NSS As R2CoreFinancialSystemAccountCodingStructure) Handles UcucAccountCodingCollectionAdvanced.UCRequestLowLevelsEvent

    End Sub

    Private Sub UcManipulationAccountCoding_UCDataChangedEvent() Handles UcManipulationAccountCoding.UCDataChangedEvent
        Try
            If ChkRefresh.Checked Then UcucAccountCodingCollectionAdvanced.UCRefreshCollection()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
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