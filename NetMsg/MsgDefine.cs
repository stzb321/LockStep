using LockStepFrameWork.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace LockStepFrameWork.NetMsg
{
    public interface ISerializable
    {
        void Serialize(Serializer writer);

        void Deserialize(Deserializer reader);
    }

    [System.Serializable]
    public class BaseFormater : ISerializable
    {
        public virtual void Deserialize(Deserializer reader)
        {
            
        }

        public virtual void Serialize(Serializer writer)
        {
            
        }

        public byte[] ToBytes()
        {
            var writer = new Serializer();
            Serialize(writer);
            var bytes = writer.CopyData();
            return bytes;
        }

        public void FromBytes(byte[] data)
        {
            var reader = new Deserializer(data);
            Deserialize(reader);
        }

        public static T FromByte<T>(byte[] data) where T : BaseFormater, new()
        {
            var msg = new T();
            msg.FromBytes(data);
            return msg;
        }
    }

    public class BaseMsg : BaseFormater
    {
        
    }

    public class Msg_C2S_Ping : BaseMsg
    {
        public int Tick;

        public override void Deserialize(Deserializer reader)
        {
            Tick = reader.ReadInt32();
        }

        public override void Serialize(Serializer writer)
        {
            writer.Write(Tick);
        }
    }

    public class Msg_S2C_Ping : BaseMsg
    {

    }
}
