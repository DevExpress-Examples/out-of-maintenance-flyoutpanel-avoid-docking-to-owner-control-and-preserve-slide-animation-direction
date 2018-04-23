Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.Utils.Win

Namespace WindowsFormsApplication741
    Public Class MyPopupToolWindowLeftRightSlideAnimationProvider
        Inherits PopupToolWindowLeftRightSlideAnimationProvider

        Public Sub New(ByVal info As IPopupToolWindowAnimationSupports)
            MyBase.New(info)
        End Sub
        Public Overrides Function CalcTargetFormSize() As Size
            Return Info.FormSize
        End Function
    End Class
End Namespace
