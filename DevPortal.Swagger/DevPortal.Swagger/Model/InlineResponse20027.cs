/* 
 * Apprenda.DeveloperPortal.Web
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// InlineResponse20027
    /// </summary>
    [DataContract]
    public partial class InlineResponse20027 :  IEquatable<InlineResponse20027>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20027" /> class.
        /// </summary>
        /// <param name="CurrentPage">CurrentPage.</param>
        /// <param name="PageSize">PageSize.</param>
        /// <param name="TotalPages">TotalPages.</param>
        /// <param name="TotalItems">TotalItems.</param>
        /// <param name="Items">Items.</param>
        /// <param name="NextPage">NextPage.</param>
        /// <param name="PreviousPage">PreviousPage.</param>
        /// <param name="Href">Href.</param>
        public InlineResponse20027(int? CurrentPage = default(int?), int? PageSize = default(int?), int? TotalPages = default(int?), long? TotalItems = default(long?), List<InlineResponse20027Items> Items = default(List<InlineResponse20027Items>), InlineResponse200Icon NextPage = default(InlineResponse200Icon), InlineResponse200Icon PreviousPage = default(InlineResponse200Icon), string Href = default(string))
        {
            this.CurrentPage = CurrentPage;
            this.PageSize = PageSize;
            this.TotalPages = TotalPages;
            this.TotalItems = TotalItems;
            this.Items = Items;
            this.NextPage = NextPage;
            this.PreviousPage = PreviousPage;
            this.Href = Href;
        }
        
        /// <summary>
        /// Gets or Sets CurrentPage
        /// </summary>
        [DataMember(Name="currentPage", EmitDefaultValue=false)]
        public int? CurrentPage { get; set; }
        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name="totalPages", EmitDefaultValue=false)]
        public int? TotalPages { get; set; }
        /// <summary>
        /// Gets or Sets TotalItems
        /// </summary>
        [DataMember(Name="totalItems", EmitDefaultValue=false)]
        public long? TotalItems { get; set; }
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<InlineResponse20027Items> Items { get; set; }
        /// <summary>
        /// Gets or Sets NextPage
        /// </summary>
        [DataMember(Name="nextPage", EmitDefaultValue=false)]
        public InlineResponse200Icon NextPage { get; set; }
        /// <summary>
        /// Gets or Sets PreviousPage
        /// </summary>
        [DataMember(Name="previousPage", EmitDefaultValue=false)]
        public InlineResponse200Icon PreviousPage { get; set; }
        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20027 {\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  TotalItems: ").Append(TotalItems).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  PreviousPage: ").Append(PreviousPage).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InlineResponse20027);
        }

        /// <summary>
        /// Returns true if InlineResponse20027 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20027 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20027 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CurrentPage == other.CurrentPage ||
                    this.CurrentPage != null &&
                    this.CurrentPage.Equals(other.CurrentPage)
                ) && 
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) && 
                (
                    this.TotalPages == other.TotalPages ||
                    this.TotalPages != null &&
                    this.TotalPages.Equals(other.TotalPages)
                ) && 
                (
                    this.TotalItems == other.TotalItems ||
                    this.TotalItems != null &&
                    this.TotalItems.Equals(other.TotalItems)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
                ) && 
                (
                    this.NextPage == other.NextPage ||
                    this.NextPage != null &&
                    this.NextPage.Equals(other.NextPage)
                ) && 
                (
                    this.PreviousPage == other.PreviousPage ||
                    this.PreviousPage != null &&
                    this.PreviousPage.Equals(other.PreviousPage)
                ) && 
                (
                    this.Href == other.Href ||
                    this.Href != null &&
                    this.Href.Equals(other.Href)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.CurrentPage != null)
                    hash = hash * 59 + this.CurrentPage.GetHashCode();
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                if (this.TotalPages != null)
                    hash = hash * 59 + this.TotalPages.GetHashCode();
                if (this.TotalItems != null)
                    hash = hash * 59 + this.TotalItems.GetHashCode();
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                if (this.NextPage != null)
                    hash = hash * 59 + this.NextPage.GetHashCode();
                if (this.PreviousPage != null)
                    hash = hash * 59 + this.PreviousPage.GetHashCode();
                if (this.Href != null)
                    hash = hash * 59 + this.Href.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
