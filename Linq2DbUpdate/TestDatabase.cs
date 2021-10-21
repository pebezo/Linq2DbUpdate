using LinqToDB;
using LinqToDB.DataProvider;
using LinqToDB.DataProvider.MySql;

namespace Linq2DbUpdate
{
    public class TestDatabase : LinqToDB.Data.DataConnection
    {
        internal TestDatabase(string connectionString, string providerName) : base(GetDataProvider(providerName), connectionString)
        {

        }

        private new static IDataProvider GetDataProvider(string providerName)
        {
            return new MySqlDataProvider(providerName);
        }

        internal ITable<TestTableNotNull> TestTable => Table<TestTableNotNull>();

        private ITable<T> Table<T>() where T : class => GetTable<T>();
    }
}