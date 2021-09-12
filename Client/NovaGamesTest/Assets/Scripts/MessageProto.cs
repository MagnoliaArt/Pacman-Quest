// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MessageProto.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.Test.Pacman {

  /// <summary>Holder for reflection information generated from MessageProto.proto</summary>
  public static partial class MessageProtoReflection {

    #region Descriptor
    /// <summary>File descriptor for MessageProto.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageProtoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJNZXNzYWdlUHJvdG8ucHJvdG8SD2NvbS50ZXN0LnBhY21hbiJGCgdSZXF1",
            "ZXN0EhUKCGlucHV0TXNnGAEgASgFSACIAQESFwoPQ3VycmVudFBvc2l0aW9u",
            "GAIgAygFQgsKCV9pbnB1dE1zZyKnAQoIUmVzcG9uc2USGAoLcmVzcG9uc2VN",
            "c2cYASABKAVIAIgBARITCgtQb3NpdGlvbk1zZxgCIAMoBRIVCghTcGVlZE1z",
            "ZxgDIAEoAkgBiAEBEhQKDExldmVsU2l6ZU1zZxgEIAMoBRIQCghXYWxsTXNn",
            "WBgFIAMoBRIQCghXYWxsTXNnWRgGIAMoBUIOCgxfcmVzcG9uc2VNc2dCCwoJ",
            "X1NwZWVkTXNnYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Test.Pacman.Request), global::Com.Test.Pacman.Request.Parser, new[]{ "InputMsg", "CurrentPosition" }, new[]{ "InputMsg" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Test.Pacman.Response), global::Com.Test.Pacman.Response.Parser, new[]{ "ResponseMsg", "PositionMsg", "SpeedMsg", "LevelSizeMsg", "WallMsgX", "WallMsgY" }, new[]{ "ResponseMsg", "SpeedMsg" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Request : pb::IMessage<Request>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Request> _parser = new pb::MessageParser<Request>(() => new Request());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Request> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Test.Pacman.MessageProtoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Request() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Request(Request other) : this() {
      _hasBits0 = other._hasBits0;
      inputMsg_ = other.inputMsg_;
      currentPosition_ = other.currentPosition_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Request Clone() {
      return new Request(this);
    }

    /// <summary>Field number for the "inputMsg" field.</summary>
    public const int InputMsgFieldNumber = 1;
    private int inputMsg_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int InputMsg {
      get { if ((_hasBits0 & 1) != 0) { return inputMsg_; } else { return 0; } }
      set {
        _hasBits0 |= 1;
        inputMsg_ = value;
      }
    }
    /// <summary>Gets whether the "inputMsg" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasInputMsg {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "inputMsg" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearInputMsg() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "CurrentPosition" field.</summary>
    public const int CurrentPositionFieldNumber = 2;
    private static readonly pb::FieldCodec<int> _repeated_currentPosition_codec
        = pb::FieldCodec.ForInt32(18);
    private readonly pbc::RepeatedField<int> currentPosition_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> CurrentPosition {
      get { return currentPosition_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Request);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Request other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (InputMsg != other.InputMsg) return false;
      if(!currentPosition_.Equals(other.currentPosition_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasInputMsg) hash ^= InputMsg.GetHashCode();
      hash ^= currentPosition_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasInputMsg) {
        output.WriteRawTag(8);
        output.WriteInt32(InputMsg);
      }
      currentPosition_.WriteTo(output, _repeated_currentPosition_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasInputMsg) {
        output.WriteRawTag(8);
        output.WriteInt32(InputMsg);
      }
      currentPosition_.WriteTo(ref output, _repeated_currentPosition_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasInputMsg) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(InputMsg);
      }
      size += currentPosition_.CalculateSize(_repeated_currentPosition_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Request other) {
      if (other == null) {
        return;
      }
      if (other.HasInputMsg) {
        InputMsg = other.InputMsg;
      }
      currentPosition_.Add(other.currentPosition_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            InputMsg = input.ReadInt32();
            break;
          }
          case 18:
          case 16: {
            currentPosition_.AddEntriesFrom(input, _repeated_currentPosition_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            InputMsg = input.ReadInt32();
            break;
          }
          case 18:
          case 16: {
            currentPosition_.AddEntriesFrom(ref input, _repeated_currentPosition_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class Response : pb::IMessage<Response>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Response> _parser = new pb::MessageParser<Response>(() => new Response());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Response> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Test.Pacman.MessageProtoReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Response() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Response(Response other) : this() {
      _hasBits0 = other._hasBits0;
      responseMsg_ = other.responseMsg_;
      positionMsg_ = other.positionMsg_.Clone();
      speedMsg_ = other.speedMsg_;
      levelSizeMsg_ = other.levelSizeMsg_.Clone();
      wallMsgX_ = other.wallMsgX_.Clone();
      wallMsgY_ = other.wallMsgY_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Response Clone() {
      return new Response(this);
    }

    /// <summary>Field number for the "responseMsg" field.</summary>
    public const int ResponseMsgFieldNumber = 1;
    private int responseMsg_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ResponseMsg {
      get { if ((_hasBits0 & 1) != 0) { return responseMsg_; } else { return 0; } }
      set {
        _hasBits0 |= 1;
        responseMsg_ = value;
      }
    }
    /// <summary>Gets whether the "responseMsg" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasResponseMsg {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "responseMsg" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearResponseMsg() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "PositionMsg" field.</summary>
    public const int PositionMsgFieldNumber = 2;
    private static readonly pb::FieldCodec<int> _repeated_positionMsg_codec
        = pb::FieldCodec.ForInt32(18);
    private readonly pbc::RepeatedField<int> positionMsg_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> PositionMsg {
      get { return positionMsg_; }
    }

    /// <summary>Field number for the "SpeedMsg" field.</summary>
    public const int SpeedMsgFieldNumber = 3;
    private float speedMsg_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float SpeedMsg {
      get { if ((_hasBits0 & 2) != 0) { return speedMsg_; } else { return 0F; } }
      set {
        _hasBits0 |= 2;
        speedMsg_ = value;
      }
    }
    /// <summary>Gets whether the "SpeedMsg" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasSpeedMsg {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "SpeedMsg" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearSpeedMsg() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "LevelSizeMsg" field.</summary>
    public const int LevelSizeMsgFieldNumber = 4;
    private static readonly pb::FieldCodec<int> _repeated_levelSizeMsg_codec
        = pb::FieldCodec.ForInt32(34);
    private readonly pbc::RepeatedField<int> levelSizeMsg_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> LevelSizeMsg {
      get { return levelSizeMsg_; }
    }

    /// <summary>Field number for the "WallMsgX" field.</summary>
    public const int WallMsgXFieldNumber = 5;
    private static readonly pb::FieldCodec<int> _repeated_wallMsgX_codec
        = pb::FieldCodec.ForInt32(42);
    private readonly pbc::RepeatedField<int> wallMsgX_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> WallMsgX {
      get { return wallMsgX_; }
    }

    /// <summary>Field number for the "WallMsgY" field.</summary>
    public const int WallMsgYFieldNumber = 6;
    private static readonly pb::FieldCodec<int> _repeated_wallMsgY_codec
        = pb::FieldCodec.ForInt32(50);
    private readonly pbc::RepeatedField<int> wallMsgY_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> WallMsgY {
      get { return wallMsgY_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Response);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Response other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResponseMsg != other.ResponseMsg) return false;
      if(!positionMsg_.Equals(other.positionMsg_)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SpeedMsg, other.SpeedMsg)) return false;
      if(!levelSizeMsg_.Equals(other.levelSizeMsg_)) return false;
      if(!wallMsgX_.Equals(other.wallMsgX_)) return false;
      if(!wallMsgY_.Equals(other.wallMsgY_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasResponseMsg) hash ^= ResponseMsg.GetHashCode();
      hash ^= positionMsg_.GetHashCode();
      if (HasSpeedMsg) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SpeedMsg);
      hash ^= levelSizeMsg_.GetHashCode();
      hash ^= wallMsgX_.GetHashCode();
      hash ^= wallMsgY_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasResponseMsg) {
        output.WriteRawTag(8);
        output.WriteInt32(ResponseMsg);
      }
      positionMsg_.WriteTo(output, _repeated_positionMsg_codec);
      if (HasSpeedMsg) {
        output.WriteRawTag(29);
        output.WriteFloat(SpeedMsg);
      }
      levelSizeMsg_.WriteTo(output, _repeated_levelSizeMsg_codec);
      wallMsgX_.WriteTo(output, _repeated_wallMsgX_codec);
      wallMsgY_.WriteTo(output, _repeated_wallMsgY_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasResponseMsg) {
        output.WriteRawTag(8);
        output.WriteInt32(ResponseMsg);
      }
      positionMsg_.WriteTo(ref output, _repeated_positionMsg_codec);
      if (HasSpeedMsg) {
        output.WriteRawTag(29);
        output.WriteFloat(SpeedMsg);
      }
      levelSizeMsg_.WriteTo(ref output, _repeated_levelSizeMsg_codec);
      wallMsgX_.WriteTo(ref output, _repeated_wallMsgX_codec);
      wallMsgY_.WriteTo(ref output, _repeated_wallMsgY_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasResponseMsg) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ResponseMsg);
      }
      size += positionMsg_.CalculateSize(_repeated_positionMsg_codec);
      if (HasSpeedMsg) {
        size += 1 + 4;
      }
      size += levelSizeMsg_.CalculateSize(_repeated_levelSizeMsg_codec);
      size += wallMsgX_.CalculateSize(_repeated_wallMsgX_codec);
      size += wallMsgY_.CalculateSize(_repeated_wallMsgY_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Response other) {
      if (other == null) {
        return;
      }
      if (other.HasResponseMsg) {
        ResponseMsg = other.ResponseMsg;
      }
      positionMsg_.Add(other.positionMsg_);
      if (other.HasSpeedMsg) {
        SpeedMsg = other.SpeedMsg;
      }
      levelSizeMsg_.Add(other.levelSizeMsg_);
      wallMsgX_.Add(other.wallMsgX_);
      wallMsgY_.Add(other.wallMsgY_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ResponseMsg = input.ReadInt32();
            break;
          }
          case 18:
          case 16: {
            positionMsg_.AddEntriesFrom(input, _repeated_positionMsg_codec);
            break;
          }
          case 29: {
            SpeedMsg = input.ReadFloat();
            break;
          }
          case 34:
          case 32: {
            levelSizeMsg_.AddEntriesFrom(input, _repeated_levelSizeMsg_codec);
            break;
          }
          case 42:
          case 40: {
            wallMsgX_.AddEntriesFrom(input, _repeated_wallMsgX_codec);
            break;
          }
          case 50:
          case 48: {
            wallMsgY_.AddEntriesFrom(input, _repeated_wallMsgY_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ResponseMsg = input.ReadInt32();
            break;
          }
          case 18:
          case 16: {
            positionMsg_.AddEntriesFrom(ref input, _repeated_positionMsg_codec);
            break;
          }
          case 29: {
            SpeedMsg = input.ReadFloat();
            break;
          }
          case 34:
          case 32: {
            levelSizeMsg_.AddEntriesFrom(ref input, _repeated_levelSizeMsg_codec);
            break;
          }
          case 42:
          case 40: {
            wallMsgX_.AddEntriesFrom(ref input, _repeated_wallMsgX_codec);
            break;
          }
          case 50:
          case 48: {
            wallMsgY_.AddEntriesFrom(ref input, _repeated_wallMsgY_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
