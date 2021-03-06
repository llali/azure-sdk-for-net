// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.Automation;
using Microsoft.WindowsAzure.Management.Automation.Models;

namespace Microsoft.WindowsAzure.Management.Automation
{
    public static partial class RunbookDraftOperationsExtensions
    {
        /// <summary>
        /// Retrieve the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the publish runbook operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResultResponse BeginPublish(this IRunbookDraftOperations operations, string automationAccount, RunbookDraftPublishParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookDraftOperations)s).BeginPublishAsync(automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the publish runbook operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResultResponse> BeginPublishAsync(this IRunbookDraftOperations operations, string automationAccount, RunbookDraftPublishParameters parameters)
        {
            return operations.BeginPublishAsync(automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Updates the runbook draft with runbookStream as its content.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The runbook draft update parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResultResponse BeginUpdate(this IRunbookDraftOperations operations, string automationAccount, RunbookDraftUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookDraftOperations)s).BeginUpdateAsync(automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates the runbook draft with runbookStream as its content.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The runbook draft update parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResultResponse> BeginUpdateAsync(this IRunbookDraftOperations operations, string automationAccount, RunbookDraftUpdateParameters parameters)
        {
            return operations.BeginUpdateAsync(automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the content of runbook draft identified by runbook name.
        /// (see http://aka.ms/azureautomationsdk/runbookdraftoperations for
        /// more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the runbook content operation.
        /// </returns>
        public static RunbookContentResponse Content(this IRunbookDraftOperations operations, string automationAccount, string runbookName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookDraftOperations)s).ContentAsync(automationAccount, runbookName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the content of runbook draft identified by runbook name.
        /// (see http://aka.ms/azureautomationsdk/runbookdraftoperations for
        /// more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the runbook content operation.
        /// </returns>
        public static Task<RunbookContentResponse> ContentAsync(this IRunbookDraftOperations operations, string automationAccount, string runbookName)
        {
            return operations.ContentAsync(automationAccount, runbookName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the runbook draft identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the get runbook draft operation.
        /// </returns>
        public static RunbookDraftGetResponse Get(this IRunbookDraftOperations operations, string automationAccount, string runbookName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookDraftOperations)s).GetAsync(automationAccount, runbookName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the runbook draft identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the get runbook draft operation.
        /// </returns>
        public static Task<RunbookDraftGetResponse> GetAsync(this IRunbookDraftOperations operations, string automationAccount, string runbookName)
        {
            return operations.GetAsync(automationAccount, runbookName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the publish runbook operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResultResponse Publish(this IRunbookDraftOperations operations, string automationAccount, RunbookDraftPublishParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookDraftOperations)s).PublishAsync(automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the publish runbook operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResultResponse> PublishAsync(this IRunbookDraftOperations operations, string automationAccount, RunbookDraftPublishParameters parameters)
        {
            return operations.PublishAsync(automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the undoedit runbook operation.
        /// </returns>
        public static RunbookDraftUndoEditResponse UndoEdit(this IRunbookDraftOperations operations, string automationAccount, string runbookName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookDraftOperations)s).UndoEditAsync(automationAccount, runbookName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the undoedit runbook operation.
        /// </returns>
        public static Task<RunbookDraftUndoEditResponse> UndoEditAsync(this IRunbookDraftOperations operations, string automationAccount, string runbookName)
        {
            return operations.UndoEditAsync(automationAccount, runbookName, CancellationToken.None);
        }
        
        /// <summary>
        /// Updates the runbook draft with runbookStream as its content.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The runbook draft update parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResultResponse Update(this IRunbookDraftOperations operations, string automationAccount, RunbookDraftUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookDraftOperations)s).UpdateAsync(automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates the runbook draft with runbookStream as its content.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The runbook draft update parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResultResponse> UpdateAsync(this IRunbookDraftOperations operations, string automationAccount, RunbookDraftUpdateParameters parameters)
        {
            return operations.UpdateAsync(automationAccount, parameters, CancellationToken.None);
        }
    }
}
