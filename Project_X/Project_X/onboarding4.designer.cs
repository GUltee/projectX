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
    [Register ("onboarding4")]
    partial class onboarding4
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView bluebox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buddy_button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider slider { get; set; }

        [Action ("Buddy_button_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Buddy_button_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton4339_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton4339_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton4344_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton4344_TouchUpInside (UIKit.UIButton sender);

        [Action ("Up:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Up (UIKit.UISlider sender);

        void ReleaseDesignerOutlets ()
        {
            if (bluebox != null) {
                bluebox.Dispose ();
                bluebox = null;
            }

            if (buddy_button != null) {
                buddy_button.Dispose ();
                buddy_button = null;
            }

            if (slider != null) {
                slider.Dispose ();
                slider = null;
            }
        }
    }
}