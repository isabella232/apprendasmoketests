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
    /// Version1
    /// </summary>
    [DataContract]
    public partial class Version1 :  IEquatable<Version1>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets LoadBalancerUrlConfiguration
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LoadBalancerUrlConfigurationEnum
        {
            
            /// <summary>
            /// Enum Preserve for "Preserve"
            /// </summary>
            [EnumMember(Value = "Preserve")]
            Preserve,
            
            /// <summary>
            /// Enum Redirect for "Redirect"
            /// </summary>
            [EnumMember(Value = "Redirect")]
            Redirect
        }

        /// <summary>
        /// Gets or Sets LoadBalancerUrlConfiguration
        /// </summary>
        [DataMember(Name="loadBalancerUrlConfiguration", EmitDefaultValue=false)]
        public LoadBalancerUrlConfigurationEnum? LoadBalancerUrlConfiguration { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Version1" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Alias">Alias.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Stage">Stage.</param>
        /// <param name="State">State.</param>
        /// <param name="Application">Application.</param>
        /// <param name="EnableStickySessions">EnableStickySessions.</param>
        /// <param name="EnableSessionReplication">EnableSessionReplication.</param>
        /// <param name="EnableSslEnforcement">EnableSslEnforcement.</param>
        /// <param name="LoadBalancerUrlConfiguration">LoadBalancerUrlConfiguration.</param>
        /// <param name="InMaintenance">InMaintenance.</param>
        /// <param name="Href">Href.</param>
        public Version1(string Name = default(string), string Alias = default(string), string Description = default(string), string Stage = default(string), string State = default(string), InlineResponse200Icon Application = default(InlineResponse200Icon), bool? EnableStickySessions = default(bool?), bool? EnableSessionReplication = default(bool?), bool? EnableSslEnforcement = default(bool?), LoadBalancerUrlConfigurationEnum? LoadBalancerUrlConfiguration = default(LoadBalancerUrlConfigurationEnum?), bool? InMaintenance = default(bool?), string Href = default(string))
        {
            this.Name = Name;
            this.Alias = Alias;
            this.Description = Description;
            this.Stage = Stage;
            this.State = State;
            this.Application = Application;
            this.EnableStickySessions = EnableStickySessions;
            this.EnableSessionReplication = EnableSessionReplication;
            this.EnableSslEnforcement = EnableSslEnforcement;
            this.LoadBalancerUrlConfiguration = LoadBalancerUrlConfiguration;
            this.InMaintenance = InMaintenance;
            this.Href = Href;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Alias
        /// </summary>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Stage
        /// </summary>
        [DataMember(Name="stage", EmitDefaultValue=false)]
        public string Stage { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
        /// <summary>
        /// Gets or Sets Application
        /// </summary>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public InlineResponse200Icon Application { get; set; }
        /// <summary>
        /// Gets or Sets EnableStickySessions
        /// </summary>
        [DataMember(Name="enableStickySessions", EmitDefaultValue=false)]
        public bool? EnableStickySessions { get; set; }
        /// <summary>
        /// Gets or Sets EnableSessionReplication
        /// </summary>
        [DataMember(Name="enableSessionReplication", EmitDefaultValue=false)]
        public bool? EnableSessionReplication { get; set; }
        /// <summary>
        /// Gets or Sets EnableSslEnforcement
        /// </summary>
        [DataMember(Name="enableSslEnforcement", EmitDefaultValue=false)]
        public bool? EnableSslEnforcement { get; set; }
        /// <summary>
        /// Gets or Sets InMaintenance
        /// </summary>
        [DataMember(Name="inMaintenance", EmitDefaultValue=false)]
        public bool? InMaintenance { get; set; }
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
            sb.Append("class Version1 {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Stage: ").Append(Stage).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  EnableStickySessions: ").Append(EnableStickySessions).Append("\n");
            sb.Append("  EnableSessionReplication: ").Append(EnableSessionReplication).Append("\n");
            sb.Append("  EnableSslEnforcement: ").Append(EnableSslEnforcement).Append("\n");
            sb.Append("  LoadBalancerUrlConfiguration: ").Append(LoadBalancerUrlConfiguration).Append("\n");
            sb.Append("  InMaintenance: ").Append(InMaintenance).Append("\n");
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
            return this.Equals(obj as Version1);
        }

        /// <summary>
        /// Returns true if Version1 instances are equal
        /// </summary>
        /// <param name="other">Instance of Version1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Version1 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Alias == other.Alias ||
                    this.Alias != null &&
                    this.Alias.Equals(other.Alias)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Stage == other.Stage ||
                    this.Stage != null &&
                    this.Stage.Equals(other.Stage)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Application == other.Application ||
                    this.Application != null &&
                    this.Application.Equals(other.Application)
                ) && 
                (
                    this.EnableStickySessions == other.EnableStickySessions ||
                    this.EnableStickySessions != null &&
                    this.EnableStickySessions.Equals(other.EnableStickySessions)
                ) && 
                (
                    this.EnableSessionReplication == other.EnableSessionReplication ||
                    this.EnableSessionReplication != null &&
                    this.EnableSessionReplication.Equals(other.EnableSessionReplication)
                ) && 
                (
                    this.EnableSslEnforcement == other.EnableSslEnforcement ||
                    this.EnableSslEnforcement != null &&
                    this.EnableSslEnforcement.Equals(other.EnableSslEnforcement)
                ) && 
                (
                    this.LoadBalancerUrlConfiguration == other.LoadBalancerUrlConfiguration ||
                    this.LoadBalancerUrlConfiguration != null &&
                    this.LoadBalancerUrlConfiguration.Equals(other.LoadBalancerUrlConfiguration)
                ) && 
                (
                    this.InMaintenance == other.InMaintenance ||
                    this.InMaintenance != null &&
                    this.InMaintenance.Equals(other.InMaintenance)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Alias != null)
                    hash = hash * 59 + this.Alias.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Stage != null)
                    hash = hash * 59 + this.Stage.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Application != null)
                    hash = hash * 59 + this.Application.GetHashCode();
                if (this.EnableStickySessions != null)
                    hash = hash * 59 + this.EnableStickySessions.GetHashCode();
                if (this.EnableSessionReplication != null)
                    hash = hash * 59 + this.EnableSessionReplication.GetHashCode();
                if (this.EnableSslEnforcement != null)
                    hash = hash * 59 + this.EnableSslEnforcement.GetHashCode();
                if (this.LoadBalancerUrlConfiguration != null)
                    hash = hash * 59 + this.LoadBalancerUrlConfiguration.GetHashCode();
                if (this.InMaintenance != null)
                    hash = hash * 59 + this.InMaintenance.GetHashCode();
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