using ShopDev.Device;
using ShopDev.Components;
using System;

namespace ShopDev.Device
{
    class Desktop : DeviceIN
    {
        CPU cpu = new CPU(CPU.NumberCore.Cores_4);
        Mouse mouse = new Mouse(Mouse.Button.Button_2);
        RAM ram = new RAM(RAM.NumberRAM.Gb_16);
        ROM rom = new ROM(ROM.NumberROM.T_1);

        public DeviceIN Clone()
        {
            return new Desktop();
        }

        public void GetInformationDevice()
        {
            Console.WriteLine(
                $"CPU: {cpu.ToString()}\n" +
                $"Mouse: {mouse.ToString()}\n" +
                $"RAM: {ram.ToString()}\n" +
                $"ROM: {rom.ToString()}\n"
                );
        }
    }
}
