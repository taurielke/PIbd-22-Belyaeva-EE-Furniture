using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureAssemblyContracts.ViewModels
{
    public class ReportOrdersGroupedByDateViewModel
    {
        public DateTime DateCreate { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
    }
}
