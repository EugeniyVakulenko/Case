using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Metrics
{
    class MostOccurencesMetric : ISimpleMetric
    {
        public string CalculateMetric(string text)
        {
            char result = text.Where(i => i != ' ').GroupBy(i => i).OrderByDescending(i => i.Count()).First().Key;
            return $"Character '{result}' has the most ocurrences in the text";
        }
    }
}
