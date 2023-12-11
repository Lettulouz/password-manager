﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Domain.Services
{
    public interface IDataService<T>
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> Get(int id);

        Task<T> Create(T entity);

        Task<T> Update(int id, T entity);
        Task<T> UpdateRecord(int id, T entity);
        Task<Tuple<string,string>> GetAES(int id);
        Task<string> GetPassword(int id);

    }
}
