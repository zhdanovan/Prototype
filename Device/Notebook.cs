using System;
using ShopDev.Device;
using ShopDev.Components;

namespace ShopDev.Device
{
    class Notebook : DeviceIN
    {
        Keyboard keyboard = new Keyboard(Keyboard.Buttons.Buttons_108);
        Display display = new Display(Display.Format.FullHD);
        TouchPad touchPad = new TouchPad(TouchPad.Button.Button_1);
        CPU cpu = new CPU(CPU.NumberCore.Cores_2);
        RAM ram = new RAM(RAM.NumberRAM.Gb_8);
        ROM rom = new ROM(ROM.NumberROM.Gb_512);

        public DeviceIN Clone()
        {
            return new Notebook();
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
