using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureAssemblyContracts.BindingModels
{
    public class CreateOrderBindingModel
    {
        public int FurnitureId { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }

    }
}
