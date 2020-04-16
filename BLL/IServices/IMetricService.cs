using BLL.Metrics;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IMetricService
    {
        public List<Metric> GetAllMetrics();
        public string DoMetric(int id, string text);
    }
}
