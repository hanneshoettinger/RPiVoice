﻿#pragma checksum "C:\Users\Hannes\Documents\Visual Studio 2015\Projects\RPIVoiceGPIO\RPIVoiceGPIO\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "13B1937A5E6BAF5D940EB529875D8CAB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RPIVoiceGPIO
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
                    this.Ellipse1 = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 2:
                {
                    this.Ellipse2 = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 3:
                {
                    this.Button_Led1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 13 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Button_Led1).Click += this.Button_Led1_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.Button_Led2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Button_Led2).Click += this.Button_Led2_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.ScenarioFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 6:
                {
                    this.StatusPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7:
                {
                    this.StatusLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.StatusBorder = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 9:
                {
                    this.StatusBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

