using GenericDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Rules
{
    public class NameMustNotHaveSpace : IBusinessRule
    {
        private readonly string _name;
        public NameMustNotHaveSpace(string name)
        {
            _name = name;
        }
        public bool HasValidRule()
        {
            return !_name.Contains(' ');
        }
        public string Message => $"نام {_name} نباید کاراکتر space داشته باشد";
    }
}
