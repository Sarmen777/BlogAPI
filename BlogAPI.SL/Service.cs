using BlogAPI.CL.Interfaces.Repositories;
using BlogAPI.CL.Interfaces.Services;

namespace BlogAPI.SL
{
    public class Service<T> : IService<T> where T : class
    {
        protected readonly IRepository<T> _repository;

        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public IEnumerable<T> GetAll() => _repository.GetAll();

        public T GetById(int id) => _repository.GetById(id);

        public void Add(T entity) => _repository.Add(entity);

        public void Update(T entity) => _repository.Update(entity);

        public void Delete(int id) => _repository.Delete(id);
    }
}
