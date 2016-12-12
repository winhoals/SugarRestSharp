// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

namespace SugarRestSharp.Models
{
	using System;
	using Newtonsoft.Json;
	

    /// <summary>
    /// A class which represents the contacts_bugs table.
    /// </summary>
	[ModuleProperty(ModuleName = "ContactsBugs", TableName="contacts_bugs")]
	public partial class ContactsBugs : EntityBase
	{
		[JsonProperty(PropertyName = "id")]
		public virtual string Id { get; set; }

		[JsonProperty(PropertyName = "contact_id")]
		public virtual string ContactId { get; set; }

		[JsonProperty(PropertyName = "bug_id")]
		public virtual string BugId { get; set; }

		[JsonProperty(PropertyName = "contact_role")]
		public virtual string ContactRole { get; set; }

		[JsonProperty(PropertyName = "date_modified")]
		public virtual DateTime? DateModified { get; set; }

		[JsonProperty(PropertyName = "deleted")]
		public virtual sbyte? Deleted { get; set; }

	}
}