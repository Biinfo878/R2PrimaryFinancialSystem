
Imports System.Reflection
Imports System.Drawing

Imports R2Core
Imports R2Core.BaseStandardClass
Imports R2Core.DatabaseManagement




Namespace R2CoreFinancialSystem

    Namespace AccountsCoding

        Namespace AccountsCodingLevels

            Public MustInherit Class R2CoreFinancialSystemAccountsCodingLevels
                Public Shared ReadOnly None As Int64 = 0
                Public Shared ReadOnly Group As Int64 = 1
                Public Shared ReadOnly GeneralLedger As Int64 = 2
                Public Shared ReadOnly Ledger As Int64 = 3
                Public Shared ReadOnly Detailed1 As Int64 = 4
                Public Shared ReadOnly Detailed2 As Int64 = 5
            End Class

            Public Class R2CoreFinancialSystemAccountsCodingLevelStructure
                Inherits BaseStandardClass.R2StandardStructure

                Public Property AClId As Int64 = Int64.MinValue
                Public Property AClTitle As String = String.Empty
                Public Property AClLength As Int16 = Int16.MinValue
                Public Property AClPriority As Int16 = Int16.MinValue
                Public Property DateTimeMilladi As DateTime = Now
                Public Property DateShamsi As String = String.Empty
                Public Property ViewFlag As Boolean = Boolean.FalseString
                Public Property Active As Boolean = Boolean.FalseString
                Public Property Deleted As Boolean = Boolean.TrueString

                Public Sub New()
                    MyBase.New()
                    AClId = Int64.MinValue
                    AClTitle = String.Empty
                    AClLength = Int16.MinValue
                    AClPriority = Int16.MinValue
                    DateTimeMilladi = Now
                    DateShamsi = String.Empty
                    ViewFlag = Boolean.FalseString
                    Active = Boolean.FalseString
                    Deleted = Boolean.TrueString
                End Sub

                Public Sub New(YourAClId As Int64, YourAClTitle As String, YourAClLength As Int16, YourAClPriority As Int16, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
                    MyBase.New(YourAClId, YourAClTitle.Trim())
                    _AClId = YourAClId
                    _AClTitle = YourAClTitle.Trim()
                    _AClLength = YourAClLength
                    _AClPriority = YourAClPriority
                    _DateTimeMilladi = YourDateTimeMilladi
                    _DateShamsi = YourDateShamsi.Trim()
                    _ViewFlag = YourViewFlag
                    _Active = YourActive
                    _Deleted = YourDeleted
                End Sub

            End Class

            Public NotInheritable Class R2CoreFinancialSystemMClassAccountsCodingLevelsManagement
                Public Shared Function GetAccountsCodingLevels_SearchforLeftCharacters(YourSearchString As String) As List(Of R2CoreFinancialSystemAccountsCodingLevelStructure)
                    Try
                        Dim Lst As New List(Of R2CoreFinancialSystemAccountsCodingLevelStructure)
                        Dim DS As DataSet = Nothing
                        R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels Where Left(AClTitle," & YourSearchString.Length & ")='" & YourSearchString & "' and Deleted=0 and Active=1 Order By AClTitle", 3600, DS)
                        For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                            Lst.Add(New R2CoreFinancialSystemAccountsCodingLevelStructure(DS.Tables(0).Rows(Loopx).Item("AClId"), DS.Tables(0).Rows(Loopx).Item("AClTitle"), DS.Tables(0).Rows(Loopx).Item("AClLength"), DS.Tables(0).Rows(Loopx).Item("AClPriority"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                        Next
                        Return Lst
                    Catch ex As Exception
                        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Function

                Public Shared Function GetAccountsCodingLevels_SearchIntroCharacters(YourSearchString As String) As List(Of R2CoreFinancialSystemAccountsCodingLevelStructure)
                    Try
                        Dim Lst As New List(Of R2CoreFinancialSystemAccountsCodingLevelStructure)
                        Dim DS As DataSet = Nothing
                        R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels Where AClTitle Like '%" & YourSearchString & "%' and Deleted=0 and Active=1 Order By AClTitle", 3600, DS)
                        For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                            Lst.Add(New R2CoreFinancialSystemAccountsCodingLevelStructure(DS.Tables(0).Rows(Loopx).Item("AClId"), DS.Tables(0).Rows(Loopx).Item("AClTitle"), DS.Tables(0).Rows(Loopx).Item("AClLength"), DS.Tables(0).Rows(Loopx).Item("AClPriority"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                        Next
                        Return Lst
                    Catch ex As Exception
                        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Function



            End Class


        End Namespace

        Namespace AccountCoding


        End Namespace

        Namespace BalanceSheetAccountTypes

            Public MustInherit Class R2CoreFinancialSystemBalanceSheetAccountTypes
                Public Shared ReadOnly None As Int64 = 0
                Public Shared ReadOnly Permanent As Int64 = 1
                Public Shared ReadOnly Temporary As Int64 = 2
                Public Shared ReadOnly Complex As Int64 = 3
            End Class

            Public Class R2CoreFinancialSystemBalanceSheetAccountTypeStructure
                Inherits BaseStandardClass.R2StandardStructure

                Public Property BSId As Int64 = Int64.MinValue
                Public Property BSTitle As String = String.Empty
                Public Property DateTimeMilladi As DateTime = Now
                Public Property DateShamsi As String = String.Empty
                Public Property ViewFlag As Boolean = Boolean.FalseString
                Public Property Active As Boolean = Boolean.FalseString
                Public Property Deleted As Boolean = Boolean.TrueString

                Public Sub New()
                    MyBase.New()
                    BSId = Int64.MinValue
                    BSTitle = String.Empty
                    DateTimeMilladi = Now
                    DateShamsi = String.Empty
                    ViewFlag = Boolean.FalseString
                    Active = Boolean.FalseString
                    Deleted = Boolean.TrueString
                End Sub

                Public Sub New(YourBSId As Int64, YourBSTitle As String, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
                    MyBase.New(YourBSId, YourBSTitle.Trim())
                    _BSId = YourBSId
                    _BSTitle = YourBSTitle.Trim()
                    _DateTimeMilladi = YourDateTimeMilladi
                    _DateShamsi = YourDateShamsi.Trim()
                    _ViewFlag = YourViewFlag
                    _Active = YourActive
                    _Deleted = YourDeleted
                End Sub

            End Class

            Public NotInheritable Class R2CoreFinancialSystemMClassBalanceSheetAccountTypesManagement
                Public Shared Function GetBalanceSheetAccountTypes_SearchforLeftCharacters(YourSearchString As String) As List(Of R2CoreFinancialSystemBalanceSheetAccountTypeStructure)
                    Try
                        Dim Lst As New List(Of R2CoreFinancialSystemBalanceSheetAccountTypeStructure)
                        Dim DS As DataSet = Nothing
                        R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryFinancialSystem.dbo.TblBalanceSheetAccountTypes Where Left(BSTitle," & YourSearchString.Length & ")='" & YourSearchString & "' and Deleted=0 and Active=1 Order By BSTitle", 3600, DS)
                        For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                            Lst.Add(New R2CoreFinancialSystemBalanceSheetAccountTypeStructure(DS.Tables(0).Rows(Loopx).Item("BSId"), DS.Tables(0).Rows(Loopx).Item("BSTitle"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                        Next
                        Return Lst
                    Catch ex As Exception
                        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Function

                Public Shared Function GetBalanceSheetAccountTypes_SearchIntroCharacters(YourSearchString As String) As List(Of R2CoreFinancialSystemBalanceSheetAccountTypeStructure)
                    Try
                        Dim Lst As New List(Of R2CoreFinancialSystemBalanceSheetAccountTypeStructure)
                        Dim DS As DataSet = Nothing
                        R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryFinancialSystem.dbo.TblBalanceSheetAccountTypes Where BSTitle Like '%" & YourSearchString & "%' and Deleted=0 and Active=1 Order By BSTitle", 3600, DS)
                        For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                            Lst.Add(New R2CoreFinancialSystemBalanceSheetAccountTypeStructure(DS.Tables(0).Rows(Loopx).Item("BSId"), DS.Tables(0).Rows(Loopx).Item("BSTitle"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                        Next
                        Return Lst
                    Catch ex As Exception
                        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Function

            End Class

        End Namespace

        Namespace CostBenefitAccountTypes
            Public MustInherit Class R2CoreFinancialSystemCostBenefitAccountTypes
                Public Shared ReadOnly None As Int64 = 0
                Public Shared ReadOnly Income As Int64 = 1
                Public Shared ReadOnly Expense As Int64 = 2
            End Class

            Public Class R2CoreFinancialSystemCostBenefitAccountTypeStructure
                Inherits BaseStandardClass.R2StandardStructure

                Public Property CBId As Int64 = Int64.MinValue
                Public Property CBTitle As String = String.Empty
                Public Property DateTimeMilladi As DateTime = Now
                Public Property DateShamsi As String = String.Empty
                Public Property ViewFlag As Boolean = Boolean.FalseString
                Public Property Active As Boolean = Boolean.FalseString
                Public Property Deleted As Boolean = Boolean.TrueString

                Public Sub New()
                    MyBase.New()
                    CBId = Int64.MinValue
                    CBTitle = String.Empty
                    DateTimeMilladi = Now
                    DateShamsi = String.Empty
                    ViewFlag = Boolean.FalseString
                    Active = Boolean.FalseString
                    Deleted = Boolean.TrueString
                End Sub

                Public Sub New(YourCBId As Int64, YourCBTitle As String, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
                    MyBase.New(YourCBId, YourCBTitle.Trim())
                    _CBId = YourCBId
                    _CBTitle = YourCBTitle.Trim()
                    _DateTimeMilladi = YourDateTimeMilladi
                    _DateShamsi = YourDateShamsi.Trim()
                    _ViewFlag = YourViewFlag
                    _Active = YourActive
                    _Deleted = YourDeleted
                End Sub

            End Class

            Public NotInheritable Class R2CoreFinancialSystemMClassCostBenefitAccountTypesManagement
                Public Shared Function GetCostBenefitAccountTypes_SearchforLeftCharacters(YourSearchString As String) As List(Of R2CoreFinancialSystemCostBenefitAccountTypeStructure)
                    Try
                        Dim Lst As New List(Of R2CoreFinancialSystemCostBenefitAccountTypeStructure)
                        Dim DS As DataSet = Nothing
                        R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryFinancialSystem.dbo.TblCostBenefitAccountTypes Where Left(CBTitle," & YourSearchString.Length & ")='" & YourSearchString & "' and Deleted=0 and Active=1 Order By CBTitle", 3600, DS)
                        For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                            Lst.Add(New R2CoreFinancialSystemCostBenefitAccountTypeStructure(DS.Tables(0).Rows(Loopx).Item("CBId"), DS.Tables(0).Rows(Loopx).Item("CBTitle"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                        Next
                        Return Lst
                    Catch ex As Exception
                        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Function

                Public Shared Function GetCostBenefitAccountTypes_SearchIntroCharacters(YourSearchString As String) As List(Of R2CoreFinancialSystemCostBenefitAccountTypeStructure)
                    Try
                        Dim Lst As New List(Of R2CoreFinancialSystemCostBenefitAccountTypeStructure)
                        Dim DS As DataSet = Nothing
                        R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryFinancialSystem.dbo.TblCostBenefitAccountTypes Where CBTitle Like '%" & YourSearchString & "%' and Deleted=0 and Active=1 Order By CBTitle", 3600, DS)
                        For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                            Lst.Add(New R2CoreFinancialSystemCostBenefitAccountTypeStructure(DS.Tables(0).Rows(Loopx).Item("CBId"), DS.Tables(0).Rows(Loopx).Item("CBTitle"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                        Next
                        Return Lst
                    Catch ex As Exception
                        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Function

            End Class

        End Namespace

    End Namespace

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

            Public Sub New(ByVal YourOId As Int64, ByVal YourADTypeId As Int64, ByVal YourADTypeName As String, ByVal YourADTypeTitle As String, YourADTypeColor As Color, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
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

