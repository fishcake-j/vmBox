Imports Microsoft.Web.WebView2.Core

Public Class Form1
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 确保 WebView2 初始化完成
        Await WebView.EnsureCoreWebView2Async()
        ' 导航到目标网页
        WebView.CoreWebView2.Navigate("https://copy.sh/v86")
    End Sub
    Private Sub NewWindowHandler(sender As Object, e As CoreWebView2NewWindowRequestedEventArgs)
        e.Handled = True
        WebView.CoreWebView2.Navigate(e.Uri)
    End Sub

End Class
