using System;
using System.Collections.Generic;
using System.Text;
using FurnitureAssemblyContracts.BusinessLogicsContracts;

namespace FurnitureAssemblyContracts.BusinessLogicsContracts
{
    public interface IWorkProcess
    {
        void DoWork(IImplementerLogic implementerLogic, IOrderLogic orderLogic);
    }
}
