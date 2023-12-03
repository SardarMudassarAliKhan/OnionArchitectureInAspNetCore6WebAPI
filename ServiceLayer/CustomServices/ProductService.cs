using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.ICustomServices;

namespace ServiceLayer.CustomServices
{
    public class ProductService : ICustomService<Product>
    {
        private readonly IRepository<Product> _studentRepository;
        public ProductService(IRepository<Product> studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void Delete(Product entity)
        {
            try
            {
                if(entity != null)
                {
                    _studentRepository.Delete(entity);
                    _studentRepository.SaveChanges();
                }
            }
            catch(Exception)
            {

                throw;
            }
        }

        public Product Get(int Id)
        {
            try
            {
                var obj = _studentRepository.Get(Id);
                if(obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }

            }
            catch(Exception)
            {

                throw;
            }
        }

        public IEnumerable<Product> GetAll()
        {
            try
            {
                var obj = _studentRepository.GetAll();
                if(obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception)
            {

                throw;
            }
        }

        public void Insert(Product entity)
        {
            try
            {
                if(entity != null)
                {
                    _studentRepository.Insert(entity);
                    _studentRepository.SaveChanges();
                }
            }
            catch(Exception)
            {

                throw;
            }
        }

        public void Remove(Product entity)
        {
            try
            {
                if(entity != null)
                {
                    _studentRepository.Remove(entity);
                    _studentRepository.SaveChanges();
                }
            }
            catch(Exception)
            {

                throw;
            }
        }
        public void Update(Product entity)
        {
            try
            {
                if(entity != null)
                {
                    _studentRepository.Update(entity);
                    _studentRepository.SaveChanges();
                }
            }
            catch(Exception)
            {

                throw;
            }
        }
    }
}
