namespace Polymorphism
{
    public abstract class DbConnection
    {
        private string _connectionString;
        public DbConnection(string connectionString)
        {
            if(connectionString == null) 
                throw new ArgumentNullException(nameof(connectionString));
            _connectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();

        public abstract void Run(string command);
    }
}
 