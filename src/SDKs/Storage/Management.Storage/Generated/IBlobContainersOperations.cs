// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// BlobContainersOperations operations.
    /// </summary>
    public partial interface IBlobContainersOperations
    {
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ListContainerItems>> ListWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='publicAccess'>
        /// TODO. Possible values include: 'container', 'blob'
        /// </param>
        /// <param name='metadata'>
        /// TODO
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BlobContainer>> CreateWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, PublicAccess? publicAccess = default(PublicAccess?), IDictionary<string, string> metadata = default(IDictionary<string, string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='publicAccess'>
        /// TODO. Possible values include: 'container', 'blob'
        /// </param>
        /// <param name='metadata'>
        /// TODO
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BlobContainer>> UpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, PublicAccess? publicAccess = default(PublicAccess?), IDictionary<string, string> metadata = default(IDictionary<string, string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BlobContainer>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> LeaseWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='tags'>
        /// TODO
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<LegalHold>> SetLegalHoldWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, IList<string> tags = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='tags'>
        /// TODO
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<LegalHold>> ClearLegalHoldWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, IList<string> tags = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='ifMatch'>
        /// The entity state (ETag) version of the immutability policy to
        /// update. A value of "*" can be used to apply the operation only if
        /// the immutability policy already exists. If omitted, this operation
        /// will always be applied.
        /// </param>
        /// <param name='immutabilityPeriodSinceCreationInDays'>
        /// TODO
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ImmutabilityPolicy,BlobContainersCreateOrUpdateImmutabilityPolicyHeaders>> CreateOrUpdateImmutabilityPolicyWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, string ifMatch, int immutabilityPeriodSinceCreationInDays, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='ifMatch'>
        /// The entity state (ETag) version of the immutability policy to
        /// update. A value of "*" can be used to apply the operation only if
        /// the immutability policy already exists. If omitted, this operation
        /// will always be applied.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ImmutabilityPolicy>> GetImmutabilityPolicyWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='ifMatch'>
        /// The entity state (ETag) version of the immutability policy to
        /// update. A value of "*" can be used to apply the operation only if
        /// the immutability policy already exists. If omitted, this operation
        /// will always be applied.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ImmutabilityPolicy>> DeleteImmutabilityPolicyWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, string ifMatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='ifMatch'>
        /// The entity state (ETag) version of the immutability policy to
        /// update. A value of "*" can be used to apply the operation only if
        /// the immutability policy already exists. If omitted, this operation
        /// will always be applied.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ImmutabilityPolicy>> LockImmutabilityPolicyWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, string ifMatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='ifMatch'>
        /// The entity state (ETag) version of the immutability policy to
        /// update. A value of "*" can be used to apply the operation only if
        /// the immutability policy already exists. If omitted, this operation
        /// will always be applied.
        /// </param>
        /// <param name='immutabilityPeriodSinceCreationInDays'>
        /// TODO
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ImmutabilityPolicy>> ExtendImmutabilityPolicyWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, string ifMatch, int immutabilityPeriodSinceCreationInDays, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
