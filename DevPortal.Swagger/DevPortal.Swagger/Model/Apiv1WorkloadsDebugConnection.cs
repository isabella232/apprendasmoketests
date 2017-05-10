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
    /// Apiv1WorkloadsDebugConnection
    /// </summary>
    [DataContract]
    public partial class Apiv1WorkloadsDebugConnection :  IEquatable<Apiv1WorkloadsDebugConnection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Apiv1WorkloadsDebugConnection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Apiv1WorkloadsDebugConnection()
        {
        }
        
        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public string Host { get; private set; }
        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; private set; }
        /// <summary>
        /// Gets or Sets Fqdn
        /// </summary>
        [DataMember(Name="fqdn", EmitDefaultValue=false)]
        public string Fqdn { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Apiv1WorkloadsDebugConnection {\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Fqdn: ").Append(Fqdn).Append("\n");
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
            return this.Equals(obj as Apiv1WorkloadsDebugConnection);
        }

        /// <summary>
        /// Returns true if Apiv1WorkloadsDebugConnection instances are equal
        /// </summary>
        /// <param name="other">Instance of Apiv1WorkloadsDebugConnection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Apiv1WorkloadsDebugConnection other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Host == other.Host ||
                    this.Host != null &&
                    this.Host.Equals(other.Host)
                ) && 
                (
                    this.Port == other.Port ||
                    this.Port != null &&
                    this.Port.Equals(other.Port)
                ) && 
                (
                    this.Fqdn == other.Fqdn ||
                    this.Fqdn != null &&
                    this.Fqdn.Equals(other.Fqdn)
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
                if (this.Host != null)
                    hash = hash * 59 + this.Host.GetHashCode();
                if (this.Port != null)
                    hash = hash * 59 + this.Port.GetHashCode();
                if (this.Fqdn != null)
                    hash = hash * 59 + this.Fqdn.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}