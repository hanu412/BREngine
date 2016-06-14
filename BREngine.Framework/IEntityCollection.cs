using System.Collections.Generic;
using System.Data;

namespace BREngine.Framework
{
    public interface IEntityCollection<T> where T: class ,new ()
    {

        ICollection<T> CreateCollection(DataTable dataTable);
    }
}
