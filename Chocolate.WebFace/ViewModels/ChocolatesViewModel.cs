using Chocolate.Domain.Core.Dtos;
using System.Collections;
using System.Collections.Generic;

namespace Chocolate.WebFace.ViewModels
{
    public class ChocolatesViewModel
    {
        public IEnumerable<ChocolateDto> Chocolates { get; set; }
    }
}
