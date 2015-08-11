// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Class containing Routing in production experiments
    /// </summary>
    public partial class Experiments
    {
        /// <summary>
        /// List of {Microsoft.Web.Hosting.Administration.RampUpRule} objects.
        /// </summary>
        [JsonProperty(PropertyName = "rampUpRules")]
        public IList<RampUpRule> RampUpRules { get; set; }

    }
}
