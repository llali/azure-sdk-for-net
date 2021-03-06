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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;

namespace Microsoft.Azure.Management.Resources.Models
{
    /// <summary>
    /// Parameters of move resources.
    /// </summary>
    public partial class ResourcesMoveInfo
    {
        private IList<string> _resources;
        
        /// <summary>
        /// Optional. Gets or sets the ids of the resources.
        /// </summary>
        public IList<string> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }
        
        private string _targetResourceGroup;
        
        /// <summary>
        /// Optional. The target resource group.
        /// </summary>
        public string TargetResourceGroup
        {
            get { return this._targetResourceGroup; }
            set { this._targetResourceGroup = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ResourcesMoveInfo class.
        /// </summary>
        public ResourcesMoveInfo()
        {
            this.Resources = new LazyList<string>();
        }
    }
}
