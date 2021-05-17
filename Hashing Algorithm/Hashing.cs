using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Hashing_Algorithm
{
    enum supportedHash
    {
        SHA256, SHA384, SHA512
    }

    enum supportedOutput
    {
        Text, Hex, Binary
    }

    class Hashing
    {
        public static String CalculateHash(string txt, supportedHash hashType, supportedOutput outputType)
        {
            var msgBytes = Encoding.ASCII.GetBytes(txt);

            byte[] hashValue = null;
            String output = null;

            switch (hashType)
            {
                case supportedHash.SHA256:
                    var sha = new SHA256Managed();
                    hashValue = sha.ComputeHash(msgBytes);
                    sha.Dispose();
                    break;
                case supportedHash.SHA384:
                    var sha1 = new SHA384Managed();
                    hashValue = sha1.ComputeHash(msgBytes);
                    sha1.Dispose();
                    break;
                case supportedHash.SHA512:
                    var sha2 = new SHA512Managed();
                    hashValue = sha2.ComputeHash(msgBytes);
                    sha2.Dispose();
                    break;
            }

            switch (outputType)
            {
                case supportedOutput.Text:
                    var convert1 = Convert.ToBase64String(hashValue);
                    output = convert1;
                    break;
                case supportedOutput.Hex:
                    break;
                case supportedOutput.Binary:
                    String str = Convert.ToBase64String(hashValue);
                    var b = Encoding.UTF8.GetBytes(str);
                    var convert3 = string.Join("   ", b.Select( x => Convert.ToString(x, 2).PadLeft(8, '0')));

                    output = convert3;
                    break;
            }

            return output;
        }
    }
}
