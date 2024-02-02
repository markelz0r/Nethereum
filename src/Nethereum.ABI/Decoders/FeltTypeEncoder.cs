using System;
using System.Linq;
using System.Numerics;
using System.Text;
using Nethereum.ABI.Encoders;

namespace Nethereum.ABI.Decoders
{
   public class FeltTypeEncoder : ITypeEncoder
   {
      public byte[] Encode(object value)
      {
         switch (value)
         {
            case string s:
               return EncodeString(s);
            case BigInteger bi:
               return EncodeBigInteger(bi);
            default:
               throw new ArgumentException();
         }
      }

      private static byte[] EncodeBigInteger(BigInteger bi)
      {
         return bi.ToByteArray();
      }

      private byte[] EncodeString(string s)
      {
         if (s.Length > 31)
            throw new ArgumentException();
         
         //TODO add isASCII check
         
         var encoded = string.Join("", s.Select(c => ((int)c).ToString("X2")));
         return Encoding.UTF8.GetBytes(encoded);
      }

      public byte[] EncodePacked(object value)
      {
         switch (value)
         {
            case string s:
               return EncodeString(s);
            case BigInteger bi:
               return EncodeBigInteger(bi);
            default:
               throw new ArgumentException();
         }
      }
   }
}