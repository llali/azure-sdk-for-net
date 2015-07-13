namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Azure;

    /// <summary>
    /// </summary>
    public partial class VirtualMachineSizeListResult
    {
        /// <summary>
        /// Gets or sets the list of virtual machine sizes.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<VirtualMachineSize> Value { get; set; }

    }
}