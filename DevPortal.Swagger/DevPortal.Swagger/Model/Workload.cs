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
    /// Workload
    /// </summary>
    [DataContract]
    public partial class Workload :  IEquatable<Workload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Workload" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Server">Server.</param>
        /// <param name="Component">Component.</param>
        /// <param name="ResourcePolicy">ResourcePolicy.</param>
        /// <param name="StorageQuota">StorageQuota.</param>
        /// <param name="StorageBlocks">StorageBlocks.</param>
        /// <param name="TenantCount">TenantCount.</param>
        /// <param name="Utilization">Utilization.</param>
        /// <param name="AllocatedPorts">AllocatedPorts.</param>
        /// <param name="DebugConnection">DebugConnection.</param>
        /// <param name="InstanceId">InstanceId.</param>
        /// <param name="JmxConnection">JmxConnection.</param>
        /// <param name="Href">Href.</param>
        public Workload(string Name = default(string), string Server = default(string), Apiv1monitoringsubscriptionsappAliasversionAliasComponent Component = default(Apiv1monitoringsubscriptionsappAliasversionAliasComponent), InlineResponse2002Cloud ResourcePolicy = default(InlineResponse2002Cloud), InlineResponse2002Cloud StorageQuota = default(InlineResponse2002Cloud), long? StorageBlocks = default(long?), int? TenantCount = default(int?), InlineResponse200Icon Utilization = default(InlineResponse200Icon), List<int?> AllocatedPorts = default(List<int?>), Apiv1WorkloadsDebugConnection DebugConnection = default(Apiv1WorkloadsDebugConnection), Guid? InstanceId = default(Guid?), Apiv1WorkloadsJmxConnection JmxConnection = default(Apiv1WorkloadsJmxConnection), string Href = default(string))
        {
            this.Name = Name;
            this.Server = Server;
            this.Component = Component;
            this.ResourcePolicy = ResourcePolicy;
            this.StorageQuota = StorageQuota;
            this.StorageBlocks = StorageBlocks;
            this.TenantCount = TenantCount;
            this.Utilization = Utilization;
            this.AllocatedPorts = AllocatedPorts;
            this.DebugConnection = DebugConnection;
            this.InstanceId = InstanceId;
            this.JmxConnection = JmxConnection;
            this.Href = Href;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Server
        /// </summary>
        [DataMember(Name="server", EmitDefaultValue=false)]
        public string Server { get; set; }
        /// <summary>
        /// Gets or Sets Component
        /// </summary>
        [DataMember(Name="component", EmitDefaultValue=false)]
        public Apiv1monitoringsubscriptionsappAliasversionAliasComponent Component { get; set; }
        /// <summary>
        /// Gets or Sets ResourcePolicy
        /// </summary>
        [DataMember(Name="resourcePolicy", EmitDefaultValue=false)]
        public InlineResponse2002Cloud ResourcePolicy { get; set; }
        /// <summary>
        /// Gets or Sets StorageQuota
        /// </summary>
        [DataMember(Name="storageQuota", EmitDefaultValue=false)]
        public InlineResponse2002Cloud StorageQuota { get; set; }
        /// <summary>
        /// Gets or Sets StorageBlocks
        /// </summary>
        [DataMember(Name="storageBlocks", EmitDefaultValue=false)]
        public long? StorageBlocks { get; set; }
        /// <summary>
        /// Gets or Sets TenantCount
        /// </summary>
        [DataMember(Name="tenantCount", EmitDefaultValue=false)]
        public int? TenantCount { get; set; }
        /// <summary>
        /// Gets or Sets Utilization
        /// </summary>
        [DataMember(Name="utilization", EmitDefaultValue=false)]
        public InlineResponse200Icon Utilization { get; set; }
        /// <summary>
        /// Gets or Sets AllocatedPorts
        /// </summary>
        [DataMember(Name="allocatedPorts", EmitDefaultValue=false)]
        public List<int?> AllocatedPorts { get; set; }
        /// <summary>
        /// Gets or Sets DebugConnection
        /// </summary>
        [DataMember(Name="debugConnection", EmitDefaultValue=false)]
        public Apiv1WorkloadsDebugConnection DebugConnection { get; set; }
        /// <summary>
        /// Gets or Sets InstanceId
        /// </summary>
        [DataMember(Name="instanceId", EmitDefaultValue=false)]
        public Guid? InstanceId { get; set; }
        /// <summary>
        /// Gets or Sets JmxConnection
        /// </summary>
        [DataMember(Name="jmxConnection", EmitDefaultValue=false)]
        public Apiv1WorkloadsJmxConnection JmxConnection { get; set; }
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
            sb.Append("class Workload {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Server: ").Append(Server).Append("\n");
            sb.Append("  Component: ").Append(Component).Append("\n");
            sb.Append("  ResourcePolicy: ").Append(ResourcePolicy).Append("\n");
            sb.Append("  StorageQuota: ").Append(StorageQuota).Append("\n");
            sb.Append("  StorageBlocks: ").Append(StorageBlocks).Append("\n");
            sb.Append("  TenantCount: ").Append(TenantCount).Append("\n");
            sb.Append("  Utilization: ").Append(Utilization).Append("\n");
            sb.Append("  AllocatedPorts: ").Append(AllocatedPorts).Append("\n");
            sb.Append("  DebugConnection: ").Append(DebugConnection).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  JmxConnection: ").Append(JmxConnection).Append("\n");
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
            return this.Equals(obj as Workload);
        }

        /// <summary>
        /// Returns true if Workload instances are equal
        /// </summary>
        /// <param name="other">Instance of Workload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Workload other)
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
                    this.Server == other.Server ||
                    this.Server != null &&
                    this.Server.Equals(other.Server)
                ) && 
                (
                    this.Component == other.Component ||
                    this.Component != null &&
                    this.Component.Equals(other.Component)
                ) && 
                (
                    this.ResourcePolicy == other.ResourcePolicy ||
                    this.ResourcePolicy != null &&
                    this.ResourcePolicy.Equals(other.ResourcePolicy)
                ) && 
                (
                    this.StorageQuota == other.StorageQuota ||
                    this.StorageQuota != null &&
                    this.StorageQuota.Equals(other.StorageQuota)
                ) && 
                (
                    this.StorageBlocks == other.StorageBlocks ||
                    this.StorageBlocks != null &&
                    this.StorageBlocks.Equals(other.StorageBlocks)
                ) && 
                (
                    this.TenantCount == other.TenantCount ||
                    this.TenantCount != null &&
                    this.TenantCount.Equals(other.TenantCount)
                ) && 
                (
                    this.Utilization == other.Utilization ||
                    this.Utilization != null &&
                    this.Utilization.Equals(other.Utilization)
                ) && 
                (
                    this.AllocatedPorts == other.AllocatedPorts ||
                    this.AllocatedPorts != null &&
                    this.AllocatedPorts.SequenceEqual(other.AllocatedPorts)
                ) && 
                (
                    this.DebugConnection == other.DebugConnection ||
                    this.DebugConnection != null &&
                    this.DebugConnection.Equals(other.DebugConnection)
                ) && 
                (
                    this.InstanceId == other.InstanceId ||
                    this.InstanceId != null &&
                    this.InstanceId.Equals(other.InstanceId)
                ) && 
                (
                    this.JmxConnection == other.JmxConnection ||
                    this.JmxConnection != null &&
                    this.JmxConnection.Equals(other.JmxConnection)
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
                if (this.Server != null)
                    hash = hash * 59 + this.Server.GetHashCode();
                if (this.Component != null)
                    hash = hash * 59 + this.Component.GetHashCode();
                if (this.ResourcePolicy != null)
                    hash = hash * 59 + this.ResourcePolicy.GetHashCode();
                if (this.StorageQuota != null)
                    hash = hash * 59 + this.StorageQuota.GetHashCode();
                if (this.StorageBlocks != null)
                    hash = hash * 59 + this.StorageBlocks.GetHashCode();
                if (this.TenantCount != null)
                    hash = hash * 59 + this.TenantCount.GetHashCode();
                if (this.Utilization != null)
                    hash = hash * 59 + this.Utilization.GetHashCode();
                if (this.AllocatedPorts != null)
                    hash = hash * 59 + this.AllocatedPorts.GetHashCode();
                if (this.DebugConnection != null)
                    hash = hash * 59 + this.DebugConnection.GetHashCode();
                if (this.InstanceId != null)
                    hash = hash * 59 + this.InstanceId.GetHashCode();
                if (this.JmxConnection != null)
                    hash = hash * 59 + this.JmxConnection.GetHashCode();
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
