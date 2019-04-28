using System;
using System.Threading.Tasks;
using WebApplication4.Models;
using WebApplication4.Models;

namespace WebApplication4.Services.Interfaces
{
    public interface IUserlnfoService
    {
        Task<User> GetById(Guid id);
    }
}