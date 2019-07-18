using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using waEntity;


namespace waService
{
    public class serviceProducts
    {
        public static List<Products> GetAllProducts()
        {
            return waRepository.repositoryProducts.GetAllProducts();

        }

        public static int DeleteProductById(int id)
        {
            return waRepository.repositoryProducts.DeleteProductById(id);
        }

        public static int AddProduct(string name)
        {
            return waRepository.repositoryProducts.AddProduct(name);
        }

        public static int AddProduct_Detail(int id, string name_Detail)
        {
            return waRepository.repositoryProducts.AddProduct_Detail(id, name_Detail);
        }

        public static int UpdateProduct_Detail(int id, string name_Detail)
        {
            return waRepository.repositoryProducts.UpdateProduct_Detail(id, name_Detail);
        }
    }
}
