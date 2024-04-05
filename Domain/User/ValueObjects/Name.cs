using Domain.User.Rules;
using GenericDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.ValueObjects
{
    public class Name : ValueObject
    {
        private readonly string _name;
        public string Value => _name;
        public Name(string name)
        {
            CheckRule(new NameMustNotHaveSpace(name));
            CheckRule(new ValueMustNotBeEmptyOrNull(name));
            _name = name;
        }
    }
}
