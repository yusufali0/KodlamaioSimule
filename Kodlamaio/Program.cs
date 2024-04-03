using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Kodlamaio
{
    public class Program
    {
        static void Main(string[] args)
        {
            CategoryCrud();
            Console.WriteLine();
            CourseManager courseManager = new(new CourseDal());

            List<Course> listAll= courseManager.GetAll();
            foreach (Course c in listAll)
            {
                Console.WriteLine(c.Name+" "+c.Description+" "+c.ImageUrl);
            }
            Console.WriteLine();
            var courseDetail=courseManager.GetById(1);
            Console.WriteLine(courseDetail.Name+"****");

            courseManager.Update(new Course { Id = 1, Name = "c++", Description = "Orta Seviye", ImageUrl = "cc.jpg" });
            Console.WriteLine(courseDetail.Name+" Degistirilen kurs");
            Console.WriteLine();


            courseManager.Add(new Course { Id = 7, Name = "Algoritma Tasarım", Description = "Temel seviye", ImageUrl = "alg.jpg" });
            foreach (Course c in listAll)
            {
                Console.WriteLine(c.Name);
            }
            courseManager.Remove(courseDetail);


        }

        private static void CategoryCrud()
        {
            CategoryManager categoryManager = new(new CategoryDal());
            foreach(var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("***");
            Category category1 = new() { Id = 4, Name="Security" };
            categoryManager.Add(category1);
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("***");
            var category2 = categoryManager.GetById(3);
            Console.WriteLine(category2.Name+" "+category2.Id);

            Console.WriteLine("***");
            var category3 = new Category() { Id = 3, Name = "DataBase Systems" };
            categoryManager.Update(category3);
            Console.WriteLine(category2.Name+" "+category2.Id);

            Console.WriteLine("***");
            categoryManager.Remove(category2);

            Console.WriteLine("***");
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.Name);
            }
        }
            

       
        
    }
}
