using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using FurnitureAssemblyContracts.BindingModels;
using FurnitureAssemblyContracts.BusinessLogicsContracts;
using FurnitureAssemblyBusinessLogic.BusinessLogics;
using FurnitureAssemblyContracts.StoragesContracts;
using FurnitureAssemblyDatabaseImplement.Implements;
using Unity.Lifetime;

namespace FurnitureAssemblyView
{
    static class Program
    {
        private static IUnityContainer container = null;
        public static IUnityContainer Container
        {
            get
            {
                if (container == null)
                {
                    container = BuildUnityContainer();
                }
                return container;
            }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Container.Resolve<FormMain>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IComponentStorage, ComponentStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderStorage, OrderStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IFurnitureStorage, FurnitureStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IWarehouseStorage, WarehouseStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IComponentLogic, ComponentLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderLogic, OrderLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IFurnitureLogic, FurnitureLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IWarehouseLogic, WarehouseLogic>(new HierarchicalLifetimeManager());
            return currentContainer;
        }

    }
}
