using Chocolate.Domain.Core.Enums;

namespace Chocolate.Domain.Core.Dtos
{
    public class ChocolateDto
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public ChocolateType Type { get; set; }
        public string CountryOrigin { get; set; }
        public float SugarVolume { get; set; }
        public float CocoaVolume { get; set; }
        public float Calories { get; set; }
    }
}
