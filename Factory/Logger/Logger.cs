using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Factory
{
    public class Logger : ILogger
    {
        private string FILE_LOG_PATH = String.Empty;
        public Logger()
        {
            string FILE_NAME_LOG = "logs.txt";
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = Path.Combine(sCurrentDirectory, (@"..\..\..\Data\" + FILE_NAME_LOG));
            FILE_LOG_PATH = Path.GetFullPath(sFile);
        }

        public void WriteToLogFile(Product selected_product)
        {
            var time = DateTime.Now.ToString("dd/MM/yyyy h:m:s tt");
            if (!File.Exists(FILE_LOG_PATH)) File.Create(FILE_LOG_PATH);
            using (StreamWriter sw = File.AppendText(FILE_LOG_PATH))
            {
                sw.WriteLine($"{time};{selected_product?.Name};{selected_product?.Discount}%");
            }

        }
        public void WriteToConsole(Product selected_product)
        {
            Console.WriteLine($"{selected_product.ToString()}---------------------");
        }

        public void WriteToConsole(string text)
        {
            Console.WriteLine(text);
        }

    }
}
