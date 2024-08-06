using Core.Entities;

namespace Core.Interfaces {
    public interface IProductRepository {
        Task<Product> GetProductByIdAsync(int id);

        //use readonlylist bcz we don't need all functionalities of List
        Task<IReadOnlyList<Product>> GetProductsAsync();
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}
