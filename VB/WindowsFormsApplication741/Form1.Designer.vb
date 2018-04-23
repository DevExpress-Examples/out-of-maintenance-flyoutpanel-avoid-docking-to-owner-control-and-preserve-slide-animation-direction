Namespace WindowsFormsApplication741
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.flyoutPanel1 = New MyFlyoutPanel()
            Me.flyoutPanelControl1 = New DevExpress.Utils.FlyoutPanelControl()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            CType(Me.flyoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanel1.SuspendLayout()
            CType(Me.flyoutPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' flyoutPanel1
            ' 
            Me.flyoutPanel1.Controls.Add(Me.flyoutPanelControl1)
            Me.flyoutPanel1.Location = New System.Drawing.Point(12, 12)
            Me.flyoutPanel1.Name = "flyoutPanel1"
            Me.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Left
            Me.flyoutPanel1.Options.CloseOnOuterClick = True
            Me.flyoutPanel1.OwnerControl = Me
            Me.flyoutPanel1.Size = New System.Drawing.Size(175, 173)
            Me.flyoutPanel1.TabIndex = 0
            ' 
            ' flyoutPanelControl1
            ' 
            Me.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.flyoutPanelControl1.FlyoutPanel = Me.flyoutPanel1
            Me.flyoutPanelControl1.Location = New System.Drawing.Point(0, 0)
            Me.flyoutPanelControl1.Name = "flyoutPanelControl1"
            Me.flyoutPanelControl1.Size = New System.Drawing.Size(175, 173)
            Me.flyoutPanelControl1.TabIndex = 0
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(108, 232)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(91, 30)
            Me.simpleButton1.TabIndex = 1
            Me.simpleButton1.Text = "Show Popup"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(290, 265)
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.flyoutPanel1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.flyoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanel1.ResumeLayout(False)
            CType(Me.flyoutPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private flyoutPanel1 As MyFlyoutPanel
        Private flyoutPanelControl1 As DevExpress.Utils.FlyoutPanelControl
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace

