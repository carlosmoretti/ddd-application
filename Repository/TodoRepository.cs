using Repository.IoC;
using System;
using System.Collections.Generic;
using System.Text;
using Persistence;
using Domain;

namespace Repository
{
    public class TodoRepository : Repository<Todo>, ITodoRepository
    {
        private Contexto _context;
        public TodoRepository(Contexto context) : base(context)
        {
            _context = context;
        }
    }
}
