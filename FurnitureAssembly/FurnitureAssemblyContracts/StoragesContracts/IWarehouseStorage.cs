﻿using System;
using System.Collections.Generic;
using System.Text;
using FurnitureAssemblyContracts.BindingModels;
using FurnitureAssemblyContracts.ViewModels;

namespace FurnitureAssemblyContracts.StoragesContracts
{
    public interface IWarehouseStorage
    {
        List<WarehouseViewModel> GetFullList();
        List<WarehouseViewModel> GetFilteredList(WarehouseBindingModel model);
        WarehouseViewModel GetElement(WarehouseBindingModel model);
        void Insert(WarehouseBindingModel model);
        void Update(WarehouseBindingModel model);
        void Delete(WarehouseBindingModel model);
        bool CheckComponentsAmount(int amount, Dictionary<int, (string, int)> components);
    }
}
