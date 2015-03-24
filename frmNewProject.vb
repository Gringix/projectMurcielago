Imports System.Data.SqlClient
Public Class frmNewProject

    Dim strConexion As String = "Data Source=localhost;Initial Catalog=timelog;Integrated Security=True"
    Dim connection As New SqlConnection(strConexion)

    Public Sub Insert_Work_Category(ByVal categoryName As String)

        Dim cmdInsert As New SqlCommand("INSERT INTO dbo.Proyect (project_name,budget,hours_total,initial_date,due_date,hours_left)" & _
        " VALUES('" & txtProyectName.Text & "' , " & getBudget() & ", " & getHoursTotal() & ", '" & getInitialDate() & "', '" & getDueDate() & "', " & ");", connection)

        connection.Open()
        cmdInsert.ExecuteNonQuery()
        connection.Close()

    End Sub

    Public Function getBudget()
        Dim budget As Integer = CInt(txtBudget.Text)
        Return budget
    End Function

    Public Function getHoursTotal()
        Dim hoursTotal As Integer = CInt(txtHoursOfTheProject.Text)
        Return hoursTotal
    End Function

    Public Function getInitialDate()
        Dim initialDate As Date = dtpInicialDate.Value.Date

        Return initialDate
    End Function

    Public Function getDueDate()
        Dim dueDate As Date = dtpDueDate.Value.Date
        Return dueDate
    End Function

End Class
