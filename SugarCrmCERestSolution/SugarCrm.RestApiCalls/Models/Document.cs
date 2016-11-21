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
    /// A class which represents the documents table.
    /// </summary>
	[ModuleProperty(ModuleName = "Documents", TableName="documents")]
	public partial class Document : EntityBase
	{
		[JsonProperty(PropertyName = "id")]
		public virtual string Id { get; set; }

		[JsonProperty(PropertyName = "date_entered")]
		public virtual DateTime? DateEntered { get; set; }

		[JsonProperty(PropertyName = "date_modified")]
		public virtual DateTime? DateModified { get; set; }

		[JsonProperty(PropertyName = "modified_user_id")]
		public virtual string ModifiedUserId { get; set; }

		[JsonProperty(PropertyName = "created_by")]
		public virtual string CreatedBy { get; set; }

		[JsonProperty(PropertyName = "description")]
		public virtual string Description { get; set; }

		[JsonProperty(PropertyName = "deleted")]
		public virtual sbyte? Deleted { get; set; }

		[JsonProperty(PropertyName = "assigned_user_id")]
		public virtual string AssignedUserId { get; set; }

		[JsonProperty(PropertyName = "document_name")]
		public virtual string DocumentName { get; set; }

		[JsonProperty(PropertyName = "doc_id")]
		public virtual string DocId { get; set; }

		[JsonProperty(PropertyName = "doc_type")]
		public virtual string DocType { get; set; }

		[JsonProperty(PropertyName = "doc_url")]
		public virtual string DocUrl { get; set; }

		[JsonProperty(PropertyName = "active_date")]
		public virtual DateTime? ActiveDate { get; set; }

		[JsonProperty(PropertyName = "exp_date")]
		public virtual DateTime? ExpDate { get; set; }

		[JsonProperty(PropertyName = "category_id")]
		public virtual string CategoryId { get; set; }

		[JsonProperty(PropertyName = "subcategory_id")]
		public virtual string SubcategoryId { get; set; }

		[JsonProperty(PropertyName = "status_id")]
		public virtual string StatusId { get; set; }

		[JsonProperty(PropertyName = "document_revision_id")]
		public virtual string DocumentRevisionId { get; set; }

		[JsonProperty(PropertyName = "related_doc_id")]
		public virtual string RelatedDocId { get; set; }

		[JsonProperty(PropertyName = "related_doc_rev_id")]
		public virtual string RelatedDocRevId { get; set; }

		[JsonProperty(PropertyName = "is_template")]
		public virtual sbyte? IsTemplate { get; set; }

		[JsonProperty(PropertyName = "template_type")]
		public virtual string TemplateType { get; set; }

	}
}