using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BREngine.Framework
{
    public abstract class BusinessRule<T> : BaseValidationRule<T>, IBusinessRule<T> where T : class,new()
    {

  
        

        public override void ValidateRule(T entity)
        {


        }

        

        public abstract void SetNextRule(BusinessRule<T> next);

        public abstract void Initialize();

        public abstract void AddMessage();

        public abstract void LogException(Exception exception);

        
        
    }
}