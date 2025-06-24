Public Class CustomerRepository
    Private customers As New DataTable()

    Public Sub New()
        customers.Columns.Add("ID", GetType(Integer))
        customers.Columns.Add("CustomerName", GetType(String))
        customers.Columns.Add("Phone", GetType(String))
        customers.Columns.Add("Email", GetType(String))
    End Sub

    Public Function GetAllCustomers() As DataTable
        Return customers
    End Function

    Public Function GetNextID() As Integer
        If customers.Rows.Count = 0 Then
            Return 1
        Else
            Dim maxID = customers.AsEnumerable().Max(Function(row) row.Field(Of Integer)("ID"))
            Return maxID + 1
        End If
    End Function

    Public Sub AddCustomer(customer As Customer)
        customers.Rows.Add(customer.ID, customer.Name, customer.Phone, customer.Email)
    End Sub

    Public Sub UpdateCustomer(customer As Customer)
        Dim row = customers.Select("ID = " & customer.ID).FirstOrDefault()
        If row IsNot Nothing Then
            row("CustomerName") = customer.Name
            row("Phone") = customer.Phone
            row("Email") = customer.Email
        End If
    End Sub

    Public Sub DeleteCustomer(id As Integer)
        Dim row = customers.Select("ID = " & id).FirstOrDefault()
        If row IsNot Nothing Then
            customers.Rows.Remove(row)
        End If
    End Sub
End Class

Public Class Customer
    Public Property ID As Integer
    Public Property Name As String
    Public Property Phone As String
    Public Property Email As String
End Class
