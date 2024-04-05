using Domain.User.ValueObjects;
using GenericDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User
{
    public sealed class User: AggreagetRoot<Guid>
    {
        public User(string name, string family, string email)
        {
            Name = new Name(name);
            Family = new Family(family);
            Email = new Email(email);
        }

        public Name Name { get; private set; }
        public Family Family { get; private set; }
        public Email Email { get; private set; }
    }
}
