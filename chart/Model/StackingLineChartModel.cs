#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;

namespace Syncfusion.ChartDemos.WinUI
{
    public class StackingLineChartModel
    {
        public string Name
        {
            get;
            set;
        }

        public double Father
        {
            get;
            set;
        }

        public double Mother
        {
            get;
            set;
        }

        public double Son
        {
            get;
            set;
        }

        public double Daughter
        {
            get;
            set;
        }
    }
}