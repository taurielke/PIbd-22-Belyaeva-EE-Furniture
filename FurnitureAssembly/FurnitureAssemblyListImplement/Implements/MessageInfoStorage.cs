﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureAssemblyContracts.BindingModels;
using FurnitureAssemblyContracts.StoragesContracts;
using FurnitureAssemblyContracts.ViewModels;
using FurnitureAssemblyListImplement.Models;

namespace FurnitureAssemblyListImplement.Implements
{
    public class MessageInfoStorage : IMessageInfoStorage
    {
        private readonly DataListSingleton source;
        public MessageInfoStorage()
        {
            source = DataListSingleton.GetInstance();
        }
        public List<MessageInfoViewModel> GetFullList()
        {
            var result = new List<MessageInfoViewModel>();
            foreach (var message in source.MessagesInfo)
            {
                result.Add(CreateModel(message));
            }
            return result;
        }
        public List<MessageInfoViewModel> GetFilteredList(MessageInfoBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            int toSkip = model.ToSkip ?? 0;
            int toTake = model.ToTake ?? source.MessagesInfo.Count;
            var result = new List<MessageInfoViewModel>();
            foreach (var message in source.MessagesInfo)
            {
                if ((model.ClientId.HasValue && message.ClientId == model.ClientId)
                    || (!model.ClientId.HasValue && (model.ToSkip.HasValue && model.ToTake.HasValue || message.DateDelivery.Date == model.DateDelivery.Date)))
                {
                    if (toSkip > 0)
                    {
                        toSkip--;
                        continue;
                    }
                    if (toTake > 0)
                    {
                        result.Add(CreateModel(message));
                        toTake--;
                    }
                }
            }
            return result;
        }
        public MessageInfoViewModel GetElement(MessageInfoBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            foreach (var message in source.MessagesInfo)
            {
                if (message.MessageId == model.MessageId)
                {
                    return CreateModel(message);
                }
            }
            return null;
        }
        public void Insert(MessageInfoBindingModel model)
        {
            if (model == null)
            {
                return;
            }
            source.MessagesInfo.Add(CreateModel(model, new MessageInfo()));
        }
        public void Update(MessageInfoBindingModel model)
        {
            MessageInfo tempMessage = null;
            foreach (var message in source.MessagesInfo)
            {
                if (message.MessageId == model.MessageId)
                {
                    tempMessage = message;
                }
            }
            if (tempMessage == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, tempMessage);
        }
        private MessageInfo CreateModel(MessageInfoBindingModel model,
            MessageInfo message)
        {
            message.MessageId = model.MessageId;
            message.SenderName = model.FromMailAddress;
            message.Body = model.Body;
            message.ClientId = model.ClientId;
            message.DateDelivery = model.DateDelivery;
            message.Subject = model.Subject;
            message.IsRead = model.IsRead;
            message.Reply = model.Reply;
            return message;
        }
        private MessageInfoViewModel CreateModel(MessageInfo message)
        {
            return new MessageInfoViewModel
            {
                MessageId = message.MessageId,
                Body = message.Body,
                DateDelivery = message.DateDelivery,
                SenderName = message.SenderName,
                Subject = message.Subject,
                Reply = message.Reply,
                IsRead = message.IsRead
            };
        }
    }
}
