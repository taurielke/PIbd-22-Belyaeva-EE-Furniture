using FurnitureAssemblyBusinessLogic.OfficePackage;
using FurnitureAssemblyBusinessLogic.OfficePackage.HelperModels;
using FurnitureAssemblyContracts.BindingModels;
using FurnitureAssemblyContracts.BusinessLogicsContracts;
using FurnitureAssemblyContracts.StoragesContracts;
using FurnitureAssemblyContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureAssemblyBusinessLogic.BusinessLogics
{
    public class ReportLogic : IReportLogic
    {
        private readonly IComponentStorage _componentStorage;
        private readonly IFurnitureStorage _furnitureStorage;
        private readonly IOrderStorage _orderStorage;
        private readonly IWarehouseStorage _warehouseStorage;
        private readonly AbstractSaveToExcel _saveToExcel;
        private readonly AbstractSaveToWord _saveToWord;
        private readonly AbstractSaveToPdf _saveToPdf;
        public ReportLogic(IWarehouseStorage warehouseStorage, IFurnitureStorage furnitureStorage, IComponentStorage componentStorage, IOrderStorage orderStorage,
        AbstractSaveToExcel saveToExcel, AbstractSaveToWord saveToWord, AbstractSaveToPdf saveToPdf)
        {
            _furnitureStorage = furnitureStorage;
            _componentStorage = componentStorage;
            _orderStorage = orderStorage;
            _warehouseStorage = warehouseStorage;
            _saveToExcel = saveToExcel;
            _saveToWord = saveToWord;
            _saveToPdf = saveToPdf;
        }
        public List<ReportFurnitureComponentViewModel> GetFurnitureComponent()
        {
            var components = _componentStorage.GetFullList();
            var furnitures = _furnitureStorage.GetFullList();
            var list = new List<ReportFurnitureComponentViewModel>();
            foreach (var furniture in furnitures)
            {
                var record = new ReportFurnitureComponentViewModel
                {
                    FurnitureName = furniture.FurnitureName,
                    Components = new List<Tuple<string, int>>(),
                    TotalCount = 0
                };
                foreach (var component in components)
                {
                    if (furniture.FurnitureComponents.ContainsKey(component.Id))
                    {
                        record.Components.Add(new Tuple<string, int>(component.ComponentName, furniture.FurnitureComponents[component.Id].Item2));
                        record.TotalCount += furniture.FurnitureComponents[component.Id].Item2;
                    }
                }
                list.Add(record);
            }
            return list;
        }
        public List<ReportWarehouseComponentViewModel> GetWarehouseComponent()
        {
            var warehouses = _warehouseStorage.GetFullList();
            var list = new List<ReportWarehouseComponentViewModel>();
            foreach (var warehouse in warehouses)
            {
                var record = new ReportWarehouseComponentViewModel
                {
                    WarehouseName = warehouse.WarehouseName,
                    Components = new List<Tuple<string, int>>(),
                    TotalCount = 0
                };
                foreach (var component in warehouse.WarehouseComponents)
                {
                    record.Components.Add(new Tuple<string, int>(component.Value.Item1, component.Value.Item2));
                    record.TotalCount += component.Value.Item2;
                }
                list.Add(record);
            }
            return list;
        }

        public List<ReportOrdersGroupedByDateViewModel> GetOrdersGroupedByDate()
        {
            return _orderStorage.GetFullList()
            .GroupBy(rec => rec.DateCreate.ToShortDateString())
            .Select(x => new ReportOrdersGroupedByDateViewModel
            {
                DateCreate = Convert.ToDateTime(x.Key),
                Count = x.Count(),
                Sum = x.Sum(rec => rec.Sum)
            })
           .ToList();
        }
        public List<ReportOrdersViewModel> GetOrders(ReportBindingModel model)
        {
            return _orderStorage.GetFilteredList(new OrderBindingModel
            {
                DateFrom = model.DateFrom,
                DateTo = model.DateTo
            }).Select(x => new ReportOrdersViewModel
            {
                DateCreate = x.DateCreate,
                FurnitureName = x.FurnitureName,
                Count = x.Count,
                Sum = x.Sum,
                Status = x.Status
            }).ToList();
        }

        public void SaveFurnituresToWordFile(ReportBindingModel model)
        {
            _saveToWord.CreateDoc(new WordInfo
            {
                FileName = model.FileName,
                Title = "Список изделий", 
                Furnitures = _furnitureStorage.GetFullList()
            });
        }
        public void SaveWarehousesToWordFile(ReportBindingModel model)
        {
            _saveToWord.CreateDocWarehouse(new WordInfo
            {
                FileName = model.FileName,
                Title = "Список складов",
                Warehouses = _warehouseStorage.GetFullList()
            });
        }
        public void SaveFurnitureComponentToExcelFile(ReportBindingModel model)
        {
            _saveToExcel.CreateReport(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "Список изделий и содержащихся в них компонентов",
                FurnitureComponents = GetFurnitureComponent()
            });
        }

        public void SaveWarehouseComponentToExcelFile(ReportBindingModel model)
        {
            _saveToExcel.CreateReportWarehouse(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "Загруженность складов",
                WarehouseComponents = GetWarehouseComponent()
            });
        }
        public void SaveOrdersToPdfFile(ReportBindingModel model)
        {
            _saveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Список заказов",
                DateFrom = model.DateFrom.Value,
                DateTo = model.DateTo.Value,
                Orders = GetOrders(model)
            });
        }
        public void SaveOrdersGroupedByDateToPdfFile(ReportBindingModel model)
        {
            _saveToPdf.CreateDocOrdersGroupedByDate(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Список заказов, объединенных по датам",
                OrdersGroupedByDate = GetOrdersGroupedByDate()
            });
        }

    }
}
