using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Factory
{
    public class Logger : ILogger
    {

        private readonly string FILE_NAME_LOG = @"C:\Users\Suz\Desktop\Diplomski Algebra\Semester_02\Advanced Application Development Based on Development Templates\Assignments\Factory\Factory\Factory\Data\logs.txt";

        public void WriteToLogFile(Product selected_product)
        {
            var time = DateTime.Now.ToString("dd/MM/yyyy h:m:s tt");
            using (StreamWriter sw = File.AppendText(FILE_NAME_LOG))
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
