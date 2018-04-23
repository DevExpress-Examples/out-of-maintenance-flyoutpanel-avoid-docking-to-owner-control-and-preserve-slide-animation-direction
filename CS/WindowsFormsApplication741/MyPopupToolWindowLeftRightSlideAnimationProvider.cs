using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.Utils.Win;

namespace WindowsFormsApplication741 {
    public class MyPopupToolWindowLeftRightSlideAnimationProvider : PopupToolWindowLeftRightSlideAnimationProvider {
        public MyPopupToolWindowLeftRightSlideAnimationProvider(IPopupToolWindowAnimationSupports info)
            : base(info) {
        }
        public override Size CalcTargetFormSize() {
            return Info.FormSize;
        }
    }
}
