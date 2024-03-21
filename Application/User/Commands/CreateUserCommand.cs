﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User.Commands
{
    public class CreateUserCommand:IRequest<Guid>
    {
        public  string Name { get; set; }
        public string Family { get; set; }
        public string Email { get; set; }

    }
}
