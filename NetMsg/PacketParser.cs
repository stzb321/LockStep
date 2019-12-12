using System;
using System.Collections.Generic;
using System.Text;

namespace LockStepFrameWork.NetMsg
{
    public class Packet
    {
        public byte[] Bytes;
        public ushort Opcode
        {
            get
            {
                return BitConverter.ToUInt16(Bytes, 0);
            }
            set{}
        }

        public Packet(ushort opcode)
        {
            Opcode = opcode;
        }
    }

    class PacketParser
    {
        public static Packet Parse(byte[] buf)
        {
            Packet packet = new Packet((ushort)MsgType.ERROR);
            ushort opcode = buf[0];
            packet.Opcode = opcode;
            byte[] data = new byte[buf.Length -1];
            Array.Copy(buf, 1, data, 0, buf.Length - 1);
            packet.Bytes = data;
            return packet;
        }
    }
}
