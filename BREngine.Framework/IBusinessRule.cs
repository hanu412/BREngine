using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BREngine.Framework
{
    public interface IBusinessRule<T> : IBusinessRuleHandler where T : class,new()
    {
        void Initialize();
        void SetNextRule(BusinessRule<T> next);
    }

   
   
}
