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
        Protected Overrides Function CreateAnimationProvider() As PopupToolWindowAnimationProviderBase
            If Anchor.HasFlag(AnchorStyles.Left) Then
                Return New MyPopupToolWindowLeftRightSlideAnimationProvider(Me)
            End If
            Return MyBase.CreateAnimationProvider()
        End Function
    End Class
End Namespace
