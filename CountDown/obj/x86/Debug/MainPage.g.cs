﻿#pragma checksum "E:\GitHub\CountDown\CountDown\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C7BDD0FE089DD853D5EE690D11491DA69DA08AD244ACD85CA2EE0B16B830D448"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CountDown
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 15
                {
                    this.BtnSelectDateTime = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnSelectDateTime).Click += this.BtnSelectDateTime_Click;
                }
                break;
            case 3: // MainPage.xaml line 17
                {
                    this.PickTime = (global::Windows.UI.Xaml.Controls.TimePicker)(target);
                }
                break;
            case 4: // MainPage.xaml line 18
                {
                    this.BtnStart = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnStart).Click += this.BtnStart_Click;
                }
                break;
            case 5: // MainPage.xaml line 19
                {
                    this.TxtEndDate = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // MainPage.xaml line 32
                {
                    this.TxtSeconds = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // MainPage.xaml line 33
                {
                    this.TxtMilliSeconds = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // MainPage.xaml line 34
                {
                    this.PickDate = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 9: // MainPage.xaml line 27
                {
                    this.TxtDays = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10: // MainPage.xaml line 28
                {
                    this.TxtHours = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // MainPage.xaml line 29
                {
                    this.TxtMinutes = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

