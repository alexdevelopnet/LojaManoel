using ProductAPI.Data.ValueObjects;

namespace ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProdutoVO>> FindAll();
        Task<ProdutoVO> FindById(long id);
        Task<ProdutoVO> Create(ProdutoVO vo);
        Task<ProdutoVO> Update(ProdutoVO vo);
        Task<bool> Delete(long id);
    }
}
