using Application.Interfaces;
using Domain.Entities;

namespace Application.UseCases
{
    public class UserService
    {
        private readonly IUserRepository _repo;
        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public Task<IEnumerable<User>> GetAllAsync() => _repo.GetAllAsync();
        public Task<User?> GetByIdAsync(Guid id) => _repo.GetByIdAsync(id);
        public Task AddAsync(User user) => _repo.AddAsync(user);
        public Task UpdateAsync(User user) => _repo.UpdateAsync(user);
        public Task DeleteAsync(Guid id) => _repo.DeleteAsync(id);
    }
}
