// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Project_X
{
    [Register ("data_view")]
    partial class data_view
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView box { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView chart { get; set; }

        [Action ("UIButton4493_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton4493_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton4541_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton4541_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (box != null) {
                box.Dispose ();
                box = null;
            }

            if (chart != null) {
                chart.Dispose ();
                chart = null;
            }
        }
    }
}