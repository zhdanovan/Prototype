using System;
using ShopDev.Device;

namespace ShopDev
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shop shop = new Shop();

                Console.Write("Enter  device: ");
                string choiceDevice = Console.ReadLine();

                Console.WriteLine();

                DeviceIN device = shop.SetDevice(choiceDevice);

                device.GetInformationDevice();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
