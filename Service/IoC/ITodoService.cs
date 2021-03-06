﻿using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.IoC
{
    public interface ITodoService
    {
        void Adicionar(Todo todo);
        IEnumerable<Todo> GetAll();
    }
}
