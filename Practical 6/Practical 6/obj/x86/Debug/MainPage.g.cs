﻿#pragma checksum "D:\School\sem1.2\PRG2\Week 6\Practical 6\Practical 6\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FDBE82633EA64D680D0D06E577C1BEA8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practical_6
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.listAllBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.listAllBtn).Click += this.listAllBtn_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.displayAreaBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.displayAreaBtn).Click += this.displayAreaBtn_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.displayPerimeterBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.displayPerimeterBtn).Click += this.displayPerimeterBtn_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.addCircleBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.addCircleBtn).Click += this.addCircleBtn_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.deleteCircleBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.deleteCircleBtn).Click += this.deleteCircleBtn_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.detailsTxt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.Sort = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 30 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Sort).Click += this.Sort_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

