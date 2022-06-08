using FurnitureAssemblyContracts.BusinessLogicsContracts;
using FurnitureAssemblyContracts.BindingModels;
using FurnitureAssemblyContracts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace FurnitureAssemblyRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IOrderLogic _order;
        private readonly IFurnitureLogic _furniture;
        private readonly IMessageInfoLogic _messageInfoLogic;
        public MainController(IOrderLogic order, IFurnitureLogic furniture, IMessageInfoLogic messageInfoLogic)
        {
            _order = order;
            _furniture = furniture;
            _messageInfoLogic = messageInfoLogic;
        }
        [HttpGet]
        public List<FurnitureViewModel> GetFurnitureList() => _furniture.Read(null)?.ToList();
        [HttpGet]
        public FurnitureViewModel GetFurniture(int furnitureId) => _furniture.Read(new FurnitureBindingModel { Id = furnitureId })?[0];
        [HttpGet]
        public List<OrderViewModel> GetOrders(int clientId) => _order.Read(new OrderBindingModel { ClientId = clientId });
        [HttpPost]
        public void CreateOrder(CreateOrderBindingModel model) => _order.CreateOrder(model);
    }

}
