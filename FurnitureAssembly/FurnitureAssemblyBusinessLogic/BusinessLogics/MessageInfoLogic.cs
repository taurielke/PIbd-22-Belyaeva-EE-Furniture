﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureAssemblyContracts.BindingModels;
using FurnitureAssemblyContracts.BusinessLogicsContracts;
using FurnitureAssemblyContracts.StoragesContracts;
using FurnitureAssemblyContracts.ViewModels;

namespace FurnitureAssemblyBusinessLogic.BusinessLogics
{
    public class MessageInfoLogic : IMessageInfoLogic
    {
        private readonly IMessageInfoStorage messageInfoStorage;
        public MessageInfoLogic(IMessageInfoStorage messageInfoStorage)
        {
            this.messageInfoStorage = messageInfoStorage;
        }
        public List<MessageInfoViewModel> Read(MessageInfoBindingModel model)
        {
            if (model == null)
            {
                return messageInfoStorage.GetFullList();
            }
            if (!string.IsNullOrEmpty(model.MessageId))
            {
                return new List<MessageInfoViewModel> { messageInfoStorage.GetElement(model) };
            }
            return messageInfoStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(MessageInfoBindingModel model)
        {
            var element = messageInfoStorage.GetElement(new MessageInfoBindingModel
            {
                MessageId = model.MessageId
            });
            if (element != null)
            {
                messageInfoStorage.Update(model);
            }
            else
            {
                messageInfoStorage.Insert(model);
            }
        }
    }
}
