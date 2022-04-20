﻿using System;
using System.Collections.Generic;
using System.Text;
using FurnitureAssemblyContracts.BindingModels;
using FurnitureAssemblyContracts.StoragesContracts;
using FurnitureAssemblyContracts.ViewModels;
using FurnitureAssemblyDatabaseImplement.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FurnitureAssemblyDatabaseImplement.Implements
{
    public class ImplementerStorage : IImplementerStorage
    {
        public List<ImplementerViewModel> GetFullList()
        {
            using var context = new FurnitureAssemblyDatabase();
            return context.Implementers.Select(CreateModel).ToList();
        }

        public List<ImplementerViewModel> GetFilteredList(ImplementerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using var context = new FurnitureAssemblyDatabase();
            return context.Implementers.Where(rec => rec.ImplementerFIO == model.ImplementerFIO).Select(CreateModel).ToList();
        }

        public ImplementerViewModel GetElement(ImplementerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using var context = new FurnitureAssemblyDatabase();
            var implementer = context.Implementers.FirstOrDefault(rec => rec.ImplementerFIO == model.ImplementerFIO || rec.Id == model.Id);
            return implementer != null ? CreateModel(implementer) : null;
        }

        public void Insert(ImplementerBindingModel model)
        {
            using var context = new FurnitureAssemblyDatabase();
            context.Implementers.Add(CreateModel(model, new Implementer()));
            context.SaveChanges();
        }

        public void Update(ImplementerBindingModel model)
        {
            using var context = new FurnitureAssemblyDatabase();
            var implementer = context.Implementers.FirstOrDefault(rec => rec.Id == model.Id);
            if (implementer == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, implementer);
            context.SaveChanges();
        }

        public void Delete(ImplementerBindingModel model)
        {
            using var context = new FurnitureAssemblyDatabase();
            Implementer implementer = context.Implementers.FirstOrDefault(rec => rec.Id == model.Id);
            if (implementer != null)
            {
                context.Implementers.Remove(implementer);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        private Implementer CreateModel(ImplementerBindingModel model, Implementer implementer)
        {
            implementer.ImplementerFIO = model.ImplementerFIO;
            implementer.WorkingTime = model.WorkingTime;
            implementer.PauseTime = model.PauseTime;
            return implementer;
        }

        private static ImplementerViewModel CreateModel(Implementer implementer)
        {
            return new ImplementerViewModel
            {
                Id = implementer.Id,
                ImplementerFIO = implementer.ImplementerFIO,
                WorkingTime = implementer.WorkingTime,
                PauseTime = implementer.PauseTime
            };
        }
    }
}
