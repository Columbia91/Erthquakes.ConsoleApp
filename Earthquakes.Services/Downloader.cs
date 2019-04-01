using System;
using System.Net;
using Earthquakes.Services.Abstract;

namespace Earthquakes.Services
{
    public class Downloader : IDownloader
    {
        private readonly ILogger logger;

        public Downloader(ILogger logger)
        {
            this.logger = logger;
        }

        public string DownloadInfo(string url)
        {
            using(var client = new WebClient())
            {
                try
                {
                    return client.DownloadString(url);
                }
                catch (WebException exception)
                {
                    logger.LogError(exception);
                    return exception.Message;
                }
                catch (Exception exception)
                {
                    logger.LogError(exception);
                    return exception.Message;
                }
            }
        }
    }
}
