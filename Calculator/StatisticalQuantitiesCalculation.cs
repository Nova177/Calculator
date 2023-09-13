using System;
using System.Collections.Generic;
using System.Linq;


namespace Calculator
{
    /// <summary>
    /// Represents a class for calculating various statistical quantities.
    /// </summary>
    public class StatisticalQuantitiesCalculation : ICalculationLogic
    {
        /// <summary>
        /// Linked list for storing arithmetic values
        /// </summary>
        public LinkedList<double> arithmeticList = new LinkedList<double>();


        /// <summary>
        /// Performs statistical calculations based on user input
        /// Arithmetic Medium, Mode, Range, Mean Absolute Deviation (MAD), Variance and Standard Deviation
        /// </summary>
        /// <param name="io"></param>
        public void Calculation(IInputOutput io)
        {
            io.Instructions();
            double input = 0;

            do
            {
                input = io.Input("");

                if (input != 0)
                {
                    arithmeticList.AddLast(input);
                }
                else
                {
                    break;
                }
            } while (true);


            double sum = 0;
            foreach (double number in arithmeticList)
            {
                sum += number;
            }

            double arithmeticMean = sum / arithmeticList.Count;

            io.ResultOutput("Arithmetic Medium: {0}", arithmeticMean);

            IEnumerable<double> mode = arithmeticList.GroupBy(x => x)
                                           .OrderByDescending(g => g.Count())
                                           .Select(g => g.Key);

            double modeValue = mode.FirstOrDefault();

            io.ResultOutput("Mode: {0}", modeValue);

            double[] sortedData = arithmeticList.OrderBy(x => x).ToArray();
            int q1Index = (int)Math.Ceiling(0.25 * (sortedData.Length + 1)) - 1;
            int medianIndex = (int)Math.Ceiling(0.5 * (sortedData.Length + 1)) - 1;
            int q3Index = (int)Math.Ceiling(0.75 * (sortedData.Length + 1)) - 1;

            double q1 = sortedData[q1Index];
            double median = sortedData[medianIndex];
            double q3 = sortedData[q3Index];

            io.ResultOutput("Q1: {0}", q1);
            io.ResultOutput("Median (Q2): {0}", median);
            io.ResultOutput("Q3: {0}", q3);


            double range = sortedData.Max() - sortedData.Min();
            io.ResultOutput("Range: {0}", range);

            double mad = arithmeticList.Average(x => Math.Abs(x - arithmeticMean));
            io.ResultOutput("Mean Absolute Deviation (MAD): {0}", mad);


            double variance = arithmeticList.Average(x => Math.Pow(x - arithmeticMean, 2));
            io.ResultOutput("Variance: {0}", variance);

            double standardDeviation = Math.Sqrt(arithmeticList.Average(x => Math.Pow(x - arithmeticMean, 2)));
            io.ResultOutput("Standard Deviation: {0}", standardDeviation);
        }


    }
        
        


    
}
