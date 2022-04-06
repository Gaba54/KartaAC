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
        public List<RowData> listDataString = null;
        public List<RowDataDecimal> listData = null;

        public CsvLoading(string path)
        {
            this.path = path;
            listDataString = new List<RowData>();
            listData = new List<RowDataDecimal>();
            LoadingData();
            ConvertListToDeciaml();
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

                    listDataString = csvReader.GetRecords<RowData>().ToList();

                }
            }
        }

        private void ConvertListToDeciaml()
        {
            foreach (RowData rd in listDataString)
            {
                listData.Add(new RowDataDecimal(rd.Time, rd.X, rd.Y));
            }
        }


    }
}
