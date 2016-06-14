using System.Collections.Generic;
using System.Data;

namespace BREngine.Framework
{
    public interface IRecordCreator<T>
    {
        List<T> GetRecords(DataSet dataSet);
    }
}