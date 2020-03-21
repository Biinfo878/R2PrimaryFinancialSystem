
Imports System.Reflection
Imports System.Globalization
Imports System.Drawing

Imports R2Core
Imports R2Core.BaseStandardClass
Imports R2Core.DatabaseManagement
Imports R2Core.ProcessesManagement
Imports R2CoreFinancialSystem.AccountsCoding.Exceptions
Imports R2CoreFinancialSystem.AccountsCoding.AccountsCoding
Imports R2CoreFinancialSystem.AccountsCoding.AccountsCodingLevels
Imports R2CoreFinancialSystem.AccountingDocuments
Imports R2CoreFinancialSystem.AccountingDocuments.Exceptions
Imports R2CoreFinancialSystem.AccountsCoding.AccountsCodingLevels.Exceptions
Imports R2CoreFinancialSystem.AccountsCoding.BalanceSheetAccountTypes.Exceptions
Imports R2CoreFinancialSystem.AccountsCoding.CostBenefitAccountTypes.Exceptions


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
            Public Property AClLengthTotal As Int16 = Int16.MinValue
            Public Property AClPriority As Int16 = Int16.MinValue
            Public Property AClColor As Color = Color.White
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
                AClLengthTotal = Int16.MinValue
                AClPriority = Int16.MinValue
                AClColor = Color.White
                DateTimeMilladi = Now
                DateShamsi = String.Empty
                ViewFlag = Boolean.FalseString
                Active = Boolean.FalseString
                Deleted = Boolean.TrueString
            End Sub

            Public Sub New(YourAClId As Int64, YourAClTitle As String, YourAClLength As Int16, YourAClLengthTotal As Int16, YourAClPriority As Int16, YourAClColor As Color, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
                MyBase.New(YourAClId, YourAClTitle.Trim())
                _AClId = YourAClId
                _AClTitle = YourAClTitle.Trim()
                _AClLength = YourAClLength
                _AClLengthTotal = YourAClLengthTotal
                _AClPriority = YourAClPriority
                _AClColor = YourAClColor
                _DateTimeMilladi = YourDateTimeMilladi
                _DateShamsi = YourDateShamsi.Trim()
                _ViewFlag = YourViewFlag
                _Active = YourActive
                _Deleted = YourDeleted
            End Sub

        End Class

        Public NotInheritable Class R2CoreFinancialSystemMClassAccountsCodingLevelsManagement
            Public Shared Function GetNSSAccountsCodingLevel(YourAClId As Int64) As R2CoreFinancialSystemAccountsCodingLevelStructure
                Try
                    Dim DS As DataSet = Nothing
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * From R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels Where AClId=" & YourAClId & " and Active=1 and Deleted=0", 3600, DS).GetRecordsCount = 0 Then Throw New AccountsCodingLevelNotFoundException
                    Return New R2CoreFinancialSystemAccountsCodingLevelStructure(DS.Tables(0).Rows(0).Item("AClId"), DS.Tables(0).Rows(0).Item("AClTitle"), DS.Tables(0).Rows(0).Item("AClLength"), DS.Tables(0).Rows(0).Item("AClLengthTotal"), DS.Tables(0).Rows(0).Item("AClPriority"), Color.FromName(DS.Tables(0).Rows(0).Item("AClColor").trim), DS.Tables(0).Rows(0).Item("DateTimeMilladi"), DS.Tables(0).Rows(0).Item("DateShamsi"), DS.Tables(0).Rows(0).Item("ViewFlag"), DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("Deleted"))
                Catch ex As AccountsCodingLevelNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetAccountsCodingLevels_SearchforLeftCharacters(YourSearchString As String) As List(Of R2CoreFinancialSystemAccountsCodingLevelStructure)
                Try
                    Dim Lst As New List(Of R2CoreFinancialSystemAccountsCodingLevelStructure)
                    Dim DS As DataSet = Nothing
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels Where Left(AClTitle," & YourSearchString.Length & ")='" & YourSearchString & "' and Deleted=0 and Active=1 Order By AClId", 3600, DS)
                    For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                        Lst.Add(New R2CoreFinancialSystemAccountsCodingLevelStructure(DS.Tables(0).Rows(Loopx).Item("AClId"), DS.Tables(0).Rows(Loopx).Item("AClTitle"), DS.Tables(0).Rows(Loopx).Item("AClLength"), DS.Tables(0).Rows(0).Item("AClLengthTotal"), DS.Tables(0).Rows(Loopx).Item("AClPriority"), Color.FromName(DS.Tables(0).Rows(0).Item("AClColor")), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
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
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels Where AClTitle Like '%" & YourSearchString & "%' and Deleted=0 and Active=1 Order By AClId", 3600, DS)
                    For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                        Lst.Add(New R2CoreFinancialSystemAccountsCodingLevelStructure(DS.Tables(0).Rows(Loopx).Item("AClId"), DS.Tables(0).Rows(Loopx).Item("AClTitle"), DS.Tables(0).Rows(Loopx).Item("AClLength"), DS.Tables(0).Rows(0).Item("AClLengthTotal"), DS.Tables(0).Rows(Loopx).Item("AClPriority"), Color.FromName(DS.Tables(0).Rows(0).Item("AClColor")), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                    Next
                    Return Lst
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

        End Class

        Namespace Exceptions

            Public Class AccountsCodingLevelNotFoundException
                Inherits ApplicationException

                Public Overrides ReadOnly Property Message As String
                    Get
                        Return "در سطوح کدینگ ، سطحی با اطلاعات مورد نظر وجود ندارد"
                    End Get
                End Property
            End Class

        End Namespace

    End Namespace

    Namespace AccountsCoding

        Public Class R2CoreFinancialSystemAccountCodingStructure
            Inherits BaseStandardClass.R2StandardStructure

            Public Property ACId As Int64 = Int64.MinValue
            Public Property ACCode As String = String.Empty
            Public Property ACTitle As String = String.Empty
            Public Property ACDescription As String = String.Empty
            Public Property AClId As Int64 = Int64.MinValue
            Public Property BSId As Int64 = Int64.MinValue
            Public Property CBId As Int64 = Int64.MinValue
            Public Property DateTimeMilladi As DateTime = Now
            Public Property DateShamsi As String = String.Empty
            Public Property ViewFlag As Boolean = Boolean.FalseString
            Public Property Active As Boolean = Boolean.FalseString
            Public Property Deleted As Boolean = Boolean.TrueString

            Public Sub New()
                MyBase.New()
                ACId = Int64.MinValue
                ACCode = String.Empty
                ACTitle = String.Empty
                ACDescription = String.Empty
                AClId = Int64.MinValue
                BSId = Int64.MinValue
                CBId = Int64.MinValue
                DateTimeMilladi = Now
                DateShamsi = String.Empty
                ViewFlag = Boolean.FalseString
                Active = Boolean.FalseString
                Deleted = Boolean.TrueString
            End Sub

            Public Sub New(YourACId As Int64, YourACCode As String, YourACTitle As String, YourACDescription As String, YourAClId As Int64, YourBSId As Int64, YourCBId As Int64, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
                MyBase.New(YourACCode, YourACTitle.Trim())
                _ACId = YourACId
                _ACCode = YourACCode
                _ACTitle = YourACTitle.Trim()
                _ACDescription = YourACDescription
                _AClId = YourAClId
                _BSId = YourBSId
                _CBId = YourCBId
                _DateTimeMilladi = YourDateTimeMilladi
                _DateShamsi = YourDateShamsi
                _ViewFlag = YourViewFlag
                _Active = YourActive
                _Deleted = YourDeleted
            End Sub

        End Class

        Public Class R2CoreFinancialSystemAccountCodingExtendedStructure
            Inherits R2CoreFinancialSystemAccountCodingStructure

            Public Property AClTitle As String = String.Empty
            Public Property BSTitle As String = String.Empty
            Public Property CBTitle As String = String.Empty
            Public Property AClColor As Color = Color.Black

            Public Sub New()
                MyBase.New()
                AClTitle = String.Empty
                BSTitle = String.Empty
                CBTitle = String.Empty
                AClColor = Color.Black
            End Sub

            Public Sub New(YourNSS As R2CoreFinancialSystemAccountCodingStructure, YourAClTitle As String, YourBSTitle As String, YourCBTitle As String, YourAClColor As Color)
                MyBase.New(YourNSS.ACId, YourNSS.ACCode, YourNSS.ACTitle, YourNSS.ACDescription, YourNSS.AClId, YourNSS.BSId, YourNSS.CBId, YourNSS.DateTimeMilladi, YourNSS.DateShamsi, YourNSS.ViewFlag, YourNSS.Active, YourNSS.Deleted)
                AClTitle = YourAClTitle
                BSTitle = YourBSTitle
                CBTitle = YourCBTitle
                AClColor = YourAClColor
            End Sub

        End Class

        Public NotInheritable Class R2CoreFinancialSystemMClassAccountsCodingManagement
            Private Shared _DateTime As New DateAndTimeManagement.R2DateTime

            Public Shared Function GetAccountsCodingCollection_SearchIntroCharacters(YourSearchString As String, YourOrder As R2Core.R2Enums.SortOrder) As List(Of R2CoreFinancialSystemAccountCodingExtendedStructure)
                Try
                    Dim OrderString As String = IIf(YourOrder = R2Enums.SortOrder.Code, " Order By AC.ACCode ,AC.AClId ", " Order By AC.ACTitle ")
                    Dim Lst As New List(Of R2CoreFinancialSystemAccountCodingExtendedStructure)
                    Dim DS As DataSet = Nothing
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                          "Select AC.*,ACl.AClTitle,BS.BSTitle,CB.CBTitle,ACl.AClColor from R2PrimaryFinancialSystem.dbo.TblAccountsCoding as AC
                             Inner Join R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels as ACl On AC.AClId=ACl.AClId 
                             Inner Join R2PrimaryFinancialSystem.dbo.TblBalanceSheetAccountTypes as BS On AC.BSId=BS.BSId 
                             Inner Join R2PrimaryFinancialSystem.dbo.TblCostBenefitAccountTypes as CB On AC.CBId =CB.CBId 
                           Where AC.Active=1 and AC.Deleted=0 and AC.ViewFlag=1 and ACl.Active=1 and ACl.Deleted=0 and BS.Active=1 and BS.Deleted=0 and CB.Active=1 and CB.Deleted=0 and AC.ACTitle like '%" & YourSearchString & "%'
                           " + OrderString + "", 1, DS)
                    For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                        Lst.Add(New R2CoreFinancialSystemAccountCodingExtendedStructure(New R2CoreFinancialSystemAccountCodingStructure(DS.Tables(0).Rows(Loopx).Item("ACId"), DS.Tables(0).Rows(Loopx).Item("ACCode"), DS.Tables(0).Rows(Loopx).Item("ACTitle"), DS.Tables(0).Rows(Loopx).Item("ACDescription"), DS.Tables(0).Rows(Loopx).Item("AClId"), DS.Tables(0).Rows(Loopx).Item("BSId"), DS.Tables(0).Rows(Loopx).Item("CBId"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")), DS.Tables(0).Rows(Loopx).Item("AClTitle").trim, DS.Tables(0).Rows(Loopx).Item("BSTitle").trim, DS.Tables(0).Rows(Loopx).Item("CBTitle").trim, Color.FromName(DS.Tables(0).Rows(Loopx).Item("AClColor").trim)))
                    Next
                    Return Lst
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetAccountsCodingCollection_SearchforLeftCharacters(YourSearchString As String, YourOrder As R2Core.R2Enums.SortOrder) As List(Of R2CoreFinancialSystemAccountCodingExtendedStructure)
                Try
                    Dim OrderString As String = IIf(YourOrder = R2Enums.SortOrder.Code, " Order By AC.ACCode ,AC.AClId ", " Order By AC.ACTitle ")
                    Dim Lst As New List(Of R2CoreFinancialSystemAccountCodingExtendedStructure)
                    Dim DS As DataSet = Nothing
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                          "Select AC.*,ACl.AClTitle,BS.BSTitle,CB.CBTitle,ACl.AClColor from R2PrimaryFinancialSystem.dbo.TblAccountsCoding as AC
                              Inner Join R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels as ACl On AC.AClId=ACl.AClId 
                              Inner Join R2PrimaryFinancialSystem.dbo.TblBalanceSheetAccountTypes as BS On AC.BSId=BS.BSId 
                              Inner Join R2PrimaryFinancialSystem.dbo.TblCostBenefitAccountTypes as CB On AC.CBId =CB.CBId 
                           Where AC.Active=1 and AC.Deleted=0 and AC.ViewFlag=1 and ACl.Active=1 and ACl.Deleted=0 and BS.Active=1 and BS.Deleted=0 and CB.Active=1 and CB.Deleted=0 and AC.ACTitle like '" & YourSearchString & "%'
                           " + OrderString + "", 1, DS)
                    For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                        Lst.Add(New R2CoreFinancialSystemAccountCodingExtendedStructure(New R2CoreFinancialSystemAccountCodingStructure(DS.Tables(0).Rows(Loopx).Item("ACId"), DS.Tables(0).Rows(Loopx).Item("ACCode"), DS.Tables(0).Rows(Loopx).Item("ACTitle"), DS.Tables(0).Rows(Loopx).Item("ACDescription"), DS.Tables(0).Rows(Loopx).Item("AClId"), DS.Tables(0).Rows(Loopx).Item("BSId"), DS.Tables(0).Rows(Loopx).Item("CBId"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")), DS.Tables(0).Rows(Loopx).Item("AClTitle").trim, DS.Tables(0).Rows(Loopx).Item("BSTitle").trim, DS.Tables(0).Rows(Loopx).Item("CBTitle").trim, Color.FromName(DS.Tables(0).Rows(Loopx).Item("AClColor").trim)))
                    Next
                    Return Lst
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetAccountsCodingCollection_LowLevels(YourNSS As R2CoreFinancialSystemAccountCodingExtendedStructure, YourOrder As R2Core.R2Enums.SortOrder) As List(Of R2CoreFinancialSystemAccountCodingExtendedStructure)
                Try
                    Dim OrderString As String = IIf(YourOrder = R2Enums.SortOrder.Code, " Order By AC.ACCode ,AC.AClId ", " Order By AC.ACTitle ")
                    Dim Lst As New List(Of R2CoreFinancialSystemAccountCodingExtendedStructure)
                    Dim DS As DataSet = Nothing
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                          "Select AC.*,ACLevels.AClTitle,BS.BSTitle,CB.CBTitle,ACLevels.AClColor from R2PrimaryFinancialSystem.dbo.TblAccountsCoding as AC 
                               Inner Join R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels as ACLevels On AC.AClId=ACLevels.AClId  
                               Inner Join R2PrimaryFinancialSystem.dbo.TblBalanceSheetAccountTypes as BS On AC.BSId=BS.BSId 
                               Inner Join R2PrimaryFinancialSystem.dbo.TblCostBenefitAccountTypes as CB On AC.CBId =CB.CBId 
                           Where ACLevels.AClPriority=(Select ACLevels.AClPriority from R2PrimaryFinancialSystem.dbo.TblAccountsCoding as AC 
                                                          Inner Join R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels as ACLevels On AC.AClId=ACLevels.AClId
                                                       Where AC.ACCode='" & YourNSS.ACCode.Trim & "' and AC.Active=1 and AC.Deleted=0)+1 
	                             and left(AC.ACCode," & YourNSS.ACCode.Trim.Length & ")='" & YourNSS.ACCode.Trim & "' and AC.Active=1 and AC.Deleted=0 " + OrderString + "", 1, DS)
                    For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                        Lst.Add(New R2CoreFinancialSystemAccountCodingExtendedStructure(New R2CoreFinancialSystemAccountCodingStructure(DS.Tables(0).Rows(Loopx).Item("ACId"), DS.Tables(0).Rows(Loopx).Item("ACCode"), DS.Tables(0).Rows(Loopx).Item("ACTitle"), DS.Tables(0).Rows(Loopx).Item("ACDescription"), DS.Tables(0).Rows(Loopx).Item("AClId"), DS.Tables(0).Rows(Loopx).Item("BSId"), DS.Tables(0).Rows(Loopx).Item("CBId"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")), DS.Tables(0).Rows(Loopx).Item("AClTitle").trim, DS.Tables(0).Rows(Loopx).Item("BSTitle").trim, DS.Tables(0).Rows(Loopx).Item("CBTitle").trim, Color.FromName(DS.Tables(0).Rows(Loopx).Item("AClColor").trim)))
                    Next
                    Return Lst
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetAccountsCodingCollection_HighLevels(YourNSS As R2CoreFinancialSystemAccountCodingExtendedStructure, YourOrder As R2Core.R2Enums.SortOrder) As List(Of R2CoreFinancialSystemAccountCodingExtendedStructure)
                Try
                    Dim OrderString As String = IIf(YourOrder = R2Enums.SortOrder.Code, " Order By AC.ACCode ,AC.AClId ", " Order By AC.ACTitle ")
                    Dim Lst As New List(Of R2CoreFinancialSystemAccountCodingExtendedStructure)
                    Dim DS As DataSet = Nothing
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                          "Declare @AClLengthTotal2Up Varchar
                           Declare @AClPriority1Up Varchar
                           Select @AClLengthTotal2Up = ACLevels.AClLengthTotal from R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels as ACLevels
                           Where ACLevels.AClPriority=(Select ACLevels.AClPriority from R2PrimaryFinancialSystem.dbo.TblAccountsCoding as AC 
                                                         Inner Join R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels as ACLevels On AC.AClId=ACLevels.AClId
                                                       Where AC.ACCode='" & YourNSS.ACCode.Trim & "' and AC.Active=1 and AC.Deleted=0)-2

                          Select @AClPriority1Up = ACLevels.AClPriority-1 from R2PrimaryFinancialSystem.dbo.TblAccountsCoding as AC 
                              Inner Join R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels as ACLevels On AC.AClId=ACLevels.AClId
                          Where AC.ACCode='" & YourNSS.ACCode.Trim & "' and AC.Active=1 and AC.Deleted=0

                          Select AC.*,ACLevels.AClTitle,BS.BSTitle,CB.CBTitle,ACLevels.AClColor from R2PrimaryFinancialSystem.dbo.TblAccountsCoding as AC 
                            Inner Join R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels as ACLevels On AC.AClId=ACLevels.AClId  
                            Inner Join R2PrimaryFinancialSystem.dbo.TblBalanceSheetAccountTypes as BS On AC.BSId=BS.BSId 
                            Inner Join R2PrimaryFinancialSystem.dbo.TblCostBenefitAccountTypes as CB On AC.CBId =CB.CBId 
                          Where ACLevels.AClPriority=@AClPriority1Up and left(AC.ACCode,@AClLengthTotal2Up)=left('" & YourNSS.ACCode.Trim & "',@AClLengthTotal2Up) and AC.Active=1 and AC.Deleted=0 " + OrderString + "", 1, DS)
                    For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                        Lst.Add(New R2CoreFinancialSystemAccountCodingExtendedStructure(New R2CoreFinancialSystemAccountCodingStructure(DS.Tables(0).Rows(Loopx).Item("ACId"), DS.Tables(0).Rows(Loopx).Item("ACCode"), DS.Tables(0).Rows(Loopx).Item("ACTitle"), DS.Tables(0).Rows(Loopx).Item("ACDescription"), DS.Tables(0).Rows(Loopx).Item("AClId"), DS.Tables(0).Rows(Loopx).Item("BSId"), DS.Tables(0).Rows(Loopx).Item("CBId"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")), DS.Tables(0).Rows(Loopx).Item("AClTitle").trim, DS.Tables(0).Rows(Loopx).Item("BSTitle").trim, DS.Tables(0).Rows(Loopx).Item("CBTitle").trim, Color.FromName(DS.Tables(0).Rows(Loopx).Item("AClColor").trim)))
                    Next
                    Return Lst
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetAccountsCodingCollection_ByAClPriority(YourAClPriority As Int16, YourOrder As R2Core.R2Enums.SortOrder) As List(Of R2CoreFinancialSystemAccountCodingExtendedStructure)
                Try
                    Dim OrderString As String = IIf(YourOrder = R2Enums.SortOrder.Code, " Order By AC.ACCode ,AC.AClId ", " Order By AC.ACTitle ")
                    Dim Lst As New List(Of R2CoreFinancialSystemAccountCodingExtendedStructure)
                    Dim DS As DataSet = Nothing
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                          "Select AC.*,ACLevels.AClTitle,BS.BSTitle,CB.CBTitle,ACLevels.AClColor from R2PrimaryFinancialSystem.dbo.TblAccountsCoding as AC 
                            Inner Join R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels as ACLevels On AC.AClId=ACLevels.AClId  
                            Inner Join R2PrimaryFinancialSystem.dbo.TblBalanceSheetAccountTypes as BS On AC.BSId=BS.BSId 
                            Inner Join R2PrimaryFinancialSystem.dbo.TblCostBenefitAccountTypes as CB On AC.CBId =CB.CBId 
                          Where ACLevels.AClPriority=" & YourAClPriority & " and AC.Active=1 and AC.Deleted=0 " + OrderString + "", 1, DS)
                    For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                        Lst.Add(New R2CoreFinancialSystemAccountCodingExtendedStructure(New R2CoreFinancialSystemAccountCodingStructure(DS.Tables(0).Rows(Loopx).Item("ACId"), DS.Tables(0).Rows(Loopx).Item("ACCode"), DS.Tables(0).Rows(Loopx).Item("ACTitle"), DS.Tables(0).Rows(Loopx).Item("ACDescription"), DS.Tables(0).Rows(Loopx).Item("AClId"), DS.Tables(0).Rows(Loopx).Item("BSId"), DS.Tables(0).Rows(Loopx).Item("CBId"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")), DS.Tables(0).Rows(Loopx).Item("AClTitle").trim, DS.Tables(0).Rows(Loopx).Item("BSTitle").trim, DS.Tables(0).Rows(Loopx).Item("CBTitle").trim, Color.FromName(DS.Tables(0).Rows(Loopx).Item("AClColor").trim)))
                    Next
                    Return Lst
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function HasAccountLowLevels(YourNSS As R2CoreFinancialSystemAccountCodingStructure) As Boolean
                Try
                    Dim DS As DataSet = Nothing
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                          "Select AC.ACId from R2PrimaryFinancialSystem.dbo.TblAccountsCoding as AC 
                               Inner Join R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels as ACLevels On AC.AClId=ACLevels.AClId  
                           Where ACLevels.AClPriority=(Select ACLevels.AClPriority from R2PrimaryFinancialSystem.dbo.TblAccountsCoding as AC 
                                                          Inner Join R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels as ACLevels On AC.AClId=ACLevels.AClId
                                                       Where AC.ACCode='" & YourNSS.ACCode.Trim & "' and AC.Active=1 and AC.Deleted=0)+1 
	                             and left(AC.ACCode," & YourNSS.ACCode.Trim.Length & ")='" & YourNSS.ACCode.Trim & "' and AC.Active=1 and AC.Deleted=0 ", 1, DS).GetRecordsCount = 0 Then
                        Return False
                    Else
                        Return True
                    End If
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetNSSAccount(YourACId As Int64) As R2CoreFinancialSystemAccountCodingStructure
                Try
                    Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                    Da.SelectCommand = New SqlClient.SqlCommand("Select * from R2PrimaryFinancialSystem.dbo.TblAccountsCoding Where Deleted=0 and ACId=" & YourACId & "")
                    Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection
                    If Da.Fill(Ds) = 0 Then Throw New AccountNotFoundException()
                    Return New R2CoreFinancialSystemAccountCodingStructure(Ds.Tables(0).Rows(0).Item("ACId"), Ds.Tables(0).Rows(0).Item("ACCode"), Ds.Tables(0).Rows(0).Item("ACTitle"), Ds.Tables(0).Rows(0).Item("ACDescription"), Ds.Tables(0).Rows(0).Item("AClId"), Ds.Tables(0).Rows(0).Item("BSId"), Ds.Tables(0).Rows(0).Item("CBId"), Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), Ds.Tables(0).Rows(0).Item("DateShamsi"), Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("Deleted"))
                Catch ex As AccountNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetNSSAccount(YourACCode As String) As R2CoreFinancialSystemAccountCodingStructure
                Try
                    Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                    Da.SelectCommand = New SqlClient.SqlCommand("Select * from R2PrimaryFinancialSystem.dbo.TblAccountsCoding Where Deleted=0 and ltrim(rtrim(ACCode))='" & YourACCode & "'")
                    Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection
                    If Da.Fill(Ds) = 0 Then Throw New AccountNotFoundException()
                    Return New R2CoreFinancialSystemAccountCodingStructure(Ds.Tables(0).Rows(0).Item("ACId"), Ds.Tables(0).Rows(0).Item("ACCode"), Ds.Tables(0).Rows(0).Item("ACTitle"), Ds.Tables(0).Rows(0).Item("ACDescription"), Ds.Tables(0).Rows(0).Item("AClId"), Ds.Tables(0).Rows(0).Item("BSId"), Ds.Tables(0).Rows(0).Item("CBId"), Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), Ds.Tables(0).Rows(0).Item("DateShamsi"), Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("Deleted"))
                Catch ex As AccountNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetNSSActiveAccount(YourACId As Int64) As R2CoreFinancialSystemAccountCodingExtendedStructure
                Try
                    Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                    Da.SelectCommand = New SqlClient.SqlCommand(
                        "Select AC.*,ACl.AClTitle,BS.BSTitle,CB.CBTitle,ACl.AClColor from R2PrimaryFinancialSystem.dbo.TblAccountsCoding as AC
                             Inner Join R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels as ACl On AC.AClId=ACl.AClId 
                             Inner Join R2PrimaryFinancialSystem.dbo.TblBalanceSheetAccountTypes as BS On AC.BSId=BS.BSId 
                             Inner Join R2PrimaryFinancialSystem.dbo.TblCostBenefitAccountTypes as CB On AC.CBId =CB.CBId 
                           Where AC.Active=1 and AC.Deleted=0 and AC.ViewFlag=1 and ACl.Active=1 and ACl.Deleted=0 and BS.Active=1 and BS.Deleted=0 and CB.Active=1 and CB.Deleted=0 and AC.ACId=" & YourACId & "")
                    Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection
                    If Da.Fill(Ds) = 0 Then Throw New AccountNotFoundException()
                    Return New R2CoreFinancialSystemAccountCodingExtendedStructure(New R2CoreFinancialSystemAccountCodingStructure(Ds.Tables(0).Rows(0).Item("ACId"), Ds.Tables(0).Rows(0).Item("ACCode"), Ds.Tables(0).Rows(0).Item("ACTitle").trim, Ds.Tables(0).Rows(0).Item("ACDescription").trim, Ds.Tables(0).Rows(0).Item("AClId"), Ds.Tables(0).Rows(0).Item("BSId"), Ds.Tables(0).Rows(0).Item("CBId"), Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), Ds.Tables(0).Rows(0).Item("DateShamsi"), Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("Deleted")), Ds.Tables(0).Rows(0).Item("AClTitle").trim, Ds.Tables(0).Rows(0).Item("BSTitle").trim, Ds.Tables(0).Rows(0).Item("CBTitle").trim, Color.FromName(Ds.Tables(0).Rows(0).Item("AClColor").trim))
                Catch ex As AccountNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetNSSActiveAccount(YourACCode As String) As R2CoreFinancialSystemAccountCodingStructure
                Try
                    Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                    Da.SelectCommand = New SqlClient.SqlCommand(
                        "Select AC.*,ACl.AClTitle,BS.BSTitle,CB.CBTitle,ACl.AClColor from R2PrimaryFinancialSystem.dbo.TblAccountsCoding as AC
                             Inner Join R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels as ACl On AC.AClId=ACl.AClId 
                             Inner Join R2PrimaryFinancialSystem.dbo.TblBalanceSheetAccountTypes as BS On AC.BSId=BS.BSId 
                             Inner Join R2PrimaryFinancialSystem.dbo.TblCostBenefitAccountTypes as CB On AC.CBId =CB.CBId 
                           Where AC.Active=1 and AC.Deleted=0 and AC.ViewFlag=1 and ACl.Active=1 and ACl.Deleted=0 and BS.Active=1 and BS.Deleted=0 and CB.Active=1 and CB.Deleted=0 and AC.ACCode='" & YourACCode & "'")
                    Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection
                    If Da.Fill(Ds) = 0 Then Throw New AccountNotFoundException()
                    Return New R2CoreFinancialSystemAccountCodingExtendedStructure(New R2CoreFinancialSystemAccountCodingStructure(Ds.Tables(0).Rows(0).Item("ACId"), Ds.Tables(0).Rows(0).Item("ACCode"), Ds.Tables(0).Rows(0).Item("ACTitle").trim, Ds.Tables(0).Rows(0).Item("ACDescription").trim, Ds.Tables(0).Rows(0).Item("AClId"), Ds.Tables(0).Rows(0).Item("BSId"), Ds.Tables(0).Rows(0).Item("CBId"), Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), Ds.Tables(0).Rows(0).Item("DateShamsi"), Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("Deleted")), Ds.Tables(0).Rows(0).Item("AClTitle").trim, Ds.Tables(0).Rows(0).Item("BSTitle").trim, Ds.Tables(0).Rows(0).Item("CBTitle").trim, Color.FromName(Ds.Tables(0).Rows(0).Item("AClColor").trim))
                Catch ex As AccountNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function DoesAccountExist(YourACId As Int64) As Boolean
                Try
                    GetNSSAccount(YourACId)
                    Return True
                Catch ex As AccountNotFoundException
                    Return False
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function DoesAccountExist(YourACCode As String) As Boolean
                Try
                    GetNSSAccount(YourACCode)
                    Return True
                Catch ex As AccountNotFoundException
                    Return False
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function DoesActiveAccountExist(YourACCode As String) As Boolean
                Try
                    GetNSSActiveAccount(YourACCode)
                    Return True
                Catch ex As AccountNotFoundException
                    Return False
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function IsAccountAcceptable(YourNSS As R2CoreFinancialSystemAccountCodingStructure) As Boolean
                Try
                    If (YourNSS.ACTitle.Trim = String.Empty) Or (YourNSS.ACId = Int64.MinValue) Then Throw New AccountStructureDeclinedException
                    Dim AcountCodeLength As Int64 = YourNSS.ACCode.Trim.Length
                    If AcountCodeLength <> R2CoreFinancialSystemMClassAccountsCodingLevelsManagement.GetNSSAccountsCodingLevel(YourNSS.AClId).AClLengthTotal Then Throw New IllegalAccountLengthTotalException
                    If YourNSS.AClId <> R2CoreFinancialSystemAccountsCodingLevels.Group Then
                        If Not DoesActiveAccountExist(Left(YourNSS.ACCode, YourNSS.ACCode.Length - R2CoreFinancialSystemMClassAccountsCodingLevelsManagement.GetNSSAccountsCodingLevel(YourNSS.AClId).AClLength)) Then Throw New CascadingAccountingCodingIllegalException
                    End If
                    Return True
                Catch ex As CascadingAccountingCodingIllegalException
                    Throw ex
                Catch ex As IllegalAccountLengthTotalException
                    Throw ex
                Catch ex As AccountStructureDeclinedException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function RegisterAccount(YourNSS As R2CoreFinancialSystemAccountCodingStructure) As Int64
                Dim CmdSql As New SqlClient.SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
                Try
                    If DoesActiveAccountExist(YourNSS.ACCode) Then Throw New AccountAlreadyExistException
                    If IsAccountAcceptable(YourNSS) Then
                        CmdSql.Connection.Open()
                        CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                        CmdSql.CommandText = "Select top 1 * from R2PrimaryFinancialSystem.dbo.TblAccountsCoding with (tablockx)" : CmdSql.ExecuteNonQuery()
                        CmdSql.CommandText = "Select IDENT_CURRENT('R2PrimaryFinancialSystem.dbo.TblAccountsCoding')"
                        Dim myACId As Int64 = CmdSql.ExecuteScalar + 1

                        CmdSql.CommandText = "Insert Into R2PrimaryFinancialSystem.dbo.TblAccountsCoding(ACCode,ACTitle,ACDescription,AClId,BSId,CBId,DateTimeMilladi,DateShamsi,ViewFlag,Active,Deleted) 
                                              Values('" & YourNSS.ACCode & "','" & YourNSS.ACTitle & "','" & YourNSS.ACDescription & "'," & YourNSS.AClId & "," & YourNSS.BSId & "," & YourNSS.CBId & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated & "','" & _DateTime.GetCurrentDateShamsiFull & "',1,1,0)"
                        CmdSql.ExecuteNonQuery()
                        CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                        Return myACId
                    Else
                        Throw New AccountDeclineforRegisteringException
                    End If
                Catch ex As CascadingAccountingCodingIllegalException
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw ex
                Catch ex As IllegalAccountLengthTotalException
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw ex
                Catch ex As AccountStructureDeclinedException
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw ex
                Catch ex As AccountDeclineforRegisteringException
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw ex
                Catch ex As AccountAlreadyExistException
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw ex
                Catch ex As Exception
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function EditAccount(YourNSS As R2CoreFinancialSystemAccountCodingStructure) As Int64
                Dim CmdSql As New SqlClient.SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
                Try
                    If Not DoesActiveAccountExist(YourNSS.ACCode) Then Throw New AccountAlreadyDosNotExistException
                    If IsAccountAcceptable(YourNSS) Then
                        CmdSql.Connection.Open()
                        CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                        CmdSql.CommandText = "Update R2PrimaryFinancialSystem.dbo.TblAccountsCoding Set Active=0 Where ltrim(rtrim(ACCode))='" & YourNSS.ACCode & "'"
                        CmdSql.ExecuteNonQuery()
                        CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                        Return RegisterAccount(YourNSS)
                    Else
                        Throw New AccountDeclineforEditingException
                    End If
                Catch ex As CascadingAccountingCodingIllegalException
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw ex
                Catch ex As IllegalAccountLengthTotalException
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw ex
                Catch ex As AccountStructureDeclinedException
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw ex
                Catch ex As AccountDeclineforEditingException
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw ex
                Catch ex As AccountAlreadyDosNotExistException
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw ex
                Catch ex As AccountDeclineforRegisteringException
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw ex
                Catch ex As AccountAlreadyExistException
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw ex
                Catch ex As Exception
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Sub DeleteAccount(YourNSS As R2CoreFinancialSystemAccountCodingStructure)
                Dim CmdSql As New SqlClient.SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
                Try
                    If Not DoesAccountExist(YourNSS.ACCode) Then Throw New AccountNotFoundException
                    If R2CoreFinancialSystemMClassAccountingDocumentsManagement.HasAccountTurnOverinAccountingDocuments(YourNSS) Then Throw New AccountHasTurnOverinAccountingDocumentsException
                    If HasAccountLowLevels(YourNSS) Then Throw New AccountHasLowLevelsException
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                    CmdSql.CommandText = "Update R2PrimaryFinancialSystem.dbo.TblAccountsCoding Set Deleted=1 Where ltrim(rtrim(ACCode))='" & YourNSS.ACCode & "'"
                    CmdSql.ExecuteNonQuery()
                    CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                Catch ex As AccountHasLowLevelsException
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw ex
                Catch ex As AccountNotFoundException
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw ex
                Catch ex As AccountHasTurnOverinAccountingDocumentsException
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw ex
                Catch ex As Exception
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Shared Function GetAccountHighLevelsString(YourNSS As R2CoreFinancialSystemAccountCodingExtendedStructure) As String
                Dim CmdSql As SqlClient.SqlCommand = New SqlClient.SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
                Try
                    CmdSql.Connection.Open()
                    CmdSql.CommandText = "Select ACLevels.AClPriority from R2PrimaryFinancialSystem.dbo.TblAccountsCoding as AC 
                                             Inner Join R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels as ACLevels On AC.AClId=ACLevels.AClId
                                          Where AC.ACCode='" & YourNSS.ACCode & "'"
                    Dim AClPriority As Int16 = CmdSql.ExecuteScalar
                    Dim ACHighLevelsString As String = String.Empty
                    For Loopx As Int16 = AClPriority - 1 To 1 Step -1
                        CmdSql.Parameters.Clear()
                        CmdSql.Parameters.Add("@ACCodeOut", SqlDbType.Int) : CmdSql.Parameters("@ACCodeOut").Direction = ParameterDirection.Output
                        CmdSql.Parameters.Add("@ACTitleOut", SqlDbType.NVarChar, 200) : CmdSql.Parameters("@ACTitleOut").Direction = ParameterDirection.Output
                        CmdSql.CommandText = "Select Top 1 @ACCodeOut=AC.ACCode,@ACTitleOut=AC.ACTitle from R2PrimaryFinancialSystem.dbo.TblAccountsCoding as AC 
                                                 Inner Join R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels as ACLevels On 1=1 
                                              Where ACLevels.AClPriority=(Select AClPriority from R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels 
                                                                          Where AClPriority=(Select Top 1 ACLevels.AClPriority-" & Loopx & " from R2PrimaryFinancialSystem.dbo.TblAccountsCoding as AC  
                                                                                               Inner Join R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels as ACLevels On AC.AClId=ACLevels.AClId
                                                                                             Where AC.Active=1 and AC.Deleted=0 and AC.ACCode='" & YourNSS.ACCode.Trim & "'))
                                                    and AC.ACCode=left('" & YourNSS.ACCode.Trim & "',(Select AClLengthTotal from R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels 
                                                                                                      Where AClPriority=(Select Top 1 ACLevels.AClPriority-" & Loopx & " from R2PrimaryFinancialSystem.dbo.TblAccountsCoding as AC 
                                                                                                                            Inner Join R2PrimaryFinancialSystem.dbo.TblAccountsCodingLevels as ACLevels On AC.AClId=ACLevels.AClId
                                                                                                                         Where AC.Active=1 and AC.Deleted=0 and AC.ACCode='" & YourNSS.ACCode.Trim & "')))
	                                                and AC.Active=1 and AC.Deleted=0"
                        CmdSql.ExecuteNonQuery()
                        ACHighLevelsString = ACHighLevelsString + Space(AClPriority - Loopx) + CmdSql.Parameters("@ACCodeOut").Value.ToString.Trim + "  " + CmdSql.Parameters("@ACTitleOut").Value.ToString.Trim + vbCrLf
                    Next
                    CmdSql.Connection.Close()
                    Return ACHighLevelsString
                Catch ex As Exception
                    If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function




        End Class

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
            Public Shared Function GetNSSBalanceSheetAccountType(YourBSId As Int64) As R2CoreFinancialSystemBalanceSheetAccountTypeStructure
                Try
                    Dim DS As DataSet = Nothing
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * From R2PrimaryFinancialSystem.dbo.TblBalanceSheetAccountTypes Where BSId=" & YourBSId & " and Deleted=0 and Active=1", 3600, DS).GetRecordsCount = 0 Then Throw New BalanceSheetAccountTypeNotFoundException
                    Return New R2CoreFinancialSystemBalanceSheetAccountTypeStructure(DS.Tables(0).Rows(0).Item("BSId"), DS.Tables(0).Rows(0).Item("BSTitle"), DS.Tables(0).Rows(0).Item("DateTimeMilladi"), DS.Tables(0).Rows(0).Item("DateShamsi"), DS.Tables(0).Rows(0).Item("ViewFlag"), DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("Deleted"))
                Catch ex As BalanceSheetAccountTypeNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetBalanceSheetAccountTypes_SearchforLeftCharacters(YourSearchString As String) As List(Of R2CoreFinancialSystemBalanceSheetAccountTypeStructure)
                Try
                    Dim Lst As New List(Of R2CoreFinancialSystemBalanceSheetAccountTypeStructure)
                    Dim DS As DataSet = Nothing
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryFinancialSystem.dbo.TblBalanceSheetAccountTypes Where Left(BSTitle," & YourSearchString.Length & ")='" & YourSearchString & "' and Deleted=0 and Active=1 Order By BSId", 3600, DS)
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
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryFinancialSystem.dbo.TblBalanceSheetAccountTypes Where BSTitle Like '%" & YourSearchString & "%' and Deleted=0 and Active=1 Order By BSId", 3600, DS)
                    For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                        Lst.Add(New R2CoreFinancialSystemBalanceSheetAccountTypeStructure(DS.Tables(0).Rows(Loopx).Item("BSId"), DS.Tables(0).Rows(Loopx).Item("BSTitle"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                    Next
                    Return Lst
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function


        End Class

        Namespace Exceptions

            Public Class BalanceSheetAccountTypeNotFoundException
                Inherits ApplicationException

                Public Overrides ReadOnly Property Message As String
                    Get
                        Return "نوع حساب ترازنامه یافت نشد"
                    End Get
                End Property
            End Class

        End Namespace

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
            Public Shared Function GetNSSCostBenefitAccountType(YourCBId As Int64) As R2CoreFinancialSystemCostBenefitAccountTypeStructure
                Try
                    Dim DS As DataSet = Nothing
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryFinancialSystem.dbo.TblCostBenefitAccountTypes Where CBId=" & YourCBId & " and Deleted=0 and Active=1", 3600, DS).GetRecordsCount = 0 Then Throw New CostBenefitAccountTypeNotFoundException
                    Return New R2CoreFinancialSystemCostBenefitAccountTypeStructure(DS.Tables(0).Rows(0).Item("CBId"), DS.Tables(0).Rows(0).Item("CBTitle"), DS.Tables(0).Rows(0).Item("DateTimeMilladi"), DS.Tables(0).Rows(0).Item("DateShamsi"), DS.Tables(0).Rows(0).Item("ViewFlag"), DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("Deleted"))
                Catch ex As CostBenefitAccountTypeNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetCostBenefitAccountTypes_SearchforLeftCharacters(YourSearchString As String) As List(Of R2CoreFinancialSystemCostBenefitAccountTypeStructure)
                Try
                    Dim Lst As New List(Of R2CoreFinancialSystemCostBenefitAccountTypeStructure)
                    Dim DS As DataSet = Nothing
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryFinancialSystem.dbo.TblCostBenefitAccountTypes Where Left(CBTitle," & YourSearchString.Length & ")='" & YourSearchString & "' and Deleted=0 and Active=1 Order By CBId", 3600, DS)
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
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryFinancialSystem.dbo.TblCostBenefitAccountTypes Where CBTitle Like '%" & YourSearchString & "%' and Deleted=0 and Active=1 Order By CBId", 3600, DS)
                    For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                        Lst.Add(New R2CoreFinancialSystemCostBenefitAccountTypeStructure(DS.Tables(0).Rows(Loopx).Item("CBId"), DS.Tables(0).Rows(Loopx).Item("CBTitle"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                    Next
                    Return Lst
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

        End Class

        Namespace Exceptions

            Public Class CostBenefitAccountTypeNotFoundException
                Inherits ApplicationException

                Public Overrides ReadOnly Property Message As String
                    Get
                        Return "نوع حساب سود و زیان یافت نشد"
                    End Get
                End Property
            End Class

        End Namespace

    End Namespace

    Namespace Exceptions

        Public Class AccountHasLowLevelsException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "حساب با سطوح پایین تر" + vbCrLf + "این حساب دارای سطوح پایین تری در کدینگ است"
                End Get
            End Property
        End Class

        Public Class CascadingAccountingCodingIllegalException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "ساختار آبشاری کدینگ حساب" + vbCrLf + "ثبت حساب اصلی در حالت آبشاری رعایت نشده است"
                End Get
            End Property
        End Class

        Public Class AccountStructureDeclinedException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "ساختار اطلاعات وارد شده نادرست است" + vbCrLf + "اطلاعات مورد نظر قابل ثبت در لیست حساب ها نیست"
                End Get
            End Property
        End Class

        Public Class AccountDeclineforRegisteringException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "اطلاعات مورد نظر برای ثبت حساب مورد تایید نیست"
                End Get
            End Property
        End Class

        Public Class AccountDeclineforEditingException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "اطلاعات مورد نظر برای ویرایش حساب مورد تایید نیست"
                End Get
            End Property
        End Class

        Public Class AccountNotFoundException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "حساب در لیست کدینگ حساب ها موجود نیست"
                End Get
            End Property
        End Class

        Public Class AccountAlreadyExistException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "ثبت تکراری حساب" + vbCrLf + "کدحساب مورد نظر قبلا در لیست حساب ها موجود است"
                End Get
            End Property
        End Class

        Public Class AccountAlreadyDosNotExistException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "حساب وجود ندارد" + vbCrLf + "حساب با کد مورد نظر در لیست حساب ها موجود نیست"
                End Get
            End Property
        End Class

        Public Class IllegalAccountLengthTotalException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "طول کد حساب نادرست است"
                End Get
            End Property
        End Class

        Public Class NotSelectedAccountException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "حساب انتخاب نشده است"
                End Get
            End Property
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
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2PrimaryFinancialSystem.dbo.TblAccountingDocumentTypes Where ADTypeId=" & AccountingDocumentTypeId & "", 3600, Ds)
                Return New R2CoreFinancialSystemStandardAccountingDocumentTypeStructure(Ds.Tables(0).Rows(0).Item("OId"), Ds.Tables(0).Rows(0).Item("ADTypeId"), Ds.Tables(0).Rows(0).Item("ADTypeName").trim, Ds.Tables(0).Rows(0).Item("ADTypeTitle").trim, Color.FromName(Ds.Tables(0).Rows(0).Item("ADTypeColor").trim), Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), Ds.Tables(0).Rows(0).Item("DateShamsi").trim, Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("Deleted"))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class


End Namespace

Namespace AccountingDocuments
    Public NotInheritable Class R2CoreFinancialSystemMClassAccountingDocumentsManagement
        Public Shared Function HasAccountTurnOverinAccountingDocuments(YourNSS As R2CoreFinancialSystemAccountCodingStructure) As Boolean
            Try

            Catch ex As Exception

            End Try

        End Function
    End Class

    Namespace Exceptions

        Public Class AccountHasTurnOverinAccountingDocumentsException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "حساب مورد نظر در اسناد حسابداری دارای گردش است"
                End Get
            End Property
        End Class


    End Namespace




End Namespace

Namespace ProcessesManagement

    Public MustInherit Class R2CoreFinancialSystemProcesses
        Inherits R2CoreProcesses

        Public Shared ReadOnly FrmcManipulationAccountsCoding As Int64 = 39



    End Class

End Namespace





