Public Class WorkCategory

    Private idCategory As Integer
    Private categoryName As String

    Public Property category_Name() As String
        Get
            Return categoryName
        End Get
        Set(ByVal value As String)
            categoryName = value
        End Set
    End Property

    Public Property id_Category() As Integer
        Get
            Return idCategory
        End Get
        Set(ByVal value As Integer)
            idCategory = value
        End Set
    End Property


End Class
