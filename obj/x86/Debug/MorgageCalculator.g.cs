﻿#pragma checksum "C:\Users\User\source\repos\Tafe-Universal Calculator\MorgageCalculator.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "811E029ECAF11CC97BF5D220FB4316528573C3083C527BBE5093F76A44AF35E4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tafe_Universal_Calculator
{
    partial class MorgageCalculator : 
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
            case 2: // MorgageCalculator.xaml line 43
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.calButton_Click;
                }
                break;
            case 3: // MorgageCalculator.xaml line 44
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.HyperlinkButton_Click;
                }
                break;
            case 4: // MorgageCalculator.xaml line 41
                {
                    this.repaymentMTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // MorgageCalculator.xaml line 37
                {
                    this.IRMTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // MorgageCalculator.xaml line 33
                {
                    this.iRYTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // MorgageCalculator.xaml line 29
                {
                    this.monthsTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // MorgageCalculator.xaml line 25
                {
                    this.yearsTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // MorgageCalculator.xaml line 21
                {
                    this.principalAmount = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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
