// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Grafana.Models
{
    public partial class Smtp : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(Host))
            {
                writer.WritePropertyName("host"u8);
                writer.WriteStringValue(Host);
            }
            if (Optional.IsDefined(User))
            {
                writer.WritePropertyName("user"u8);
                writer.WriteStringValue(User);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(FromAddress))
            {
                writer.WritePropertyName("fromAddress"u8);
                writer.WriteStringValue(FromAddress);
            }
            if (Optional.IsDefined(FromName))
            {
                writer.WritePropertyName("fromName"u8);
                writer.WriteStringValue(FromName);
            }
            if (Optional.IsDefined(StartTLSPolicy))
            {
                writer.WritePropertyName("startTLSPolicy"u8);
                writer.WriteStringValue(StartTLSPolicy.Value.ToString());
            }
            if (Optional.IsDefined(SkipVerify))
            {
                writer.WritePropertyName("skipVerify"u8);
                writer.WriteBooleanValue(SkipVerify.Value);
            }
            writer.WriteEndObject();
        }

        internal static Smtp DeserializeSmtp(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<string> host = default;
            Optional<string> user = default;
            Optional<string> password = default;
            Optional<string> fromAddress = default;
            Optional<string> fromName = default;
            Optional<StartTLSPolicy> startTLSPolicy = default;
            Optional<bool> skipVerify = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("host"u8))
                {
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("user"u8))
                {
                    user = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fromAddress"u8))
                {
                    fromAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fromName"u8))
                {
                    fromName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTLSPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTLSPolicy = new StartTLSPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("skipVerify"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skipVerify = property.Value.GetBoolean();
                    continue;
                }
            }
            return new Smtp(Optional.ToNullable(enabled), host.Value, user.Value, password.Value, fromAddress.Value, fromName.Value, Optional.ToNullable(startTLSPolicy), Optional.ToNullable(skipVerify));
        }
    }
}
