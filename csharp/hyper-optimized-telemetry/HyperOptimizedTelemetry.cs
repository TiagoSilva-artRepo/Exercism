using System;
using System.Collections.Generic;

public static class TelemetryBuffer
{
    private const sbyte SHORT_BYTECOUNT = 2; 
    private const sbyte INT_BYTECOUNT = 4; 
    private const sbyte LONG_BYTECOUNT = 8; 

    public static byte[] ToBuffer(long reading)
    {
        byte[] compressedData = new byte[9];

        (byte[] payloadBytes, byte prefixByte) = reading switch
        {
            > uint.MaxValue => (BitConverter.GetBytes(reading), BitToByte(LONG_BYTECOUNT)),
            > int.MaxValue => (BitConverter.GetBytes(reading), (byte)INT_BYTECOUNT),
            > ushort.MaxValue => (BitConverter.GetBytes(reading), BitToByte(INT_BYTECOUNT)),
            >= ushort.MinValue => (BitConverter.GetBytes(reading), (byte)SHORT_BYTECOUNT),
            >= short.MinValue => (BitConverter.GetBytes((short)reading), BitToByte(SHORT_BYTECOUNT)),
            >= Int32.MinValue => (BitConverter.GetBytes((int)reading), BitToByte(INT_BYTECOUNT)),
            >= long.MinValue => (BitConverter.GetBytes(reading), BitToByte(LONG_BYTECOUNT)),
        };

        compressedData[0] = prefixByte;
        payloadBytes.CopyTo(compressedData, 1);
        return compressedData;
    }

    private static byte BitToByte (sbyte bit)
    {
        return (byte)(256 - bit);
    }

    public static long FromBuffer(byte[] buffer)
    {    
        return (sbyte)buffer[0] switch
        {
            SHORT_BYTECOUNT => BitConverter.ToUInt16(buffer, 1),
            INT_BYTECOUNT => BitConverter.ToUInt32(buffer, 1),
            -LONG_BYTECOUNT => BitConverter.ToInt64(buffer, 1),
            -INT_BYTECOUNT => BitConverter.ToInt32(buffer, 1),
            -SHORT_BYTECOUNT => BitConverter.ToInt16(buffer, 1),
            _ => 0
        };
    }
}
