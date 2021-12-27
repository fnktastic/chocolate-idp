using Chocolate.Domain.Core.Enums;
using System;

namespace Chocolate.Domain.Core.Entities
{
    public partial class ChocolateEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public ChocolateType Type { get; set; }
        public string CountryOrigin { get; set; }
        public float SugarVolume { get; set; }
        public float CocoaVolume { get; set; }
        public float Calories { get; set; }
    }
}
