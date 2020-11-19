using System.Collections.Generic;

namespace TheSpaceCinema.ISqlProvider
{
    interface IGetByFilterSqlProvider<T>
    {
        IEnumerable<T> GetByFilter(int entity);
    }
}
