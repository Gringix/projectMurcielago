Imports System.Data.SqlClient

Public Class User

    Private name As String
    Private holidays As Integer
    Private userName As String
    Private password As String
    Private isActive As Boolean
    Private entryDate As String
    Private idRole As Integer
    Private role As Role


    Public Property User_Role() As Role
        Get
            Return role
        End Get
        Set(ByVal value As Role)
            role = value
        End Set
    End Property


    Public Property First_Name() As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property

    Public Property Available_Holidays() As String
        Get
            Return holidays
        End Get
        Set(ByVal value As String)
            holidays = value
        End Set
    End Property

    Public Property User_Name() As String
        Get
            Return userName
        End Get
        Set(ByVal value As String)
            userName = value
        End Set
    End Property

    Public Property User_Password() As String
        Get
            Return password
        End Get
        Set(ByVal value As String)
            password = value
        End Set
    End Property

    Public Property User_Is_Active() As Boolean
        Get
            Return isActive
        End Get
        Set(ByVal value As Boolean)
            isActive = value
        End Set
    End Property

    Public Property User_Entry_Date() As String
        Get
            Return entryDate
        End Get
        Set(ByVal value As String)
            entryDate = value
        End Set
    End Property

    Public Property User_ID_Role() As Integer
        Get
            Return idRole
        End Get
        Set(ByVal value As Integer)
            idRole = value
        End Set
    End Property

    Private email As String

    Public Property Email_Address() As String
        Get
            Return email
        End Get
        Set(ByVal value As String)
            email = value
        End Set
    End Property


  

    Public Sub buildRole(ByVal idRole As Integer)
        Dim strConexion As String = "Data Source=localhost;Initial Catalog=Clessidra;Integrated Security=True"
        Dim connection As New SqlConnection(strConexion)
        Dim roletemp As Role = New Role
        connection.Open()
        Dim cmdQuery As New SqlCommand("SELECT * FROM [dbo].[role];", connection)
        Dim reader As SqlDataReader = cmdQuery.ExecuteReader()

        Do While reader.HasRows
            Do While reader.Read()
                roletemp.Role_Id = reader.GetInt32(0)
                roletemp.Role_Name = reader.GetString(1)
                roletemp.role_Description = reader.GetString(2)
                If roletemp.Role_Id = idRole Then
                    Me.role = roletemp
                End If

            Loop

            reader.NextResult()
        Loop

        connection.Close()

    End Sub


End Class
