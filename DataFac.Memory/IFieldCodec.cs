using System;

namespace DataFac.Memory
{
    public interface IFieldCodec
    {
        object? ReadObject(ReadOnlySpan<byte> source);
        void WriteObject(Span<byte> target, object? input);
    }
}
