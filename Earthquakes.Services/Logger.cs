using Earthquakes.Services.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earthquakes.Services
{
    public class Logger : ILogger
    {
        public void LogError(Exception exception)
        {
            var text = $"{DateTime.Now} - {exception.Message}";
            using(var stream = File.Open("error.log", FileMode.Append))
            {
                var data = Encoding.UTF8.GetBytes(text);
                stream.Write(data, 0, data.Length);
            }
        }

        public void LogMessage(string message)
        {
            var text = $"{DateTime.Now} - {message}";
            using (var stream = File.Open("info.log", FileMode.Append))
            {
                var data = Encoding.UTF8.GetBytes(text);
                stream.Write(data, 0, data.Length);
            }
        }
    }
}
