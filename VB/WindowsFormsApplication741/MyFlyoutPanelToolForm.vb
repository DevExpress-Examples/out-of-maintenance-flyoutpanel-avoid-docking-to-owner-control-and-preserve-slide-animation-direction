Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.Win

Namespace WindowsFormsApplication741
    Public Class MyFlyoutPanelToolForm
        Inherits FlyoutPanelToolForm

        Public Sub New(ByVal owner As Control, ByVal flyoutPanel As FlyoutPanel, ByVal options As FlyoutPanelOptions)
            MyBase.New(owner, flyoutPanel, options)
        End Sub
        Protected Overrides Function CreateHandler() As BasePopupToolWindowHandler
            Return New MyFlyoutPanelToolFormHandler(Me)
        End Function
    End Class
End Namespace
