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

namespace Azure.ResourceManager.Advisor
{
    /// <summary>
    /// A Class representing a SuppressionContract along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SuppressionContractResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSuppressionContractResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceRecommendationBaseResource"/> using the GetSuppressionContract method.
    /// </summary>
    public partial class SuppressionContractResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SuppressionContractResource"/> instance. </summary>
        /// <param name="resourceUri"> The resourceUri. </param>
        /// <param name="recommendationId"> The recommendationId. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceUri, string recommendationId, string name)
        {
            var resourceId = $"{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}/suppressions/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _suppressionContractSuppressionsClientDiagnostics;
        private readonly SuppressionsRestOperations _suppressionContractSuppressionsRestClient;
        private readonly SuppressionContractData _data;

        /// <summary> Initializes a new instance of the <see cref="SuppressionContractResource"/> class for mocking. </summary>
        protected SuppressionContractResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SuppressionContractResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SuppressionContractResource(ArmClient client, SuppressionContractData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SuppressionContractResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SuppressionContractResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _suppressionContractSuppressionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Advisor", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string suppressionContractSuppressionsApiVersion);
            _suppressionContractSuppressionsRestClient = new SuppressionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, suppressionContractSuppressionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Advisor/recommendations/suppressions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SuppressionContractData Data
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
        /// Obtains the details of a suppression.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}/suppressions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Suppressions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SuppressionContractResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _suppressionContractSuppressionsClientDiagnostics.CreateScope("SuppressionContractResource.Get");
            scope.Start();
            try
            {
                var response = await _suppressionContractSuppressionsRestClient.GetAsync(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SuppressionContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Obtains the details of a suppression.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}/suppressions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Suppressions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SuppressionContractResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _suppressionContractSuppressionsClientDiagnostics.CreateScope("SuppressionContractResource.Get");
            scope.Start();
            try
            {
                var response = _suppressionContractSuppressionsRestClient.Get(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SuppressionContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Enables the activation of a snoozed or dismissed recommendation. The snoozed or dismissed attribute of a recommendation is referred to as a suppression.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}/suppressions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Suppressions_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _suppressionContractSuppressionsClientDiagnostics.CreateScope("SuppressionContractResource.Delete");
            scope.Start();
            try
            {
                var response = await _suppressionContractSuppressionsRestClient.DeleteAsync(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AdvisorArmOperation(response);
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
        /// Enables the activation of a snoozed or dismissed recommendation. The snoozed or dismissed attribute of a recommendation is referred to as a suppression.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}/suppressions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Suppressions_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _suppressionContractSuppressionsClientDiagnostics.CreateScope("SuppressionContractResource.Delete");
            scope.Start();
            try
            {
                var response = _suppressionContractSuppressionsRestClient.Delete(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AdvisorArmOperation(response);
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
        /// Enables the snoozed or dismissed attribute of a recommendation. The snoozed or dismissed attribute is referred to as a suppression. Use this API to create or update the snoozed or dismissed status of a recommendation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}/suppressions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Suppressions_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The snoozed or dismissed attribute; for example, the snooze duration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SuppressionContractResource>> UpdateAsync(WaitUntil waitUntil, SuppressionContractData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _suppressionContractSuppressionsClientDiagnostics.CreateScope("SuppressionContractResource.Update");
            scope.Start();
            try
            {
                var response = await _suppressionContractSuppressionsRestClient.CreateAsync(Id.Parent.Parent, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AdvisorArmOperation<SuppressionContractResource>(Response.FromValue(new SuppressionContractResource(Client, response), response.GetRawResponse()));
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
        /// Enables the snoozed or dismissed attribute of a recommendation. The snoozed or dismissed attribute is referred to as a suppression. Use this API to create or update the snoozed or dismissed status of a recommendation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}/suppressions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Suppressions_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The snoozed or dismissed attribute; for example, the snooze duration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SuppressionContractResource> Update(WaitUntil waitUntil, SuppressionContractData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _suppressionContractSuppressionsClientDiagnostics.CreateScope("SuppressionContractResource.Update");
            scope.Start();
            try
            {
                var response = _suppressionContractSuppressionsRestClient.Create(Id.Parent.Parent, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new AdvisorArmOperation<SuppressionContractResource>(Response.FromValue(new SuppressionContractResource(Client, response), response.GetRawResponse()));
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
    }
}
