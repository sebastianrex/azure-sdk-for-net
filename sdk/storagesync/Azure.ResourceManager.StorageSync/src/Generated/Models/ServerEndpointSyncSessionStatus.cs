// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Sync Session status object. </summary>
    public partial class ServerEndpointSyncSessionStatus
    {
        /// <summary> Initializes a new instance of ServerEndpointSyncSessionStatus. </summary>
        internal ServerEndpointSyncSessionStatus()
        {
            FilesNotSyncingErrors = new ChangeTrackingList<ServerEndpointFilesNotSyncingError>();
        }

        /// <summary> Initializes a new instance of ServerEndpointSyncSessionStatus. </summary>
        /// <param name="lastSyncResult"> Last sync result (HResult). </param>
        /// <param name="lastSyncTimestamp"> Last sync timestamp. </param>
        /// <param name="lastSyncSuccessTimestamp"> Last sync success timestamp. </param>
        /// <param name="lastSyncPerItemErrorCount"> Last sync per item error count. </param>
        /// <param name="persistentFilesNotSyncingCount"> Count of persistent files not syncing. </param>
        /// <param name="transientFilesNotSyncingCount"> Count of transient files not syncing. </param>
        /// <param name="filesNotSyncingErrors"> Array of per-item errors coming from the last sync session. </param>
        /// <param name="lastSyncMode"> Sync mode. </param>
        internal ServerEndpointSyncSessionStatus(int? lastSyncResult, DateTimeOffset? lastSyncTimestamp, DateTimeOffset? lastSyncSuccessTimestamp, long? lastSyncPerItemErrorCount, long? persistentFilesNotSyncingCount, long? transientFilesNotSyncingCount, IReadOnlyList<ServerEndpointFilesNotSyncingError> filesNotSyncingErrors, ServerEndpointSyncMode? lastSyncMode)
        {
            LastSyncResult = lastSyncResult;
            LastSyncTimestamp = lastSyncTimestamp;
            LastSyncSuccessTimestamp = lastSyncSuccessTimestamp;
            LastSyncPerItemErrorCount = lastSyncPerItemErrorCount;
            PersistentFilesNotSyncingCount = persistentFilesNotSyncingCount;
            TransientFilesNotSyncingCount = transientFilesNotSyncingCount;
            FilesNotSyncingErrors = filesNotSyncingErrors;
            LastSyncMode = lastSyncMode;
        }

        /// <summary> Last sync result (HResult). </summary>
        public int? LastSyncResult { get; }
        /// <summary> Last sync timestamp. </summary>
        public DateTimeOffset? LastSyncTimestamp { get; }
        /// <summary> Last sync success timestamp. </summary>
        public DateTimeOffset? LastSyncSuccessTimestamp { get; }
        /// <summary> Last sync per item error count. </summary>
        public long? LastSyncPerItemErrorCount { get; }
        /// <summary> Count of persistent files not syncing. </summary>
        public long? PersistentFilesNotSyncingCount { get; }
        /// <summary> Count of transient files not syncing. </summary>
        public long? TransientFilesNotSyncingCount { get; }
        /// <summary> Array of per-item errors coming from the last sync session. </summary>
        public IReadOnlyList<ServerEndpointFilesNotSyncingError> FilesNotSyncingErrors { get; }
        /// <summary> Sync mode. </summary>
        public ServerEndpointSyncMode? LastSyncMode { get; }
    }
}
