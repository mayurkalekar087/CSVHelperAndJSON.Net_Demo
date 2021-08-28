using System;

namespace CSVHelperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read Data From CSV & Write in CSV
            Console.WriteLine("# Read Data from CSV & Write Data in CSV!");
            csvHandler.ImplementCSVDataHandling();
            Console.WriteLine();
            //Read Data from CSV & Write In Json
            Console.WriteLine("# Read Data from CSV & Write Data in JSON !");
            ReadCSV_And_WriteJSON.ImplementCSVToJSON();
            Console.WriteLine();
            //Read Data From Json & Write in CSV File
            Console.WriteLine("# Read Data from JSON & Write Data in CSV !");
            ReadJSON_And_WriteCSV.ImplementJSONToCSV();
            Console.WriteLine();
        }
    }
}
