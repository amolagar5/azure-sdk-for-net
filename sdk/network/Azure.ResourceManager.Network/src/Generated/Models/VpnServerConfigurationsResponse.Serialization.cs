// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnServerConfigurationsResponse
    {
        internal static VpnServerConfigurationsResponse DeserializeVpnServerConfigurationsResponse(JsonElement element)
        {
            IReadOnlyList<string> vpnServerConfigurationResourceIds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vpnServerConfigurationResourceIds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    vpnServerConfigurationResourceIds = array;
                    continue;
                }
            }
            return new VpnServerConfigurationsResponse(vpnServerConfigurationResourceIds);
        }
    }
}
