Imports System.Data.SqlClient

Public Class frmTimeRegistrationManagement


    Dim strConexion As String = "Data Source=localhost;Initial Catalog=timelog;Integrated Security=True"
    Dim connection As New SqlConnection(strConexion)


    Private Sub frmTimeRegistrationManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim workCategories = New Dictionary(Of String, String)

        Dim cmdQuery As New SqlCommand("SELECT * FROM [dbo].[Work_Category];", connection)
        connection.Open()
        Dim reader As SqlDataReader = cmdQuery.ExecuteReader()

        Do While reader.HasRows
            Do While reader.Read()
                Dim category As WorkCategory = New WorkCategory
                category.id_Category = reader.GetInt32(0)
                category.category_Name = reader.GetString(1)

                workCategories("" & category.id_Category) = category.category_Name

            Loop

            reader.NextResult()

        Loop

        cbxWorkCategory.DataSource = New BindingSource(workCategories, Nothing)

        cbxWorkCategory.DisplayMember = "value"

        cbxWorkCategory.ValueMember = "key"

        connection.Close()


      
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