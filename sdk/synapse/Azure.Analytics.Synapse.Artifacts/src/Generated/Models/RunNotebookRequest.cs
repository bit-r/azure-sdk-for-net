// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Run notebook request. </summary>
    public partial class RunNotebookRequest
    {
        /// <summary> Initializes a new instance of RunNotebookRequest. </summary>
        public RunNotebookRequest()
        {
            Parameters = new ChangeTrackingDictionary<string, RunNotebookParameter>();
        }

        /// <summary> Notebook name. </summary>
        public string Notebook { get; set; }
        /// <summary> SparkPool name. </summary>
        public string SparkPool { get; set; }
        /// <summary> Session properties. </summary>
        public RunNotebookSparkSessionOptions SessionOptions { get; set; }
        /// <summary> Whether session should run till time to live after run completes. </summary>
        public bool? HonorSessionTimeToLive { get; set; }
        /// <summary> Run notebook parameters. </summary>
        public IDictionary<string, RunNotebookParameter> Parameters { get; }
    }
}
