using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado Net
            string tableNumber; 

            Console.WriteLine("********** C# Veri Tabanlı Ürün Kategori Bilgi Sistemi *********");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz");



            SqlConnection sqlConnection=new SqlConnection("Data Source=IST;Initial Catalog=EgitimKampiDB;integrated security=true");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from TBL_Category",sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
           sqlConnection.Close();

            foreach (DataRow item in dataTable.Rows)
            {
                foreach (var row in item.ItemArray)
                {
                    Console.WriteLine(row.ToString());
                }

            }

            Console.ReadLine();

        }
    }
}
