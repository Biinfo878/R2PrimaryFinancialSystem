Imports R2CoreFinancialSystem.AccountsCoding.AccountsCoding

Public Class Form2
    Private Sub UcManipulationAccountCoding1_UCNSSCurrentChanged(NSSCurrent As R2CoreFinancialSystemAccountCodingStructure) Handles UcManipulationAccountCoding1.UCNSSCurrentChanged
        UcViewNSSAccountCoding1.UCViewNSS(NSSCurrent)
    End Sub
End Class