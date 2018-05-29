using System;
namespace FactorAuth.Core.Models
{
    public enum OtpKeyType
    {
        Hotp,
        Totp
    }

    public enum OtpKeyAlgorithm
    {
        SHA1,
        SHA256,
        SHA512
    }

    public class OtpKeyUri
    {
        public OtpKeyUri()
        {
            Type = OtpKeyType.Totp;
            Algorithm = OtpKeyAlgorithm.SHA1;
            Digits = 6;
            Counter = 0;
            Period = 30;
        }

        public OtpKeyType Type { get; set; }
        public string Label { get; set; }
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public OtpKeyAlgorithm Algorithm { get; set; }
        public int Digits { get; set; }
        public int Counter { get; set; }
        public int Period { get; set; }
    }
}
