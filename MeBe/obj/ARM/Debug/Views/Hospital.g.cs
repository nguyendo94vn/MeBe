﻿

#pragma checksum "d:\Users\nguye_000\documents\visual studio 2013\Projects\MeBe\MeBe\Views\Hospital.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BC28AA92930B395F2FEDC2644C7E51CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeBe.Views
{
    partial class Hospital : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 34 "..\..\..\Views\Hospital.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.FindHospital_Tapped;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 35 "..\..\..\Views\Hospital.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.MyLocation_Tapped;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 36 "..\..\..\Views\Hospital.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.NextHospital_Tapped;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 27 "..\..\..\Views\Hospital.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.ChooseHospital_Checked;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 28 "..\..\..\Views\Hospital.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.ChooseVaccination_Checked;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 30 "..\..\..\Views\Hospital.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.NotesIcon_Tapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


