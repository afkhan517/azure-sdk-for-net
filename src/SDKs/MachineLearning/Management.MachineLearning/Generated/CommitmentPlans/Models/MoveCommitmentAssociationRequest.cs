// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.CommitmentPlans.Models
{
    using System.Linq;

    /// <summary>
    /// Specifies the destination Azure ML commitment plan for a move
    /// operation.
    /// </summary>
    public partial class MoveCommitmentAssociationRequest
    {
        /// <summary>
        /// Initializes a new instance of the MoveCommitmentAssociationRequest
        /// class.
        /// </summary>
        public MoveCommitmentAssociationRequest() { }

        /// <summary>
        /// Initializes a new instance of the MoveCommitmentAssociationRequest
        /// class.
        /// </summary>
        /// <param name="destinationPlanId">The ARM ID of the commitment plan
        /// to re-parent the commitment association to.</param>
        public MoveCommitmentAssociationRequest(string destinationPlanId = default(string))
        {
            DestinationPlanId = destinationPlanId;
        }

        /// <summary>
        /// Gets or sets the ARM ID of the commitment plan to re-parent the
        /// commitment association to.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "destinationPlanId")]
        public string DestinationPlanId { get; set; }

    }
}