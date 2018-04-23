using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;

namespace WindowsFormsApplication741 {
    public class MyFlyoutPanel : FlyoutPanel {
        protected override FlyoutPanelToolForm CreateToolFormCore(Control owner, FlyoutPanel content, FlyoutPanelOptions options) {
            return new MyFlyoutPanelToolForm(owner, content, options);
        }
    }
}
