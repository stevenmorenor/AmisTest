using System;


namespace Capacitacion
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            Category category = new Category();
            BaseEntity entity = new BaseEntity();
            

            product.Name = "Sofa";
            product.Price = 480000;
            product.Description = "Hermoso sofa color azul, reclinable 170 * 120";
            category.Name = "Hogar";
            category.Code = 12345;
            category.SubCategory = "Muebles";
            entity.CreateBy = "Steven Moreno";
            entity.DateModified = DateTime.Parse("2022/07/06 12:35:05 PM");
            entity.EditBy = "Fabrica de muebles";
            

            Console.WriteLine(Extensions.ToCorrectFormat(category.DateModified));
            Console.WriteLine(product.ToString());
            Console.WriteLine(category);
            Console.WriteLine(entity.ToString());


        }
        
    }
}
