// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a ResourceGroupSecurityAlert along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ResourceGroupSecurityAlertResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetResourceGroupSecurityAlertResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource"/> using the GetResourceGroupSecurityAlert method.
    /// </summary>
    public partial class ResourceGroupSecurityAlertResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResourceGroupSecurityAlertResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="ascLocation"> The ascLocation. </param>
        /// <param name="alertName"> The alertName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, AzureLocation ascLocation, string alertName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resourceGroupSecurityAlertAlertsClientDiagnostics;
        private readonly AlertsRestOperations _resourceGroupSecurityAlertAlertsRestClient;
        private readonly SecurityAlertData _data;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupSecurityAlertResource"/> class for mocking. </summary>
        protected ResourceGroupSecurityAlertResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupSecurityAlertResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResourceGroupSecurityAlertResource(ArmClient client, SecurityAlertData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupSecurityAlertResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupSecurityAlertResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceGroupSecurityAlertAlertsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string resourceGroupSecurityAlertAlertsApiVersion);
            _resourceGroupSecurityAlertAlertsRestClient = new AlertsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceGroupSecurityAlertAlertsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/locations/alerts";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecurityAlertData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get an alert that is associated a resource group or a resource in a resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetResourceGroupLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceGroupSecurityAlertResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupSecurityAlertAlertsClientDiagnostics.CreateScope("ResourceGroupSecurityAlertResource.Get");
            scope.Start();
            try
            {
                var response = await _resourceGroupSecurityAlertAlertsRestClient.GetResourceGroupLevelAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupSecurityAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an alert that is associated a resource group or a resource in a resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetResourceGroupLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceGroupSecurityAlertResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupSecurityAlertAlertsClientDiagnostics.CreateScope("ResourceGroupSecurityAlertResource.Get");
            scope.Start();
            try
            {
                var response = _resourceGroupSecurityAlertAlertsRestClient.GetResourceGroupLevel(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupSecurityAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert's state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/resolve</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_UpdateResourceGroupLevelStateToResolve</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ResolveAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupSecurityAlertAlertsClientDiagnostics.CreateScope("ResourceGroupSecurityAlertResource.Resolve");
            scope.Start();
            try
            {
                var response = await _resourceGroupSecurityAlertAlertsRestClient.UpdateResourceGroupLevelStateToResolveAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert's state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/resolve</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_UpdateResourceGroupLevelStateToResolve</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Resolve(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupSecurityAlertAlertsClientDiagnostics.CreateScope("ResourceGroupSecurityAlertResource.Resolve");
            scope.Start();
            try
            {
                var response = _resourceGroupSecurityAlertAlertsRestClient.UpdateResourceGroupLevelStateToResolve(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert's state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/dismiss</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_UpdateResourceGroupLevelStateToDismiss</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DismissAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupSecurityAlertAlertsClientDiagnostics.CreateScope("ResourceGroupSecurityAlertResource.Dismiss");
            scope.Start();
            try
            {
                var response = await _resourceGroupSecurityAlertAlertsRestClient.UpdateResourceGroupLevelStateToDismissAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert's state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/dismiss</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_UpdateResourceGroupLevelStateToDismiss</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Dismiss(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupSecurityAlertAlertsClientDiagnostics.CreateScope("ResourceGroupSecurityAlertResource.Dismiss");
            scope.Start();
            try
            {
                var response = _resourceGroupSecurityAlertAlertsRestClient.UpdateResourceGroupLevelStateToDismiss(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert's state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/activate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_UpdateResourceGroupLevelStateToActivate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ActivateAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupSecurityAlertAlertsClientDiagnostics.CreateScope("ResourceGroupSecurityAlertResource.Activate");
            scope.Start();
            try
            {
                var response = await _resourceGroupSecurityAlertAlertsRestClient.UpdateResourceGroupLevelStateToActivateAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert's state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/activate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_UpdateResourceGroupLevelStateToActivate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Activate(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupSecurityAlertAlertsClientDiagnostics.CreateScope("ResourceGroupSecurityAlertResource.Activate");
            scope.Start();
            try
            {
                var response = _resourceGroupSecurityAlertAlertsRestClient.UpdateResourceGroupLevelStateToActivate(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert's state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/inProgress</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_UpdateResourceGroupLevelStateToInProgress</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UpdateSatateToInProgressAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupSecurityAlertAlertsClientDiagnostics.CreateScope("ResourceGroupSecurityAlertResource.UpdateSatateToInProgress");
            scope.Start();
            try
            {
                var response = await _resourceGroupSecurityAlertAlertsRestClient.UpdateResourceGroupLevelStateToInProgressAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert's state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/inProgress</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_UpdateResourceGroupLevelStateToInProgress</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response UpdateSatateToInProgress(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupSecurityAlertAlertsClientDiagnostics.CreateScope("ResourceGroupSecurityAlertResource.UpdateSatateToInProgress");
            scope.Start();
            try
            {
                var response = _resourceGroupSecurityAlertAlertsRestClient.UpdateResourceGroupLevelStateToInProgress(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
