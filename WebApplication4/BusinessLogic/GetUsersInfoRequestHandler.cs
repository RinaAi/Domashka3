using System;
using System.Threading.Tasks;
using WebApplication4.Models;
using WebApplication4.Services.Interfaces;

namespace WebApplication4.BusinessLogic
{
    public class GetUsersInfoRequestHandler
    {
        private readonly IUserlnfoService _userInfoService;
        public GetUsersInfoRequestHandler(IUserlnfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }
        public Task<User> Handle(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("Некорректный идентификатор пользователя", nameof(id));
            }
            return _userInfoService.GetById(id);
        }
    }
}