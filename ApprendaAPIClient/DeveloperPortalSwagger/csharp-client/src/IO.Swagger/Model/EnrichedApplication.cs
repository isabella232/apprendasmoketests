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
    /// EnrichedApplication
    /// </summary>
    [DataContract]
    public partial class EnrichedApplication :  IEquatable<EnrichedApplication>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DatabaseProvider
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DatabaseProviderEnum
        {
            
            /// <summary>
            /// Enum SqlServer for "SqlServer"
            /// </summary>
            [EnumMember(Value = "SqlServer")]
            SqlServer,
            
            /// <summary>
            /// Enum Oracle11G for "Oracle11G"
            /// </summary>
            [EnumMember(Value = "Oracle11G")]
            Oracle11G,
            
            /// <summary>
            /// Enum Oracle12C for "Oracle12C"
            /// </summary>
            [EnumMember(Value = "Oracle12C")]
            Oracle12C
        }

        /// <summary>
        /// Gets or Sets DatabaseModelType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DatabaseModelTypeEnum
        {
            
            /// <summary>
            /// Enum Commingled for "Commingled"
            /// </summary>
            [EnumMember(Value = "Commingled")]
            Commingled,
            
            /// <summary>
            /// Enum Isolated for "Isolated"
            /// </summary>
            [EnumMember(Value = "Isolated")]
            Isolated
        }

        /// <summary>
        /// Gets or Sets UserInterfaceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UserInterfaceTypeEnum
        {
            
            /// <summary>
            /// Enum CommingledRootApp for "CommingledRootApp"
            /// </summary>
            [EnumMember(Value = "CommingledRootApp")]
            CommingledRootApp,
            
            /// <summary>
            /// Enum CommingledAppRoot for "CommingledAppRoot"
            /// </summary>
            [EnumMember(Value = "CommingledAppRoot")]
            CommingledAppRoot
        }

        /// <summary>
        /// Gets or Sets PaymentOptions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentOptionsEnum
        {
            
            /// <summary>
            /// Enum Automatic for "Automatic"
            /// </summary>
            [EnumMember(Value = "Automatic")]
            Automatic,
            
            /// <summary>
            /// Enum Manual for "Manual"
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual,
            
            /// <summary>
            /// Enum Both for "Both"
            /// </summary>
            [EnumMember(Value = "Both")]
            Both
        }

        /// <summary>
        /// Gets or Sets ApplicationServices
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplicationServicesEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Authentication for "Authentication"
            /// </summary>
            [EnumMember(Value = "Authentication")]
            Authentication,
            
            /// <summary>
            /// Enum Authorization for "Authorization"
            /// </summary>
            [EnumMember(Value = "Authorization")]
            Authorization,
            
            /// <summary>
            /// Enum Multitenancy for "Multitenancy"
            /// </summary>
            [EnumMember(Value = "Multitenancy")]
            Multitenancy,
            
            /// <summary>
            /// Enum Billing for "Billing"
            /// </summary>
            [EnumMember(Value = "Billing")]
            Billing
        }

        /// <summary>
        /// Gets or Sets DatabaseProvider
        /// </summary>
        [DataMember(Name="databaseProvider", EmitDefaultValue=false)]
        public DatabaseProviderEnum? DatabaseProvider { get; set; }
        /// <summary>
        /// Gets or Sets DatabaseModelType
        /// </summary>
        [DataMember(Name="databaseModelType", EmitDefaultValue=false)]
        public DatabaseModelTypeEnum? DatabaseModelType { get; set; }
        /// <summary>
        /// Gets or Sets UserInterfaceType
        /// </summary>
        [DataMember(Name="userInterfaceType", EmitDefaultValue=false)]
        public UserInterfaceTypeEnum? UserInterfaceType { get; set; }
        /// <summary>
        /// Gets or Sets PaymentOptions
        /// </summary>
        [DataMember(Name="paymentOptions", EmitDefaultValue=false)]
        public PaymentOptionsEnum? PaymentOptions { get; set; }
        /// <summary>
        /// Gets or Sets ApplicationServices
        /// </summary>
        [DataMember(Name="applicationServices", EmitDefaultValue=false)]
        public ApplicationServicesEnum? ApplicationServices { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnrichedApplication" /> class.
        /// </summary>
        /// <param name="Versions">Versions.</param>
        /// <param name="DatabaseProvider">DatabaseProvider.</param>
        /// <param name="DatabaseModelType">DatabaseModelType.</param>
        /// <param name="UserInterfaceType">UserInterfaceType.</param>
        /// <param name="PaymentOptions">PaymentOptions.</param>
        /// <param name="ApplicationServices">ApplicationServices.</param>
        /// <param name="CustomAuthenticationStyleUrl">CustomAuthenticationStyleUrl.</param>
        /// <param name="CustomInvoiceStyleUrl">CustomInvoiceStyleUrl.</param>
        /// <param name="CustomUrl">CustomUrl.</param>
        /// <param name="CustomUrlCertificate">CustomUrlCertificate.</param>
        /// <param name="Cloud">Cloud.</param>
        /// <param name="HasDatabaseModel">HasDatabaseModel.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Alias">Alias.</param>
        /// <param name="Description">Description.</param>
        /// <param name="CurrentVersion">CurrentVersion.</param>
        /// <param name="TransitioningVersion">TransitioningVersion.</param>
        /// <param name="UiAllocatedCpuMhz">UiAllocatedCpuMhz.</param>
        /// <param name="DbAllocatedCpuMhz">DbAllocatedCpuMhz.</param>
        /// <param name="SvcAllocatedCpuMhz">SvcAllocatedCpuMhz.</param>
        /// <param name="WarAllocatedCpuMhz">WarAllocatedCpuMhz.</param>
        /// <param name="LinuxServiceAllocatedCpuMhz">LinuxServiceAllocatedCpuMhz.</param>
        /// <param name="UiAllocatedMemoryMb">UiAllocatedMemoryMb.</param>
        /// <param name="DbAllocatedMemoryMb">DbAllocatedMemoryMb.</param>
        /// <param name="SvcAllocatedMemoryMb">SvcAllocatedMemoryMb.</param>
        /// <param name="WarAllocatedMemoryMb">WarAllocatedMemoryMb.</param>
        /// <param name="LinuxServiceAllocatedMemoryMb">LinuxServiceAllocatedMemoryMb.</param>
        /// <param name="AllocatedStorageMb">AllocatedStorageMb.</param>
        /// <param name="Href">Href.</param>
        public EnrichedApplication(ResourceBase Versions = default(ResourceBase), DatabaseProviderEnum? DatabaseProvider = default(DatabaseProviderEnum?), DatabaseModelTypeEnum? DatabaseModelType = default(DatabaseModelTypeEnum?), UserInterfaceTypeEnum? UserInterfaceType = default(UserInterfaceTypeEnum?), PaymentOptionsEnum? PaymentOptions = default(PaymentOptionsEnum?), ApplicationServicesEnum? ApplicationServices = default(ApplicationServicesEnum?), string CustomAuthenticationStyleUrl = default(string), string CustomInvoiceStyleUrl = default(string), string CustomUrl = default(string), MinimalCustomUrlCertificate CustomUrlCertificate = default(MinimalCustomUrlCertificate), CloudReference Cloud = default(CloudReference), bool? HasDatabaseModel = default(bool?), string Name = default(string), string Alias = default(string), string Description = default(string), Version CurrentVersion = default(Version), Version TransitioningVersion = default(Version), long? UiAllocatedCpuMhz = default(long?), long? DbAllocatedCpuMhz = default(long?), long? SvcAllocatedCpuMhz = default(long?), long? WarAllocatedCpuMhz = default(long?), long? LinuxServiceAllocatedCpuMhz = default(long?), long? UiAllocatedMemoryMb = default(long?), long? DbAllocatedMemoryMb = default(long?), long? SvcAllocatedMemoryMb = default(long?), long? WarAllocatedMemoryMb = default(long?), long? LinuxServiceAllocatedMemoryMb = default(long?), long? AllocatedStorageMb = default(long?), string Href = default(string))
        {
            this.Versions = Versions;
            this.DatabaseProvider = DatabaseProvider;
            this.DatabaseModelType = DatabaseModelType;
            this.UserInterfaceType = UserInterfaceType;
            this.PaymentOptions = PaymentOptions;
            this.ApplicationServices = ApplicationServices;
            this.CustomAuthenticationStyleUrl = CustomAuthenticationStyleUrl;
            this.CustomInvoiceStyleUrl = CustomInvoiceStyleUrl;
            this.CustomUrl = CustomUrl;
            this.CustomUrlCertificate = CustomUrlCertificate;
            this.Cloud = Cloud;
            this.HasDatabaseModel = HasDatabaseModel;
            this.Name = Name;
            this.Alias = Alias;
            this.Description = Description;
            this.CurrentVersion = CurrentVersion;
            this.TransitioningVersion = TransitioningVersion;
            this.UiAllocatedCpuMhz = UiAllocatedCpuMhz;
            this.DbAllocatedCpuMhz = DbAllocatedCpuMhz;
            this.SvcAllocatedCpuMhz = SvcAllocatedCpuMhz;
            this.WarAllocatedCpuMhz = WarAllocatedCpuMhz;
            this.LinuxServiceAllocatedCpuMhz = LinuxServiceAllocatedCpuMhz;
            this.UiAllocatedMemoryMb = UiAllocatedMemoryMb;
            this.DbAllocatedMemoryMb = DbAllocatedMemoryMb;
            this.SvcAllocatedMemoryMb = SvcAllocatedMemoryMb;
            this.WarAllocatedMemoryMb = WarAllocatedMemoryMb;
            this.LinuxServiceAllocatedMemoryMb = LinuxServiceAllocatedMemoryMb;
            this.AllocatedStorageMb = AllocatedStorageMb;
            this.Href = Href;
        }
        
        /// <summary>
        /// Gets or Sets Versions
        /// </summary>
        [DataMember(Name="versions", EmitDefaultValue=false)]
        public ResourceBase Versions { get; set; }
        /// <summary>
        /// Gets or Sets CustomAuthenticationStyleUrl
        /// </summary>
        [DataMember(Name="customAuthenticationStyleUrl", EmitDefaultValue=false)]
        public string CustomAuthenticationStyleUrl { get; set; }
        /// <summary>
        /// Gets or Sets CustomInvoiceStyleUrl
        /// </summary>
        [DataMember(Name="customInvoiceStyleUrl", EmitDefaultValue=false)]
        public string CustomInvoiceStyleUrl { get; set; }
        /// <summary>
        /// Gets or Sets CustomUrl
        /// </summary>
        [DataMember(Name="customUrl", EmitDefaultValue=false)]
        public string CustomUrl { get; set; }
        /// <summary>
        /// Gets or Sets CustomUrlCertificate
        /// </summary>
        [DataMember(Name="customUrlCertificate", EmitDefaultValue=false)]
        public MinimalCustomUrlCertificate CustomUrlCertificate { get; set; }
        /// <summary>
        /// Gets or Sets Cloud
        /// </summary>
        [DataMember(Name="cloud", EmitDefaultValue=false)]
        public CloudReference Cloud { get; set; }
        /// <summary>
        /// Gets or Sets HasDatabaseModel
        /// </summary>
        [DataMember(Name="hasDatabaseModel", EmitDefaultValue=false)]
        public bool? HasDatabaseModel { get; set; }
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
        /// Gets or Sets CurrentVersion
        /// </summary>
        [DataMember(Name="currentVersion", EmitDefaultValue=false)]
        public Version CurrentVersion { get; set; }
        /// <summary>
        /// Gets or Sets TransitioningVersion
        /// </summary>
        [DataMember(Name="transitioningVersion", EmitDefaultValue=false)]
        public Version TransitioningVersion { get; set; }
        /// <summary>
        /// Gets or Sets UiAllocatedCpuMhz
        /// </summary>
        [DataMember(Name="uiAllocatedCpuMhz", EmitDefaultValue=false)]
        public long? UiAllocatedCpuMhz { get; set; }
        /// <summary>
        /// Gets or Sets DbAllocatedCpuMhz
        /// </summary>
        [DataMember(Name="dbAllocatedCpuMhz", EmitDefaultValue=false)]
        public long? DbAllocatedCpuMhz { get; set; }
        /// <summary>
        /// Gets or Sets SvcAllocatedCpuMhz
        /// </summary>
        [DataMember(Name="svcAllocatedCpuMhz", EmitDefaultValue=false)]
        public long? SvcAllocatedCpuMhz { get; set; }
        /// <summary>
        /// Gets or Sets WarAllocatedCpuMhz
        /// </summary>
        [DataMember(Name="warAllocatedCpuMhz", EmitDefaultValue=false)]
        public long? WarAllocatedCpuMhz { get; set; }
        /// <summary>
        /// Gets or Sets LinuxServiceAllocatedCpuMhz
        /// </summary>
        [DataMember(Name="linuxServiceAllocatedCpuMhz", EmitDefaultValue=false)]
        public long? LinuxServiceAllocatedCpuMhz { get; set; }
        /// <summary>
        /// Gets or Sets UiAllocatedMemoryMb
        /// </summary>
        [DataMember(Name="uiAllocatedMemoryMb", EmitDefaultValue=false)]
        public long? UiAllocatedMemoryMb { get; set; }
        /// <summary>
        /// Gets or Sets DbAllocatedMemoryMb
        /// </summary>
        [DataMember(Name="dbAllocatedMemoryMb", EmitDefaultValue=false)]
        public long? DbAllocatedMemoryMb { get; set; }
        /// <summary>
        /// Gets or Sets SvcAllocatedMemoryMb
        /// </summary>
        [DataMember(Name="svcAllocatedMemoryMb", EmitDefaultValue=false)]
        public long? SvcAllocatedMemoryMb { get; set; }
        /// <summary>
        /// Gets or Sets WarAllocatedMemoryMb
        /// </summary>
        [DataMember(Name="warAllocatedMemoryMb", EmitDefaultValue=false)]
        public long? WarAllocatedMemoryMb { get; set; }
        /// <summary>
        /// Gets or Sets LinuxServiceAllocatedMemoryMb
        /// </summary>
        [DataMember(Name="linuxServiceAllocatedMemoryMb", EmitDefaultValue=false)]
        public long? LinuxServiceAllocatedMemoryMb { get; set; }
        /// <summary>
        /// Gets or Sets AllocatedStorageMb
        /// </summary>
        [DataMember(Name="allocatedStorageMb", EmitDefaultValue=false)]
        public long? AllocatedStorageMb { get; set; }
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
            sb.Append("class EnrichedApplication {\n");
            sb.Append("  Versions: ").Append(Versions).Append("\n");
            sb.Append("  DatabaseProvider: ").Append(DatabaseProvider).Append("\n");
            sb.Append("  DatabaseModelType: ").Append(DatabaseModelType).Append("\n");
            sb.Append("  UserInterfaceType: ").Append(UserInterfaceType).Append("\n");
            sb.Append("  PaymentOptions: ").Append(PaymentOptions).Append("\n");
            sb.Append("  ApplicationServices: ").Append(ApplicationServices).Append("\n");
            sb.Append("  CustomAuthenticationStyleUrl: ").Append(CustomAuthenticationStyleUrl).Append("\n");
            sb.Append("  CustomInvoiceStyleUrl: ").Append(CustomInvoiceStyleUrl).Append("\n");
            sb.Append("  CustomUrl: ").Append(CustomUrl).Append("\n");
            sb.Append("  CustomUrlCertificate: ").Append(CustomUrlCertificate).Append("\n");
            sb.Append("  Cloud: ").Append(Cloud).Append("\n");
            sb.Append("  HasDatabaseModel: ").Append(HasDatabaseModel).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CurrentVersion: ").Append(CurrentVersion).Append("\n");
            sb.Append("  TransitioningVersion: ").Append(TransitioningVersion).Append("\n");
            sb.Append("  UiAllocatedCpuMhz: ").Append(UiAllocatedCpuMhz).Append("\n");
            sb.Append("  DbAllocatedCpuMhz: ").Append(DbAllocatedCpuMhz).Append("\n");
            sb.Append("  SvcAllocatedCpuMhz: ").Append(SvcAllocatedCpuMhz).Append("\n");
            sb.Append("  WarAllocatedCpuMhz: ").Append(WarAllocatedCpuMhz).Append("\n");
            sb.Append("  LinuxServiceAllocatedCpuMhz: ").Append(LinuxServiceAllocatedCpuMhz).Append("\n");
            sb.Append("  UiAllocatedMemoryMb: ").Append(UiAllocatedMemoryMb).Append("\n");
            sb.Append("  DbAllocatedMemoryMb: ").Append(DbAllocatedMemoryMb).Append("\n");
            sb.Append("  SvcAllocatedMemoryMb: ").Append(SvcAllocatedMemoryMb).Append("\n");
            sb.Append("  WarAllocatedMemoryMb: ").Append(WarAllocatedMemoryMb).Append("\n");
            sb.Append("  LinuxServiceAllocatedMemoryMb: ").Append(LinuxServiceAllocatedMemoryMb).Append("\n");
            sb.Append("  AllocatedStorageMb: ").Append(AllocatedStorageMb).Append("\n");
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
            return this.Equals(obj as EnrichedApplication);
        }

        /// <summary>
        /// Returns true if EnrichedApplication instances are equal
        /// </summary>
        /// <param name="other">Instance of EnrichedApplication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnrichedApplication other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Versions == other.Versions ||
                    this.Versions != null &&
                    this.Versions.Equals(other.Versions)
                ) && 
                (
                    this.DatabaseProvider == other.DatabaseProvider ||
                    this.DatabaseProvider != null &&
                    this.DatabaseProvider.Equals(other.DatabaseProvider)
                ) && 
                (
                    this.DatabaseModelType == other.DatabaseModelType ||
                    this.DatabaseModelType != null &&
                    this.DatabaseModelType.Equals(other.DatabaseModelType)
                ) && 
                (
                    this.UserInterfaceType == other.UserInterfaceType ||
                    this.UserInterfaceType != null &&
                    this.UserInterfaceType.Equals(other.UserInterfaceType)
                ) && 
                (
                    this.PaymentOptions == other.PaymentOptions ||
                    this.PaymentOptions != null &&
                    this.PaymentOptions.Equals(other.PaymentOptions)
                ) && 
                (
                    this.ApplicationServices == other.ApplicationServices ||
                    this.ApplicationServices != null &&
                    this.ApplicationServices.Equals(other.ApplicationServices)
                ) && 
                (
                    this.CustomAuthenticationStyleUrl == other.CustomAuthenticationStyleUrl ||
                    this.CustomAuthenticationStyleUrl != null &&
                    this.CustomAuthenticationStyleUrl.Equals(other.CustomAuthenticationStyleUrl)
                ) && 
                (
                    this.CustomInvoiceStyleUrl == other.CustomInvoiceStyleUrl ||
                    this.CustomInvoiceStyleUrl != null &&
                    this.CustomInvoiceStyleUrl.Equals(other.CustomInvoiceStyleUrl)
                ) && 
                (
                    this.CustomUrl == other.CustomUrl ||
                    this.CustomUrl != null &&
                    this.CustomUrl.Equals(other.CustomUrl)
                ) && 
                (
                    this.CustomUrlCertificate == other.CustomUrlCertificate ||
                    this.CustomUrlCertificate != null &&
                    this.CustomUrlCertificate.Equals(other.CustomUrlCertificate)
                ) && 
                (
                    this.Cloud == other.Cloud ||
                    this.Cloud != null &&
                    this.Cloud.Equals(other.Cloud)
                ) && 
                (
                    this.HasDatabaseModel == other.HasDatabaseModel ||
                    this.HasDatabaseModel != null &&
                    this.HasDatabaseModel.Equals(other.HasDatabaseModel)
                ) && 
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
                    this.CurrentVersion == other.CurrentVersion ||
                    this.CurrentVersion != null &&
                    this.CurrentVersion.Equals(other.CurrentVersion)
                ) && 
                (
                    this.TransitioningVersion == other.TransitioningVersion ||
                    this.TransitioningVersion != null &&
                    this.TransitioningVersion.Equals(other.TransitioningVersion)
                ) && 
                (
                    this.UiAllocatedCpuMhz == other.UiAllocatedCpuMhz ||
                    this.UiAllocatedCpuMhz != null &&
                    this.UiAllocatedCpuMhz.Equals(other.UiAllocatedCpuMhz)
                ) && 
                (
                    this.DbAllocatedCpuMhz == other.DbAllocatedCpuMhz ||
                    this.DbAllocatedCpuMhz != null &&
                    this.DbAllocatedCpuMhz.Equals(other.DbAllocatedCpuMhz)
                ) && 
                (
                    this.SvcAllocatedCpuMhz == other.SvcAllocatedCpuMhz ||
                    this.SvcAllocatedCpuMhz != null &&
                    this.SvcAllocatedCpuMhz.Equals(other.SvcAllocatedCpuMhz)
                ) && 
                (
                    this.WarAllocatedCpuMhz == other.WarAllocatedCpuMhz ||
                    this.WarAllocatedCpuMhz != null &&
                    this.WarAllocatedCpuMhz.Equals(other.WarAllocatedCpuMhz)
                ) && 
                (
                    this.LinuxServiceAllocatedCpuMhz == other.LinuxServiceAllocatedCpuMhz ||
                    this.LinuxServiceAllocatedCpuMhz != null &&
                    this.LinuxServiceAllocatedCpuMhz.Equals(other.LinuxServiceAllocatedCpuMhz)
                ) && 
                (
                    this.UiAllocatedMemoryMb == other.UiAllocatedMemoryMb ||
                    this.UiAllocatedMemoryMb != null &&
                    this.UiAllocatedMemoryMb.Equals(other.UiAllocatedMemoryMb)
                ) && 
                (
                    this.DbAllocatedMemoryMb == other.DbAllocatedMemoryMb ||
                    this.DbAllocatedMemoryMb != null &&
                    this.DbAllocatedMemoryMb.Equals(other.DbAllocatedMemoryMb)
                ) && 
                (
                    this.SvcAllocatedMemoryMb == other.SvcAllocatedMemoryMb ||
                    this.SvcAllocatedMemoryMb != null &&
                    this.SvcAllocatedMemoryMb.Equals(other.SvcAllocatedMemoryMb)
                ) && 
                (
                    this.WarAllocatedMemoryMb == other.WarAllocatedMemoryMb ||
                    this.WarAllocatedMemoryMb != null &&
                    this.WarAllocatedMemoryMb.Equals(other.WarAllocatedMemoryMb)
                ) && 
                (
                    this.LinuxServiceAllocatedMemoryMb == other.LinuxServiceAllocatedMemoryMb ||
                    this.LinuxServiceAllocatedMemoryMb != null &&
                    this.LinuxServiceAllocatedMemoryMb.Equals(other.LinuxServiceAllocatedMemoryMb)
                ) && 
                (
                    this.AllocatedStorageMb == other.AllocatedStorageMb ||
                    this.AllocatedStorageMb != null &&
                    this.AllocatedStorageMb.Equals(other.AllocatedStorageMb)
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
                if (this.Versions != null)
                    hash = hash * 59 + this.Versions.GetHashCode();
                if (this.DatabaseProvider != null)
                    hash = hash * 59 + this.DatabaseProvider.GetHashCode();
                if (this.DatabaseModelType != null)
                    hash = hash * 59 + this.DatabaseModelType.GetHashCode();
                if (this.UserInterfaceType != null)
                    hash = hash * 59 + this.UserInterfaceType.GetHashCode();
                if (this.PaymentOptions != null)
                    hash = hash * 59 + this.PaymentOptions.GetHashCode();
                if (this.ApplicationServices != null)
                    hash = hash * 59 + this.ApplicationServices.GetHashCode();
                if (this.CustomAuthenticationStyleUrl != null)
                    hash = hash * 59 + this.CustomAuthenticationStyleUrl.GetHashCode();
                if (this.CustomInvoiceStyleUrl != null)
                    hash = hash * 59 + this.CustomInvoiceStyleUrl.GetHashCode();
                if (this.CustomUrl != null)
                    hash = hash * 59 + this.CustomUrl.GetHashCode();
                if (this.CustomUrlCertificate != null)
                    hash = hash * 59 + this.CustomUrlCertificate.GetHashCode();
                if (this.Cloud != null)
                    hash = hash * 59 + this.Cloud.GetHashCode();
                if (this.HasDatabaseModel != null)
                    hash = hash * 59 + this.HasDatabaseModel.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Alias != null)
                    hash = hash * 59 + this.Alias.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.CurrentVersion != null)
                    hash = hash * 59 + this.CurrentVersion.GetHashCode();
                if (this.TransitioningVersion != null)
                    hash = hash * 59 + this.TransitioningVersion.GetHashCode();
                if (this.UiAllocatedCpuMhz != null)
                    hash = hash * 59 + this.UiAllocatedCpuMhz.GetHashCode();
                if (this.DbAllocatedCpuMhz != null)
                    hash = hash * 59 + this.DbAllocatedCpuMhz.GetHashCode();
                if (this.SvcAllocatedCpuMhz != null)
                    hash = hash * 59 + this.SvcAllocatedCpuMhz.GetHashCode();
                if (this.WarAllocatedCpuMhz != null)
                    hash = hash * 59 + this.WarAllocatedCpuMhz.GetHashCode();
                if (this.LinuxServiceAllocatedCpuMhz != null)
                    hash = hash * 59 + this.LinuxServiceAllocatedCpuMhz.GetHashCode();
                if (this.UiAllocatedMemoryMb != null)
                    hash = hash * 59 + this.UiAllocatedMemoryMb.GetHashCode();
                if (this.DbAllocatedMemoryMb != null)
                    hash = hash * 59 + this.DbAllocatedMemoryMb.GetHashCode();
                if (this.SvcAllocatedMemoryMb != null)
                    hash = hash * 59 + this.SvcAllocatedMemoryMb.GetHashCode();
                if (this.WarAllocatedMemoryMb != null)
                    hash = hash * 59 + this.WarAllocatedMemoryMb.GetHashCode();
                if (this.LinuxServiceAllocatedMemoryMb != null)
                    hash = hash * 59 + this.LinuxServiceAllocatedMemoryMb.GetHashCode();
                if (this.AllocatedStorageMb != null)
                    hash = hash * 59 + this.AllocatedStorageMb.GetHashCode();
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
