using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BLL.Metrics
{
    public class ExclamationSentencesMetric : ISimpleMetric
    {
        public string CalculateMetric(string text)
        {
            string[] sentences = Regex.Split(text, @"(?<=[\!])\s+");
            int result = sentences.Where(i => i.Contains('!')).Count();
            return $"There are {result} exclamation sentences in the text";
        }
    }
}
