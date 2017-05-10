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
    /// InlineResponse20020
    /// </summary>
    [DataContract]
    public partial class InlineResponse20020 :  IEquatable<InlineResponse20020>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20020" /> class.
        /// </summary>
        /// <param name="UpgradeInProgress">UpgradeInProgress.</param>
        public InlineResponse20020(bool? UpgradeInProgress = default(bool?))
        {
            this.UpgradeInProgress = UpgradeInProgress;
        }
        
        /// <summary>
        /// Gets or Sets UpgradeInProgress
        /// </summary>
        [DataMember(Name="upgradeInProgress", EmitDefaultValue=false)]
        public bool? UpgradeInProgress { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20020 {\n");
            sb.Append("  UpgradeInProgress: ").Append(UpgradeInProgress).Append("\n");
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
            return this.Equals(obj as InlineResponse20020);
        }

        /// <summary>
        /// Returns true if InlineResponse20020 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20020 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20020 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UpgradeInProgress == other.UpgradeInProgress ||
                    this.UpgradeInProgress != null &&
                    this.UpgradeInProgress.Equals(other.UpgradeInProgress)
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
                if (this.UpgradeInProgress != null)
                    hash = hash * 59 + this.UpgradeInProgress.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}