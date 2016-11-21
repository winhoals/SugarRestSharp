// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

namespace SugarCrm.RestApiCalls.Models
{
	using System;
	using Newtonsoft.Json;
	

    /// <summary>
    /// A class which represents the project_task table.
    /// </summary>
	[ModuleProperty(ModuleName = "ProjectTask", TableName="project_task")]
	public partial class ProjectTask : EntityBase
	{
		[JsonProperty(PropertyName = "id")]
		public virtual string Id { get; set; }

		[JsonProperty(PropertyName = "date_entered")]
		public virtual DateTime? DateEntered { get; set; }

		[JsonProperty(PropertyName = "date_modified")]
		public virtual DateTime? DateModified { get; set; }

		[JsonProperty(PropertyName = "project_id")]
		public virtual string ProjectId { get; set; }

		[JsonProperty(PropertyName = "project_task_id")]
		public virtual int? ProjectTaskId { get; set; }

		[JsonProperty(PropertyName = "name")]
		public virtual string Name { get; set; }

		[JsonProperty(PropertyName = "status")]
		public virtual string Status { get; set; }

		[JsonProperty(PropertyName = "description")]
		public virtual string Description { get; set; }

		[JsonProperty(PropertyName = "predecessors")]
		public virtual string Predecessors { get; set; }

		[JsonProperty(PropertyName = "date_start")]
		public virtual DateTime? DateStart { get; set; }

		[JsonProperty(PropertyName = "time_start")]
		public virtual int? TimeStart { get; set; }

		[JsonProperty(PropertyName = "time_finish")]
		public virtual int? TimeFinish { get; set; }

		[JsonProperty(PropertyName = "date_finish")]
		public virtual DateTime? DateFinish { get; set; }

		[JsonProperty(PropertyName = "duration")]
		public virtual int? Duration { get; set; }

		[JsonProperty(PropertyName = "duration_unit")]
		public virtual string DurationUnit { get; set; }

		[JsonProperty(PropertyName = "actual_duration")]
		public virtual int? ActualDuration { get; set; }

		[JsonProperty(PropertyName = "percent_complete")]
		public virtual int? PercentComplete { get; set; }

		[JsonProperty(PropertyName = "date_due")]
		public virtual DateTime? DateDue { get; set; }

		[JsonProperty(PropertyName = "time_due")]
		public virtual string TimeDue { get; set; }

		[JsonProperty(PropertyName = "parent_task_id")]
		public virtual int? ParentTaskId { get; set; }

		[JsonProperty(PropertyName = "assigned_user_id")]
		public virtual string AssignedUserId { get; set; }

		[JsonProperty(PropertyName = "modified_user_id")]
		public virtual string ModifiedUserId { get; set; }

		[JsonProperty(PropertyName = "priority")]
		public virtual string Priority { get; set; }

		[JsonProperty(PropertyName = "created_by")]
		public virtual string CreatedBy { get; set; }

		[JsonProperty(PropertyName = "milestone_flag")]
		public virtual sbyte? MilestoneFlag { get; set; }

		[JsonProperty(PropertyName = "order_number")]
		public virtual int? OrderNumber { get; set; }

		[JsonProperty(PropertyName = "task_number")]
		public virtual int? TaskNumber { get; set; }

		[JsonProperty(PropertyName = "estimated_effort")]
		public virtual int? EstimatedEffort { get; set; }

		[JsonProperty(PropertyName = "actual_effort")]
		public virtual int? ActualEffort { get; set; }

		[JsonProperty(PropertyName = "deleted")]
		public virtual sbyte? Deleted { get; set; }

		[JsonProperty(PropertyName = "utilization")]
		public virtual int? Utilization { get; set; }

	}
}