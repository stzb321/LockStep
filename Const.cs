using System;
using System.Collections.Generic;
using System.Text;

namespace LockStepServer.LockStepFrameWork
{
    class Const
    {
        // 每秒逻辑帧次数
        public static readonly int Frame_Rate = 30;

        // 每秒逻辑帧长度
        public static readonly float Frame_Length = Frame_Rate / 1000f;
    }
}
