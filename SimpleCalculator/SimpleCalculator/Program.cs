using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var processor = new InputProcessor();
                processor.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Критическая ошибка: {0}", ex.Message);
            }
        }
    }
}