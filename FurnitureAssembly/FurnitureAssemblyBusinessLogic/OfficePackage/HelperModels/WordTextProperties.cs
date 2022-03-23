﻿using System;
using System.Collections.Generic;
using System.Text;
using FurnitureAssemblyBusinessLogic.OfficePackage.HelperEnums;

namespace FurnitureAssemblyBusinessLogic.OfficePackage.HelperModels
{
    public class WordTextProperties
    {
        public string Size { get; set; }
        public bool Bold { get; set; }
        public WordJustificationType JustificationType { get; set; }
    }
}
