using System.Collections.Generic;
using System.Threading.Tasks;
using webAPI.Model;

namespace webAPI.Services.IServices
{
    public interface IBookService
    {
        Task<IList<Book>> GetAll();
        Task<Book> GetById(int id);
        Task Create(Book input);
        Task Update(int id, Book input);
        Task Delete(int id);
    }
}