using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureAssemblyContracts.Enums
{
    public enum OrderStatus
    {
        Принят = 0,
        Выполняется = 1,
        Готов = 2, 
        Выдан = 3,
        ТребуютсяМатериалы = 4
    }
}
