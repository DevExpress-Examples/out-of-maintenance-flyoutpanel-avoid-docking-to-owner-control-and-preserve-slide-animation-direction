Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Utils
Imports DevExpress.Utils.Win

Namespace WindowsFormsApplication741
    Public Class MyFlyoutPanelToolFormHandler
        Inherits FlyoutPanelToolFormHandler

        Public Sub New(ByVal toolForm As FlyoutPanelToolForm)
            MyBase.New(toolForm)
        End Sub
        Protected Overrides Function CreateAnimationProvider() As PopupToolWindowAnimationProviderBase
            If Anchor = PopupToolWindowAnchor.Left Then
                Return New MyPopupToolWindowLeftRightSlideAnimationProvider(Me)
            End If
            Return MyBase.CreateAnimationProvider()
        End Function
        Protected ReadOnly Property Anchor() As PopupToolWindowAnchor
            Get
                Return DirectCast(Me, IPopupToolWindowAnimationSupports).AnchorType
            End Get
        End Property
    End Class
End Namespace
