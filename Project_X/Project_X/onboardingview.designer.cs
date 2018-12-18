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
    [Register ("onboardingview")]
    partial class onboardingview
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton get_started { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (get_started != null) {
                get_started.Dispose ();
                get_started = null;
            }
        }
    }
}