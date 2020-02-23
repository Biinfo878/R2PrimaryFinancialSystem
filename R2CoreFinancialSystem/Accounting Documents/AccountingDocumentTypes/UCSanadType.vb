
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms


Imports R2CoreFinancialSystem.R2CoreFinancialSystem.AccountingDocumentTypes



Public Class UCSanadType
    Inherits R2CoreGUI.UCGeneral

#Region "General Properties"

    Private _UCCurrentNSS As R2CoreFinancialSystemStandardAccountingDocumentTypeStructure = R2CoreFinancialSystemMClassAccountingDocumentTypesManagement.GetNSSAccountingDocumentType(R2CoreAccountingDocumentTypes.None)
    Public Property UCCurrentNSS As R2CoreFinancialSystemStandardAccountingDocumentTypeStructure
        Get
            Return _UCCurrentNSS
        End Get
        Set(ByVal value As R2CoreFinancialSystemStandardAccountingDocumentTypeStructure)
            _UCCurrentNSS = value
            UcLabel.UCForeColor = value.ADTypeColor
            UcLabel.UCValue = value.ADTypeTitle
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub UCRefresh()
        Try
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"

#End Region

#Region "Event Handlers"

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region




End Class
