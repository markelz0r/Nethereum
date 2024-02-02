using System;
using System.Linq;
using System.Numerics;

namespace Nethereum.ABI.Decoders
{
   public class FeltTypeDecoder : TypeDecoder
   {
      public override Type GetDefaultDecodingType()
      {
         return typeof(BigInteger);
      }

      public override bool IsSupportedType(Type type)
      {
         return type == typeof(BigInteger);
      }

      public override object Decode(byte[] encoded, Type type)
      {
         return new BigInteger(encoded);
      }
   }
}