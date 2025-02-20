// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Details of on demand test probe request. </summary>
    public partial class ApplicationGatewayOnDemandProbe
    {
        /// <summary> Initializes a new instance of ApplicationGatewayOnDemandProbe. </summary>
        public ApplicationGatewayOnDemandProbe()
        {
        }

        /// <summary> The protocol used for the probe. </summary>
        public ApplicationGatewayProtocol? Protocol { get; set; }
        /// <summary> Host name to send the probe to. </summary>
        public string Host { get; set; }
        /// <summary> Relative path of probe. Valid path starts from '/'. Probe is sent to &lt;Protocol&gt;://&lt;host&gt;:&lt;port&gt;&lt;path&gt;. </summary>
        public string Path { get; set; }
        /// <summary> The probe timeout in seconds. Probe marked as failed if valid response is not received with this timeout period. Acceptable values are from 1 second to 86400 seconds. </summary>
        public int? Timeout { get; set; }
        /// <summary> Whether the host header should be picked from the backend http settings. Default value is false. </summary>
        public bool? PickHostNameFromBackendHttpSettings { get; set; }
        /// <summary> Criterion for classifying a healthy probe response. </summary>
        public ApplicationGatewayProbeHealthResponseMatch Match { get; set; }
        /// <summary> Reference to backend pool of application gateway to which probe request will be sent. </summary>
        internal WritableSubResource BackendAddressPool { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier BackendAddressPoolId
        {
            get => BackendAddressPool is null ? default : BackendAddressPool.Id;
            set
            {
                if (BackendAddressPool is null)
                    BackendAddressPool = new WritableSubResource();
                BackendAddressPool.Id = value;
            }
        }

        /// <summary> Reference to backend http setting of application gateway to be used for test probe. </summary>
        internal WritableSubResource BackendHttpSettings { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier BackendHttpSettingsId
        {
            get => BackendHttpSettings is null ? default : BackendHttpSettings.Id;
            set
            {
                if (BackendHttpSettings is null)
                    BackendHttpSettings = new WritableSubResource();
                BackendHttpSettings.Id = value;
            }
        }
    }
}
