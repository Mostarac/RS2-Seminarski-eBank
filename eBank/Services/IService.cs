using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Services
{
    public interface IService<T, TSearch>
    {

        List<T> Get(TSearch search);

        T GetById(int id);

    }
}
