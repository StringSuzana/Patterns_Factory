namespace Factory
{
    public interface ILogger
    {
        void WriteToConsole(Product selected_product);
        void WriteToConsole(string text);
        void WriteToLogFile(Product selected_product);
    }
}