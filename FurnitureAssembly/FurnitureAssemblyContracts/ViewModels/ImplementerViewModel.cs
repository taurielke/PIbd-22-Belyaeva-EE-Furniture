using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using FurnitureAssemblyContracts.Attributes;
using System.Runtime.Serialization;

namespace FurnitureAssemblyContracts.ViewModels
{
    public class ImplementerViewModel
    {
        [Column(title: "Номер", width: 100)]
        public int Id { get; set; }

        [Column(title: "Исполнитель", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ImplementerFIO { get; set; }

        [Column(title: "Время работы", gridViewAutoSize: GridViewAutoSize.Fill)]
        public int WorkingTime { get; set; }

        [Column(title: "Время отдыха", gridViewAutoSize: GridViewAutoSize.Fill)]
        public int PauseTime { get; set; }
    }
}
