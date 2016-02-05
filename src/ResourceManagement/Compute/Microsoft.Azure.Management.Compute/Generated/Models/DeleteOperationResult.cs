// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The compute long running operation response.
    /// </summary>
    public partial class DeleteOperationResult
    {
        /// <summary>
        /// Initializes a new instance of the DeleteOperationResult class.
        /// </summary>
        public DeleteOperationResult() { }

        /// <summary>
        /// Initializes a new instance of the DeleteOperationResult class.
        /// </summary>
        public DeleteOperationResult(string operationId, OperationStatus? status, DateTime? startTime, DateTime? endTime = default(DateTime?), ApiError error = default(ApiError))
        {
            OperationId = operationId;
            Status = status;
            StartTime = startTime;
            EndTime = endTime;
            Error = error;
        }

        /// <summary>
        /// Gets the operation identifier.
        /// </summary>
        [JsonProperty(PropertyName = "operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// Gets the operation status. Possible values for this property
        /// include: 'InProgress', 'Succeeded', 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public OperationStatus? Status { get; set; }

        /// <summary>
        /// Gets the operation start time
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets the operation end time
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the operation error if any occurred
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ApiError Error { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (OperationId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OperationId");
            }
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
            if (StartTime == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StartTime");
            }
        }
    }
}
