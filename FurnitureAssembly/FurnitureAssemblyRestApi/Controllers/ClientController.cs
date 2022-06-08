using FurnitureAssemblyContracts.BusinessLogicsContracts;
using FurnitureAssemblyContracts.BindingModels;
using FurnitureAssemblyContracts.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureAssemblyRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientLogic _logic;
        private readonly IMessageInfoLogic _messageInfoLogic;
        private readonly int messagesPage = 3;
        public ClientController(IClientLogic logic, IMessageInfoLogic messageInfoLogic)
        {
            _logic = logic;
            _messageInfoLogic = messageInfoLogic;
        }
        [HttpGet]
        public ClientViewModel Login(string login, string password)
        {
            var list = _logic.Read(new ClientBindingModel
            {
                Email = login,
                Password = password
            });
            return (list != null && list.Count > 0) ? list[0] : null;
        }
        [HttpPost]
        public void Register(ClientBindingModel model) => _logic.CreateOrUpdate(model);
        [HttpPost]
        public void UpdateData(ClientBindingModel model) => _logic.CreateOrUpdate(model);
        [HttpGet]
        public (List<MessageInfoViewModel>, bool) GetClientsMessageInfo(int clientId, int page)
        {
            var list = _messageInfoLogic.Read(new MessageInfoBindingModel
            {
                ClientId = clientId,
                ToSkip = (page - 1) * messagesPage,
                ToTake = messagesPage + 1
            }).ToList();
            var isNext = !(list.Count() <= messagesPage);
            return (list.Take(messagesPage).ToList(), isNext);
        }
    }
}
