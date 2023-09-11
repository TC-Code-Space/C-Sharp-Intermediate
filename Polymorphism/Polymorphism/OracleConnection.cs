namespace Polymorphism
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) 
        {  }

        public override void Close()
        {
            Console.WriteLine("Closed Oracle.");
        }

        public override void Open()
        {
            Console.WriteLine("Opened Oracle.");
        }

        public override void Run(string command) => Console.WriteLine("Running: " + command);
    }
}
 