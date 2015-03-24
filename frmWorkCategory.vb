Imports System.Data.SqlClient

Public Class frmWorkCategory

    Dim strConexion As String = "Data Source=localhost;Initial Catalog=timelog;Integrated Security=True"
    Dim connection As New SqlConnection(strConexion)

    Private Sub frmWorkCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TimelogDataSet.Work_Category' Puede moverla o quitarla según sea necesario.
        Me.Work_CategoryTableAdapter1.Fill(Me.TimelogDataSet.Work_Category)


    End Sub


    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Insert_Work_Category(InputBox("please enter the name the category"))


    End Sub

    Public Sub updateCategory(ByVal categoryId As String, ByVal categoryName As String)

        Dim cmdupdate As New SqlCommand("UPDATE [dbo].[Work_Category] SET [Category_Name] = '" & categoryName & "' WHERE Id_Category =" & categoryId & ";", connection)

        connection.Open()
        cmdupdate.ExecuteNonQuery()
        connection.Close()

    End Sub
    

    Public Sub Insert_Work_Category(ByVal categoryName As String)

        Dim cmdInsert As New SqlCommand("INSERT INTO dbo.Work_Category   (Category_Name)" & _
" VALUES('" & categoryName & "');", connection)
        
        connection.Open()
        cmdInsert.ExecuteNonQuery()
        connection.Close()

    End Sub

    Public Sub Remove(ByVal categoryName As String)
        Dim cmdRemove As New SqlCommand("DELETE FROM [dbo].[Work_Category] WHERE Category_name='" & categoryName & "';", connection)

        connection.Open()
        cmdRemove.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Remove(InputBox("Which category should be removed?"))
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.Work_CategoryTableAdapter1.Fill(Me.TimelogDataSet.Work_Category)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        updateCategory(InputBox("Which is the id of the Work Category that is going to be updated?"), InputBox("Insert new name"))
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim AnchoBorde As Integer = 5
        Dim ColorBorde As Color = Color.Red
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, ColorBorde,
        AnchoBorde, ButtonBorderStyle.Solid, ColorBorde, AnchoBorde,
        ButtonBorderStyle.Solid, ColorBorde, AnchoBorde, ButtonBorderStyle.Solid,
        ColorBorde, AnchoBorde, ButtonBorderStyle.Solid)
    End Sub

End Class