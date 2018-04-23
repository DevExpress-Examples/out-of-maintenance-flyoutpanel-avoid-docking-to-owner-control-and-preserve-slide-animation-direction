namespace WindowsFormsApplication741 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.flyoutPanel1 = new MyFlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Controls.Add(this.flyoutPanelControl1);
            this.flyoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Left;
            this.flyoutPanel1.Options.CloseOnOuterClick = true;
            this.flyoutPanel1.OwnerControl = this;
            this.flyoutPanel1.Size = new System.Drawing.Size(175, 173);
            this.flyoutPanel1.TabIndex = 0;
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.flyoutPanel1;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(175, 173);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(108, 232);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(91, 30);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Show Popup";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 265);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.flyoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyFlyoutPanel flyoutPanel1;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

