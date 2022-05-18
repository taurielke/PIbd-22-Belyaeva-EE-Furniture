using FurnitureAssemblyWarehouseApp.Models;
using FurnitureAssemblyContracts.BindingModels;
using FurnitureAssemblyContracts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace FurnitureAssemblyWarehouseApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            if (Program.Authorized == false)
            {
                return Redirect("~/Home/Enter");
            }
            return View(APIClient.GetRequest<List<WarehouseViewModel>>($"api/Warehouse/GetWarehouseList"));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult Enter()
        {
            return View();
        }
        [HttpPost]
        public void Enter(string password)
        {
            if (!string.IsNullOrEmpty(password))
            {
                if (_configuration["Password"] != password)
                {
                    throw new Exception("Неверный пароль");
                }
                Program.Authorized = true;
                Response.Redirect("Index");
                return;
            }
            throw new Exception("Введите пароль");
        }
        [HttpGet]
        public IActionResult Create()
        {
            if (Program.Authorized == false)
            {
                return Redirect("~/Home/Enter");
            }
            return View();
        }
        [HttpPost]
        public void Create(string warehouseName, string responsiblePerson)
        {
            if (String.IsNullOrEmpty(warehouseName) || String.IsNullOrEmpty(responsiblePerson))
            {
                return;
            }
            APIClient.PostRequest("api/Warehouse/CreateUpdateWarehouse", new WarehouseBindingModel
            {
                WarehouseName = warehouseName,
                ResponsiblePerson = responsiblePerson,
                DateCreate = DateTime.Now,
                WarehouseComponents = new Dictionary<int, (string, int)>()
            });
            Response.Redirect("Index");
        }
        [HttpGet]
        public IActionResult Add()
        {
            if (Program.Authorized == false)
            {
                return Redirect("~/Home/Enter");
            }
            ViewBag.Warehouses = APIClient.GetRequest<List<WarehouseViewModel>>("api/Warehouse/GetWarehouseList");
            ViewBag.Components = APIClient.GetRequest<List<ComponentViewModel>>("api/Warehouse/GetComponentsList");
            return View();
        }
        [HttpPost]
        public void Add(int warehouse, int component, int count)
        {
            APIClient.PostRequest("api/Warehouse/AddComponentWarehouse", new WarehouseAddComponentsBindingModel
            {
                WarehouseId = warehouse,
                ComponentId = component,
                Count = count
            });
            Response.Redirect("Index");
        }
        [HttpGet]
        public IActionResult Delete()
        {
            if (Program.Authorized == false)
            {
                return Redirect("~/Home/Enter");
            }
            ViewBag.Warehouses = APIClient.GetRequest<List<WarehouseViewModel>>("api/Warehouse/GetWarehouseList");
            return View();
        }
        [HttpPost]
        public void Delete(int warehouse)
        {
            APIClient.PostRequest("api/Warehouse/DeleteWarehouse", new WarehouseBindingModel
            {
                Id = warehouse
            });
            Response.Redirect("Index");
        }
        [HttpGet]
        public IActionResult Edit(int warehouseId)
        {
            if (Program.Authorized == false)
            {
                return Redirect("~/Home/Enter");
            }
            WarehouseViewModel warehouse = APIClient.GetRequest<WarehouseViewModel>($"api/Warehouse/GetWarehouse?warehouseId={warehouseId}");
            ViewBag.WarehouseName = warehouse.WarehouseName;
            ViewBag.ResponsiblePerson = warehouse.ResponsiblePerson;
            ViewBag.ComponentsWarehouse = warehouse.WarehouseComponents.Values;
            return View();
        }
        [HttpPost]
        public void Edit(int warehouseId, string warehouseName, string responsiblePerson)
        {
            if (String.IsNullOrEmpty(warehouseName) || String.IsNullOrEmpty(responsiblePerson))
            {
                return;
            }
            WarehouseViewModel warehouse = APIClient.GetRequest<WarehouseViewModel>($"api/Warehouse/GetWarehouse?warehouseId={warehouseId}");
            APIClient.PostRequest("api/Warehouse/CreateUpdateWarehouse", new WarehouseBindingModel
            {
                Id = warehouseId,
                WarehouseName = warehouseName,
                ResponsiblePerson = responsiblePerson,
                WarehouseComponents = warehouse.WarehouseComponents,
                DateCreate = DateTime.Now
            });
            Response.Redirect("Index");
        }
    }
}