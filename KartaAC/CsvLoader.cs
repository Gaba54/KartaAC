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
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.Interpolation;

namespace KartaAC
{
    public class CsvLoader
    {
        string path = string.Empty;
        public List<RowData> listDataString = null;
        public List<RowDataDecimal> listData = null;
        public double integralX, integralY;
        public List<double> xList, yList, dydxList;

        public CsvLoader(string path)
        {
            this.path = path;
            listDataString = new List<RowData>();
            listData = new List<RowDataDecimal>();
            LoadingData();
            ConvertListToDeciaml();
            CalculateIntegral();
            CalculateDerivative();
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

        //Obliczanie całki
        private void CalculateIntegral() 
        {
            for (int i = 1; i < listData.Count; i++)
            {
                integralX += (listData[i].X + listData[i - 1].X) / 2 * (listData[i].Time - listData[i-1].Time);
                integralY += (listData[i].Y + listData[i - 1].Y) / 2 * (listData[i].Time - listData[i - 1].Time);
            }

        }

        private void CalculateDerivative() 
        {
            var tvec = new DenseVector(listData.Select(item => item.Time).ToArray());
            var xvec = new DenseVector(listData.Select(item => item.X).ToArray());
            var yvec = new DenseVector(listData.Select(item => item.Y).ToArray());
            var csTX = CubicSpline.InterpolateNatural(tvec, xvec);
            var csTY = CubicSpline.InterpolateNatural(tvec, yvec);
            var dxdt = new DenseVector(listData.Count);
            var dydt = new DenseVector(listData.Count);


            for (int i = 0; i < listData.Count; i++) 
            {

                dxdt[i] = csTX.Differentiate(listData[i].Time);
                dydt[i] = csTY.Differentiate(listData[i].Time);

                listData[i].dxdt = dxdt[i];
                listData[i].dydt = dydt[i];
            }

        }


    }
}
