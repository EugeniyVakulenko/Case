using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BLL.Metrics
{
    class CommaMetric : ISimpleMetric
    {
        public string CalculateMetric(string text)
        {
            int result = text.Where(i => i == ',').Count();
            return $"There are {result} commas in the text";
        }
    }
}
