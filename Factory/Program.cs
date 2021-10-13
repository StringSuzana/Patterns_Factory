using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            var server = new Server(logger);
            new Client(server, logger).Start();
        }

    }
}
