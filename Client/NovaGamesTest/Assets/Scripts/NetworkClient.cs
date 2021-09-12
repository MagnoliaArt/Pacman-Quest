using UnityEngine;
using System;
using System.Net.Sockets;
using ProtoBuf;
using System.IO;
using Google.Protobuf;
using System.Collections.Generic;
using Com.Test.Pacman;

public class NetworkClient : MonoBehaviour
{
    private static TcpClient socket;
    private NetworkStream stream;
    public string ip = "127.0.0.1";
    public int port = 6666;

    private int dataBufSize = 4096;
    private byte[] receiveBuffer;

    private Controller ct;
    private LevelConstruct level_construct;
    private void Start()
    {
        ct = GetComponent<Controller>();
        level_construct = GetComponent<LevelConstruct>();
        Connect();
    }

    public void Connect()
    {
        socket = new TcpClient()
        {
            ReceiveBufferSize = dataBufSize,
            SendBufferSize = dataBufSize
        };

        receiveBuffer = new byte[dataBufSize];

        socket.BeginConnect(ip, port, ConnectCallback, socket);
    }
    public void Send(int input)
    {
        try
        {
            Serializer.Serialize(stream, new MessageSend(input));

            //byte[] b = Encode();
            //stream.WriteAsync(b, 0, b.Length);
        }
        catch (Exception e)
        {
            Debug.Log("Не отправилось" + e);
        }
    }
    private void ConnectCallback(IAsyncResult _result)
    {
        socket.EndConnect(_result);
        if (!socket.Connected)
        {
            return;
        }
        stream = socket.GetStream();
        stream.BeginRead(receiveBuffer, 0, dataBufSize, ReceiveCallback, null);
    }
    private void ReceiveCallback(IAsyncResult _result)
    {
        int _byteLength = stream.EndRead(_result);

        if (_byteLength < 0)
        {
            return;
        }

        byte[] _data = new byte[_byteLength];
        Array.Copy(receiveBuffer, _data, _byteLength);

        stream.BeginRead(receiveBuffer, 0, dataBufSize, ReceiveCallback, null);

        List<byte> bytes = new List<byte>();
        for (int i = 0; i < _byteLength; i++)
        {
            bytes.Add(receiveBuffer[i]);
        }
        var result = Decode(bytes.ToArray()) as Response;

        if (result.SpeedMsg > 0)
        {
            ct.TransfromPacman(result.PositionMsg[0], result.PositionMsg[1], result.SpeedMsg);
        }
        else
        {
            level_construct.Construct(result.WallMsgX, result.WallMsgY);
            ct.TransfromPacman(result.PositionMsg[0], result.PositionMsg[1], 6);
        }
    }
    //public static byte[] Encode(IMessage msg)
    //{
    //    using (MemoryStream rawOutput = new MemoryStream())
    //    {
    //        CodedOutputStream output = new CodedOutputStream(rawOutput);
    //        output.WriteMessage(msg);
    //        output.Flush();
    //        byte[] result = rawOutput.ToArray();

    //        return result;
    //    }
    //}
    public static IMessage Decode(byte[] msg)
    {
        IMessage message = null;
        try
        {
            message = Response.Parser.ParseFrom(msg);
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }

        return message;
    }
    public void Disconnect()
    {
        Debug.Log("Disconnect");
        if (stream != null)
        {
            stream.Close();           
            socket.Close();       
        }
    }
    public void OnApplicationQuit()
    {
        Disconnect();
    }
}
