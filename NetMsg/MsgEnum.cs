using System;
using System.Collections.Generic;
using System.Text;

namespace LockStepFrameWork.NetMsg
{
    // 协议opcode
    public enum MsgType : ushort
    {
        ERROR,
        C2S_Ping,
        S2C_Ping,
    }
}
