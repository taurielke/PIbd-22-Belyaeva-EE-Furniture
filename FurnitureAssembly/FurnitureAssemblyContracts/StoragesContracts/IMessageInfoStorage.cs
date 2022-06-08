using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureAssemblyContracts.ViewModels;
using FurnitureAssemblyContracts.BindingModels;

namespace FurnitureAssemblyContracts.StoragesContracts
{
    public interface IMessageInfoStorage
    {
        List<MessageInfoViewModel> GetFullList();
        List<MessageInfoViewModel> GetFilteredList(MessageInfoBindingModel model);
        MessageInfoViewModel GetElement(MessageInfoBindingModel model);
        void Insert(MessageInfoBindingModel model);
        void Update(MessageInfoBindingModel model);
    }
}
