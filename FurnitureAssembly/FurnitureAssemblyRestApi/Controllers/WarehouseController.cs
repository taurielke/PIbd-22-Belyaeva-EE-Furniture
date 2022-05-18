using FurnitureAssemblyContracts.BusinessLogicsContracts;
using FurnitureAssemblyContracts.BindingModels;
using FurnitureAssemblyContracts.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureAssemblyRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseLogic _warehouseLogic;
        private readonly IComponentLogic _componentLogic;
        public WarehouseController(IWarehouseLogic warehouseLogic, IComponentLogic componentLogic)
        {
            _warehouseLogic = warehouseLogic;
            _componentLogic = componentLogic;
        }
        [HttpGet]
        public List<WarehouseViewModel> GetWarehouseList() => _warehouseLogic.Read(null)?.ToList();
        [HttpGet]
        public WarehouseViewModel GetWarehouse(int warehouseId) => _warehouseLogic.Read(new WarehouseBindingModel { Id = warehouseId })?[0];
        [HttpGet]
        public List<ComponentViewModel> GetComponentsList() => _componentLogic.Read(null)?.ToList();
        [HttpPost]
        public void CreateUpdateWarehouse(WarehouseBindingModel model) => _warehouseLogic.CreateOrUpdate(model);
        [HttpPost]
        public void DeleteWarehouse(WarehouseBindingModel model) => _warehouseLogic.Delete(model);
        [HttpPost]
        public void AddComponentWarehouse(WarehouseAddComponentsBindingModel model) => _warehouseLogic.AddComponent(new WarehouseBindingModel { Id = model.WarehouseId }, model.ComponentId, model.Count);
    }
}
