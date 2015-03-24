Imports System.Data.SqlClient

Public Class frmSignIn

    Dim strConexion As String = "Data Source=localhost;Initial Catalog=timelog;Integrated Security=True"
    Dim connection As New SqlConnection(strConexion)
    Public user As User
    Public frmWelcome As frmWelcome

    Private Sub frmSignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmWelcome = New frmWelcome
        user = New User
        encryptPassword()



    End Sub

    Public Function tellUser() As User

        Return Me.user
    End Function
    

    Public Sub encryptPassword()

        txtPassword.Text = ""
        txtPassword.PasswordChar = "*"
        txtPassword.MaxLength = 50

    End Sub


    Public Function verify() As Boolean

        Dim userName As String = txtUserName.Text
        Dim password As String = txtPassword.Text
        Dim ret As Boolean = False


        Dim cmdQuery As New SqlCommand("SELECT * FROM [dbo].[User];", connection)
        connection.Open()
        Dim reader As SqlDataReader = cmdQuery.ExecuteReader()
        Dim tempUser As User

        Do While reader.HasRows
            Do While reader.Read()
                tempUser = New User
                tempUser.First_Name = reader.GetString(1)
                tempUser.User_Name = reader.GetString(2)
                tempUser.User_Password = reader.GetString(3)
                tempUser.User_Is_Active = reader.GetInt32(4)
                tempUser.User_Entry_Date = (New Date)
                tempUser.Email_Address = reader.GetString(6)
                tempUser.User_ID_Role = reader.GetInt32(7)
                tempUser.Available_Holidays = reader.GetInt32(8)

                If tempUser.User_Name = userName Then
                    If tempUser.User_Password = password Then
                        Me.user = tempUser
                        Me.user.buildRole(reader.GetInt32(7))
                        ret = True



                    End If

                End If

            Loop

            reader.NextResult()
        Loop

        connection.Close()

        Return ret
    End Function





    Private Function convertToBoolean(ByVal number As Integer) As Boolean

        If number = 0 Then
            convertToBoolean = False
        Else
            convertToBoolean = True
        End If

    End Function

    Private Sub btnSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignIn.Click

        If verify() Then
            MsgBox("Welcome")
            frmWelcome.Show()
            Me.Hide()
        Else
            MsgBox("Error: The username or password is incorrect", 5 + 16, "Login")
        End If


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