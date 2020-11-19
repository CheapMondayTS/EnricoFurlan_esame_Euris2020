namespace TheSpaceCinema.ISqlProvider
{
    public class ConnectionSqlProvider
    {
        protected readonly string _connectionString;

        public ConnectionSqlProvider(string connectionstring)
        {
            _connectionString = connectionstring;
        }
    }
}
