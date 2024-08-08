﻿using ClienteBanco.Entities.Interfaces;
using CsvHelper;
using System.Globalization;

namespace ClienteBanco.Helpers;

public class CSVHelperRepository : ICSVService
{
    public IEnumerable<T> ReadCSV<T>(Stream file)
    {
        var reader = new StreamReader(file);
        var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        var records = csv.GetRecords<T>();
        return records;
    }
}