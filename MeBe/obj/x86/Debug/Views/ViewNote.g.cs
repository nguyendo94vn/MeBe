﻿

#pragma checksum "D:\Users\nguye_000\Documents\Visual Studio 2013\Projects\MeBe\MeBe\Views\ViewNote.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7B46E65865EB1183B45FD99B9D289DF6"
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
    partial class ViewNote : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 18 "..\..\..\Views\ViewNote.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.BackNoteList_Tapped;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 30 "..\..\..\Views\ViewNote.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerPressed += this.PointContentNote_Pressed;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 33 "..\..\..\Views\ViewNote.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.SaveNote_Tapped;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 34 "..\..\..\Views\ViewNote.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.DeleteNote_Tapped;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 25 "..\..\..\Views\ViewNote.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).KeyUp += this.InputTitleNote_Keyup;
                 #line default
                 #line hidden
                #line 25 "..\..\..\Views\ViewNote.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerPressed += this.PointNote_Pressed;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


