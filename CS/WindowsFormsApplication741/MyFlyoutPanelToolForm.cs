using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Win;

namespace WindowsFormsApplication741 {
    public class MyFlyoutPanelToolForm : FlyoutPanelToolForm {
        public MyFlyoutPanelToolForm(Control owner, FlyoutPanel flyoutPanel, FlyoutPanelOptions options)
            : base(owner, flyoutPanel, options) {
        }
        protected override BasePopupToolWindowHandler CreateHandler() {
            return new MyFlyoutPanelToolFormHandler(this);
        }
    }
}
