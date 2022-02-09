﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace FurnitureAssemblyContracts.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int FurnitureId { get; set; }
        [DisplayName("Изделие")]
        public string FurnitureName { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }
        [DisplayName("Сумма")]
        public decimal Sum { get; set; }
        [DisplayName("Статус")]
        public string Status { get; set; }
        [DisplayName("Дата создания")]
        public DateTime DateCreate { get; set; }
        [DisplayName("Дата выполнения")]
        public DateTime? DateImplement { get; set; }

    }
}
