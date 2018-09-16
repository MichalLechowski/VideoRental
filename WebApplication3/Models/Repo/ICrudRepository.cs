using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppVideoRental.Models.Repo
{
    public interface ICrudRepository<T>
    {
        void Add(T obj);
        void Delete(int id);
        T GetSingle(int id);
        List<T> GetAll();
        bool Update(T obj);
    }
}