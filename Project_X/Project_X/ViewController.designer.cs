// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Project_X
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton button1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField email { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField name { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView v { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField wachtword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField wachtword2 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (button1 != null) {
                button1.Dispose ();
                button1 = null;
            }

            if (email != null) {
                email.Dispose ();
                email = null;
            }

            if (name != null) {
                name.Dispose ();
                name = null;
            }

            if (v != null) {
                v.Dispose ();
                v = null;
            }

            if (wachtword != null) {
                wachtword.Dispose ();
                wachtword = null;
            }

            if (wachtword2 != null) {
                wachtword2.Dispose ();
                wachtword2 = null;
            }
        }
    }
}