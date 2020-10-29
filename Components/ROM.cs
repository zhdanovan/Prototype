using ShopDev.Components;

namespace ShopDev.Components
{
    class ROM : ComponentsIN
    {
        public enum NumberROM
        {
            Gb_128,
            Gb_320,
            Gb_512,
            T_1
        }

        public NumberROM rom { get; set; }

        public ROM(NumberROM rom)
        {
            this.rom = rom;
        }

        public override string ToString()
        {
            switch (this.rom)
            {
                case NumberROM.Gb_128:
                    return "128Gb";

                case NumberROM.Gb_320:
                    return "320Gb";

                case NumberROM.Gb_512:
                    return "512Gb";

                case NumberROM.T_1:
                    return "1T";

                default:
                    return "-";
            }
        }
    }
}
