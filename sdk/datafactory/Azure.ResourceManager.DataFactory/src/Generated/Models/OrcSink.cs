// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity ORC sink. </summary>
    public partial class OrcSink : CopySink
    {
        /// <summary> Initializes a new instance of OrcSink. </summary>
        public OrcSink()
        {
            CopySinkType = "OrcSink";
        }

        /// <summary> Initializes a new instance of OrcSink. </summary>
        /// <param name="copySinkType"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="storeSettings">
        /// ORC store settings.
        /// Please note <see cref="StoreWriteSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureBlobFSWriteSettings"/>, <see cref="AzureBlobStorageWriteSettings"/>, <see cref="AzureDataLakeStoreWriteSettings"/>, <see cref="AzureFileStorageWriteSettings"/>, <see cref="FileServerWriteSettings"/>, <see cref="LakeHouseWriteSettings"/> and <see cref="SftpWriteSettings"/>.
        /// </param>
        /// <param name="formatSettings"> ORC format settings. </param>
        internal OrcSink(string copySinkType, DataFactoryElement<int> writeBatchSize, DataFactoryElement<string> writeBatchTimeout, DataFactoryElement<int> sinkRetryCount, DataFactoryElement<string> sinkRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, StoreWriteSettings storeSettings, OrcWriteSettings formatSettings) : base(copySinkType, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            StoreSettings = storeSettings;
            FormatSettings = formatSettings;
            CopySinkType = copySinkType ?? "OrcSink";
        }

        /// <summary>
        /// ORC store settings.
        /// Please note <see cref="StoreWriteSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureBlobFSWriteSettings"/>, <see cref="AzureBlobStorageWriteSettings"/>, <see cref="AzureDataLakeStoreWriteSettings"/>, <see cref="AzureFileStorageWriteSettings"/>, <see cref="FileServerWriteSettings"/>, <see cref="LakeHouseWriteSettings"/> and <see cref="SftpWriteSettings"/>.
        /// </summary>
        public StoreWriteSettings StoreSettings { get; set; }
        /// <summary> ORC format settings. </summary>
        public OrcWriteSettings FormatSettings { get; set; }
    }
}
