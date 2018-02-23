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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ImmutabilityPolicyState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImmutabilityPolicyState
    {
        [EnumMember(Value = "Locked")]
        Locked,
        [EnumMember(Value = "Unlocked")]
        Unlocked
    }
    internal static class ImmutabilityPolicyStateEnumExtension
    {
        internal static string ToSerializedValue(this ImmutabilityPolicyState? value)
        {
            return value == null ? null : ((ImmutabilityPolicyState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ImmutabilityPolicyState value)
        {
            switch( value )
            {
                case ImmutabilityPolicyState.Locked:
                    return "Locked";
                case ImmutabilityPolicyState.Unlocked:
                    return "Unlocked";
            }
            return null;
        }

        internal static ImmutabilityPolicyState? ParseImmutabilityPolicyState(this string value)
        {
            switch( value )
            {
                case "Locked":
                    return ImmutabilityPolicyState.Locked;
                case "Unlocked":
                    return ImmutabilityPolicyState.Unlocked;
            }
            return null;
        }
    }
}