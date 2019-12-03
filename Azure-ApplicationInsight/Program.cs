using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure_ApplicationInsight
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime _correlationTimeId = DateTime.UtcNow;
            string _correlationId = Guid.NewGuid().ToString();
            string _traceMessage = $"Starting sales service {DateTime.UtcNow.ToString()}";
            AppInsightHelper.Instance.AppInsightInit(new AppInsightPayload
            {
                _operation = "SketcherSale",
                _type = AppInsightLanguage.AppInsightTrace,
                _payload = _traceMessage,
                _correlationId = _correlationId,
                _correlationTimeId = _correlationTimeId

            });
        }
    }
}
