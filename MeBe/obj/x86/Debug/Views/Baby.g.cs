﻿

#pragma checksum "d:\Users\nguye_000\documents\visual studio 2013\Projects\MeBe\MeBe\Views\Baby.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D99F704627DA7DAA5A98C078F698DE68"
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
    partial class Baby : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 55 "..\..\..\Views\Baby.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.MapIndex_Tapped;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 31 "..\..\..\Views\Baby.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.CheckSex_Tapped;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 46 "..\..\..\Views\Baby.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ResultBaby_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 25 "..\..\..\Views\Baby.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.NotesIcon_Tapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


