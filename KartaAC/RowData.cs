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
    public class RowData
    {
        [Name("T [s]")]
        public string Time { get; set; }
        [Name("Ux [V]")]
        public string X { get; set; }
        [Name("Uy [V]")]
        public string Y { get; set; }
    }
}
