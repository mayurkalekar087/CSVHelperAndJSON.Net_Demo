using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper;
using Newtonsoft.Json;
using System.IO;
using System.Globalization; 



namespace CSVHelperDemo
{
    class ReadJSON_And_WriteCSV
    {
        public static void ImplementJSONToCSV()
        {
            string importFilePath = @"C:\Users\ASUS\source\repos\CSVHelper\CSVHelper\export.json";
            string exportFilePath = @"C:\Users\ASUS\source\repos\CSVHelper\CSVHelper\JsonData.csv";

            IList<AddressData> addressData = JsonConvert.DeserializeObject<IList<AddressData>>(File.ReadAllText(importFilePath));

            Console.WriteLine("*****************Now Reading from Json file And Write to CSV file*********************");
            //writing CSV File
            using var writer = new StreamWriter(exportFilePath);
            using var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture);
            {
                csvExport.WriteRecords(addressData);
            }
        }
    }
}
