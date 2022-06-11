using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using FurnitureAssemblyContracts.Attributes;
using System.Runtime.Serialization;

namespace FurnitureAssemblyContracts.ViewModels
{
    public class ComponentViewModel
    {
        [Column(title: "Номер", width: 100)]
        public int Id { get; set; }
        [Column(title: "Название компонента", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ComponentName { get; set; }

    }
}
