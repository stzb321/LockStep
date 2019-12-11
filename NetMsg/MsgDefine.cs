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
    }

    public class BaseMsg : BaseFormater
    {

    }

    public class PingMsg : BaseMsg
    {
        public int Tick;
    }
}
