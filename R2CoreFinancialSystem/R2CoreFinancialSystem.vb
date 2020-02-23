
Imports System.Reflection
Imports System.Drawing

Imports R2Core
Imports R2Core.BaseStandardClass
Imports R2Core.DatabaseManagement




Namespace R2CoreFinancialSystem

    Namespace AccountingDocumentTypes

        Public MustInherit Class R2CoreAccountingDocumentTypes
            Public Shared ReadOnly Property None As Int64 = 0








        End Class

        Public Class R2CoreFinancialSystemStandardAccountingDocumentTypeStructure
            Inherits R2StandardStructure

            Public Sub New()
                MyBase.New()
                OId = Long.MinValue
                ADTypeId = Long.MinValue
                ADTypeName = String.Empty
                ADTypeTitle = String.Empty
                ADTypeColor = Color.Empty
                DateTimeMilladi = Now
                DateShamsi = String.Empty
                ViewFlag = Boolean.FalseString
                Active = Boolean.FalseString
                Deleted = Boolean.TrueString
            End Sub

            Public Sub New(ByVal YourOId As Int64, ByVal YourADTypeId As Int64, ByVal YourADTypeName As String, ByVal YourADTypeTitle As String, YourADTypeColor As color, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
                MyBase.New(YourADTypeId, YourADTypeName)
                OId = YourOId
                ADTypeId = YourADTypeId
                ADTypeName = YourADTypeName
                ADTypeTitle = YourADTypeTitle
                ADTypeColor = YourADTypeColor
                DateTimeMilladi = YourDateTimeMilladi
                DateShamsi = YourDateShamsi
                ViewFlag = YourViewFlag
                Active = YourActive
                Deleted = YourDeleted
            End Sub

            Public Property OId As Int64
            Public Property ADTypeId As Int64
            Public Property ADTypeName As String
            Public Property ADTypeTitle As String
            Public Property ADTypeColor As Drawing.Color
            Public Property DateTimeMilladi As DateTime
            Public Property DateShamsi As String
            Public Property ViewFlag As Boolean
            Public Property Active As Boolean
            Public Property Deleted As Boolean

        End Class

        Public MustInherit Class R2CoreFinancialSystemMClassAccountingDocumentTypesManagement
            Public Shared Function GetNSSAccountingDocumentType(ByVal AccountingDocumentTypeId As Int64) As R2CoreFinancialSystemStandardAccountingDocumentTypeStructure
                Try
                    Dim Ds As DataSet
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2PrimaryFinancialSystem.dbo.AccountingDocumentTypes Where ADTypeId=" & AccountingDocumentTypeId & "", 3600, Ds)
                    Return New R2CoreFinancialSystemStandardAccountingDocumentTypeStructure(Ds.Tables(0).Rows(0).Item("OId"), Ds.Tables(0).Rows(0).Item("ADTypeId"), Ds.Tables(0).Rows(0).Item("ADTypeName").trim, Ds.Tables(0).Rows(0).Item("ADTypeTitle").trim, Color.FromName(Ds.Tables(0).Rows(0).Item("ADTypeColor").trim), Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), Ds.Tables(0).Rows(0).Item("DateShamsi").trim, Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("Deleted"))
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

        End Class


    End Namespace

End Namespace

