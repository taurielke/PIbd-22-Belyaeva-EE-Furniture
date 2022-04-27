using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureAssemblyContracts.BindingModels
{
    public class WarehouseAddComponentsBindingModel
    {
        public int WarehouseId { get; set; }
        public int ComponentId { get; set; }
        public int Count { get; set; }
    }
}
