// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.LabServices;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Paged list of lab plans. </summary>
    internal partial class PagedLabPlans
    {
        /// <summary> Initializes a new instance of PagedLabPlans. </summary>
        internal PagedLabPlans()
        {
            Value = new ChangeTrackingList<LabPlanData>();
        }

        /// <summary> Initializes a new instance of PagedLabPlans. </summary>
        /// <param name="value"> The array page of lab plans. </param>
        /// <param name="nextLink"> The link to get the next page of lab plan results. </param>
        internal PagedLabPlans(IReadOnlyList<LabPlanData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The array page of lab plans. </summary>
        public IReadOnlyList<LabPlanData> Value { get; }
        /// <summary> The link to get the next page of lab plan results. </summary>
        public string NextLink { get; }
    }
}
