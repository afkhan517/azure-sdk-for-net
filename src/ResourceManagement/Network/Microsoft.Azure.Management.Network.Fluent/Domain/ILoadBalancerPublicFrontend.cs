// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent
{
    /// <summary>
    /// An immutable client-side representation of a public frontend of an Internet-facing load balancer.
    /// </summary>
    /// <remarks>
    /// (Beta: This functionality is in preview and as such is subject to change in non-backwards compatible ways in future releases, including removal, regardless of any compatibility expectations set by the containing library version number.)
    /// </remarks>
    public interface ILoadBalancerPublicFrontend  :
        ILoadBalancerFrontend,
        IHasPublicIPAddress
    {
    }
}