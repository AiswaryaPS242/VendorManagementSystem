Public Class ProductRepository
    Private products As New DataTable()

    Public Sub New()
        products.Columns.Add("ID", GetType(Integer))
        products.Columns.Add("ProductName", GetType(String))
        products.Columns.Add("Category", GetType(String))
        products.Columns.Add("Price", GetType(Decimal))
    End Sub

    Public Function GetAllProducts() As DataTable
        Return products
    End Function

    Public Function GetNextID() As Integer
        If products.Rows.Count = 0 Then
            Return 1
        Else
            Dim maxID = products.AsEnumerable().Max(Function(row) row.Field(Of Integer)("ID"))
            Return maxID + 1
        End If
    End Function

    Public Sub AddProduct(product As Product)
        products.Rows.Add(product.ID, product.Name, product.Category, product.Price)
    End Sub

    Public Sub UpdateProduct(product As Product)
        Dim row = products.Select("ID = " & product.ID).FirstOrDefault()
        If row IsNot Nothing Then
            row("ProductName") = product.Name
            row("Category") = product.Category
            row("Price") = product.Price
        End If
    End Sub

    Public Sub DeleteProduct(id As Integer)
        Dim row = products.Select("ID = " & id).FirstOrDefault()
        If row IsNot Nothing Then
            products.Rows.Remove(row)
        End If
    End Sub
End Class

Public Class Product
    Public Property ID As Integer
    Public Property Name As String
    Public Property Category As String
    Public Property Price As Decimal
End Class
