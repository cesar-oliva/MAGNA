using MAGNA_CLIENT.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Abstractions
{
    public interface ICrudAsync<T>
    {
        Task<List<T>> GetEntity(string nameService, string actionService);
        Task<bool> PostCreateEntity(string nameService, string actionService, T Entity);
        Task<T> GetUpdateEntity(string nameService, string actionService, Guid Id);
        Task<bool> PutUpdateEntity(string nameService, string actionService, T Entity);
        Task<bool> GetDeleteEntity(string nameService, string actionService, Guid Id);
        Task<T> GetDetailEntity(string nameService, string actionService, Guid Id);
    }
}
  

