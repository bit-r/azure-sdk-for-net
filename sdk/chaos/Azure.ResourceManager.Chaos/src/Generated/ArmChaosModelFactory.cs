// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Chaos;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmChaosModelFactory
    {
        /// <summary> Initializes a new instance of CapabilityData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="publisher"> String of the Publisher that this Capability extends. </param>
        /// <param name="targetType"> String of the Target Type that this Capability extends. </param>
        /// <param name="description"> Localized string of the description. </param>
        /// <param name="parametersSchema"> URL to retrieve JSON schema of the Capability parameters. </param>
        /// <param name="urn"> String of the URN for this Capability Type. </param>
        /// <returns> A new <see cref="Chaos.CapabilityData"/> instance for mocking. </returns>
        public static CapabilityData CapabilityData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string publisher = null, string targetType = null, string description = null, string parametersSchema = null, string urn = null)
        {
            return new CapabilityData(id, name, resourceType, systemData, publisher, targetType, description, parametersSchema, urn);
        }

        /// <summary> Initializes a new instance of CapabilityTypeData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Location of the Capability Type resource. </param>
        /// <param name="publisher"> String of the Publisher that this Capability Type extends. </param>
        /// <param name="targetType"> String of the Target Type that this Capability Type extends. </param>
        /// <param name="displayName"> Localized string of the display name. </param>
        /// <param name="description"> Localized string of the description. </param>
        /// <param name="parametersSchema"> URL to retrieve JSON schema of the Capability Type parameters. </param>
        /// <param name="urn"> String of the URN for this Capability Type. </param>
        /// <param name="kind"> String of the kind of this Capability Type. </param>
        /// <param name="azureRbacActions"> Control plane actions necessary to execute capability type. </param>
        /// <param name="azureRbacDataActions"> Data plane actions necessary to execute capability type. </param>
        /// <param name="runtimeKind"> Runtime properties of this Capability Type. </param>
        /// <returns> A new <see cref="Chaos.CapabilityTypeData"/> instance for mocking. </returns>
        public static CapabilityTypeData CapabilityTypeData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, AzureLocation? location = null, string publisher = null, string targetType = null, string displayName = null, string description = null, string parametersSchema = null, string urn = null, string kind = null, IEnumerable<string> azureRbacActions = null, IEnumerable<string> azureRbacDataActions = null, string runtimeKind = null)
        {
            azureRbacActions ??= new List<string>();
            azureRbacDataActions ??= new List<string>();

            return new CapabilityTypeData(id, name, resourceType, systemData, location, publisher, targetType, displayName, description, parametersSchema, urn, kind, azureRbacActions?.ToList(), azureRbacDataActions?.ToList(), runtimeKind != null ? new CapabilityTypePropertiesRuntimeProperties(runtimeKind) : null);
        }

        /// <summary> Initializes a new instance of ExperimentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The identity of the experiment resource. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <param name="steps"> List of steps. </param>
        /// <param name="selectors">
        /// List of selectors.
        /// Please note <see cref="Selector"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ListSelector"/> and <see cref="QuerySelector"/>.
        /// </param>
        /// <param name="startOnCreation"> A boolean value that indicates if experiment should be started on creation or not. </param>
        /// <returns> A new <see cref="Chaos.ExperimentData"/> instance for mocking. </returns>
        public static ExperimentData ExperimentData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, IEnumerable<Step> steps = null, IEnumerable<Selector> selectors = null, bool? startOnCreation = null)
        {
            tags ??= new Dictionary<string, string>();
            steps ??= new List<Step>();
            selectors ??= new List<Selector>();

            return new ExperimentData(id, name, resourceType, systemData, tags, location, identity, steps?.ToList(), selectors?.ToList(), startOnCreation);
        }

        /// <summary> Initializes a new instance of ExperimentCancelOperationResult. </summary>
        /// <param name="name"> String of the Experiment name. </param>
        /// <param name="statusUri"> URL to retrieve the Experiment status. </param>
        /// <returns> A new <see cref="Models.ExperimentCancelOperationResult"/> instance for mocking. </returns>
        public static ExperimentCancelOperationResult ExperimentCancelOperationResult(string name = null, string statusUri = null)
        {
            return new ExperimentCancelOperationResult(name, statusUri);
        }

        /// <summary> Initializes a new instance of ExperimentStartOperationResult. </summary>
        /// <param name="name"> String of the Experiment name. </param>
        /// <param name="statusUri"> URL to retrieve the Experiment status. </param>
        /// <returns> A new <see cref="Models.ExperimentStartOperationResult"/> instance for mocking. </returns>
        public static ExperimentStartOperationResult ExperimentStartOperationResult(string name = null, string statusUri = null)
        {
            return new ExperimentStartOperationResult(name, statusUri);
        }

        /// <summary> Initializes a new instance of ExperimentStatusData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="status"> String that represents the status of a Experiment. </param>
        /// <param name="createdDateUtc"> String that represents the created date time of a Experiment. </param>
        /// <param name="endDateUtc"> String that represents the end date time of a Experiment. </param>
        /// <returns> A new <see cref="Chaos.ExperimentStatusData"/> instance for mocking. </returns>
        public static ExperimentStatusData ExperimentStatusData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string status = null, DateTimeOffset? createdDateUtc = null, DateTimeOffset? endDateUtc = null)
        {
            return new ExperimentStatusData(id, name, resourceType, systemData, status, createdDateUtc, endDateUtc);
        }

        /// <summary> Initializes a new instance of ExperimentExecutionDetailData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="experimentId"> The id of the experiment. </param>
        /// <param name="status"> The value of the status of the experiment execution. </param>
        /// <param name="failureReason"> The reason why the execution failed. </param>
        /// <param name="createdOn"> String that represents the created date time. </param>
        /// <param name="lastActionOn"> String that represents the last action date time. </param>
        /// <param name="startOn"> String that represents the start date time. </param>
        /// <param name="stopOn"> String that represents the stop date time. </param>
        /// <param name="runInformationSteps"> The information of the experiment run. </param>
        /// <returns> A new <see cref="Chaos.ExperimentExecutionDetailData"/> instance for mocking. </returns>
        public static ExperimentExecutionDetailData ExperimentExecutionDetailData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string experimentId = null, string status = null, string failureReason = null, DateTimeOffset? createdOn = null, DateTimeOffset? lastActionOn = null, DateTimeOffset? startOn = null, DateTimeOffset? stopOn = null, IEnumerable<StepStatus> runInformationSteps = null)
        {
            runInformationSteps ??= new List<StepStatus>();

            return new ExperimentExecutionDetailData(id, name, resourceType, systemData, experimentId, status, failureReason, createdOn, lastActionOn, startOn, stopOn, runInformationSteps != null ? new ExperimentExecutionDetailsPropertiesRunInformation(runInformationSteps?.ToList()) : null);
        }

        /// <summary> Initializes a new instance of StepStatus. </summary>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="stepId"> The id of the step. </param>
        /// <param name="status"> The value of the status of the step. </param>
        /// <param name="branches"> The array of branches. </param>
        /// <returns> A new <see cref="Models.StepStatus"/> instance for mocking. </returns>
        public static StepStatus StepStatus(string stepName = null, string stepId = null, string status = null, IEnumerable<BranchStatus> branches = null)
        {
            branches ??= new List<BranchStatus>();

            return new StepStatus(stepName, stepId, status, branches?.ToList());
        }

        /// <summary> Initializes a new instance of BranchStatus. </summary>
        /// <param name="branchName"> The name of the branch status. </param>
        /// <param name="branchId"> The id of the branch status. </param>
        /// <param name="status"> The status of the branch. </param>
        /// <param name="actions"> The array of actions. </param>
        /// <returns> A new <see cref="Models.BranchStatus"/> instance for mocking. </returns>
        public static BranchStatus BranchStatus(string branchName = null, string branchId = null, string status = null, IEnumerable<ActionStatus> actions = null)
        {
            actions ??= new List<ActionStatus>();

            return new BranchStatus(branchName, branchId, status, actions?.ToList());
        }

        /// <summary> Initializes a new instance of ActionStatus. </summary>
        /// <param name="actionName"> The name of the action status. </param>
        /// <param name="actionId"> The id of the action status. </param>
        /// <param name="status"> The status of the action. </param>
        /// <param name="startOn"> String that represents the start time of the action. </param>
        /// <param name="endOn"> String that represents the end time of the action. </param>
        /// <param name="targets"> The array of targets. </param>
        /// <returns> A new <see cref="Models.ActionStatus"/> instance for mocking. </returns>
        public static ActionStatus ActionStatus(string actionName = null, string actionId = null, string status = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, IEnumerable<ExperimentExecutionActionTargetDetailsProperties> targets = null)
        {
            targets ??= new List<ExperimentExecutionActionTargetDetailsProperties>();

            return new ActionStatus(actionName, actionId, status, startOn, endOn, targets?.ToList());
        }

        /// <summary> Initializes a new instance of ExperimentExecutionActionTargetDetailsProperties. </summary>
        /// <param name="status"> The status of the execution. </param>
        /// <param name="target"> The target for the action. </param>
        /// <param name="targetFailedOn"> String that represents the failed date time. </param>
        /// <param name="targetCompletedOn"> String that represents the completed date time. </param>
        /// <param name="error"> The error of the action. </param>
        /// <returns> A new <see cref="Models.ExperimentExecutionActionTargetDetailsProperties"/> instance for mocking. </returns>
        public static ExperimentExecutionActionTargetDetailsProperties ExperimentExecutionActionTargetDetailsProperties(string status = null, string target = null, DateTimeOffset? targetFailedOn = null, DateTimeOffset? targetCompletedOn = null, ExperimentExecutionActionTargetDetailsError error = null)
        {
            return new ExperimentExecutionActionTargetDetailsProperties(status, target, targetFailedOn, targetCompletedOn, error);
        }

        /// <summary> Initializes a new instance of ExperimentExecutionActionTargetDetailsError. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <returns> A new <see cref="Models.ExperimentExecutionActionTargetDetailsError"/> instance for mocking. </returns>
        public static ExperimentExecutionActionTargetDetailsError ExperimentExecutionActionTargetDetailsError(string code = null, string message = null)
        {
            return new ExperimentExecutionActionTargetDetailsError(code, message);
        }

        /// <summary> Initializes a new instance of TargetTypeData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Location of the Target Type resource. </param>
        /// <param name="displayName"> Localized string of the display name. </param>
        /// <param name="description"> Localized string of the description. </param>
        /// <param name="propertiesSchema"> URL to retrieve JSON schema of the Target Type properties. </param>
        /// <param name="resourceTypes"> List of resource types this Target Type can extend. </param>
        /// <returns> A new <see cref="Chaos.TargetTypeData"/> instance for mocking. </returns>
        public static TargetTypeData TargetTypeData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, AzureLocation? location = null, string displayName = null, string description = null, string propertiesSchema = null, IEnumerable<string> resourceTypes = null)
        {
            resourceTypes ??= new List<string>();

            return new TargetTypeData(id, name, resourceType, systemData, location, displayName, description, propertiesSchema, resourceTypes?.ToList());
        }

        /// <summary> Initializes a new instance of TargetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Location of the target resource. </param>
        /// <param name="properties"> The properties of the target resource. </param>
        /// <returns> A new <see cref="Chaos.TargetData"/> instance for mocking. </returns>
        public static TargetData TargetData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, AzureLocation? location = null, IDictionary<string, BinaryData> properties = null)
        {
            properties ??= new Dictionary<string, BinaryData>();

            return new TargetData(id, name, resourceType, systemData, location, properties);
        }
    }
}
