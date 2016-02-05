// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Class that represents a Biztalk Hybrid Connection
    /// </summary>
    public partial class RelayServiceConnectionEntity : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RelayServiceConnectionEntity
        /// class.
        /// </summary>
        public RelayServiceConnectionEntity() { }

        /// <summary>
        /// Initializes a new instance of the RelayServiceConnectionEntity
        /// class.
        /// </summary>
        public RelayServiceConnectionEntity(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string entityName = default(string), string entityConnectionString = default(string), string resourceType = default(string), string resourceConnectionString = default(string), string hostname = default(string), int? port = default(int?), string biztalkUri = default(string))
            : base(location, id, name, type, tags)
        {
            EntityName = entityName;
            EntityConnectionString = entityConnectionString;
            ResourceType = resourceType;
            ResourceConnectionString = resourceConnectionString;
            Hostname = hostname;
            Port = port;
            BiztalkUri = biztalkUri;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.entityName")]
        public string EntityName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.entityConnectionString")]
        public string EntityConnectionString { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceType")]
        public string ResourceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceConnectionString")]
        public string ResourceConnectionString { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.port")]
        public int? Port { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.biztalkUri")]
        public string BiztalkUri { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
