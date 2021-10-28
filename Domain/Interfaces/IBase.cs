using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IBase<T>
    {
        void Create(T t);
        void Add(T t, ref T[] arr);
        T[] FindAll();
    }
}
