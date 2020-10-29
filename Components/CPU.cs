using ShopDev.Components;

namespace ShopDev.Components
{
    public class CPU : ComponentsIN
    {
        public enum NumberCore
        {
            Cores_2,
            Cores_4,
            Cores_8
        }

        public NumberCore cores { get; set; }

        public CPU (NumberCore cores)
        {
            this.cores = cores;
        }

        public override string ToString()
        {
            switch(cores)
            {
                case NumberCore.Cores_2:
                    return "2 cores";

                case NumberCore.Cores_4:
                    return "4 cores";

                case NumberCore.Cores_8:
                    return "8 cores";

                default:
                    return "-";
            }
        }
    }
}
