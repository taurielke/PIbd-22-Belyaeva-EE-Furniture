using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using FurnitureAssemblyContracts.Attributes;
using System.Runtime.Serialization;

namespace FurnitureAssemblyContracts.ViewModels
{
    public class FurnitureViewModel
    {
        [Column(title: "Номер", width: 100)]
        public int Id { get; set; }

        [Column(title: "Название изделия", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string FurnitureName { get; set; }

        [Column(title: "Цена", gridViewAutoSize: GridViewAutoSize.Fill)]
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> FurnitureComponents { get; set; }
    }
}
