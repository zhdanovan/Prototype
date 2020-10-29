using System;
using ShopDev.Device;
using ShopDev.Device;

namespace ShopDev
{
    public class Shop
    {
        private Desktop desktop = new Desktop();
        private Laptop laptop = new Laptop();
        private Notebook notebook = new Notebook();
        private Tablet tablet = new Tablet();

        public DeviceIN SetDevice(string choiceDevice)
        {
            switch(choiceDevice)
            {
                case "Desktop":
                    return desktop.Clone();

                case "desktop":
                    return desktop.Clone();

                case "Laptop":
                    return laptop.Clone();

                case "laptop":
                    return laptop.Clone();

                case "Notebook":
                    return notebook.Clone();

                case "notebook":
                    return notebook.Clone();

                case "Tablet":
                    return tablet.Clone();

                case "tablet":
                    return tablet.Clone();

                default:
                    throw new ArgumentException("This device is not available in our store or you entered the wrong name");
            }
        }
    }
}
