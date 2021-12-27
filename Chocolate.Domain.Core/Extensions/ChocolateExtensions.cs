using Chocolate.Domain.Core.Dtos;
using Chocolate.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chocolate.Domain.Core.Extensions
{
    public static class ChocolateExtensions
    {
        public static ChocolateDto ToChocolateDto(this ChocolateEntity chocolateEntity)
            => new ChocolateDto
            {
                Id = chocolateEntity.Id,
                Calories = chocolateEntity.Calories,
                CocoaVolume = chocolateEntity.CocoaVolume,
                CountryOrigin = chocolateEntity.CountryOrigin,
                Manufacturer = chocolateEntity.Manufacturer,
                SugarVolume = chocolateEntity.SugarVolume,
                Name =  chocolateEntity.Name,
                Type = chocolateEntity.Type
            };
    }
}
