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
    [Register ("reflection")]
    partial class reflection
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIDatePicker day_pick { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField text_boxer { get; set; }

        [Action ("UP:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UP (UIKit.UITextField sender);

        void ReleaseDesignerOutlets ()
        {
            if (day_pick != null) {
                day_pick.Dispose ();
                day_pick = null;
            }

            if (text_boxer != null) {
                text_boxer.Dispose ();
                text_boxer = null;
            }
        }
    }
}