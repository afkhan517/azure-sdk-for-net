// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Insights.Models
{

    /// <summary>
    /// Defines values for Unit.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Unit
    {
        [System.Runtime.Serialization.EnumMember(Value = "Count")]
        Count,
        [System.Runtime.Serialization.EnumMember(Value = "Bytes")]
        Bytes,
        [System.Runtime.Serialization.EnumMember(Value = "Seconds")]
        Seconds,
        [System.Runtime.Serialization.EnumMember(Value = "CountPerSecond")]
        CountPerSecond,
        [System.Runtime.Serialization.EnumMember(Value = "BytesPerSecond")]
        BytesPerSecond,
        [System.Runtime.Serialization.EnumMember(Value = "Percent")]
        Percent,
        [System.Runtime.Serialization.EnumMember(Value = "MilliSeconds")]
        MilliSeconds
    }
}
