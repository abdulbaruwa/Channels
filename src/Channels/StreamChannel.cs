﻿using System;
using System.IO;

namespace Channels
{
    internal class StreamChannel : IChannel
    {
        public StreamChannel(ChannelFactory factory, Stream stream)
        {
            Input = factory.MakeReadableChannel(stream);
            Output = factory.MakeWriteableChannel(stream);
        }

        public IReadableChannel Input { get; }

        public IWritableChannel Output { get; }

        public void Dispose()
        {
            // What do we dipose here? We don't own the stream
        }
    }
}