using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DownloadSpeedChecker
{
    public static class InternalEthernetSpeedTest
    {
        public static double SpeedAcrossEthernet()
        {
            NetworkInterface[] networks = NetworkInterface.GetAllNetworkInterfaces();

            NetworkInterface ethernetNetwork = networks.FirstOrDefault(x => x.Name.ToLower() == "wifi" && x.OperationalStatus == OperationalStatus.Up);

            ReadRequest GetRequest = new ReadRequest();
            Console.WriteLine("Measurement in progress");
            Task downloadTask = GetRequest.init(new Uri("http://ipv4.download.thinkbroadband.com/10MB.zip"));

            ICollection<long> times = new Collection<long>();

            while(!downloadTask.IsCompleted)
            {
                times.Add(ethernetNetwork.Speed);
                Thread.Sleep(500);
                ConsoleSpiner.Spin();
            }

            double normalisedSpeed = times.Average() / 10000000;

            return normalisedSpeed;
        }
    }
}
