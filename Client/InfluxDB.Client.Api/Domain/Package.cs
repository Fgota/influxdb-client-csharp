/* 
 * Influx API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// represents a complete package source tree
    /// </summary>
    [DataContract]
    public partial class Package :  IEquatable<Package>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Package" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="path">package import path.</param>
        /// <param name="package">package name.</param>
        /// <param name="files">package files.</param>
        public Package(string type = default(string), string path = default(string), string package = default(string), List<System.IO.Stream> files = default(List<System.IO.Stream>))
        {
            this.Type = type;
            this.Path = path;
            this._Package = package;
            this.Files = files;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// package import path
        /// </summary>
        /// <value>package import path</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// package name
        /// </summary>
        /// <value>package name</value>
        [DataMember(Name="package", EmitDefaultValue=false)]
        public string _Package { get; set; }

        /// <summary>
        /// package files
        /// </summary>
        /// <value>package files</value>
        [DataMember(Name="files", EmitDefaultValue=false)]
        public List<System.IO.Stream> Files { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Package {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  _Package: ").Append(_Package).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Package);
        }

        /// <summary>
        /// Returns true if Package instances are equal
        /// </summary>
        /// <param name="input">Instance of Package to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Package input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this._Package == input._Package ||
                    (this._Package != null &&
                    this._Package.Equals(input._Package))
                ) && 
                (
                    this.Files == input.Files ||
                    this.Files != null &&
                    this.Files.SequenceEqual(input.Files)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this._Package != null)
                    hashCode = hashCode * 59 + this._Package.GetHashCode();
                if (this.Files != null)
                    hashCode = hashCode * 59 + this.Files.GetHashCode();
                return hashCode;
            }
        }

    }

}