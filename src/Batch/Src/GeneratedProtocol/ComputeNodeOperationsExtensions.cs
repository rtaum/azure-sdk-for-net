// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ComputeNodeOperations.
    /// </summary>
    public static partial class ComputeNodeOperationsExtensions
    {
            /// <summary>
            /// Adds a user account to the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the machine on which you want to create a user account.
            /// </param>
            /// <param name='user'>
            /// Specifies the user account to be created.
            /// </param>
            /// <param name='computeNodeAddUserOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static ComputeNodeAddUserHeaders AddUser(this IComputeNodeOperations operations, string poolId, string nodeId, ComputeNodeUser user, ComputeNodeAddUserOptions computeNodeAddUserOptions = default(ComputeNodeAddUserOptions))
            {
                return Task.Factory.StartNew(s => ((IComputeNodeOperations)s).AddUserAsync(poolId, nodeId, user, computeNodeAddUserOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a user account to the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the machine on which you want to create a user account.
            /// </param>
            /// <param name='user'>
            /// Specifies the user account to be created.
            /// </param>
            /// <param name='computeNodeAddUserOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ComputeNodeAddUserHeaders> AddUserAsync(this IComputeNodeOperations operations, string poolId, string nodeId, ComputeNodeUser user, ComputeNodeAddUserOptions computeNodeAddUserOptions = default(ComputeNodeAddUserOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddUserWithHttpMessagesAsync(poolId, nodeId, user, computeNodeAddUserOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Deletes a user account from the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the machine on which you want to delete a user account.
            /// </param>
            /// <param name='userName'>
            /// The name of the user account to delete.
            /// </param>
            /// <param name='computeNodeDeleteUserOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static ComputeNodeDeleteUserHeaders DeleteUser(this IComputeNodeOperations operations, string poolId, string nodeId, string userName, ComputeNodeDeleteUserOptions computeNodeDeleteUserOptions = default(ComputeNodeDeleteUserOptions))
            {
                return Task.Factory.StartNew(s => ((IComputeNodeOperations)s).DeleteUserAsync(poolId, nodeId, userName, computeNodeDeleteUserOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a user account from the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the machine on which you want to delete a user account.
            /// </param>
            /// <param name='userName'>
            /// The name of the user account to delete.
            /// </param>
            /// <param name='computeNodeDeleteUserOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ComputeNodeDeleteUserHeaders> DeleteUserAsync(this IComputeNodeOperations operations, string poolId, string nodeId, string userName, ComputeNodeDeleteUserOptions computeNodeDeleteUserOptions = default(ComputeNodeDeleteUserOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteUserWithHttpMessagesAsync(poolId, nodeId, userName, computeNodeDeleteUserOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Updates the password or expiration time of a user account on the specified
            /// compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the machine on which you want to update a user account.
            /// </param>
            /// <param name='userName'>
            /// The name of the user account to update.
            /// </param>
            /// <param name='nodeUpdateUserParameter'>
            /// The parameters for the request.
            /// </param>
            /// <param name='computeNodeUpdateUserOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static ComputeNodeUpdateUserHeaders UpdateUser(this IComputeNodeOperations operations, string poolId, string nodeId, string userName, NodeUpdateUserParameter nodeUpdateUserParameter, ComputeNodeUpdateUserOptions computeNodeUpdateUserOptions = default(ComputeNodeUpdateUserOptions))
            {
                return Task.Factory.StartNew(s => ((IComputeNodeOperations)s).UpdateUserAsync(poolId, nodeId, userName, nodeUpdateUserParameter, computeNodeUpdateUserOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the password or expiration time of a user account on the specified
            /// compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the machine on which you want to update a user account.
            /// </param>
            /// <param name='userName'>
            /// The name of the user account to update.
            /// </param>
            /// <param name='nodeUpdateUserParameter'>
            /// The parameters for the request.
            /// </param>
            /// <param name='computeNodeUpdateUserOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ComputeNodeUpdateUserHeaders> UpdateUserAsync(this IComputeNodeOperations operations, string poolId, string nodeId, string userName, NodeUpdateUserParameter nodeUpdateUserParameter, ComputeNodeUpdateUserOptions computeNodeUpdateUserOptions = default(ComputeNodeUpdateUserOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateUserWithHttpMessagesAsync(poolId, nodeId, userName, nodeUpdateUserParameter, computeNodeUpdateUserOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets information about the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the compute node that you want to get information about.
            /// </param>
            /// <param name='computeNodeGetOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static ComputeNode Get(this IComputeNodeOperations operations, string poolId, string nodeId, ComputeNodeGetOptions computeNodeGetOptions = default(ComputeNodeGetOptions))
            {
                return Task.Factory.StartNew(s => ((IComputeNodeOperations)s).GetAsync(poolId, nodeId, computeNodeGetOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the compute node that you want to get information about.
            /// </param>
            /// <param name='computeNodeGetOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ComputeNode> GetAsync(this IComputeNodeOperations operations, string poolId, string nodeId, ComputeNodeGetOptions computeNodeGetOptions = default(ComputeNodeGetOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(poolId, nodeId, computeNodeGetOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Restarts the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the compute node that you want to restart.
            /// </param>
            /// <param name='nodeRebootOption'>
            /// Sets when to reboot the compute node and what to do with currently running
            /// tasks. The default value is requeue. Possible values include: 'requeue',
            /// 'terminate', 'taskcompletion', 'retaineddata'
            /// </param>
            /// <param name='computeNodeRebootOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static ComputeNodeRebootHeaders Reboot(this IComputeNodeOperations operations, string poolId, string nodeId, ComputeNodeRebootOption? nodeRebootOption = default(ComputeNodeRebootOption?), ComputeNodeRebootOptions computeNodeRebootOptions = default(ComputeNodeRebootOptions))
            {
                return Task.Factory.StartNew(s => ((IComputeNodeOperations)s).RebootAsync(poolId, nodeId, nodeRebootOption, computeNodeRebootOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Restarts the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the compute node that you want to restart.
            /// </param>
            /// <param name='nodeRebootOption'>
            /// Sets when to reboot the compute node and what to do with currently running
            /// tasks. The default value is requeue. Possible values include: 'requeue',
            /// 'terminate', 'taskcompletion', 'retaineddata'
            /// </param>
            /// <param name='computeNodeRebootOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ComputeNodeRebootHeaders> RebootAsync(this IComputeNodeOperations operations, string poolId, string nodeId, ComputeNodeRebootOption? nodeRebootOption = default(ComputeNodeRebootOption?), ComputeNodeRebootOptions computeNodeRebootOptions = default(ComputeNodeRebootOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RebootWithHttpMessagesAsync(poolId, nodeId, nodeRebootOption, computeNodeRebootOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Reinstalls the operating system on the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the compute node that you want to restart.
            /// </param>
            /// <param name='nodeReimageOption'>
            /// Sets when to reimage the compute node and what to do with currently
            /// running tasks. The default value is requeue. Possible values include:
            /// 'requeue', 'terminate', 'taskcompletion', 'retaineddata'
            /// </param>
            /// <param name='computeNodeReimageOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static ComputeNodeReimageHeaders Reimage(this IComputeNodeOperations operations, string poolId, string nodeId, ComputeNodeReimageOption? nodeReimageOption = default(ComputeNodeReimageOption?), ComputeNodeReimageOptions computeNodeReimageOptions = default(ComputeNodeReimageOptions))
            {
                return Task.Factory.StartNew(s => ((IComputeNodeOperations)s).ReimageAsync(poolId, nodeId, nodeReimageOption, computeNodeReimageOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Reinstalls the operating system on the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the compute node that you want to restart.
            /// </param>
            /// <param name='nodeReimageOption'>
            /// Sets when to reimage the compute node and what to do with currently
            /// running tasks. The default value is requeue. Possible values include:
            /// 'requeue', 'terminate', 'taskcompletion', 'retaineddata'
            /// </param>
            /// <param name='computeNodeReimageOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ComputeNodeReimageHeaders> ReimageAsync(this IComputeNodeOperations operations, string poolId, string nodeId, ComputeNodeReimageOption? nodeReimageOption = default(ComputeNodeReimageOption?), ComputeNodeReimageOptions computeNodeReimageOptions = default(ComputeNodeReimageOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ReimageWithHttpMessagesAsync(poolId, nodeId, nodeReimageOption, computeNodeReimageOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Disable task scheduling of the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the compute node that you want to disable task scheduling.
            /// </param>
            /// <param name='nodeDisableSchedulingOption'>
            /// Gets or sets what to do with currently running tasks when disable task
            /// scheduling on the compute node. The default value is requeue. Possible
            /// values include: 'requeue', 'terminate', 'taskcompletion'
            /// </param>
            /// <param name='computeNodeDisableSchedulingOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static ComputeNodeDisableSchedulingHeaders DisableScheduling(this IComputeNodeOperations operations, string poolId, string nodeId, DisableComputeNodeSchedulingOption? nodeDisableSchedulingOption = default(DisableComputeNodeSchedulingOption?), ComputeNodeDisableSchedulingOptions computeNodeDisableSchedulingOptions = default(ComputeNodeDisableSchedulingOptions))
            {
                return Task.Factory.StartNew(s => ((IComputeNodeOperations)s).DisableSchedulingAsync(poolId, nodeId, nodeDisableSchedulingOption, computeNodeDisableSchedulingOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Disable task scheduling of the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the compute node that you want to disable task scheduling.
            /// </param>
            /// <param name='nodeDisableSchedulingOption'>
            /// Gets or sets what to do with currently running tasks when disable task
            /// scheduling on the compute node. The default value is requeue. Possible
            /// values include: 'requeue', 'terminate', 'taskcompletion'
            /// </param>
            /// <param name='computeNodeDisableSchedulingOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ComputeNodeDisableSchedulingHeaders> DisableSchedulingAsync(this IComputeNodeOperations operations, string poolId, string nodeId, DisableComputeNodeSchedulingOption? nodeDisableSchedulingOption = default(DisableComputeNodeSchedulingOption?), ComputeNodeDisableSchedulingOptions computeNodeDisableSchedulingOptions = default(ComputeNodeDisableSchedulingOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DisableSchedulingWithHttpMessagesAsync(poolId, nodeId, nodeDisableSchedulingOption, computeNodeDisableSchedulingOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Enable task scheduling of the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the compute node that you want to enable task scheduling.
            /// </param>
            /// <param name='computeNodeEnableSchedulingOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static ComputeNodeEnableSchedulingHeaders EnableScheduling(this IComputeNodeOperations operations, string poolId, string nodeId, ComputeNodeEnableSchedulingOptions computeNodeEnableSchedulingOptions = default(ComputeNodeEnableSchedulingOptions))
            {
                return Task.Factory.StartNew(s => ((IComputeNodeOperations)s).EnableSchedulingAsync(poolId, nodeId, computeNodeEnableSchedulingOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enable task scheduling of the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the compute node that you want to enable task scheduling.
            /// </param>
            /// <param name='computeNodeEnableSchedulingOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ComputeNodeEnableSchedulingHeaders> EnableSchedulingAsync(this IComputeNodeOperations operations, string poolId, string nodeId, ComputeNodeEnableSchedulingOptions computeNodeEnableSchedulingOptions = default(ComputeNodeEnableSchedulingOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EnableSchedulingWithHttpMessagesAsync(poolId, nodeId, computeNodeEnableSchedulingOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets the settings required for remote login to a compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the compute node for which to obtain the remote login settings.
            /// </param>
            /// <param name='computeNodeGetRemoteLoginSettingsOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static ComputeNodeGetRemoteLoginSettingsResult GetRemoteLoginSettings(this IComputeNodeOperations operations, string poolId, string nodeId, ComputeNodeGetRemoteLoginSettingsOptions computeNodeGetRemoteLoginSettingsOptions = default(ComputeNodeGetRemoteLoginSettingsOptions))
            {
                return Task.Factory.StartNew(s => ((IComputeNodeOperations)s).GetRemoteLoginSettingsAsync(poolId, nodeId, computeNodeGetRemoteLoginSettingsOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the settings required for remote login to a compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the compute node for which to obtain the remote login settings.
            /// </param>
            /// <param name='computeNodeGetRemoteLoginSettingsOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ComputeNodeGetRemoteLoginSettingsResult> GetRemoteLoginSettingsAsync(this IComputeNodeOperations operations, string poolId, string nodeId, ComputeNodeGetRemoteLoginSettingsOptions computeNodeGetRemoteLoginSettingsOptions = default(ComputeNodeGetRemoteLoginSettingsOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRemoteLoginSettingsWithHttpMessagesAsync(poolId, nodeId, computeNodeGetRemoteLoginSettingsOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the Remote Desktop Protocol file for the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the compute node for which you want to get the Remote Desktop
            /// Protocol file.
            /// </param>
            /// <param name='computeNodeGetRemoteDesktopOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static System.IO.Stream GetRemoteDesktop(this IComputeNodeOperations operations, string poolId, string nodeId, ComputeNodeGetRemoteDesktopOptions computeNodeGetRemoteDesktopOptions = default(ComputeNodeGetRemoteDesktopOptions))
            {
                return Task.Factory.StartNew(s => ((IComputeNodeOperations)s).GetRemoteDesktopAsync(poolId, nodeId, computeNodeGetRemoteDesktopOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Remote Desktop Protocol file for the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The id of the compute node for which you want to get the Remote Desktop
            /// Protocol file.
            /// </param>
            /// <param name='computeNodeGetRemoteDesktopOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.IO.Stream> GetRemoteDesktopAsync(this IComputeNodeOperations operations, string poolId, string nodeId, ComputeNodeGetRemoteDesktopOptions computeNodeGetRemoteDesktopOptions = default(ComputeNodeGetRemoteDesktopOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetRemoteDesktopWithHttpMessagesAsync(poolId, nodeId, computeNodeGetRemoteDesktopOptions, null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

            /// <summary>
            /// Lists the compute nodes in the specified pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool from which you want to list nodes.
            /// </param>
            /// <param name='computeNodeListOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IPage<ComputeNode> List(this IComputeNodeOperations operations, string poolId, ComputeNodeListOptions computeNodeListOptions = default(ComputeNodeListOptions))
            {
                return Task.Factory.StartNew(s => ((IComputeNodeOperations)s).ListAsync(poolId, computeNodeListOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the compute nodes in the specified pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The id of the pool from which you want to list nodes.
            /// </param>
            /// <param name='computeNodeListOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ComputeNode>> ListAsync(this IComputeNodeOperations operations, string poolId, ComputeNodeListOptions computeNodeListOptions = default(ComputeNodeListOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(poolId, computeNodeListOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the compute nodes in the specified pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='computeNodeListNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IPage<ComputeNode> ListNext(this IComputeNodeOperations operations, string nextPageLink, ComputeNodeListNextOptions computeNodeListNextOptions = default(ComputeNodeListNextOptions))
            {
                return Task.Factory.StartNew(s => ((IComputeNodeOperations)s).ListNextAsync(nextPageLink, computeNodeListNextOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the compute nodes in the specified pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='computeNodeListNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ComputeNode>> ListNextAsync(this IComputeNodeOperations operations, string nextPageLink, ComputeNodeListNextOptions computeNodeListNextOptions = default(ComputeNodeListNextOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, computeNodeListNextOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}