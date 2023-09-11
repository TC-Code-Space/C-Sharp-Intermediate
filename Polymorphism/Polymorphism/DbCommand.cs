namespace Polymorphism
{
    partial class Program
    {
        public class DbCommand
        {
            private DbConnection _connection;
            private string _command;
            public DbCommand(DbConnection connection, string command)
            {
                if (connection != null)
                {
                    _connection = connection;
                } 
                else
                {
                    throw new NullReferenceException("Connection passed was not initialized");
                }
                
                if(command != null) 
                { 
                    _command = command; 
                }
                else
                {
                    throw new ArgumentNullException(nameof(command));
                }
                
            }

            public void Execute()
            {
                _connection.Open();
                _connection.Run(_command);
                _connection.Close();
            }
        }
    }
}
 