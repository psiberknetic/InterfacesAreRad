using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace InternalLegacySystem
{
    public class PhoneNumber : IEquatable<PhoneNumber>
    {
        public string AreaCode { get; set; }
        public string Prefix { get; set; }
        public string LineNumber { get; set; }

        public bool Equals([AllowNull] PhoneNumber other)
        {
            if (other == null)
            {
                return false;
            }

            return this.ToString().Equals(other.ToString());
        }

        public override string ToString() => $"({AreaCode}) {Prefix}-{LineNumber}";
    }
}
