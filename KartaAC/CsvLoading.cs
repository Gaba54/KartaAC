using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace KartaAC
{
    public class CsvLoading
    {
        string path = string.Empty;
        public List<RowData> listData = null;
    
        public CsvLoading(string path)
        {
            this.path = path;
            listData = new List<RowData>();
            LoadingData();
        }

        private void LoadingData()
        {
            using (var streamReader = new StreamReader(path))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = "\t",
                };

                using (var csvReader = new CsvReader(streamReader, config))
                {

                    listData = csvReader.GetRecords<RowData>().ToList();
                    
                }
            }
        }
       



    }
}
