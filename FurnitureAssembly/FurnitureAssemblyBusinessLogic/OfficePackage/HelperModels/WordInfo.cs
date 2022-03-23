using System;
using System.Collections.Generic;
using System.Text;
using FurnitureAssemblyContracts.ViewModels;

namespace FurnitureAssemblyBusinessLogic.OfficePackage.HelperModels
{
    public class WordInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<FurnitureViewModel> Furnitures { get; set; }
    }
}
