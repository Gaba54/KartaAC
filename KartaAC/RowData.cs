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

        [Name("DxDt [V]")]
        public double dxdt { get; set; }

        [Name("DyDt [V]")]
        public double dydt { get; set; }

        public RowDataDecimal(string time, string x, string y)
        {
            try
            {
                Time = double.Parse(time);
                X = double.Parse(x);
                Y = double.Parse(y);

            }
            catch (Exception e)
            {
                if (e.Source != null)
                    throw new Exception("Nie udało się przekonwertować danych - problem z danymi!");
            }
        }

        public RowDataDecimal(double T, double xVal, double yVal, double DXDT, double DYDT) 
        {
            Time = T;
            X = xVal;
            Y = yVal;
            dxdt = DXDT;
            dydt = DYDT;
        }
    }
}
