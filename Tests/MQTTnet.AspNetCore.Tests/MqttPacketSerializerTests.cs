// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using MQTTnet.Formatter;
using MQTTnet.Tests;

namespace MQTTnet.AspNetCore.Tests
{
    [TestClass]
    public class MqttPacketSerializerTestsWithSpanBasedReader : MqttPacketSerializer_Tests
    {
        protected override IMqttPacketBodyReader ReaderFactory(byte[] data)
        {
            var result = new SpanBasedMqttPacketBodyReader();
            result.SetBuffer(data);
            return result;
        }

        protected override IMqttPacketWriter WriterFactory()
        {
            return new SpanBasedMqttPacketWriter();
        }
    }
}
