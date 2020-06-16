﻿using System;
using DownloadSpeedChecker;

namespace InternetConfigurationManagement
{
    class Program
    {
        

        static void Main(string[] args)
        {
            decimal DownloadSpeed;

            string read = string.Empty;
            while (read != "q")
            {
                Console.WriteLine("1: Find Download Speed");
                Console.WriteLine("2: Find Dowload speed across ethernet");


                Console.WriteLine("q: Exit");
                read = Console.ReadLine();


                switch (read)
                {
                    case "1":
                        DownloadSpeed = DownloadSpeedo.FactoryDownloadSpeedo().DownloadSpeed;
                        Console.WriteLine($"Download speed {DownloadSpeed} Mb/s");
                        break;
                    case "2":
                        double dowloadSpeed = InternalEthernetSpeedTest.SpeedAcrossEthernet();
                        Console.WriteLine($"Speed across the network interface {dowloadSpeed} Mb/s");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
