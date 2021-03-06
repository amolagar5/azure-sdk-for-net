// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class AutomaticOSUpgradePolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (EnableAutomaticOSUpgrade != null)
            {
                writer.WritePropertyName("enableAutomaticOSUpgrade");
                writer.WriteBooleanValue(EnableAutomaticOSUpgrade.Value);
            }
            if (DisableAutomaticRollback != null)
            {
                writer.WritePropertyName("disableAutomaticRollback");
                writer.WriteBooleanValue(DisableAutomaticRollback.Value);
            }
            writer.WriteEndObject();
        }

        internal static AutomaticOSUpgradePolicy DeserializeAutomaticOSUpgradePolicy(JsonElement element)
        {
            bool? enableAutomaticOSUpgrade = default;
            bool? disableAutomaticRollback = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableAutomaticOSUpgrade"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAutomaticOSUpgrade = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableAutomaticRollback"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableAutomaticRollback = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AutomaticOSUpgradePolicy(enableAutomaticOSUpgrade, disableAutomaticRollback);
        }
    }
}
