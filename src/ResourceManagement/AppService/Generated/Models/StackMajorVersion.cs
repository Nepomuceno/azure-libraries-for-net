// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Application stack major version.
    /// </summary>
    public partial class StackMajorVersion
    {
        /// <summary>
        /// Initializes a new instance of the StackMajorVersion class.
        /// </summary>
        public StackMajorVersion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StackMajorVersion class.
        /// </summary>
        /// <param name="displayVersion">Application stack major version
        /// (display only).</param>
        /// <param name="runtimeVersion">Application stack major version
        /// (runtime only).</param>
        /// <param name="isDefault">&lt;code&gt;true&lt;/code&gt; if this is
        /// the default major version; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="minorVersions">Minor versions associated with the
        /// major version.</param>
        /// <param name="applicationInsights">&lt;code&gt;true&lt;/code&gt; if
        /// this supports Application Insights; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        public StackMajorVersion(string displayVersion = default(string), string runtimeVersion = default(string), bool? isDefault = default(bool?), IList<StackMinorVersion> minorVersions = default(IList<StackMinorVersion>), bool? applicationInsights = default(bool?))
        {
            DisplayVersion = displayVersion;
            RuntimeVersion = runtimeVersion;
            IsDefault = isDefault;
            MinorVersions = minorVersions;
            ApplicationInsights = applicationInsights;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets application stack major version (display only).
        /// </summary>
        [JsonProperty(PropertyName = "displayVersion")]
        public string DisplayVersion { get; set; }

        /// <summary>
        /// Gets or sets application stack major version (runtime only).
        /// </summary>
        [JsonProperty(PropertyName = "runtimeVersion")]
        public string RuntimeVersion { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if this
        /// is the default major version; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "isDefault")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Gets or sets minor versions associated with the major version.
        /// </summary>
        [JsonProperty(PropertyName = "minorVersions")]
        public IList<StackMinorVersion> MinorVersions { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if this
        /// supports Application Insights; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "applicationInsights")]
        public bool? ApplicationInsights { get; set; }

    }
}
