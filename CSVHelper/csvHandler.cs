using System;
using CsvHelper;
using System.Globalization;
using System.IO;
using System.Linq;


namespace CSVHelperDemo
{
    class csvHandler
    {
        public static void ImplementCSVDataHandling()
        {
            string importFilePath = @"C:\Users\ASUS\source\repos\CSVHelper\CSVHelper\Address.csv";
            string exportFilePath = @"C:\Users\ASUS\source\repos\CSVHelper\CSVHelper\export.csv";
            //reading csv file
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data successfully from addresses csv.");
                foreach (AddressData addressData in records)
                {
                    Console.WriteLine("\t" + addressData.firstname);
                    Console.WriteLine("\t" + addressData.lastname);
                    Console.WriteLine("\t" + addressData.address);
                    Console.WriteLine("\t" + addressData.City);
                    Console.WriteLine("\t" + addressData.State);
                    Console.WriteLine("\t" + addressData.Code);
                    Console.WriteLine("\n");
                    Console.WriteLine("*****************************Reading from csv file and write to csv file********************");
                }
                Console.WriteLine("\n********** Now reading from file and write to csv");
                //writing CSV File
                using var writer = new StreamWriter(exportFilePath);
                using var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture);
                {
                    csvExport.WriteRecords(records);
                }
            }
        }
    }
}
