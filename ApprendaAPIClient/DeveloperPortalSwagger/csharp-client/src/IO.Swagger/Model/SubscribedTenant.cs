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
    /// SubscribedTenant
    /// </summary>
    [DataContract]
    public partial class SubscribedTenant :  IEquatable<SubscribedTenant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscribedTenant" /> class.
        /// </summary>
        /// <param name="TenantAlias">TenantAlias.</param>
        /// <param name="TenantName">TenantName.</param>
        /// <param name="Users">Users.</param>
        public SubscribedTenant(string TenantAlias = default(string), string TenantName = default(string), ResourceBase Users = default(ResourceBase))
        {
            this.TenantAlias = TenantAlias;
            this.TenantName = TenantName;
            this.Users = Users;
        }
        
        /// <summary>
        /// Gets or Sets TenantAlias
        /// </summary>
        [DataMember(Name="tenantAlias", EmitDefaultValue=false)]
        public string TenantAlias { get; set; }
        /// <summary>
        /// Gets or Sets TenantName
        /// </summary>
        [DataMember(Name="tenantName", EmitDefaultValue=false)]
        public string TenantName { get; set; }
        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public ResourceBase Users { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscribedTenant {\n");
            sb.Append("  TenantAlias: ").Append(TenantAlias).Append("\n");
            sb.Append("  TenantName: ").Append(TenantName).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(obj as SubscribedTenant);
        }

        /// <summary>
        /// Returns true if SubscribedTenant instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscribedTenant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscribedTenant other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TenantAlias == other.TenantAlias ||
                    this.TenantAlias != null &&
                    this.TenantAlias.Equals(other.TenantAlias)
                ) && 
                (
                    this.TenantName == other.TenantName ||
                    this.TenantName != null &&
                    this.TenantName.Equals(other.TenantName)
                ) && 
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.Equals(other.Users)
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
                if (this.TenantAlias != null)
                    hash = hash * 59 + this.TenantAlias.GetHashCode();
                if (this.TenantName != null)
                    hash = hash * 59 + this.TenantName.GetHashCode();
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
