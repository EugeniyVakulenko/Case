using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Metrics
{
    public class WordsInTextMetric : ISimpleMetric
    {
        public string CalculateMetric(string text)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '!', '?' };
            int result = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries).Length;
            return $"There are {result} words in the text";
        }
    }
}
