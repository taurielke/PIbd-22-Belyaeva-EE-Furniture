﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace FurnitureAssemblyContracts.ViewModels
{
    public class ClientViewModel
    {
        public int Id { get; set; }

        [DisplayName("ФИО")]
        public string ClientFIO { get; set; }

        [DisplayName("Логин")]
        public string Email { get; set; }

        [DisplayName("Пароль")]
        public string Password { get; set; }
    }
}
