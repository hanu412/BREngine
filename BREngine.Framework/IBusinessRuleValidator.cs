using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BREngine.Framework
{
    public interface IBusinessRuleValidator<T> where T : class, new()
    {
        void TryValidateObject();

        List<BusinessRule<T>> BuildRules();
    }


   
   
}
