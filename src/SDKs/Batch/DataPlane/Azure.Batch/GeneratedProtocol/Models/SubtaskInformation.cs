// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information about an Azure Batch subtask.
    /// </summary>
    public partial class SubtaskInformation
    {
        /// <summary>
        /// Initializes a new instance of the SubtaskInformation class.
        /// </summary>
        public SubtaskInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubtaskInformation class.
        /// </summary>
        /// <param name="id">The ID of the subtask.</param>
        /// <param name="nodeInfo">Information about the compute node on which
        /// the subtask ran.</param>
        /// <param name="startTime">The time at which the subtask started
        /// running. If the subtask has been restarted or retried, this is the
        /// most recent time at which the subtask started running.</param>
        /// <param name="endTime">The time at which the subtask
        /// completed.</param>
        /// <param name="exitCode">The exit code of the program specified on
        /// the subtask command line.</param>
        /// <param name="containerInfo">Information about the container under
        /// which the task is executing.</param>
        /// <param name="failureInfo">Information describing the task failure,
        /// if any.</param>
        /// <param name="state">The current state of the subtask.</param>
        /// <param name="stateTransitionTime">The time at which the subtask
        /// entered its current state.</param>
        /// <param name="previousState">The previous state of the
        /// subtask.</param>
        /// <param name="previousStateTransitionTime">The time at which the
        /// subtask entered its previous state.</param>
        /// <param name="result">The result of the task execution.</param>
        public SubtaskInformation(int? id = default(int?), ComputeNodeInformation nodeInfo = default(ComputeNodeInformation), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), int? exitCode = default(int?), TaskContainerExecutionInformation containerInfo = default(TaskContainerExecutionInformation), TaskFailureInformation failureInfo = default(TaskFailureInformation), SubtaskState? state = default(SubtaskState?), System.DateTime? stateTransitionTime = default(System.DateTime?), SubtaskState? previousState = default(SubtaskState?), System.DateTime? previousStateTransitionTime = default(System.DateTime?), TaskExecutionResult? result = default(TaskExecutionResult?))
        {
            Id = id;
            NodeInfo = nodeInfo;
            StartTime = startTime;
            EndTime = endTime;
            ExitCode = exitCode;
            ContainerInfo = containerInfo;
            FailureInfo = failureInfo;
            State = state;
            StateTransitionTime = stateTransitionTime;
            PreviousState = previousState;
            PreviousStateTransitionTime = previousStateTransitionTime;
            Result = result;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the subtask.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets information about the compute node on which the
        /// subtask ran.
        /// </summary>
        [JsonProperty(PropertyName = "nodeInfo")]
        public ComputeNodeInformation NodeInfo { get; set; }

        /// <summary>
        /// Gets or sets the time at which the subtask started running. If the
        /// subtask has been restarted or retried, this is the most recent time
        /// at which the subtask started running.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the subtask completed.
        /// </summary>
        /// <remarks>
        /// This property is set only if the subtask is in the Completed state.
        /// </remarks>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the exit code of the program specified on the subtask
        /// command line.
        /// </summary>
        /// <remarks>
        /// This property is set only if the subtask is in the completed state.
        /// In general, the exit code for a process reflects the specific
        /// convention implemented by the application developer for that
        /// process. If you use the exit code value to make decisions in your
        /// code, be sure that you know the exit code convention used by the
        /// application process. However, if the Batch service terminates the
        /// subtask (due to timeout, or user termination via the API) you may
        /// see an operating system-defined exit code.
        /// </remarks>
        [JsonProperty(PropertyName = "exitCode")]
        public int? ExitCode { get; set; }

        /// <summary>
        /// Gets or sets information about the container under which the task
        /// is executing.
        /// </summary>
        /// <remarks>
        /// This property is set only if the task runs in a container context.
        /// </remarks>
        [JsonProperty(PropertyName = "containerInfo")]
        public TaskContainerExecutionInformation ContainerInfo { get; set; }

        /// <summary>
        /// Gets or sets information describing the task failure, if any.
        /// </summary>
        /// <remarks>
        /// This property is set only if the task is in the completed state and
        /// encountered a failure.
        /// </remarks>
        [JsonProperty(PropertyName = "failureInfo")]
        public TaskFailureInformation FailureInfo { get; set; }

        /// <summary>
        /// Gets or sets the current state of the subtask.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'preparing', 'running', 'completed'
        /// </remarks>
        [JsonProperty(PropertyName = "state")]
        public SubtaskState? State { get; set; }

        /// <summary>
        /// Gets or sets the time at which the subtask entered its current
        /// state.
        /// </summary>
        [JsonProperty(PropertyName = "stateTransitionTime")]
        public System.DateTime? StateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the previous state of the subtask.
        /// </summary>
        /// <remarks>
        /// This property is not set if the subtask is in its initial running
        /// state. Possible values include: 'preparing', 'running', 'completed'
        /// </remarks>
        [JsonProperty(PropertyName = "previousState")]
        public SubtaskState? PreviousState { get; set; }

        /// <summary>
        /// Gets or sets the time at which the subtask entered its previous
        /// state.
        /// </summary>
        /// <remarks>
        /// This property is not set if the subtask is in its initial running
        /// state.
        /// </remarks>
        [JsonProperty(PropertyName = "previousStateTransitionTime")]
        public System.DateTime? PreviousStateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the result of the task execution.
        /// </summary>
        /// <remarks>
        /// If the value is 'failed', then the details of the failure can be
        /// found in the failureInfo property. Possible values include:
        /// 'success', 'failure'
        /// </remarks>
        [JsonProperty(PropertyName = "result")]
        public TaskExecutionResult? Result { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FailureInfo != null)
            {
                FailureInfo.Validate();
            }
        }
    }
}
