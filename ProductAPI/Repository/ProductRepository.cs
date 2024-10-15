using AutoMapper;
using ProductAPI.Data;
using ProductAPI.Data.ValueObjects;

namespace ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly SqlServerContext _context;
        private IMapper _mapper;

        public Task<ProdutoVO> Create(ProdutoVO vo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProdutoVO>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProdutoVO> FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<ProdutoVO> Update(ProdutoVO vo)
        {
            throw new NotImplementedException();
        }
    }
}
