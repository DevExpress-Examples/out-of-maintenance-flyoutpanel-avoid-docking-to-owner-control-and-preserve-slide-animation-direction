Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils

Namespace WindowsFormsApplication741
    Public Class MyFlyoutPanel
        Inherits FlyoutPanel

        Protected Overrides Function CreateToolFormCore(ByVal owner As Control, ByVal content As FlyoutPanel, ByVal options As FlyoutPanelOptions) As FlyoutPanelToolForm
            Return New MyFlyoutPanelToolForm(owner, content, options)
        End Function
    End Class
End Namespace
