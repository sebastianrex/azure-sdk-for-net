// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Chaos;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents a list of Capability Type resources and a link for pagination. </summary>
    internal partial class CapabilityTypeListResult
    {
        /// <summary> Initializes a new instance of CapabilityTypeListResult. </summary>
        internal CapabilityTypeListResult()
        {
            Value = new ChangeTrackingList<CapabilityTypeData>();
        }

        /// <summary> Initializes a new instance of CapabilityTypeListResult. </summary>
        /// <param name="value"> List of Capability Type resources. </param>
        /// <param name="nextLink"> URL to retrieve the next page of Capability Type resources. </param>
        internal CapabilityTypeListResult(IReadOnlyList<CapabilityTypeData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Capability Type resources. </summary>
        public IReadOnlyList<CapabilityTypeData> Value { get; }
        /// <summary> URL to retrieve the next page of Capability Type resources. </summary>
        public string NextLink { get; }
    }
}
