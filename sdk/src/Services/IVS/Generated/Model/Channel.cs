/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IVS.Model
{
    /// <summary>
    /// Object specifying a channel.
    /// </summary>
    public partial class Channel
    {
        private string _arn;
        private string _ingestEndpoint;
        private ChannelLatencyMode _latencyMode;
        private string _name;
        private string _playbackUrl;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private ChannelType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Channel ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property IngestEndpoint. 
        /// <para>
        /// Channel ingest endpoint, part of the definition of an ingest server, used when you
        /// set up streaming software.
        /// </para>
        /// </summary>
        public string IngestEndpoint
        {
            get { return this._ingestEndpoint; }
            set { this._ingestEndpoint = value; }
        }

        // Check to see if IngestEndpoint property is set
        internal bool IsSetIngestEndpoint()
        {
            return this._ingestEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property LatencyMode. 
        /// <para>
        /// Channel latency mode. Default: <code>LOW</code>.
        /// </para>
        /// </summary>
        public ChannelLatencyMode LatencyMode
        {
            get { return this._latencyMode; }
            set { this._latencyMode = value; }
        }

        // Check to see if LatencyMode property is set
        internal bool IsSetLatencyMode()
        {
            return this._latencyMode != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Channel name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PlaybackUrl. 
        /// <para>
        /// Channel playback URL.
        /// </para>
        /// </summary>
        public string PlaybackUrl
        {
            get { return this._playbackUrl; }
            set { this._playbackUrl = value; }
        }

        // Check to see if PlaybackUrl property is set
        internal bool IsSetPlaybackUrl()
        {
            return this._playbackUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Array of 1-50 maps, each of the form <code>string:string (key:value)</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Channel type, which determines the allowable resolution and bitrate. STANDARD: The
        /// stream is transcoded; resolution (width, in landscape orientation) can be up to 1080p
        /// or the input source resolution, whichever is lower; and bitrate can be up to 8.5 Mbps.
        /// BASIC: The stream is transfixed; resolution can be up to 480p; and bitrate can be
        /// up to 1.5 Mbps. Default STANDARD.
        /// </para>
        /// </summary>
        public ChannelType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}