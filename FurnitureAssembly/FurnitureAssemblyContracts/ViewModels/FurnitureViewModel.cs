using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace FurnitureAssemblyContracts.ViewModels
{
    public class FurnitureViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название изделия")]
        public string FurnitureName { get; set; }

        [DisplayName("Цена")]
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> FurnitureComponents { get; set; }
    }
}
