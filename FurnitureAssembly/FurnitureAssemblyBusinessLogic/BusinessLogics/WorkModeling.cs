﻿using System;
using System.Collections.Generic;
using System.Text;
using FurnitureAssemblyContracts.BindingModels;
using FurnitureAssemblyContracts.BusinessLogicsContracts;
using FurnitureAssemblyContracts.Enums;
using FurnitureAssemblyContracts.ViewModels;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace FurnitureAssemblyBusinessLogic.BusinessLogics
{
    public class WorkModeling : IWorkProcess
    {
        private IOrderLogic _orderLogic;
        private readonly Random rnd;
        public WorkModeling()
        {
            rnd = new Random(1000);
        }

        public void DoWork(IImplementerLogic implementerLogic, IOrderLogic orderLogic)
        {
            _orderLogic = orderLogic;
            var implementers = implementerLogic.Read(null);
            ConcurrentBag<OrderViewModel> orders = new(_orderLogic.Read(new OrderBindingModel
            {
                SearchStatus = OrderStatus.Принят
            }));
            foreach (var implementer in implementers)
            {
                Task.Run(async () => await WorkerWorkAsync(implementer, orders));
            }
        }

        private async Task WorkerWorkAsync(ImplementerViewModel implementer, ConcurrentBag<OrderViewModel> orders)
        {
            // ищем заказы, которые уже в работе (вдруг исполнителя прервали)
            var runOrders = await Task.Run(() => _orderLogic.Read(new OrderBindingModel
            {
                ImplementerId = implementer.Id,
                Status = OrderStatus.Выполняется
            }));
            foreach (var order in runOrders)
            {
                // делаем работу заново
                Thread.Sleep(implementer.WorkingTime * rnd.Next(1, 5) * order.Count);
                _orderLogic.FinishOrder(new ChangeStatusBindingModel
                {
                    OrderId = order.Id
                });
                // отдыхаем
                Thread.Sleep(implementer.PauseTime);
            }
            await Task.Run(() =>
            {
                while (!orders.IsEmpty)
                {
                    if (orders.TryTake(out OrderViewModel order))
                    {
                        // пытаемся назначить заказ на исполнителя
                        _orderLogic.TakeOrderInWork(new ChangeStatusBindingModel
                        {
                            OrderId = order.Id,
                            ImplementerId = implementer.Id
                        });
                        // делаем работу
                        Thread.Sleep(implementer.WorkingTime * rnd.Next(1, 5) * order.Count);
                        _orderLogic.FinishOrder(new ChangeStatusBindingModel
                        {
                            OrderId = order.Id,
                            ImplementerId = implementer.Id
                        });
                        // отдыхаем
                        Thread.Sleep(implementer.PauseTime);
                    }
                }
            });
        }
    }
}
