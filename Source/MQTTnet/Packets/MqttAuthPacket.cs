// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using MQTTnet.Protocol;

namespace MQTTnet.Packets
{
    /// <summary>
    /// Added in MQTTv5.0.0.
    /// </summary>
    public sealed class MqttAuthPacket : MqttBasePacket
    {
        public MqttAuthenticateReasonCode ReasonCode { get; set; }

        public MqttAuthPacketProperties Properties { get; } = new MqttAuthPacketProperties();
    }
}
