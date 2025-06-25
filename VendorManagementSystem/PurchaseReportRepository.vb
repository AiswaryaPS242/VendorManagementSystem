Public Class PurchaseReportRepository
    Private ReadOnly purchaseList As New List(Of PurchaseReport)()

    Public Sub Add(report As PurchaseReport)
        purchaseList.Add(report)
    End Sub

    Public Function GetAll() As List(Of PurchaseReport)
        Return purchaseList
    End Function

    Public Function GetNextTransactionID() As Integer
        If purchaseList.Count = 0 Then
            Return 1
        Else
            Return purchaseList.Max(Function(p) p.TransactionID) + 1
        End If
    End Function
End Class
