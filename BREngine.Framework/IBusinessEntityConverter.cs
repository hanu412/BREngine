using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BREngine.Framework
{
    public interface IBusinessEntityConverter<in T> where T : class ,new ()
    {
        string ConvertEntityToString(T entity);
    }
}
