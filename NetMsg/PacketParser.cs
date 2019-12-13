using System;
using System.Collections.Generic;
using System.Text;

namespace LockStepFrameWork.NetMsg
{
    public class Packet
    {
        public MsgType opcode;
        public BaseMsg msg;

        public Packet(MsgType opcode, BaseMsg msg)
        {
            this.opcode = opcode;
            this.msg = msg;
        }
    }

    class PacketParser
    {

        public static Packet DeserializeFrom(byte[] buf)
        {
            if(buf.Length < 2)
            {
                return null;
            }
            MsgType opcode = (MsgType)buf[0];
            byte[] data = new byte[buf.Length - 1];
            Array.Copy(buf, 1, data, 0, buf.Length - 1);

            BaseMsg msg = null;
            switch (opcode)
            {
                case MsgType.S2C_Ping: msg = BaseFormater.FromByte<Msg_S2C_Ping>(data); break;
                case MsgType.C2S_Ping: msg = BaseFormater.FromByte<Msg_C2S_Ping>(data); break;
                default: break;
            }

            return new Packet(opcode, msg);
        }

        public static byte[] SerializeToByteArray(BaseMsg msg)
        {
            return msg.ToBytes();
        }
    }
}
