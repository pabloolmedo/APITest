using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using waEntity;
using waRepository;

namespace waApiProducts.Controllers
{
    public class ProductsController : ApiController
    {
        // GET: api/Products
        public List<Products> Get()
        {
            List<Products> LstProducts = new List<Products>();
            LstProducts = repositoryProducts.GetAllProducts();
            return LstProducts;
        }

        // GET: api/Products/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Products
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string name_Detail)
        {
        }
        [HttpPut]
        //PUT AddProduct_Detail
        // http://localhost:60708/api/Products
        public void AddProduct_Detail([FromBody] Products products)
        {
            string respApi = "";
            
            int AddProduct_Detail = repositoryProducts.AddProduct_Detail(products);
            if (AddProduct_Detail == 1)
            {
                respApi = "ok";
            }
            else
            {
                respApi = "fail";
            }


        }

        // DELETE Product
        // http://localhost:60708/api/Products?id=3
        public IHttpActionResult Delete(int id)
        {
            string respApi = "";
            int DeleteProductById = repositoryProducts.DeleteProductById(id);
            if (DeleteProductById == 1)
            {
                respApi = "ok";
            }
            else
            {
                respApi = "fail";
            }

            return Ok();
        }
       
        //POST Update Product Detail 
        // http://localhost:60708/api/Products?id=2&name_Detail=Test
        public IHttpActionResult Update(int id, string name_Detail)
        {
            string respApi = "";
            int UpdateProduct_Detail = repositoryProducts.UpdateProduct_Detail(id, name_Detail);
            if (UpdateProduct_Detail == 1)
            {
                respApi = "ok";
            }
            else
            {
                respApi = "fail";
            }

            return Ok();
        }


    }
}
