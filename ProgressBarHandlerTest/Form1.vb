Public Class Form1

    Dim web1 As New WebBrowser
    Dim web2 As New WebBrowser
    Dim web3 As New WebBrowser

    Dim subform1 As New Form
    Dim subform2 As New Form
    Dim subform3 As New Form

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        web1.Navigate("www.google.com")
        AddHandler web1.ProgressChanged, AddressOf loadweb1

        web2.Navigate("www.google.co.jp")
        AddHandler web2.ProgressChanged, AddressOf loadweb2

        web3.Navigate("www.google.de")
        AddHandler web3.ProgressChanged, AddressOf loadweb3
    End Sub

    Private Sub loadweb1(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            ProgressBar1.Maximum = e.MaximumProgress
            ProgressBar1.Value = e.CurrentProgress

            If ProgressBar1.Value = ProgressBar1.Maximum Then
                RemoveHandler web1.ProgressChanged, AddressOf loadweb1
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub loadweb2(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            ProgressBar2.Maximum = e.MaximumProgress
            ProgressBar2.Value = e.CurrentProgress

            If ProgressBar2.Value = ProgressBar2.Maximum Then
                RemoveHandler web2.ProgressChanged, AddressOf loadweb2
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub loadweb3(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            ProgressBar3.Maximum = e.MaximumProgress
            ProgressBar3.Value = e.CurrentProgress

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                RemoveHandler web3.ProgressChanged, AddressOf loadweb3
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        subform1.Controls.Add(web1)
        subform1.Size = New Size(600, 600)
        web1.Dock = DockStyle.Fill
        web1.BringToFront()
        subform1.Show()
        AddHandler subform1.FormClosing, AddressOf subform1_FormClosing
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        subform2.Controls.Add(web2)
        subform2.Size = New Size(600, 600)
        web2.Dock = DockStyle.Fill
        web2.BringToFront()
        subform2.Show()
        AddHandler subform2.FormClosing, AddressOf subform2_FormClosing
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        subform3.Controls.Add(web3)
        subform3.Size = New Size(600, 600)
        web3.Dock = DockStyle.Fill
        web3.BringToFront()
        subform3.Show()
        AddHandler subform3.FormClosing, AddressOf subform3_FormClosing
    End Sub

    Private Sub subform1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        Try
            e.Cancel = True
            subform1.Hide()
            RemoveHandler subform1.FormClosing, AddressOf subform1_FormClosing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub subform2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        Try
            e.Cancel = True
            subform2.Hide()
            RemoveHandler subform2.FormClosing, AddressOf subform2_FormClosing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub subform3_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        Try
            e.Cancel = True
            subform3.Hide()
            RemoveHandler subform3.FormClosing, AddressOf subform3_FormClosing
        Catch ex As Exception
        End Try
    End Sub
End Class
