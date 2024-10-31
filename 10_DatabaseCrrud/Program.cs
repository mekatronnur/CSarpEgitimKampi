using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crud-->Create,read,update,delete
            //Console.WriteLine("***** Menü Sipariş İşlem Paneli");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("Eklemek İstediğiniz kategori Adı");
            #region Kategori Ekleme İşlemi
            ////string categoryName = Console.ReadLine();
            ////SqlConnection sqlConnection = new SqlConnection("Data Source=IST;Initial Catalog=EgitimKampiDB;integrated security=true");
            ////sqlConnection.Open();
            ////SqlCommand sqlCommand = new SqlCommand("Insert into TBL_Category (CategoryName) values (@p1)", sqlConnection);
            ////sqlCommand.Parameters.AddWithValue("@p1", categoryName);
            ////sqlCommand.ExecuteNonQuery();
            //////SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            //////DataTable dataTable = new DataTable();
            //////adapter.Fill(dataTable);
            ////sqlConnection.Close();
            ////Console.WriteLine("Kategori başarılı bir şekilde eklendi");
            #endregion

            #region Ürün Eklem İslemi

            ////Console.Write("Ürün Adı:");
            ////string productName=Console.ReadLine();
            ////Console.Write("Fiyatı:");
            ////decimal productPrice=decimal.Parse(Console.ReadLine());


            ////SqlConnection sqlConnection = new SqlConnection("Data Source=IST;Initial Catalog=EgitimKampiDB;integrated security=true");
            ////sqlConnection.Open();
            ////SqlCommand sqlCommand = new SqlCommand("Insert into TBL_Product (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3 )", sqlConnection);
            ////sqlCommand.Parameters.AddWithValue("@p1", productName);
            ////sqlCommand.Parameters.AddWithValue("@p2", productPrice);
            ////sqlCommand.Parameters.AddWithValue("@p3", true);
            ////sqlCommand.ExecuteNonQuery();
            ////////SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            ////////DataTable dataTable = new DataTable();
            ////////adapter.Fill(dataTable);
            ////sqlConnection.Close();
            ////Console.WriteLine("Ürün  başarılı bir şekilde eklendi");
            #endregion

            #region Listeleme İşlemi

            //SqlConnection sqlConnection = new SqlConnection("Data Source=IST;Initial Catalog=EgitimKampiDB;integrated security=true");
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand("SELECT ProductName,ProductPrice from TBL_Product;", sqlConnection);
            //SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow item in dataTable.Rows)
            //{
            //    foreach (var row in item.ItemArray)
            //    {
            //        Console.Write(row.ToString() +" ");
            //    }
            //     Console.WriteLine();
            //}
            //sqlConnection.Close();


            #endregion

            #region Ürün Silme İşlemi
            //Console.WriteLine("Silinecek Ürün Id:");
            //int Id=int.Parse(Console.ReadLine());


            //SqlConnection sqlConnection = new SqlConnection("Data Source=IST;Initial Catalog=EgitimKampiDB;integrated security=true");
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand("Delete from TBL_Product where ProductId=@Id", sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@Id", Id);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();
            //Console.WriteLine("Silme İşlemi Başarılı");


            #endregion

            #region Ürün Güncelleme

            Console.WriteLine("Güncellenecek Ürün Id:");
           
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Güncellenecek Ürün Adı:");
            string name=Console.ReadLine();
            Console.WriteLine("Güncellenecek Ürün Fiyatı:");
            decimal price=decimal.Parse(Console.ReadLine());


            SqlConnection sqlConnection = new SqlConnection("Data Source=IST;Initial Catalog=EgitimKampiDB;integrated security=true");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update  TBL_Product set  ProductName=@productname,ProductPrice=@productprice where ProductId=@productId", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@productname", name);
            sqlCommand.Parameters.AddWithValue("@productprice", price);
            sqlCommand.Parameters.AddWithValue("@productId", Id);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            #endregion

            Console.Read();
        }
    }
}
