// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> Describes a worker selector that will be attached to the job. </summary>
    public partial class StaticWorkerSelectorAttachment : WorkerSelectorAttachment
    {
        /// <summary> Initializes a new instance of StaticWorkerSelectorAttachment. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of WorkerSelectorAttachment. </param>
        /// <param name="workerSelector">
        /// Describes a condition that must be met against a set of labels for worker
        /// selection
        /// </param>
        internal StaticWorkerSelectorAttachment(string kind, RouterWorkerSelector workerSelector) : base(kind)
        {
            WorkerSelector = workerSelector;
        }

        /// <summary>
        /// Describes a condition that must be met against a set of labels for worker
        /// selection
        /// </summary>
        public RouterWorkerSelector WorkerSelector { get; }
    }
}
