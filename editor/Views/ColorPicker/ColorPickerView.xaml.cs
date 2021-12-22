#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace syncfusion.editordemos.winui.Views.ColorPicker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ColorPickerView : Page
    {
        public ColorPickerView()
        {
            this.InitializeComponent();
            this.colorPickerViewPanel.PointerPressed += OnColorPickerViewPanelPointerPressed;
        }

        private void OnColorPickerViewPanelPointerPressed(object sender, Microsoft.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            // To restrict the focus on first control when clicking on empty area.
            e.Handled = true;
        }
    }
}