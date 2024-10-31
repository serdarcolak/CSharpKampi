using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10_DatabaseCrud
            //Crud-->Create-Read-Uptade-Delete

            Console.WriteLine("****** Menü Sipariş İşlem Paneli ******");
            Console.WriteLine();

            Console.WriteLine("----------------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz Kategori Adı : ");

            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R3DKO9V\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.Write("Kategori başarılı bir şekilde eklendi.");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı : ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı : ");
            //productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-R3DKO9V\\SQLEXPRESS; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();

            //Console.Write("Ürün Ekleme Başarılı");
            //connection.Close();
            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-R3DKO9V\\SQLEXPRESS; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("SELECT * FROM TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();
            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Adı : ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("data source = desktop-r3dko9v\\sqlexpress; initial catalog=egitimkampidb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("DELETE FROM TblProduct WHERE ProductId =@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme İşlemi Başarılı");

            #endregion

            #region Ürün Güncellem İşlemi
            //Console.Write("Güncellenecek Ürün Id : ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı : ");
            //String productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı : ");
            //Decimal productPrice = Decimal.Parse(Console.ReadLine());
            
            //SqlConnection connection = new SqlConnection("data source = desktop-r3dko9v\\sqlexpress; initial catalog=egitimkampidb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand
            //    ("UPDATE TblProduct SET ProductName=@productName, ProductPrice=@productPrice " +
            //    "WHERE ID = @productId", connection);

            //command.Parameters.AddWithValue("@productName", productName);

            //command.Parameters.AddWithValue("@productPrice", productPrice);

            //command.Parameters.AddWithValue("@productId", productId);

            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı");
            #endregion

            Console.Read();
        }
    }
}
