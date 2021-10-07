using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Services
{
    public interface ICRUDService<T, TSearch, TInsert, TUpdate> : IService<T,TSearch>
    {

        T Insert(TInsert request);

        T Update(int id, TUpdate request);

    }
}
