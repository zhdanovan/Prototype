using System;
using ShopDev.Components;
using ShopDev.Device;

namespace ShopDev.Device
{
    class Laptop : DeviceIN
    {
        Keyboard keyboard = new Keyboard(Keyboard.Buttons.Buttons_101);
        Display display = new Display(Display.Format.HD);
        TouchPad touchPad = new TouchPad(TouchPad.Button.Buttons_2);
        CPU cpu = new CPU(CPU.NumberCore.Cores_2);
        RAM ram = new RAM(RAM.NumberRAM.Gb_4);
        ROM rom = new ROM(ROM.NumberROM.Gb_320);

        public DeviceIN Clone()
        {
            return new Laptop();
        }

        public void GetInformationDevice()
        {
            Console.WriteLine(
                $"Keyboard: {keyboard.ToString()}\n" +
                $"Display: {display.ToString()}\n" +
                $"TouchPad: {touchPad.ToString()}\n" +
                $"CPU: {cpu.ToString()}\n" +
                $"RAM: {ram.ToString()}\n" +
                $"ROM: {rom.ToString()}"
                );
        }
    }
}
