using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDomain
{
    public abstract class ValueObject
    {
        protected static void CheckRule(IBusinessRule rule)
        {
            if(rule.HasValidRule()==false)
            {
                throw new BusinessRuleValidationException(rule);
            }
        }
    }
}
