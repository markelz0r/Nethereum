using System;
using Nethereum.ABI.Decoders;

namespace Nethereum.ABI
{
   public class FeltType : ABIType
   {
      public FeltType(string name) : base(name)
      {
         Encoder = new FeltTypeEncoder();
         Decoder = new FeltTypeDecoder();
      }

      public string ToShortString()
      {
         throw new NotImplementedException();
      }
   }
}