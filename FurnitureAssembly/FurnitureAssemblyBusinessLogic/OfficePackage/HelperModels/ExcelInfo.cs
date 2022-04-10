using System;
using System.Collections.Generic;
using System.Text;
using FurnitureAssemblyContracts.ViewModels;

namespace FurnitureAssemblyBusinessLogic.OfficePackage.HelperModels
{
    public class ExcelInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ReportFurnitureComponentViewModel> FurnitureComponents { get; set; }
        public List<ReportWarehouseComponentViewModel> WarehouseComponents { get; set; }
    }
}
