using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace DownloadSpeedChecker
{
    public class DownloadSpeedo
    {
        public double DownloadSpeed { get => DownloadSpeedCalc(new Uri("http://ipv4.download.thinkbroadband.com/10MB.zip"));}


        /// <summary>
        /// Find the download speed by downloading a some large files.
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        private double DownloadSpeedCalc(Uri uri)
        {
            
            Stopwatch watch = new Stopwatch();
            ReadRequest GetRequest = new ReadRequest();

            watch.Reset();
            //Test go
            Console.WriteLine("Measurement in progress");
            watch.Start();
            Task<byte[]> byteSize = GetRequest.init(uri);

            while (!byteSize.IsCompleted)
            {
                Thread.Sleep(500);
                ConsoleSpiner.Spin();
            }

            watch.Stop();

            //Convert bytes to bits, and times to get it in Mb
            decimal bits = ((Convert.ToDecimal(byteSize.Result.LongLength) * 8) / 1000000);

            //Time is in milliseconds, so convert to seconds and multiply to get the download speed
            return (double)Math.Round(bits * 1000 / watch.ElapsedMilliseconds, 0);
        }

        public static DownloadSpeedo FactoryDownloadSpeedo()
        {
            return new DownloadSpeedo();
        }
    }
}
