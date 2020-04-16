using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Metrics
{
    public class AverageCharactersMetric : ISimpleMetric
    {
        public string CalculateMetric(string text)
        {
            float avg, sum = 0;
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '!', '?' };
            string[] words = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in words)
            {
                sum += item.Trim().Length;
            }
            avg = sum / words.Length;
            return $"There are {avg} characters in one word average";
        }
    }
}
