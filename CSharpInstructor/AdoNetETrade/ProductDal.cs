using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetETrade
{
    public class ProductDal//Product tablomuzun ismi DAL => Data Acces Layer  DAO=> Data Acces Object
    {

        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");

        public List<Product> GetAllList() {

            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read()) { //readera gelen objeleri oku okuyabildikce devam eder//

                Product product = new Product {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);

            }


            reader.Close();
            _connection.Close();

            return products;
        }


        public DataTable GetAllDT()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            _connection.Close();

            return dataTable;
        }

        public void Add(Product product) {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into Products values(@name,@unitPrice,@stockAmount)",_connection);

            command.Parameters.AddWithValue("@name",product.Name);
            command.Parameters.AddWithValue("@unitPrice",product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount",product.StockAmount);
            command.ExecuteNonQuery();

            _connection.Close();

            }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Update Products set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@id", _connection);

            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();

            _connection.Close();

        }


        public void Delete(int Id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from Products where Id=@id", _connection);

           
            command.Parameters.AddWithValue("@id", Id);
            command.ExecuteNonQuery();

            _connection.Close();

        }


        private void ConnectionControl(){
         if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }


    }
}
