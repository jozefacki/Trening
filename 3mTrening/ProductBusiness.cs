namespace _3mTrening
{

    public interface IProductDataAccess
    {
        bool CreateProduct(Product newProduct);
    }

    public class Product
    { }


    public class ProductBusiness
    {
        private readonly IProductDataAccess _productDataAccess;

        public ProductBusiness(IProductDataAccess productDataAccess)
        {
            _productDataAccess = productDataAccess;
        }

        public bool CreateProduct(Product newProduct)
        {
            bool result = _productDataAccess.CreateProduct(newProduct);
            return result;
        }

        public int Something()
        {
            if (CreateProduct(new Product()))
            
                return 5;
            
            else
                return 10;
        }

    }
}
