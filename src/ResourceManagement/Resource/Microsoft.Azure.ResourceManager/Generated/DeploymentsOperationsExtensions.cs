// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Resources
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class DeploymentsOperationsExtensions
    {
            /// <summary>
            /// Begin deleting deployment.To determine whether the operation has finished
            /// processing the request, call GetLongRunningOperationStatus.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment to be deleted.
            /// </param>
            public static void Delete(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName)
            {
                Task.Factory.StartNew(s => ((IDeploymentsOperations)s).DeleteAsync(resourceGroupName, deploymentName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Begin deleting deployment.To determine whether the operation has finished
            /// processing the request, call GetLongRunningOperationStatus.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync( this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, deploymentName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Begin deleting deployment.To determine whether the operation has finished
            /// processing the request, call GetLongRunningOperationStatus.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment to be deleted.
            /// </param>
            public static void BeginDelete(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName)
            {
                Task.Factory.StartNew(s => ((IDeploymentsOperations)s).BeginDeleteAsync(resourceGroupName, deploymentName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Begin deleting deployment.To determine whether the operation has finished
            /// processing the request, call GetLongRunningOperationStatus.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync( this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, deploymentName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Checks whether deployment exists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to check. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            public static bool? CheckExistence(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName)
            {
                return Task.Factory.StartNew(s => ((IDeploymentsOperations)s).CheckExistenceAsync(resourceGroupName, deploymentName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks whether deployment exists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to check. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<bool?> CheckExistenceAsync( this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckExistenceWithHttpMessagesAsync(resourceGroupName, deploymentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a named template deployment using a template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters supplied to the operation.
            /// </param>
            public static DeploymentExtended CreateOrUpdate(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, Deployment parameters)
            {
                return Task.Factory.StartNew(s => ((IDeploymentsOperations)s).CreateOrUpdateAsync(resourceGroupName, deploymentName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a named template deployment using a template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters supplied to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeploymentExtended> CreateOrUpdateAsync( this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, Deployment parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, deploymentName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a named template deployment using a template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters supplied to the operation.
            /// </param>
            public static DeploymentExtended BeginCreateOrUpdate(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, Deployment parameters)
            {
                return Task.Factory.StartNew(s => ((IDeploymentsOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, deploymentName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a named template deployment using a template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters supplied to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeploymentExtended> BeginCreateOrUpdateAsync( this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, Deployment parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, deploymentName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a deployment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            public static DeploymentExtended Get(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName)
            {
                return Task.Factory.StartNew(s => ((IDeploymentsOperations)s).GetAsync(resourceGroupName, deploymentName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a deployment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeploymentExtended> GetAsync( this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, deploymentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancel a currently running template deployment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            public static void Cancel(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName)
            {
                Task.Factory.StartNew(s => ((IDeploymentsOperations)s).CancelAsync(resourceGroupName, deploymentName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancel a currently running template deployment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CancelAsync( this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.CancelWithHttpMessagesAsync(resourceGroupName, deploymentName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Validate a deployment template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='parameters'>
            /// Deployment to validate.
            /// </param>
            public static DeploymentValidateResult Validate(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, Deployment parameters)
            {
                return Task.Factory.StartNew(s => ((IDeploymentsOperations)s).ValidateAsync(resourceGroupName, deploymentName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Validate a deployment template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='parameters'>
            /// Deployment to validate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeploymentValidateResult> ValidateAsync( this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, Deployment parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ValidateWithHttpMessagesAsync(resourceGroupName, deploymentName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of deployments.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to filter by. The name is case insensitive.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<DeploymentExtended> List(this IDeploymentsOperations operations, string resourceGroupName, ODataQuery<DeploymentExtendedFilter> odataQuery = default(ODataQuery<DeploymentExtendedFilter>))
            {
                return Task.Factory.StartNew(s => ((IDeploymentsOperations)s).ListAsync(resourceGroupName, odataQuery), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of deployments.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to filter by. The name is case insensitive.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DeploymentExtended>> ListAsync( this IDeploymentsOperations operations, string resourceGroupName, ODataQuery<DeploymentExtendedFilter> odataQuery = default(ODataQuery<DeploymentExtendedFilter>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of deployments.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DeploymentExtended> ListNext(this IDeploymentsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IDeploymentsOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of deployments.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DeploymentExtended>> ListNextAsync( this IDeploymentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
