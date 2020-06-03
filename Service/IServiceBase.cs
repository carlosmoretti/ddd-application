using System;
using System.Collections.Generic;
using System.Text;
using ViewModel;

namespace Service
{
    public interface IServiceBase<T> where T : class
    {
        ErrorViewModel Validate(T obj);
    }
}
