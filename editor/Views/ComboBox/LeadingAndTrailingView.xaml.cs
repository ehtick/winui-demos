#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Syncfusion.UI.Xaml.Editors;
using Windows.System;
using Syncfusion.UI.Xaml.Core;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Syncfusion.EditorDemos.WinUI.Views.ComboBox
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LeadingAndTrailingView : Page, IDisposable
    {
        
        public LeadingAndTrailingView()
        {
            this.InitializeComponent();
        }

        private void OnEditingComboBoxPreviewKeyDown(object sender, KeyRoutedEventArgs e)
        {
            var comboBox = sender as SfComboBox;
            if (!comboBox.IsDropDownOpen)
            {
                bool allowOpenDropDown = e.Key != VirtualKey.Enter && e.Key != VirtualKey.Tab &&
                                         e.Key != VirtualKey.F4 && e.Key != VirtualKey.Escape &&
                                         e.Key != VirtualKey.Shift;

                if (allowOpenDropDown)
                {
                    comboBox.IsDropDownOpen = true;
                }
            }
        }

        /// <summary>
        /// To dispose objects.
        /// </summary>
        public void Dispose()
        {
            if (this.leadingView != null)
            {
                this.leadingView.Dispose();
            }

            if (this.trailingView != null)
            {
                this.trailingView.Dispose();
            }

            if (this.leadingAndTrailingView != null)
            {
                this.leadingAndTrailingView.Dispose();
            }

            this.Resources.Clear();
            this.DataContext = null;
        }
    }
}
