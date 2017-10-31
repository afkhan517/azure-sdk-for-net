// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// TODO
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ListContainerItem
    {
        /// <summary>
        /// Initializes a new instance of the ListContainerItem class.
        /// </summary>
        public ListContainerItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListContainerItem class.
        /// </summary>
        /// <param name="containerMeatadata">TODO</param>
        /// <param name="publicAccess">TODO. Possible values include:
        /// 'container', 'blob'</param>
        /// <param name="immutabilityPolicy">TODO</param>
        /// <param name="legalHold">TODO</param>
        public ListContainerItem(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> containerMeatadata = default(IDictionary<string, string>), PublicAccess? publicAccess = default(PublicAccess?), BlobContainerPropertiesImmutabilityPolicy immutabilityPolicy = default(BlobContainerPropertiesImmutabilityPolicy), LegalHold legalHold = default(LegalHold))
        {
            Id = id;
            Name = name;
            Type = type;
            ContainerMeatadata = containerMeatadata;
            PublicAccess = publicAccess;
            ImmutabilityPolicy = immutabilityPolicy;
            LegalHold = legalHold;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.containerMeatadata")]
        public IDictionary<string, string> ContainerMeatadata { get; set; }

        /// <summary>
        /// Gets or sets TODO. Possible values include: 'container', 'blob'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicAccess")]
        public PublicAccess? PublicAccess { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.immutabilityPolicy")]
        public BlobContainerPropertiesImmutabilityPolicy ImmutabilityPolicy { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.LegalHold")]
        public LegalHold LegalHold { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ImmutabilityPolicy != null)
            {
                ImmutabilityPolicy.Validate();
            }
        }
    }
}
