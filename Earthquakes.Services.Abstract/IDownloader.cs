namespace Earthquakes.Services.Abstract
{
    public interface IDownloader
    {
        string DownloadInfo(string url);
    }
}
