// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.KeyVault;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The attributes of an issuer managed by the Key Vault service.
    /// </summary>
    public partial class IssuerAttributes
    {
        /// <summary>
        /// Initializes a new instance of the IssuerAttributes class.
        /// </summary>
        public IssuerAttributes()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IssuerAttributes class.
        /// </summary>
        /// <param name="enabled">Determines whether the issuer is
        /// enabled.</param>
        /// <param name="created">Creation time in UTC.</param>
        /// <param name="updated">Last updated time in UTC.</param>
        public IssuerAttributes(bool? enabled = default(bool?), System.DateTime? created = default(System.DateTime?), System.DateTime? updated = default(System.DateTime?))
        {
            Enabled = enabled;
            Created = created;
            Updated = updated;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets determines whether the issuer is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets creation time in UTC.
        /// </summary>
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        [JsonProperty(PropertyName = "created")]
        public System.DateTime? Created { get; private set; }

        /// <summary>
        /// Gets last updated time in UTC.
        /// </summary>
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        [JsonProperty(PropertyName = "updated")]
        public System.DateTime? Updated { get; private set; }

    }
}
