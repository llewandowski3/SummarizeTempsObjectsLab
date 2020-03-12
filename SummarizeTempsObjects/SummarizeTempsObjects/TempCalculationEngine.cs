using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            // add logic to calculate the average

            int sumOfTemps = 0;

            // Loop through all the temps in the list

            foreach (int temp in _temperatures)
            {
                // Add each temp to my sum variable
                sumOfTemps += temp;
                // sumOfTemps = sumOfTemps + temp;
            }

            // divide sum variable by the list count
            int averageTemps = sumOfTemps / _temperatures.Count;
            return averageTemps; 

        }

        public int TempsAboveThreshold(int threshold)
        {
            // add logic to calculate temps above the threshold

            int Abovesum = 0;

            foreach (int temp in _temperatures)
            {
                if (temp > threshold)
                {
                    Abovesum += 1;
                }

            }
            return Abovesum; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            // add logic to calculate and return temps below the threshold

            int Belowsum = 0;

            foreach (int temp in _temperatures)
            {
                if (temp < threshold)
                {
                    Belowsum += 1;
                }

            }
            return Belowsum; // <-- Replace this with the number

        }


        public int TempsAtThreshold(int threshold)
        {
            // add logic to calculate and return temps at the threshold

            int Atsum = 0;

            foreach (int temp in _temperatures)
            {
                if (temp == threshold)
                {
                    Atsum += 1;
                }

            }
            return Atsum; // <-- Replace this with the number

        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            return _temperatures.Count; // <-- Replace this with the number
        }
    }
}
