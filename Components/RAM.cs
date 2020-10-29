using ShopDev.Components;

namespace ShopDev.Components
{
    class RAM : ComponentsIN
    {
        public enum NumberRAM
        {
            Gb_2,
            Gb_4,
            Gb_8,
            Gb_16
        }

        public NumberRAM ram { get; set; }

        public RAM(NumberRAM ram)
        {
            this.ram = ram;
        }

        public override string ToString()
        {
            switch (this.ram)
            {
                case NumberRAM.Gb_2:
                    return "2Gb";

                case NumberRAM.Gb_4:
                    return "4Gb";

                case NumberRAM.Gb_8:
                    return "8Gb";

                case NumberRAM.Gb_16:
                    return "16Gb";

                default:
                    return "-";
            }
        }
    }
}
