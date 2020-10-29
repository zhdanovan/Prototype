using System;
using ShopDev.Components;
using ShopDev.Device;

namespace ShopDev.Device
{
    class Tablet : DeviceIN
    {
        Display display = new Display(Display.Format.UltraHD);
        CPU cpu = new CPU(CPU.NumberCore.Cores_8);
        RAM ram = new RAM(RAM.NumberRAM.Gb_2);
        ROM rom = new ROM(ROM.NumberROM.Gb_128);

        public DeviceIN Clone()
        {
            return new Tablet();
        }

        public void GetInformationDevice()
        {
            Console.WriteLine(
                $"Display: {display.ToString()}\n" +
                $"CPU: {cpu.ToString()}\n" +
                $"RAM: {ram.ToString()}\n" +
                $"ROM: {rom.ToString()}\n"
                );
        }
    }
}
