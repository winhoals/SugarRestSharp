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
    /// A class which represents the upgrade_history table.
    /// </summary>
	[ModuleProperty(ModuleName = "UpgradeHistory", TableName="upgrade_history")]
	public partial class UpgradeHistory : EntityBase
	{
		[JsonProperty(PropertyName = "id")]
		public virtual string Id { get; set; }

		[JsonProperty(PropertyName = "filename")]
		public virtual string Filename { get; set; }

		[JsonProperty(PropertyName = "md5sum")]
		public virtual string Md5sum { get; set; }

		[JsonProperty(PropertyName = "type")]
		public virtual string Type { get; set; }

		[JsonProperty(PropertyName = "status")]
		public virtual string Status { get; set; }

		[JsonProperty(PropertyName = "version")]
		public virtual string Version { get; set; }

		[JsonProperty(PropertyName = "name")]
		public virtual string Name { get; set; }

		[JsonProperty(PropertyName = "description")]
		public virtual string Description { get; set; }

		[JsonProperty(PropertyName = "id_name")]
		public virtual string IdName { get; set; }

		[JsonProperty(PropertyName = "manifest")]
		public virtual string Manifest { get; set; }

		[JsonProperty(PropertyName = "date_entered")]
		public virtual DateTime? DateEntered { get; set; }

		[JsonProperty(PropertyName = "enabled")]
		public virtual sbyte? Enabled { get; set; }

	}
}