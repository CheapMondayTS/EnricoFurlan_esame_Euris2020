using System.Collections.Generic;

namespace TheSpaceCinema.ISqlProvider
{
    public interface IGetAllSqlProvider<T>
    {
        IEnumerable<T> GetAll();
    }
}
