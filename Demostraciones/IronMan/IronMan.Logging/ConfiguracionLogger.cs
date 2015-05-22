using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.Formatters;
using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;
using System.Diagnostics;

namespace IronMan.Logging
{
    public class ConfiguracionLogger
    {
        string _s;

        public ConfiguracionLogger(string s)
        {
            _s = s;
        }

        public void ConfigurarLogger()
        {
            Console.WriteLine(_s);
        }

//        public LoggingConfiguration ConfigurarLogger()
//        {
//            // Formateador
//            TextFormatter formatter = new TextFormatter(
//                        @"Timestamp:{timestamp(local)}{newline}
//                        Message:{message}{newline}
//                        Category: {category}{newline}
//                        Priority: {priority}{newline}
//                        EventId: {eventid}{newline}
//                        ActivityId:{property(ActivityId)}{newline}
//                        Severity:{severity}{newline}Title:{title}{newline}");

//            // Trace Listeners
//            var eventLog = new EventLog("Aplicacion", ".", "IroMan");
//            var eventLogTraceListener = new FormattedEventLogTraceListener(
//               eventLog,
//               formatter
//             );
//            var flatFileTraceListener = new FlatFileTraceListener(
//                @"C:\Temp\trace.log",
//                "----------------------------------------",
//                "----------------------------------------",
//                formatter);



//            // Build Configuration
//            var config = new LoggingConfiguration();

//            config.AddLogSource(
//               Category.General,
//               SourceLevels.All,
//               true).AddTraceListener(eventLogTraceListener);

//            config.AddLogSource(Category.Trace, SourceLevels.ActivityTracing,
//               true).AddTraceListener(flatFileTraceListener);

//            config.IsTracingEnabled = true;
//            return config;
//        }
    }
}
