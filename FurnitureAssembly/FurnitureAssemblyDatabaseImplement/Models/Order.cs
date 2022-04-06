﻿using System;
using System.Collections.Generic;
using System.Text;
using FurnitureAssemblyContracts.Enums;
using System.ComponentModel.DataAnnotations;

namespace FurnitureAssemblyDatabaseImplement.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        [Required]
        public int FurnitureId { get; set; }  
        [Required]
        public int Count { get; set; }
        [Required]
        public decimal Sum { get; set; }
        [Required]
        public OrderStatus Status { get; set; }
        [Required]
        public DateTime DateCreate { get; set; }
        public DateTime? DateImplement { get; set; }
        public virtual Furniture Furniture { get; set; }
        public virtual Client Client { get; set; }
    }
}
