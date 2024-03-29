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
    /// ResourceAllocationPolicy
    /// </summary>
    [DataContract]
    public partial class ResourceAllocationPolicy :  IEquatable<ResourceAllocationPolicy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceAllocationPolicy" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="MemoryLimit">MemoryLimit.</param>
        /// <param name="CpuLimit">CpuLimit.</param>
        /// <param name="CpuCores">CpuCores.</param>
        /// <param name="Cost">Cost.</param>
        /// <param name="AppliesToServices">AppliesToServices.</param>
        /// <param name="AppliesToDatabases">AppliesToDatabases.</param>
        /// <param name="AppliesToUserInterfaces">AppliesToUserInterfaces.</param>
        /// <param name="AppliesToWars">AppliesToWars.</param>
        /// <param name="AppliesToLinuxServices">AppliesToLinuxServices.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Href">Href.</param>
        public ResourceAllocationPolicy(string Description = default(string), long? MemoryLimit = default(long?), long? CpuLimit = default(long?), int? CpuCores = default(int?), string Cost = default(string), bool? AppliesToServices = default(bool?), bool? AppliesToDatabases = default(bool?), bool? AppliesToUserInterfaces = default(bool?), bool? AppliesToWars = default(bool?), bool? AppliesToLinuxServices = default(bool?), string Name = default(string), string Href = default(string))
        {
            this.Description = Description;
            this.MemoryLimit = MemoryLimit;
            this.CpuLimit = CpuLimit;
            this.CpuCores = CpuCores;
            this.Cost = Cost;
            this.AppliesToServices = AppliesToServices;
            this.AppliesToDatabases = AppliesToDatabases;
            this.AppliesToUserInterfaces = AppliesToUserInterfaces;
            this.AppliesToWars = AppliesToWars;
            this.AppliesToLinuxServices = AppliesToLinuxServices;
            this.Name = Name;
            this.Href = Href;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets MemoryLimit
        /// </summary>
        [DataMember(Name="memoryLimit", EmitDefaultValue=false)]
        public long? MemoryLimit { get; set; }
        /// <summary>
        /// Gets or Sets CpuLimit
        /// </summary>
        [DataMember(Name="cpuLimit", EmitDefaultValue=false)]
        public long? CpuLimit { get; set; }
        /// <summary>
        /// Gets or Sets CpuCores
        /// </summary>
        [DataMember(Name="cpuCores", EmitDefaultValue=false)]
        public int? CpuCores { get; set; }
        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public string Cost { get; set; }
        /// <summary>
        /// Gets or Sets AppliesToServices
        /// </summary>
        [DataMember(Name="appliesToServices", EmitDefaultValue=false)]
        public bool? AppliesToServices { get; set; }
        /// <summary>
        /// Gets or Sets AppliesToDatabases
        /// </summary>
        [DataMember(Name="appliesToDatabases", EmitDefaultValue=false)]
        public bool? AppliesToDatabases { get; set; }
        /// <summary>
        /// Gets or Sets AppliesToUserInterfaces
        /// </summary>
        [DataMember(Name="appliesToUserInterfaces", EmitDefaultValue=false)]
        public bool? AppliesToUserInterfaces { get; set; }
        /// <summary>
        /// Gets or Sets AppliesToWars
        /// </summary>
        [DataMember(Name="appliesToWars", EmitDefaultValue=false)]
        public bool? AppliesToWars { get; set; }
        /// <summary>
        /// Gets or Sets AppliesToLinuxServices
        /// </summary>
        [DataMember(Name="appliesToLinuxServices", EmitDefaultValue=false)]
        public bool? AppliesToLinuxServices { get; set; }
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
            sb.Append("class ResourceAllocationPolicy {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MemoryLimit: ").Append(MemoryLimit).Append("\n");
            sb.Append("  CpuLimit: ").Append(CpuLimit).Append("\n");
            sb.Append("  CpuCores: ").Append(CpuCores).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  AppliesToServices: ").Append(AppliesToServices).Append("\n");
            sb.Append("  AppliesToDatabases: ").Append(AppliesToDatabases).Append("\n");
            sb.Append("  AppliesToUserInterfaces: ").Append(AppliesToUserInterfaces).Append("\n");
            sb.Append("  AppliesToWars: ").Append(AppliesToWars).Append("\n");
            sb.Append("  AppliesToLinuxServices: ").Append(AppliesToLinuxServices).Append("\n");
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
            return this.Equals(obj as ResourceAllocationPolicy);
        }

        /// <summary>
        /// Returns true if ResourceAllocationPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of ResourceAllocationPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceAllocationPolicy other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.MemoryLimit == other.MemoryLimit ||
                    this.MemoryLimit != null &&
                    this.MemoryLimit.Equals(other.MemoryLimit)
                ) && 
                (
                    this.CpuLimit == other.CpuLimit ||
                    this.CpuLimit != null &&
                    this.CpuLimit.Equals(other.CpuLimit)
                ) && 
                (
                    this.CpuCores == other.CpuCores ||
                    this.CpuCores != null &&
                    this.CpuCores.Equals(other.CpuCores)
                ) && 
                (
                    this.Cost == other.Cost ||
                    this.Cost != null &&
                    this.Cost.Equals(other.Cost)
                ) && 
                (
                    this.AppliesToServices == other.AppliesToServices ||
                    this.AppliesToServices != null &&
                    this.AppliesToServices.Equals(other.AppliesToServices)
                ) && 
                (
                    this.AppliesToDatabases == other.AppliesToDatabases ||
                    this.AppliesToDatabases != null &&
                    this.AppliesToDatabases.Equals(other.AppliesToDatabases)
                ) && 
                (
                    this.AppliesToUserInterfaces == other.AppliesToUserInterfaces ||
                    this.AppliesToUserInterfaces != null &&
                    this.AppliesToUserInterfaces.Equals(other.AppliesToUserInterfaces)
                ) && 
                (
                    this.AppliesToWars == other.AppliesToWars ||
                    this.AppliesToWars != null &&
                    this.AppliesToWars.Equals(other.AppliesToWars)
                ) && 
                (
                    this.AppliesToLinuxServices == other.AppliesToLinuxServices ||
                    this.AppliesToLinuxServices != null &&
                    this.AppliesToLinuxServices.Equals(other.AppliesToLinuxServices)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.MemoryLimit != null)
                    hash = hash * 59 + this.MemoryLimit.GetHashCode();
                if (this.CpuLimit != null)
                    hash = hash * 59 + this.CpuLimit.GetHashCode();
                if (this.CpuCores != null)
                    hash = hash * 59 + this.CpuCores.GetHashCode();
                if (this.Cost != null)
                    hash = hash * 59 + this.Cost.GetHashCode();
                if (this.AppliesToServices != null)
                    hash = hash * 59 + this.AppliesToServices.GetHashCode();
                if (this.AppliesToDatabases != null)
                    hash = hash * 59 + this.AppliesToDatabases.GetHashCode();
                if (this.AppliesToUserInterfaces != null)
                    hash = hash * 59 + this.AppliesToUserInterfaces.GetHashCode();
                if (this.AppliesToWars != null)
                    hash = hash * 59 + this.AppliesToWars.GetHashCode();
                if (this.AppliesToLinuxServices != null)
                    hash = hash * 59 + this.AppliesToLinuxServices.GetHashCode();
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
