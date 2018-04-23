using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Utils;
using DevExpress.Utils.Win;

namespace WindowsFormsApplication741 {
    public class MyFlyoutPanelToolFormHandler : FlyoutPanelToolFormHandler {
        public MyFlyoutPanelToolFormHandler(FlyoutPanelToolForm toolForm)
            : base(toolForm) {
        }
        protected override PopupToolWindowAnimationProviderBase CreateAnimationProvider() {
            if(Anchor == PopupToolWindowAnchor.Left) {
                return new MyPopupToolWindowLeftRightSlideAnimationProvider(this);
            }
            return base.CreateAnimationProvider();
        }
        protected PopupToolWindowAnchor Anchor {
            get {
                return ((IPopupToolWindowAnimationSupports)this).AnchorType;
            }
        }
    }
}
