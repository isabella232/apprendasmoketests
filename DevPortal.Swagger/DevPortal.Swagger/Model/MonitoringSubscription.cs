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
    /// MonitoringSubscription
    /// </summary>
    [DataContract]
    public partial class MonitoringSubscription :  IEquatable<MonitoringSubscription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonitoringSubscription" /> class.
        /// </summary>
        /// <param name="Locator">Locator.</param>
        /// <param name="Component">Component.</param>
        /// <param name="UpdateInterval">UpdateInterval.</param>
        /// <param name="Properties">Properties.</param>
        /// <param name="Href">Href.</param>
        public MonitoringSubscription(Guid? Locator = default(Guid?), Apiv1monitoringsubscriptionsappAliasversionAliasComponent Component = default(Apiv1monitoringsubscriptionsappAliasversionAliasComponent), int? UpdateInterval = default(int?), List<string> Properties = default(List<string>), string Href = default(string))
        {
            this.Locator = Locator;
            this.Component = Component;
            this.UpdateInterval = UpdateInterval;
            this.Properties = Properties;
            this.Href = Href;
        }
        
        /// <summary>
        /// Gets or Sets Locator
        /// </summary>
        [DataMember(Name="locator", EmitDefaultValue=false)]
        public Guid? Locator { get; set; }
        /// <summary>
        /// Gets or Sets Component
        /// </summary>
        [DataMember(Name="component", EmitDefaultValue=false)]
        public Apiv1monitoringsubscriptionsappAliasversionAliasComponent Component { get; set; }
        /// <summary>
        /// Gets or Sets UpdateInterval
        /// </summary>
        [DataMember(Name="updateInterval", EmitDefaultValue=false)]
        public int? UpdateInterval { get; set; }
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<string> Properties { get; set; }
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
            sb.Append("class MonitoringSubscription {\n");
            sb.Append("  Locator: ").Append(Locator).Append("\n");
            sb.Append("  Component: ").Append(Component).Append("\n");
            sb.Append("  UpdateInterval: ").Append(UpdateInterval).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(obj as MonitoringSubscription);
        }

        /// <summary>
        /// Returns true if MonitoringSubscription instances are equal
        /// </summary>
        /// <param name="other">Instance of MonitoringSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonitoringSubscription other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Locator == other.Locator ||
                    this.Locator != null &&
                    this.Locator.Equals(other.Locator)
                ) && 
                (
                    this.Component == other.Component ||
                    this.Component != null &&
                    this.Component.Equals(other.Component)
                ) && 
                (
                    this.UpdateInterval == other.UpdateInterval ||
                    this.UpdateInterval != null &&
                    this.UpdateInterval.Equals(other.UpdateInterval)
                ) && 
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
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
                if (this.Locator != null)
                    hash = hash * 59 + this.Locator.GetHashCode();
                if (this.Component != null)
                    hash = hash * 59 + this.Component.GetHashCode();
                if (this.UpdateInterval != null)
                    hash = hash * 59 + this.UpdateInterval.GetHashCode();
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
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
