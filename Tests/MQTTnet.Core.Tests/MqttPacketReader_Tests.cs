// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//using System.IO;
//using System.Threading;
//using System.Threading.Tasks;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MQTTnet.Formatter;
//using MQTTnet.Internal;

//namespace MQTTnet.Tests
//{
//    [TestClass]
//    public class MqttPacketReader_Tests
//    {
//        [TestMethod]
//        public async Task MqttPacketReader_EmptyStream()
//        {
//            var fixedHeader = new byte[2];
//            var reader = new MqttPacketReader(new TestMqttChannel(new MemoryStream()));
//            var readResult = await reader.ReadFixedHeaderAsync(fixedHeader, CancellationToken.None);

//            Assert.IsTrue(readResult.ConnectionClosed);
//        }
//    }
//}
// TODO: Fix
