using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace FurnitureAssemblyContracts.ViewModels
{
    public class ImplementerViewModel
    {
        public int Id { get; set; }

        [DisplayName("ФИО исполнителя")]
        public string ImplementerFIO { get; set; }

        [DisplayName("Время работы")]
        public int WorkingTime { get; set; }

        [DisplayName("Время отдыха")]
        public int PauseTime { get; set; }
    }
}
