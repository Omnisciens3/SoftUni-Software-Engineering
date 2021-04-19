using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Telephony
{
    public class Smartphone : Phone, IBrowseable
    {
        public override string Call(string number)
        {
            Validator.ThrowIfNumberIsInvalid(number);

            return $"Calling... {number}";
        }

        public string Browse(string website)
        {
            if (website.Any(x => char.IsDigit(x)))
            {
                throw new InvalidOperationException("Invalid URL!");
            }

            return $"Browsing: {website}!";
        }

    }
}
