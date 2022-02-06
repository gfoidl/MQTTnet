// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace MQTTnet.Packets
{
    public sealed class MqttPubRecPacketProperties
    {
        public string ReasonString { get; set; }

        public List<MqttUserProperty> UserProperties { get; } = new List<MqttUserProperty>();
    }
}
