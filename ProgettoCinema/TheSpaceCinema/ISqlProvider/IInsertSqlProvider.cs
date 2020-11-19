namespace TheSpaceCinema.ISqlProvider
{
    public interface IInsertSqlProvider<T>
    {
        void Insert(T entity);
    }
}
