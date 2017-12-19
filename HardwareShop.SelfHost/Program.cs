using HardwareShop.Services;
using System;
using System.Diagnostics;
using System.ServiceModel;

namespace HardwareShop.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(HSService));
                host.Open();
                Console.WriteLine("Hit key to close the program");
                Console.ReadKey();
                host.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }
    }
}
