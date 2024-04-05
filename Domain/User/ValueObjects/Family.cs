using Domain.User.Rules;
using GenericDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.ValueObjects
{
    public class Family: ValueObject
    {
        private readonly string _family;
        public string Value => _family;
        public Family(string family)
        {
            CheckRule(new ValueMustNotBeEmptyOrNull(family));
            _family = family;
        }
    }
}
