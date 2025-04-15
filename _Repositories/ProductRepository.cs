using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Supermarket_mvp._Repositories
{
    internal class ProductRepository : IProductRepository
    {
        private readonly string connectionString;

        public int ProductId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Product VALUES (@name, @observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = productModel.Observation;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Product 
                                        SET Product_Name = @name, Product_Observation = @observation 
                                        WHERE Product_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productModel.Id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = productModel.Observation;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Product WHERE Product_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("SELECT * FROM Product", connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new ProductModel
                        {
                            Id = (int)reader["Product_Id"],
                            Name = reader["Product_Name"].ToString(),
                            Observation = reader["Product_Observation"].ToString()
                        };
                        productList.Add(product);
                    }
                }
            }

            return productList;
        }

        public IEnumerable<ProductModel> GetByValue(string value)
        {
            var productList = new List<ProductModel>();
            int productId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productName = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Product 
                                        WHERE Product_Id = @id OR Product_Name LIKE @name + '%'";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new ProductModel
                        {
                            Id = (int)reader["Product_Id"],
                            Name = reader["Product_Name"].ToString(),
                            Observation = reader["Product_Observation"].ToString()
                        };
                        productList.Add(product);
                    }
                }
            }

            return productList;
        }
    }
}
