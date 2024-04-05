using GenericDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Rules
{
    internal class ValueMustNotBeEmptyOrNull : IBusinessRule
    {
        private readonly string _value;
        public ValueMustNotBeEmptyOrNull(string value)
        {
            _value = value;
        }
        public bool HasValidRule()
        {
            var isValid = !string.IsNullOrEmpty(_value);
            return isValid;
        }
        public string Message => $"مقدار {_value} نباید خالی باشد";

    }
}
