using Domain.User.Rules;
using GenericDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.ValueObjects
{
    public class Email: ValueObject
    {
        private readonly string _email;
        public string Value => _email;
        public Email(string email)
        {
            CheckRule(new ValueMustNotBeEmptyOrNull(email));
            _email = email;
        }
    }
}
