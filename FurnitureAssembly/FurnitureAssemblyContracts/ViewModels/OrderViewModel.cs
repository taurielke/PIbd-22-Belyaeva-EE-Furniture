﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using FurnitureAssemblyContracts.Attributes;
using System.Runtime.Serialization;

namespace FurnitureAssemblyContracts.ViewModels
{
    public class OrderViewModel
    {
        [Column(title: "Номер", width: 100)]
        public int Id { get; set; }
        public int ClientId { get; set; }
        [Column(title: "Клиент", width: 150)]
        public string ClientFIO { get; set; }
        public int? ImplementerId { get; set; }
        [Column(title: "Исполнитель", width: 150)]
        public string ImplementerFIO { get; set; }
        public int FurnitureId { get; set; }
        [Column(title: "Изделие", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string FurnitureName { get; set; }
        [Column(title: "Количество", width: 100)]
        public int Count { get; set; }
        [Column(title: "Сумма", width: 50)]
        public decimal Sum { get; set; }
        [Column(title: "Статус", width: 100)]
        public string Status { get; set; }
        [Column(title: "Дата создания", width: 100)]
        public DateTime DateCreate { get; set; }
        [Column(title: "Дата выполнения", width: 100)]
        public DateTime? DateImplement { get; set; }

    }
}
