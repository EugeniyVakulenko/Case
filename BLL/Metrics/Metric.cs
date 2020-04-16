using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Metrics
{
    public class Metric
    {
        public int Id { get; set; }
        public string Description { get; set; }
        private ISimpleMetric _metric;
        public Metric() { }
        public Metric(int id, string description, ISimpleMetric metric) { 
            _metric = metric;
            Description = description;
            Id = id;
        }
        public ISimpleMetric SimpleMetric { set { _metric = value; } }
        public string DoMetric(string text)
        {
            return _metric.CalculateMetric(text);
        }
    }
}
