Public Class FormCetak
    Private Sub Btutup_Click(sender As Object, e As EventArgs) Handles Btutup.Click
        Me.Close()
    End Sub

    Private Sub FormCetak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Membuat form muncul di tengah parent
        Me.CenterToParent()
    End Sub
End Class