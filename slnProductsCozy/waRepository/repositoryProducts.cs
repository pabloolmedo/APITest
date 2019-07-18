using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using waEntity;

namespace waRepository
{
    public class repositoryProducts
    {
        public static List<Products> GetAllProducts()
        {
            try
            {
                string _Dba = @"Data Source=PABLO\SQLEXPRESS;Initial Catalog=CozyEnterprise;Integrated Security=True";
                string sp_GetAllProducts = "dbo.sp_GetAllProducts";
                using (SqlConnection conex = new SqlConnection(_Dba))
                {
                    return conex.Query<Products>(sp_GetAllProducts, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int DeleteProductById(int id)
        {
            try
            {
                string _Dba = @"Data Source=PABLO\SQLEXPRESS;Initial Catalog=CozyEnterprise;Integrated Security=True";
                string sp_DeleteProductById = "dbo.sp_DeleteProductById";
                using (SqlConnection conex = new SqlConnection(_Dba))
                {
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@Id_Detail_Product", id);
                    conex.Execute(sp_DeleteProductById, param, commandType: CommandType.StoredProcedure);
                    return 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int AddProduct(string name)
        {
            try
            {
                string _Dba = @"Data Source=PABLO\SQLEXPRESS;Initial Catalog=CozyEnterprise;Integrated Security=True";
                string sp_AddProduct = "dbo.sp_AddProduct";
                using (SqlConnection conex = new SqlConnection(_Dba))
                {
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@Name", name);
                    conex.Execute(sp_AddProduct, param, commandType: CommandType.StoredProcedure);
                    return 1;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int AddProduct_Detail (Products products)
        {
            try
            {
                string _Dba = @"Data Source=PABLO\SQLEXPRESS;Initial Catalog=CozyEnterprise;Integrated Security=True";
                string sp_AddProduct_Detail = "dbo.sp_AddProduct_Detail";
                using(SqlConnection conex = new SqlConnection(_Dba))
                {
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@Id_Product", products.Id_Product);
                    param.Add("@Name_Detail", products.Name_Detail);
                    conex.Execute(sp_AddProduct_Detail, param, commandType: CommandType.StoredProcedure);
                    return 1;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int UpdateProduct_Detail (int id, string name_Detail)
        {
            try
            {
                string _Dba = @"Data Source=PABLO\SQLEXPRESS;Initial Catalog=CozyEnterprise;Integrated Security=True";
                string sp_UpdateProduct_Detail = "dbo.sp_UpdateProduct_Detail";
                using (SqlConnection conex = new SqlConnection(_Dba))
                {
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@Id_Detail_Product", id);
                    param.Add("@Name_Detail", name_Detail);
                    conex.Execute(sp_UpdateProduct_Detail, param, commandType: CommandType.StoredProcedure);
                    return 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

       
