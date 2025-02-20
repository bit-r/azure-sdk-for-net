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

namespace Azure.ResourceManager.Automanage
{
    /// <summary>
    /// A Class representing an AutomanageBestPractice along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AutomanageBestPracticeResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAutomanageBestPracticeResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource"/> using the GetAutomanageBestPractice method.
    /// </summary>
    public partial class AutomanageBestPracticeResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AutomanageBestPracticeResource"/> instance. </summary>
        /// <param name="bestPracticeName"> The bestPracticeName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string bestPracticeName)
        {
            var resourceId = $"/providers/Microsoft.Automanage/bestPractices/{bestPracticeName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _automanageBestPracticeBestPracticesClientDiagnostics;
        private readonly BestPracticesRestOperations _automanageBestPracticeBestPracticesRestClient;
        private readonly AutomanageBestPracticeData _data;

        /// <summary> Initializes a new instance of the <see cref="AutomanageBestPracticeResource"/> class for mocking. </summary>
        protected AutomanageBestPracticeResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomanageBestPracticeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AutomanageBestPracticeResource(ArmClient client, AutomanageBestPracticeData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AutomanageBestPracticeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AutomanageBestPracticeResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automanageBestPracticeBestPracticesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automanage", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string automanageBestPracticeBestPracticesApiVersion);
            _automanageBestPracticeBestPracticesRestClient = new BestPracticesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automanageBestPracticeBestPracticesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Automanage/bestPractices";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AutomanageBestPracticeData Data
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
        /// Get information about a Automanage best practice
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Automanage/bestPractices/{bestPracticeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BestPractices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AutomanageBestPracticeResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _automanageBestPracticeBestPracticesClientDiagnostics.CreateScope("AutomanageBestPracticeResource.Get");
            scope.Start();
            try
            {
                var response = await _automanageBestPracticeBestPracticesRestClient.GetAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageBestPracticeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a Automanage best practice
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Automanage/bestPractices/{bestPracticeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BestPractices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AutomanageBestPracticeResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _automanageBestPracticeBestPracticesClientDiagnostics.CreateScope("AutomanageBestPracticeResource.Get");
            scope.Start();
            try
            {
                var response = _automanageBestPracticeBestPracticesRestClient.Get(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageBestPracticeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
