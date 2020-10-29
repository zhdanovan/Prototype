using ShopDev.Components;

namespace ShopDev.Components
{
    class Display : ComponentsIN
    {
        public enum Format
        {
            HD,
            FullHD,
            UltraHD
        }

        public Format format { get; set; }

        public Display(Format format)
        {
            this.format = format;
        }

        public override string ToString()
        {
            switch (this.format)
            {
                case Format.HD:
                    return "HD";

                case Format.FullHD:
                    return "FullHD";

                case Format.UltraHD:
                    return "UltraHD";

                default:
                    return "-";
            }
        }
    }
}
