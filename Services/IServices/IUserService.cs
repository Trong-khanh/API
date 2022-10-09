using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using webAPI.Dtos.UserDtos;
using webAPI.Model;

namespace webAPI.Services.IServices
{
    public interface IUserService
    {
        Task<AuthenticateResponse> Authenticate(AuthenticateRequest model) ;
        Task<IEnumerable<User>> GetALl();
        Task<User> GetById(int id);
        Task Register(RegisterRequest model);
        Task Update(int id, UpdateRequest model);
        Task Delete(int id);
    }
}