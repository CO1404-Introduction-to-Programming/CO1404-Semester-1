using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Extra C# libraries required for network communications
using System.Net;
using System.Net.NetworkInformation;

namespace NetworkToolbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demonstration of some networking features from the C# libraries
            // You are not expected to learn these features, although you should recognise some of the code features
            // The lab exercise is to split this code up into methods

            //-----------------------------------------
            // Display the IP addresses for a host name
            //-----------------------------------------
            // Notice the use of arrays, similar to accessing file names in the assignment
            string hostName = "bbc.co.uk";
            IPAddress[] ipAddresses = Dns.GetHostAddresses(hostName);

            Console.WriteLine("IP addresses for {0}", hostName);
            for (int i = 0; i < ipAddresses.Length; i++)
            {
                Console.WriteLine(" {0}: {1}", i+1, ipAddresses[i].ToString());
            }


            // Wait for user to press enter
            Console.WriteLine();
            Console.Write("Press Enter to continue...");
            Console.ReadLine();
            Console.WriteLine();


            //------------------------------------
            // Display host name for an IP address
            //------------------------------------
            string ipAddress = "74.125.142.147";
            IPHostEntry host = Dns.GetHostEntry(ipAddress);
            Console.WriteLine("Host name for {0}: {1}", ipAddress, host.HostName);


            // Wait for user to press enter
            Console.WriteLine();
            Console.Write("Press Enter to continue...");
            Console.ReadLine();
            Console.WriteLine();


            //--------------------------------------------------
            // Ping a host (check if we can communicate with it)
            //--------------------------------------------------
            string pingHost = "www.uclan.ac.uk"; // Change to 127.0.0.1 in the labs if destination unreachable
            Console.WriteLine("Pinging {0}...", pingHost);
            
            Ping ping = new Ping();
            PingReply pingreply = ping.Send(pingHost); // This may cause your firewall to raise an alert
            
            Console.WriteLine("Ping Status: {0}", pingreply.Status.ToString());
            Console.WriteLine("Round Trip Time: {0}ms", pingreply.RoundtripTime);


            // Wait for user to press enter
            Console.WriteLine();
            Console.Write("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}


