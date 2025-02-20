// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Describes a hybrid machine Update. </summary>
    public partial class HybridComputeMachinePatch : HybridComputeResourceUpdate
    {
        /// <summary> Initializes a new instance of HybridComputeMachinePatch. </summary>
        public HybridComputeMachinePatch()
        {
        }

        /// <summary> Identity for the resource. Current supported identity types: SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Metadata pertaining to the geographic location of the resource. </summary>
        public LocationData LocationData { get; set; }
        /// <summary> Specifies the operating system settings for the hybrid machine. </summary>
        public OSProfile OSProfile { get; set; }
        /// <summary> The metadata of the cloud environment (Azure/GCP/AWS/OCI...). </summary>
        internal CloudMetadata CloudMetadata { get; set; }
        /// <summary> Specifies the cloud provider (Azure/AWS/GCP...). </summary>
        public string CloudMetadataProvider
        {
            get => CloudMetadata is null ? default : CloudMetadata.Provider;
        }

        /// <summary> The info of the machine w.r.t Agent Upgrade. </summary>
        public AgentUpgrade AgentUpgrade { get; set; }
        /// <summary> The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any. </summary>
        public ResourceIdentifier ParentClusterResourceId { get; set; }
        /// <summary> The resource id of the private link scope this machine is assigned to, if any. </summary>
        public ResourceIdentifier PrivateLinkScopeResourceId { get; set; }
    }
}
