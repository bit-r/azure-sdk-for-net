// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Collection of logs to be enabled or disabled for log analytics. </summary>
    public partial class ClusterLogAnalyticsApplicationLogs
    {
        /// <summary> Initializes a new instance of ClusterLogAnalyticsApplicationLogs. </summary>
        public ClusterLogAnalyticsApplicationLogs()
        {
        }

        /// <summary> Initializes a new instance of ClusterLogAnalyticsApplicationLogs. </summary>
        /// <param name="isStdOutEnabled"> True if stdout is enabled, otherwise false. </param>
        /// <param name="isStdErrorEnabled"> True if stderror is enabled, otherwise false. </param>
        internal ClusterLogAnalyticsApplicationLogs(bool? isStdOutEnabled, bool? isStdErrorEnabled)
        {
            IsStdOutEnabled = isStdOutEnabled;
            IsStdErrorEnabled = isStdErrorEnabled;
        }

        /// <summary> True if stdout is enabled, otherwise false. </summary>
        public bool? IsStdOutEnabled { get; set; }
        /// <summary> True if stderror is enabled, otherwise false. </summary>
        public bool? IsStdErrorEnabled { get; set; }
    }
}
