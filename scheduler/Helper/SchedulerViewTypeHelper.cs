#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Syncfusion.UI.Xaml.Scheduler;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syncfusion.schedulerdemos.winui
{
    /// <summary>
    /// Represents helper class to get scheduler view types.
    /// </summary>
    public static class SchedulerViewTypeHelper
    {
        /// <summary>
        /// Method to get all scheduler view types.
        /// </summary>
        /// <returns> Scheduler view type collection as key and value.</returns>
        internal static ObservableCollection<SchedulerViewTypeModel> GetSchedulerViewTypes()
        {
            var schedulerViewTypes = new ObservableCollection<SchedulerViewTypeModel>();
            schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Month", SchedulerViewType = SchedulerViewType.Month });
            schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Day", SchedulerViewType = SchedulerViewType.Day });
            schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Week", SchedulerViewType = SchedulerViewType.Week });
            schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Work Week", SchedulerViewType = SchedulerViewType.WorkWeek });
            schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Timeline Day", SchedulerViewType = SchedulerViewType.TimelineDay });
            schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Timeline Week", SchedulerViewType = SchedulerViewType.TimelineWeek });
            schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Timeline Work Week", SchedulerViewType = SchedulerViewType.TimelineWorkWeek });
            schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Timeline Month", SchedulerViewType = SchedulerViewType.TimelineMonth });
            return schedulerViewTypes;
        }

		/// <summary>
		/// Method to get scheduler timeline view types.
		/// </summary>
		/// <returns> Scheduler timeline view type collection as key and value.</returns>
		internal static ObservableCollection<SchedulerViewTypeModel> GetTimelineViewTypes()
		{
			var timelineViewTypes = new ObservableCollection<SchedulerViewTypeModel>();
			timelineViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Timeline Day", SchedulerViewType = SchedulerViewType.TimelineDay });
			timelineViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Timeline Week", SchedulerViewType = SchedulerViewType.TimelineWeek });
			timelineViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Timeline Work Week", SchedulerViewType = SchedulerViewType.TimelineWorkWeek });
			timelineViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Timeline Month", SchedulerViewType = SchedulerViewType.TimelineMonth });
			return timelineViewTypes;
		}

		/// <summary>
		/// Method to get scheduler view types for appointment customization sample, which excludes day and TimelineDay types.
		/// </summary>
		/// <returns> Scheduler view type collection as key and value.</returns>
		internal static ObservableCollection<SchedulerViewTypeModel> GetAppointmentCustomizationViewTypes()
		{
			var schedulerViewTypes = new ObservableCollection<SchedulerViewTypeModel>();
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Week", SchedulerViewType = SchedulerViewType.Week });
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Work Week", SchedulerViewType = SchedulerViewType.WorkWeek });
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Month", SchedulerViewType = SchedulerViewType.Month });
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Timeline Week", SchedulerViewType = SchedulerViewType.TimelineWeek });
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Timeline Work Week", SchedulerViewType = SchedulerViewType.TimelineWorkWeek });
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Timeline Month", SchedulerViewType = SchedulerViewType.TimelineMonth });
			return schedulerViewTypes;
		}

		/// <summary>
		/// Method to get scheduler view types for resource sample, which excludes Month type.
		/// </summary>
		/// <returns> Scheduler view type collection as key and value.</returns>
		internal static ObservableCollection<SchedulerViewTypeModel> GetResourceSchedulerViewTypes()
		{
			var schedulerViewTypes = new ObservableCollection<SchedulerViewTypeModel>();
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Day", SchedulerViewType = SchedulerViewType.Day });
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Week", SchedulerViewType = SchedulerViewType.Week });
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Work Week", SchedulerViewType = SchedulerViewType.WorkWeek });
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Timeline Day", SchedulerViewType = SchedulerViewType.TimelineDay });
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Timeline Week", SchedulerViewType = SchedulerViewType.TimelineWeek });
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Timeline Work Week", SchedulerViewType = SchedulerViewType.TimelineWorkWeek });
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Timeline Month", SchedulerViewType = SchedulerViewType.TimelineMonth });
			return schedulerViewTypes;
		}

		/// <summary>
		/// Method to get scheduler view types for time slot customization sample, which excludes Month and TimelineMonth type.
		/// </summary>
		/// <returns> Scheduler view type collection as key and value.</returns>
		internal static ObservableCollection<SchedulerViewTypeModel> GetTimeSlotSchedulerViewTypes()
		{
			var schedulerViewTypes = new ObservableCollection<SchedulerViewTypeModel>();
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Day", SchedulerViewType = SchedulerViewType.Day });
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Week", SchedulerViewType = SchedulerViewType.Week });
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Work Week", SchedulerViewType = SchedulerViewType.WorkWeek });
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Timeline Day", SchedulerViewType = SchedulerViewType.TimelineDay });
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Timeline Week", SchedulerViewType = SchedulerViewType.TimelineWeek });
			schedulerViewTypes.Add(new SchedulerViewTypeModel() { ViewTypeDisplayMemberPath = "Timeline Work Week", SchedulerViewType = SchedulerViewType.TimelineWorkWeek });
			return schedulerViewTypes;
		}
	}

	/// <summary>
	/// Represents model class for SchedulerViewType.
	/// </summary>
	public class SchedulerViewTypeModel
    {
        /// <summary>
        /// Gets or sets SchedulerViewType diplay member path.
        /// </summary>
        public string ViewTypeDisplayMemberPath { get; set; }

        /// <summary>
        /// Gets or sets SchedulerViewType value member path.
        /// </summary>
        public SchedulerViewType SchedulerViewType { get; set; }
    }
}
