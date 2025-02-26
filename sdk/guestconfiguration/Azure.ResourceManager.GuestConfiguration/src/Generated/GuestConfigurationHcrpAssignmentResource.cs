// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.GuestConfiguration.Models;

namespace Azure.ResourceManager.GuestConfiguration
{
    /// <summary>
    /// A Class representing a GuestConfigurationHcrpAssignment along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="GuestConfigurationHcrpAssignmentResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetGuestConfigurationHcrpAssignmentResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetGuestConfigurationHcrpAssignment method.
    /// </summary>
    public partial class GuestConfigurationHcrpAssignmentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="GuestConfigurationHcrpAssignmentResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="machineName"> The machineName. </param>
        /// <param name="guestConfigurationAssignmentName"> The guestConfigurationAssignmentName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string machineName, string guestConfigurationAssignmentName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsClientDiagnostics;
        private readonly GuestConfigurationHcrpAssignmentsRestOperations _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsRestClient;
        private readonly ClientDiagnostics _guestConfigurationHcrpAssignmentReportsClientDiagnostics;
        private readonly GuestConfigurationHcrpAssignmentReportsRestOperations _guestConfigurationHcrpAssignmentReportsRestClient;
        private readonly GuestConfigurationAssignmentData _data;

        /// <summary> Initializes a new instance of the <see cref="GuestConfigurationHcrpAssignmentResource"/> class for mocking. </summary>
        protected GuestConfigurationHcrpAssignmentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GuestConfigurationHcrpAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal GuestConfigurationHcrpAssignmentResource(ArmClient client, GuestConfigurationAssignmentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="GuestConfigurationHcrpAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GuestConfigurationHcrpAssignmentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.GuestConfiguration", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsApiVersion);
            _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsRestClient = new GuestConfigurationHcrpAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsApiVersion);
            _guestConfigurationHcrpAssignmentReportsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.GuestConfiguration", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _guestConfigurationHcrpAssignmentReportsRestClient = new GuestConfigurationHcrpAssignmentReportsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.GuestConfiguration/guestConfigurationAssignments";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual GuestConfigurationAssignmentData Data
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
        /// Get information about a guest configuration assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationHCRPAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GuestConfigurationHcrpAssignmentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsClientDiagnostics.CreateScope("GuestConfigurationHcrpAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = await _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GuestConfigurationHcrpAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a guest configuration assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationHCRPAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GuestConfigurationHcrpAssignmentResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsClientDiagnostics.CreateScope("GuestConfigurationHcrpAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GuestConfigurationHcrpAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a guest configuration assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationHCRPAssignments_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsClientDiagnostics.CreateScope("GuestConfigurationHcrpAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = await _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new GuestConfigurationArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a guest configuration assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationHCRPAssignments_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsClientDiagnostics.CreateScope("GuestConfigurationHcrpAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new GuestConfigurationArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates an association between a ARC machine and guest configuration
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationHCRPAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create or update guest configuration assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GuestConfigurationHcrpAssignmentResource>> UpdateAsync(WaitUntil waitUntil, GuestConfigurationAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsClientDiagnostics.CreateScope("GuestConfigurationHcrpAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = await _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new GuestConfigurationArmOperation<GuestConfigurationHcrpAssignmentResource>(Response.FromValue(new GuestConfigurationHcrpAssignmentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates an association between a ARC machine and guest configuration
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationHCRPAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create or update guest configuration assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GuestConfigurationHcrpAssignmentResource> Update(WaitUntil waitUntil, GuestConfigurationAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsClientDiagnostics.CreateScope("GuestConfigurationHcrpAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new GuestConfigurationArmOperation<GuestConfigurationHcrpAssignmentResource>(Response.FromValue(new GuestConfigurationHcrpAssignmentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all reports for the guest configuration assignment, latest report first.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}/reports</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationHCRPAssignmentReports_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GuestConfigurationAssignmentReport"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GuestConfigurationAssignmentReport> GetReportsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _guestConfigurationHcrpAssignmentReportsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, GuestConfigurationAssignmentReport.DeserializeGuestConfigurationAssignmentReport, _guestConfigurationHcrpAssignmentReportsClientDiagnostics, Pipeline, "GuestConfigurationHcrpAssignmentResource.GetReports", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all reports for the guest configuration assignment, latest report first.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}/reports</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationHCRPAssignmentReports_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GuestConfigurationAssignmentReport"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GuestConfigurationAssignmentReport> GetReports(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _guestConfigurationHcrpAssignmentReportsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, GuestConfigurationAssignmentReport.DeserializeGuestConfigurationAssignmentReport, _guestConfigurationHcrpAssignmentReportsClientDiagnostics, Pipeline, "GuestConfigurationHcrpAssignmentResource.GetReports", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get a report for the guest configuration assignment, by reportId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}/reports/{reportId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationHCRPAssignmentReports_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reportId"> The GUID for the guest configuration assignment report. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportId"/> is null. </exception>
        public virtual async Task<Response<GuestConfigurationAssignmentReport>> GetReportAsync(string reportId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportId, nameof(reportId));

            using var scope = _guestConfigurationHcrpAssignmentReportsClientDiagnostics.CreateScope("GuestConfigurationHcrpAssignmentResource.GetReport");
            scope.Start();
            try
            {
                var response = await _guestConfigurationHcrpAssignmentReportsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reportId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a report for the guest configuration assignment, by reportId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}/reports/{reportId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationHCRPAssignmentReports_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reportId"> The GUID for the guest configuration assignment report. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportId"/> is null. </exception>
        public virtual Response<GuestConfigurationAssignmentReport> GetReport(string reportId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportId, nameof(reportId));

            using var scope = _guestConfigurationHcrpAssignmentReportsClientDiagnostics.CreateScope("GuestConfigurationHcrpAssignmentResource.GetReport");
            scope.Start();
            try
            {
                var response = _guestConfigurationHcrpAssignmentReportsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reportId, cancellationToken);
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
