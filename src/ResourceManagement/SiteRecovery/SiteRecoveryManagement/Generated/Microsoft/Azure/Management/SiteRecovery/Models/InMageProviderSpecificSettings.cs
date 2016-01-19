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
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// InMage provider specific protected item details
    /// </summary>
    public partial class InMageProviderSpecificSettings : ReplicationProviderSpecificSettings
    {
        private string _activeLocation;
        
        /// <summary>
        /// Optional. Indicates whether vm is active on azure or onPrem.
        /// </summary>
        public string ActiveLocation
        {
            get { return this._activeLocation; }
            set { this._activeLocation = value; }
        }
        
        private InMageAgentDetails _agentDetails;
        
        /// <summary>
        /// Optional. The agent details.
        /// </summary>
        public InMageAgentDetails AgentDetails
        {
            get { return this._agentDetails; }
            set { this._agentDetails = value; }
        }
        
        private double _compressedDataRateInMB;
        
        /// <summary>
        /// Optional. The compressed data change rate in MB.
        /// </summary>
        public double CompressedDataRateInMB
        {
            get { return this._compressedDataRateInMB; }
            set { this._compressedDataRateInMB = value; }
        }
        
        private IDictionary<string, DateTime> _consistencyPoints;
        
        /// <summary>
        /// Optional. The collection of Consistency points.
        /// </summary>
        public IDictionary<string, DateTime> ConsistencyPoints
        {
            get { return this._consistencyPoints; }
            set { this._consistencyPoints = value; }
        }
        
        private string _infrastructureVmId;
        
        /// <summary>
        /// Optional. Infrastructure VM Id.
        /// </summary>
        public string InfrastructureVmId
        {
            get { return this._infrastructureVmId; }
            set { this._infrastructureVmId = value; }
        }
        
        private string _ipAddress;
        
        /// <summary>
        /// Optional. The source IP address.
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }
        
        private System.DateTime? _lastHeartbeat;
        
        /// <summary>
        /// Optional. The last heartbeat received from the source server.
        /// </summary>
        public System.DateTime? LastHeartbeat
        {
            get { return this._lastHeartbeat; }
            set { this._lastHeartbeat = value; }
        }
        
        private string _masterTargetId;
        
        /// <summary>
        /// Optional. The master target Id.
        /// </summary>
        public string MasterTargetId
        {
            get { return this._masterTargetId; }
            set { this._masterTargetId = value; }
        }
        
        private string _multiVmGroupId;
        
        /// <summary>
        /// Optional. The multi vm group Id, if any.
        /// </summary>
        public string MultiVmGroupId
        {
            get { return this._multiVmGroupId; }
            set { this._multiVmGroupId = value; }
        }
        
        private string _multiVmGroupName;
        
        /// <summary>
        /// Optional. The multi vm group name, if any.
        /// </summary>
        public string MultiVmGroupName
        {
            get { return this._multiVmGroupName; }
            set { this._multiVmGroupName = value; }
        }
        
        private OSDiskDetails _osDetails;
        
        /// <summary>
        /// Optional. The details of the OS disk.
        /// </summary>
        public OSDiskDetails OsDetails
        {
            get { return this._osDetails; }
            set { this._osDetails = value; }
        }
        
        private string _processServerId;
        
        /// <summary>
        /// Optional. The process server Id.
        /// </summary>
        public string ProcessServerId
        {
            get { return this._processServerId; }
            set { this._processServerId = value; }
        }
        
        private IList<InMageProtectedVolumeDetails> _protectedVolumes;
        
        /// <summary>
        /// Optional. The list of protected volumes.
        /// </summary>
        public IList<InMageProtectedVolumeDetails> ProtectedVolumes
        {
            get { return this._protectedVolumes; }
            set { this._protectedVolumes = value; }
        }
        
        private string _protectionStage;
        
        /// <summary>
        /// Optional. The protection stage.
        /// </summary>
        public string ProtectionStage
        {
            get { return this._protectionStage; }
            set { this._protectionStage = value; }
        }
        
        private string _rebootAfterUpdateStatus;
        
        /// <summary>
        /// Optional. Indicates whether the source server requires a restart
        /// after update.
        /// </summary>
        public string RebootAfterUpdateStatus
        {
            get { return this._rebootAfterUpdateStatus; }
            set { this._rebootAfterUpdateStatus = value; }
        }
        
        private InitialReplicationDetails _resyncDetails;
        
        /// <summary>
        /// Optional. Resync details.
        /// </summary>
        public InitialReplicationDetails ResyncDetails
        {
            get { return this._resyncDetails; }
            set { this._resyncDetails = value; }
        }
        
        private System.DateTime? _retentionWindowEnd;
        
        /// <summary>
        /// Optional. The retention window end time.
        /// </summary>
        public System.DateTime? RetentionWindowEnd
        {
            get { return this._retentionWindowEnd; }
            set { this._retentionWindowEnd = value; }
        }
        
        private System.DateTime? _retentionWindowStart;
        
        /// <summary>
        /// Optional. The retention window start time.
        /// </summary>
        public System.DateTime? RetentionWindowStart
        {
            get { return this._retentionWindowStart; }
            set { this._retentionWindowStart = value; }
        }
        
        private long? _rpoInSeconds;
        
        /// <summary>
        /// Optional. The RPO in seconds.
        /// </summary>
        public long? RpoInSeconds
        {
            get { return this._rpoInSeconds; }
            set { this._rpoInSeconds = value; }
        }
        
        private int _sourceVmCPUCount;
        
        /// <summary>
        /// Optional. The source VM CPU count.
        /// </summary>
        public int SourceVmCPUCount
        {
            get { return this._sourceVmCPUCount; }
            set { this._sourceVmCPUCount = value; }
        }
        
        private int _sourceVmRAMSizeInMB;
        
        /// <summary>
        /// Optional. The RAM size of the VM on the primary side.
        /// </summary>
        public int SourceVmRAMSizeInMB
        {
            get { return this._sourceVmRAMSizeInMB; }
            set { this._sourceVmRAMSizeInMB = value; }
        }
        
        private double _uncompressedDataRateInMB;
        
        /// <summary>
        /// Optional. The uncompressed data change rate in MB.
        /// </summary>
        public double UncompressedDataRateInMB
        {
            get { return this._uncompressedDataRateInMB; }
            set { this._uncompressedDataRateInMB = value; }
        }
        
        private string _vCenterInfrastructureId;
        
        /// <summary>
        /// Optional. vCenter Infrastructure Id.
        /// </summary>
        public string VCenterInfrastructureId
        {
            get { return this._vCenterInfrastructureId; }
            set { this._vCenterInfrastructureId = value; }
        }
        
        private IList<VMNicDetails> _vMNics;
        
        /// <summary>
        /// Optional. Gets or sets the network details.
        /// </summary>
        public IList<VMNicDetails> VMNics
        {
            get { return this._vMNics; }
            set { this._vMNics = value; }
        }
        
        private string _volumeResized;
        
        /// <summary>
        /// Optional. Indicates whether any volume is resized for this VM.
        /// </summary>
        public string VolumeResized
        {
            get { return this._volumeResized; }
            set { this._volumeResized = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the InMageProviderSpecificSettings
        /// class.
        /// </summary>
        public InMageProviderSpecificSettings()
        {
            this.ConsistencyPoints = new LazyDictionary<string, DateTime>();
            this.ProtectedVolumes = new LazyList<InMageProtectedVolumeDetails>();
            this.VMNics = new LazyList<VMNicDetails>();
        }
    }
}
