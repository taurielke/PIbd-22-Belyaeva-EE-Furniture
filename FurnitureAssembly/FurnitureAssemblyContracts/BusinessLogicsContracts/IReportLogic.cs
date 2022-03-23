using System;
using System.Collections.Generic;
using System.Text;
using FurnitureAssemblyContracts.BindingModels;
using FurnitureAssemblyContracts.ViewModels;

namespace FurnitureAssemblyContracts.BusinessLogicsContracts
{
    public interface IReportLogic
    {
        List<ReportFurnitureComponentViewModel> GetFurnitureComponent();
        List<ReportOrdersViewModel> GetOrders(ReportBindingModel model);
        void SaveFurnituresToWordFile(ReportBindingModel model);
        void SaveFurnitureComponentToExcelFile(ReportBindingModel model);
        void SaveOrdersToPdfFile(ReportBindingModel model);
    }
}
