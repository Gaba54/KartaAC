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

    public class RowDataDecimal
    {
        [Name("T [s]")]
        public double Time { get; set; }
        [Name("Ux [V]")]
        public double X { get; set; }
        [Name("Uy [V]")]
        public double Y { get; set; }

        public RowDataDecimal(string time, string x, string y)
        {
            try
            {
                this.Time = double.Parse(time);
                this.X = double.Parse(x);
                this.Y = double.Parse(y);

            }
            catch (Exception e)
            {
                if (e.Source != null)
                    throw new Exception("Nie udało się przekonwertować danych - problem z danymi!");
            }
        }
    }
}
