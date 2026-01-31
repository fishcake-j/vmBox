<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        WebView = New Microsoft.Web.WebView2.WinForms.WebView2()
        CType(WebView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' WebView
        ' 
        WebView.AllowExternalDrop = True
        WebView.CreationProperties = Nothing
        WebView.DefaultBackgroundColor = Color.White
        WebView.Dock = DockStyle.Fill
        WebView.Location = New Point(0, 0)
        WebView.Name = "WebView"
        WebView.Size = New Size(1225, 842)
        WebView.TabIndex = 0
        WebView.ZoomFactor = 1R
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(14F, 31F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1225, 842)
        Controls.Add(WebView)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "vmBox"
        CType(WebView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents WebView As Microsoft.Web.WebView2.WinForms.WebView2

End Class
