// Updated by XamlIntelliSenseFileGenerator 28-09-2022 13:31:36
#pragma checksum "..\..\LManager.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F207495A7F2AF5C9D36AE9A66BB00977195B98382AE1C61B342E4EF6BBCCCD51"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PasswordGenerator;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace PasswordGenerator
{


    /// <summary>
    /// LManager
    /// </summary>
    public partial class LManager : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {


#line 81 "..\..\LManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;

#line default
#line hidden


#line 89 "..\..\LManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Website;

#line default
#line hidden


#line 97 "..\..\LManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox User;

#line default
#line hidden


#line 105 "..\..\LManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserPassword;

#line default
#line hidden


#line 119 "..\..\LManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame LManagerPage;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PasswordGenerator;component/lmanager.xaml", System.UriKind.Relative);

#line 1 "..\..\LManager.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.BackBtn = ((System.Windows.Controls.Button)(target));

#line 87 "..\..\LManager.xaml"
                    this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.Website = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.User = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.UserPassword = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.LManagerPage = ((System.Windows.Controls.Frame)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.DataGrid dataGrid;
    }
}

