using Domain;
using Repository.IoC;
using Service.IoC;
using System;
using System.Collections.Generic;
using ViewModel;

namespace Service
{
    public class TodoService : ITodoService, IServiceBase<Todo>
    {
        private ITodoRepository _todoRepository;
        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public void Adicionar(Todo todo)
        {
            if(true)
            {
                _todoRepository.Add(todo);
            }
        }

        public IEnumerable<Todo> GetAll()
        {
            return _todoRepository.GetAll();
        }

        public ErrorViewModel Validate(Todo obj)
        {
            throw new NotImplementedException();
        }
    }
}
