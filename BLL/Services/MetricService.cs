using BLL.Interfaces;
using BLL.Metrics;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class MetricService : IMetricService
    {
        private readonly List<Metric> metrics = new List<Metric>
            {
                new Metric(1,"Most occuring character in the text",new MostOccurencesMetric()),
                new Metric(2,"Number of words in the text",new WordsInTextMetric()),
                new Metric(3,"Number of exclamation sentences in the text",new ExclamationSentencesMetric()),
                new Metric(4,"Number of average characters in the word",new AverageCharactersMetric()),
                new Metric(5,"Number of question sentences in the text",new QuestionsMetric()),
                new Metric(6,"Number of commas in the text",new CommaMetric())
            };
      
        public string DoMetric(int id, string text)
        {
            foreach(var item in metrics)
            {
                if(item.Id == id)
                {
                    return item.DoMetric(text);
                }
            }
            return null;
        }

        public List<Metric> GetAllMetrics()
        {
            return metrics;
        }
    }
}
