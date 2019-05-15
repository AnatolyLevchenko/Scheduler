using ServiceStack.OrmLite;

namespace Scheduler.Data
{
    class ConnectionFactory
    {
        public const string DatabaseName = "scheduler.db";

        public static string GetConnection =>   $@"Data Source={DatabaseName};Version=3;";

        public static OrmLiteConnectionFactory GetConnectionFactory => new OrmLiteConnectionFactory(GetConnection, SqliteDialect.Provider);
    }
}
