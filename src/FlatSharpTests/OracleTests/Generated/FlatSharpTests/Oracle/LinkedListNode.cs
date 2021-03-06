// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatSharpTests.Oracle
{

using global::System;
using global::FlatBuffers;

public struct LinkedListNode : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static LinkedListNode GetRootAsLinkedListNode(ByteBuffer _bb) { return GetRootAsLinkedListNode(_bb, new LinkedListNode()); }
  public static LinkedListNode GetRootAsLinkedListNode(ByteBuffer _bb, LinkedListNode obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public LinkedListNode __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Value { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetValueBytes() { return __p.__vector_as_span(4); }
#else
  public ArraySegment<byte>? GetValueBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetValueArray() { return __p.__vector_as_array<byte>(4); }
  public LinkedListNode? Next { get { int o = __p.__offset(6); return o != 0 ? (LinkedListNode?)(new LinkedListNode()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<LinkedListNode> CreateLinkedListNode(FlatBufferBuilder builder,
      StringOffset ValueOffset = default(StringOffset),
      Offset<LinkedListNode> NextOffset = default(Offset<LinkedListNode>)) {
    builder.StartObject(2);
    LinkedListNode.AddNext(builder, NextOffset);
    LinkedListNode.AddValue(builder, ValueOffset);
    return LinkedListNode.EndLinkedListNode(builder);
  }

  public static void StartLinkedListNode(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddValue(FlatBufferBuilder builder, StringOffset ValueOffset) { builder.AddOffset(0, ValueOffset.Value, 0); }
  public static void AddNext(FlatBufferBuilder builder, Offset<LinkedListNode> NextOffset) { builder.AddOffset(1, NextOffset.Value, 0); }
  public static Offset<LinkedListNode> EndLinkedListNode(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<LinkedListNode>(o);
  }
};


}
