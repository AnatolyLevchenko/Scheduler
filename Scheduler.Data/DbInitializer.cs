using System.Data.SQLite;
using System.IO;
using ServiceStack.OrmLite;

namespace Scheduler.Data
{
    public class DbInitializer
    {
        private readonly OrmLiteConnectionFactory _dbFactory;

        public DbInitializer()
        {
             _dbFactory = ConnectionFactory.GetConnectionFactory;
            Init();
        }

        public void Init()
        {
            if (!File.Exists(ConnectionFactory.DatabaseName))
            {
                SQLiteConnection.CreateFile(ConnectionFactory.DatabaseName);
                using (var connection =_dbFactory.Open())
                {
                    connection.Open();
                    connection.ExecuteSql(File.ReadAllText("quartz.sql"));
                }
            }


        }
    }



}
