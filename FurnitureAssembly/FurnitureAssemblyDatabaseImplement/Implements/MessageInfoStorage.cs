﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureAssemblyContracts.StoragesContracts;
using FurnitureAssemblyContracts.ViewModels;
using FurnitureAssemblyDatabaseImplement.Models;
using FurnitureAssemblyContracts.BindingModels;

namespace FurnitureAssemblyDatabaseImplement.Implements
{
    public class MessageInfoStorage : IMessageInfoStorage
    {
        public List<MessageInfoViewModel> GetFullList()
        {
            using (var context = new FurnitureAssemblyDatabase())
            {
                return context.Messages.Select(CreateModel).ToList();
            }
        }
        public List<MessageInfoViewModel> GetFilteredList(MessageInfoBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new FurnitureAssemblyDatabase())
            {
                if (model.ToSkip.HasValue && model.ToTake.HasValue && !model.ClientId.HasValue)
                {
                    return context.Messages.Skip((int)model.ToSkip).Take((int)model.ToTake)
                    .Select(CreateModel).ToList();
                }

                return context.Messages.Where(rec => (model.ClientId.HasValue && rec.ClientId == model.ClientId)
                || (!model.ClientId.HasValue && rec.DateDelivery.Date == model.DateDelivery.Date))
                    .Skip(model.ToSkip ?? 0).Take(model.ToTake ?? context.Messages.Count())
                .Select(CreateModel)
                .ToList();
            }
        }
        public MessageInfoViewModel GetElement(MessageInfoBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new FurnitureAssemblyDatabase())
            {
                var message = context.Messages.FirstOrDefault(rec => rec.MessageId == model.MessageId);
                return message != null ? CreateModel(message) : null;
            }
        }
        public void Insert(MessageInfoBindingModel model)
        {
            using (var context = new FurnitureAssemblyDatabase())
            {
                MessageInfo element = context.Messages.FirstOrDefault(rec => rec.MessageId == model.MessageId);
                if (element != null)
                {
                    throw new Exception("Уже есть письмо с таким идентификатором");
                }
                context.Messages.Add(CreateModel(model, new MessageInfo()));
                context.SaveChanges();
            }
        }
        public void Update(MessageInfoBindingModel model)
        {
            using (var context = new FurnitureAssemblyDatabase())
            {
                MessageInfo element = context.Messages.FirstOrDefault(rec => rec.MessageId == model.MessageId);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        private MessageInfoViewModel CreateModel(MessageInfo model)
        {
            return new MessageInfoViewModel
            {
                MessageId = model.MessageId,
                SenderName = model.SenderName,
                DateDelivery = model.DateDelivery,
                Subject = model.Subject,
                Body = model.Body,
                IsRead = model.IsRead,
                Reply = model.Reply
            };
        }
        private static MessageInfo CreateModel(MessageInfoBindingModel model, MessageInfo message)
        {
            message.MessageId = model.MessageId;
            message.ClientId = model.ClientId;
            message.SenderName = model.FromMailAddress;
            message.DateDelivery = model.DateDelivery;
            message.Subject = model.Subject;
            message.Body = model.Body;
            message.IsRead = model.IsRead;
            message.Reply = model.Reply;
            return message;
        }
    }
}
