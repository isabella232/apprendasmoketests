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
    /// EnrichedStorageQuota
    /// </summary>
    [DataContract]
    public partial class EnrichedStorageQuota :  IEquatable<EnrichedStorageQuota>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnrichedStorageQuota" /> class.
        /// </summary>
        /// <param name="Notes">Notes.</param>
        /// <param name="DeploymentAllowed">DeploymentAllowed.</param>
        /// <param name="Description">Description.</param>
        /// <param name="UnitSize">UnitSize.</param>
        /// <param name="MaxUnits">MaxUnits.</param>
        /// <param name="Cost">Cost.</param>
        /// <param name="IsUnlimited">IsUnlimited.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Href">Href.</param>
        public EnrichedStorageQuota(string Notes = default(string), bool? DeploymentAllowed = default(bool?), string Description = default(string), long? UnitSize = default(long?), long? MaxUnits = default(long?), string Cost = default(string), bool? IsUnlimited = default(bool?), string Name = default(string), string Href = default(string))
        {
            this.Notes = Notes;
            this.DeploymentAllowed = DeploymentAllowed;
            this.Description = Description;
            this.UnitSize = UnitSize;
            this.MaxUnits = MaxUnits;
            this.Cost = Cost;
            this.IsUnlimited = IsUnlimited;
            this.Name = Name;
            this.Href = Href;
        }
        
        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }
        /// <summary>
        /// Gets or Sets DeploymentAllowed
        /// </summary>
        [DataMember(Name="deploymentAllowed", EmitDefaultValue=false)]
        public bool? DeploymentAllowed { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets UnitSize
        /// </summary>
        [DataMember(Name="unitSize", EmitDefaultValue=false)]
        public long? UnitSize { get; set; }
        /// <summary>
        /// Gets or Sets MaxUnits
        /// </summary>
        [DataMember(Name="maxUnits", EmitDefaultValue=false)]
        public long? MaxUnits { get; set; }
        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public string Cost { get; set; }
        /// <summary>
        /// Gets or Sets IsUnlimited
        /// </summary>
        [DataMember(Name="isUnlimited", EmitDefaultValue=false)]
        public bool? IsUnlimited { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
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
            sb.Append("class EnrichedStorageQuota {\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  DeploymentAllowed: ").Append(DeploymentAllowed).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UnitSize: ").Append(UnitSize).Append("\n");
            sb.Append("  MaxUnits: ").Append(MaxUnits).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  IsUnlimited: ").Append(IsUnlimited).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as EnrichedStorageQuota);
        }

        /// <summary>
        /// Returns true if EnrichedStorageQuota instances are equal
        /// </summary>
        /// <param name="other">Instance of EnrichedStorageQuota to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnrichedStorageQuota other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) && 
                (
                    this.DeploymentAllowed == other.DeploymentAllowed ||
                    this.DeploymentAllowed != null &&
                    this.DeploymentAllowed.Equals(other.DeploymentAllowed)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.UnitSize == other.UnitSize ||
                    this.UnitSize != null &&
                    this.UnitSize.Equals(other.UnitSize)
                ) && 
                (
                    this.MaxUnits == other.MaxUnits ||
                    this.MaxUnits != null &&
                    this.MaxUnits.Equals(other.MaxUnits)
                ) && 
                (
                    this.Cost == other.Cost ||
                    this.Cost != null &&
                    this.Cost.Equals(other.Cost)
                ) && 
                (
                    this.IsUnlimited == other.IsUnlimited ||
                    this.IsUnlimited != null &&
                    this.IsUnlimited.Equals(other.IsUnlimited)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                if (this.DeploymentAllowed != null)
                    hash = hash * 59 + this.DeploymentAllowed.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.UnitSize != null)
                    hash = hash * 59 + this.UnitSize.GetHashCode();
                if (this.MaxUnits != null)
                    hash = hash * 59 + this.MaxUnits.GetHashCode();
                if (this.Cost != null)
                    hash = hash * 59 + this.Cost.GetHashCode();
                if (this.IsUnlimited != null)
                    hash = hash * 59 + this.IsUnlimited.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
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
