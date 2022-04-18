// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/MeterReader.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MeterReaderWeb.Services {

  /// <summary>Holder for reflection information generated from Protos/MeterReader.proto</summary>
  public static partial class MeterReaderReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/MeterReader.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MeterReaderReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhQcm90b3MvTWV0ZXJSZWFkZXIucHJvdG8aElByb3Rvcy9lbnVtcy5wcm90",
            "bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byJlCg1SZWFkaW5n",
            "UGFja2V0EiEKCHJlYWRpbmdzGAEgAygLMg8uUmVhZGluZ01lc3NhZ2USDQoF",
            "bm90ZXMYAiABKAkSIgoKc3VjY2Vzc2Z1bBgDIAEoDjIOLlJlYWRpbmdTdGF0",
            "dXMigwEKDlJlYWRpbmdNZXNzYWdlEhIKCmN1c3RvbWVySWQYASABKAUSFAoM",
            "cmVhZGluZ1ZhbHVlGAIgASgFEi8KC3JlYWRpbmdUaW1lGAUgASgLMhouZ29v",
            "Z2xlLnByb3RvYnVmLlRpbWVzdGFtcEoECAMQBEoECAQQBVIKc3VjY2Vzc2Z1",
            "bCJBCg1TdGF0dXNNZXNzYWdlEg8KB21lc3NhZ2UYASABKAkSHwoHc3VjY2Vz",
            "cxgCIAEoDjIOLlJlYWRpbmdTdGF0dXMyQwoTTWV0ZXJSZWFkaW5nU2Vydmlj",
            "ZRIsCgpBZGRSZWFkaW5nEg4uUmVhZGluZ1BhY2tldBoOLlN0YXR1c01lc3Nh",
            "Z2VCGqoCF01ldGVyUmVhZGVyV2ViLlNlcnZpY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MeterReaderWeb.Services.EnumsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MeterReaderWeb.Services.ReadingPacket), global::MeterReaderWeb.Services.ReadingPacket.Parser, new[]{ "Readings", "Notes", "Successful" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::MeterReaderWeb.Services.ReadingMessage), global::MeterReaderWeb.Services.ReadingMessage.Parser, new[]{ "CustomerId", "ReadingValue", "ReadingTime" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::MeterReaderWeb.Services.StatusMessage), global::MeterReaderWeb.Services.StatusMessage.Parser, new[]{ "Message", "Success" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReadingPacket : pb::IMessage<ReadingPacket>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReadingPacket> _parser = new pb::MessageParser<ReadingPacket>(() => new ReadingPacket());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ReadingPacket> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MeterReaderWeb.Services.MeterReaderReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReadingPacket() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReadingPacket(ReadingPacket other) : this() {
      readings_ = other.readings_.Clone();
      notes_ = other.notes_;
      successful_ = other.successful_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReadingPacket Clone() {
      return new ReadingPacket(this);
    }

    /// <summary>Field number for the "readings" field.</summary>
    public const int ReadingsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::MeterReaderWeb.Services.ReadingMessage> _repeated_readings_codec
        = pb::FieldCodec.ForMessage(10, global::MeterReaderWeb.Services.ReadingMessage.Parser);
    private readonly pbc::RepeatedField<global::MeterReaderWeb.Services.ReadingMessage> readings_ = new pbc::RepeatedField<global::MeterReaderWeb.Services.ReadingMessage>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MeterReaderWeb.Services.ReadingMessage> Readings {
      get { return readings_; }
    }

    /// <summary>Field number for the "notes" field.</summary>
    public const int NotesFieldNumber = 2;
    private string notes_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Notes {
      get { return notes_; }
      set {
        notes_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "successful" field.</summary>
    public const int SuccessfulFieldNumber = 3;
    private global::MeterReaderWeb.Services.ReadingStatus successful_ = global::MeterReaderWeb.Services.ReadingStatus.Invalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MeterReaderWeb.Services.ReadingStatus Successful {
      get { return successful_; }
      set {
        successful_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ReadingPacket);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ReadingPacket other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!readings_.Equals(other.readings_)) return false;
      if (Notes != other.Notes) return false;
      if (Successful != other.Successful) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= readings_.GetHashCode();
      if (Notes.Length != 0) hash ^= Notes.GetHashCode();
      if (Successful != global::MeterReaderWeb.Services.ReadingStatus.Invalid) hash ^= Successful.GetHashCode();
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
      readings_.WriteTo(output, _repeated_readings_codec);
      if (Notes.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Notes);
      }
      if (Successful != global::MeterReaderWeb.Services.ReadingStatus.Invalid) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Successful);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      readings_.WriteTo(ref output, _repeated_readings_codec);
      if (Notes.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Notes);
      }
      if (Successful != global::MeterReaderWeb.Services.ReadingStatus.Invalid) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Successful);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += readings_.CalculateSize(_repeated_readings_codec);
      if (Notes.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Notes);
      }
      if (Successful != global::MeterReaderWeb.Services.ReadingStatus.Invalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Successful);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ReadingPacket other) {
      if (other == null) {
        return;
      }
      readings_.Add(other.readings_);
      if (other.Notes.Length != 0) {
        Notes = other.Notes;
      }
      if (other.Successful != global::MeterReaderWeb.Services.ReadingStatus.Invalid) {
        Successful = other.Successful;
      }
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
          case 10: {
            readings_.AddEntriesFrom(input, _repeated_readings_codec);
            break;
          }
          case 18: {
            Notes = input.ReadString();
            break;
          }
          case 24: {
            Successful = (global::MeterReaderWeb.Services.ReadingStatus) input.ReadEnum();
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
          case 10: {
            readings_.AddEntriesFrom(ref input, _repeated_readings_codec);
            break;
          }
          case 18: {
            Notes = input.ReadString();
            break;
          }
          case 24: {
            Successful = (global::MeterReaderWeb.Services.ReadingStatus) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ReadingMessage : pb::IMessage<ReadingMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReadingMessage> _parser = new pb::MessageParser<ReadingMessage>(() => new ReadingMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ReadingMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MeterReaderWeb.Services.MeterReaderReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReadingMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReadingMessage(ReadingMessage other) : this() {
      customerId_ = other.customerId_;
      readingValue_ = other.readingValue_;
      readingTime_ = other.readingTime_ != null ? other.readingTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReadingMessage Clone() {
      return new ReadingMessage(this);
    }

    /// <summary>Field number for the "customerId" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private int customerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CustomerId {
      get { return customerId_; }
      set {
        customerId_ = value;
      }
    }

    /// <summary>Field number for the "readingValue" field.</summary>
    public const int ReadingValueFieldNumber = 2;
    private int readingValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ReadingValue {
      get { return readingValue_; }
      set {
        readingValue_ = value;
      }
    }

    /// <summary>Field number for the "readingTime" field.</summary>
    public const int ReadingTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp readingTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ReadingTime {
      get { return readingTime_; }
      set {
        readingTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ReadingMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ReadingMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      if (ReadingValue != other.ReadingValue) return false;
      if (!object.Equals(ReadingTime, other.ReadingTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId != 0) hash ^= CustomerId.GetHashCode();
      if (ReadingValue != 0) hash ^= ReadingValue.GetHashCode();
      if (readingTime_ != null) hash ^= ReadingTime.GetHashCode();
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
      if (CustomerId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CustomerId);
      }
      if (ReadingValue != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ReadingValue);
      }
      if (readingTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ReadingTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CustomerId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CustomerId);
      }
      if (ReadingValue != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ReadingValue);
      }
      if (readingTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ReadingTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CustomerId);
      }
      if (ReadingValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ReadingValue);
      }
      if (readingTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReadingTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ReadingMessage other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId != 0) {
        CustomerId = other.CustomerId;
      }
      if (other.ReadingValue != 0) {
        ReadingValue = other.ReadingValue;
      }
      if (other.readingTime_ != null) {
        if (readingTime_ == null) {
          ReadingTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ReadingTime.MergeFrom(other.ReadingTime);
      }
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
            CustomerId = input.ReadInt32();
            break;
          }
          case 16: {
            ReadingValue = input.ReadInt32();
            break;
          }
          case 42: {
            if (readingTime_ == null) {
              ReadingTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ReadingTime);
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
            CustomerId = input.ReadInt32();
            break;
          }
          case 16: {
            ReadingValue = input.ReadInt32();
            break;
          }
          case 42: {
            if (readingTime_ == null) {
              ReadingTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ReadingTime);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class StatusMessage : pb::IMessage<StatusMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StatusMessage> _parser = new pb::MessageParser<StatusMessage>(() => new StatusMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StatusMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MeterReaderWeb.Services.MeterReaderReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StatusMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StatusMessage(StatusMessage other) : this() {
      message_ = other.message_;
      success_ = other.success_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StatusMessage Clone() {
      return new StatusMessage(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 2;
    private global::MeterReaderWeb.Services.ReadingStatus success_ = global::MeterReaderWeb.Services.ReadingStatus.Invalid;
    /// <summary>
    ///bool success = 2;
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MeterReaderWeb.Services.ReadingStatus Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StatusMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StatusMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      if (Success != other.Success) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (Success != global::MeterReaderWeb.Services.ReadingStatus.Invalid) hash ^= Success.GetHashCode();
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
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (Success != global::MeterReaderWeb.Services.ReadingStatus.Invalid) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Success);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (Success != global::MeterReaderWeb.Services.ReadingStatus.Invalid) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Success);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (Success != global::MeterReaderWeb.Services.ReadingStatus.Invalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Success);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StatusMessage other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.Success != global::MeterReaderWeb.Services.ReadingStatus.Invalid) {
        Success = other.Success;
      }
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
          case 10: {
            Message = input.ReadString();
            break;
          }
          case 16: {
            Success = (global::MeterReaderWeb.Services.ReadingStatus) input.ReadEnum();
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
          case 10: {
            Message = input.ReadString();
            break;
          }
          case 16: {
            Success = (global::MeterReaderWeb.Services.ReadingStatus) input.ReadEnum();
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
