Public Class frmSignIn

    Dim borderWidth As Integer = 10
    Dim formRegion As Rectangle

    Dim borderColor As Color = Color.Red

    Private Sub frmSignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     

        Dim borderColor As Color = Color.Red
        formRegion = New Rectangle(0, 0, 660, 489)

    End Sub

    Private Sub Form1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        'Draws the border.
        ControlPaint.DrawBorder(e.Graphics, formRegion, borderColor, _
      borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, _
      ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, _
             borderColor, borderWidth, ButtonBorderStyle.Solid)

    End Sub
End Class