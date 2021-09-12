using ProtoBuf;
using UnityEngine;

[ProtoContract]
public class MessageSend
{
    [ProtoMember(1)]
    public int InputIndex;
    [ProtoMember(2)]
    public int[] CurrentPosition;

    public MessageSend(int InputIndex)
    {
        this.InputIndex = InputIndex;
    }
}