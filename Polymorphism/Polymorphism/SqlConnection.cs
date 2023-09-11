namespace Polymorphism
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        { }

        public override void Close()
        {
            Console.WriteLine("Closed SQL.");
        }

        public override void Open()
        {
            Console.WriteLine("Opened SQL.");
        }

        public override void Run(string command) => Console.WriteLine("Running: " + command);

    }
}
 