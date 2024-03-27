﻿using System;

namespace RadishNet.Types.ServerToClientMessages
{
    [Serializable]
    public class ClientIdMessage : ServerToClientMessage<string>
    {
        public ClientIdMessage(string type, string payload) : base(type, payload)
        {
        }
    }
}
