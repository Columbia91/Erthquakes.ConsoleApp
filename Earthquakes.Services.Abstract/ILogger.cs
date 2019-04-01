using System;

namespace Earthquakes.Services.Abstract
{
    public interface ILogger
    {
        void LogError(Exception exception);
        void LogMessage(string message);
    }
}
