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
    /// Apiv1LogOverridesNotification
    /// </summary>
    [DataContract]
    public partial class Apiv1LogOverridesNotification :  IEquatable<Apiv1LogOverridesNotification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Apiv1LogOverridesNotification" /> class.
        /// </summary>
        /// <param name="Active">Active.</param>
        /// <param name="Minutes">Minutes.</param>
        public Apiv1LogOverridesNotification(bool? Active = default(bool?), int? Minutes = default(int?))
        {
            this.Active = Active;
            this.Minutes = Minutes;
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
        /// <summary>
        /// Gets or Sets Minutes
        /// </summary>
        [DataMember(Name="minutes", EmitDefaultValue=false)]
        public int? Minutes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Apiv1LogOverridesNotification {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Minutes: ").Append(Minutes).Append("\n");
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
            return this.Equals(obj as Apiv1LogOverridesNotification);
        }

        /// <summary>
        /// Returns true if Apiv1LogOverridesNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of Apiv1LogOverridesNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Apiv1LogOverridesNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.Minutes == other.Minutes ||
                    this.Minutes != null &&
                    this.Minutes.Equals(other.Minutes)
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
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this.Minutes != null)
                    hash = hash * 59 + this.Minutes.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}