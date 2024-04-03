using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : IGenericDal<Course>
    {
        List<Course> courses;
        public CourseDal()
        {
            courses = new List<Course>()
            {
                new Course()
                {
                    Id = 1,
                    CategoryId = 1,
                    InstructorId = 1,
                    Name="C# + Angular",
                    ImageUrl="ang.jpg",
                    Description="Yazilim Gelistirme"
                },
                new Course()
                {
                    Id= 2,
                    CategoryId = 2,
                    InstructorId = 2,
                    Name="Java + React ",
                    ImageUrl="rct.jpg",
                    Description="Yazilim Gelistirme"
                },
                new Course()
                {
                    Id=3,
                    CategoryId = 3,
                    InstructorId = 3,
                    Name="C#",
                    ImageUrl="c.jpg",
                    Description="Yazilim Gelistirme"
                },
                new Course()
                {
                    Id=4,
                    CategoryId = 4,
                    InstructorId = 4,
                    Name="JavaScript",
                    ImageUrl="js.jpg",
                    Description="Yazilim Gelistirme"
                },
                new Course()
                {
                    Id=5,
                    CategoryId = 5,
                    InstructorId = 5,
                    Name="Python",
                    ImageUrl="py.jpg",
                    Description="Yazilim Gelistirme"
                },
                new Course()
                {
                    Id=6,
                    CategoryId = 6,
                    InstructorId = 6,
                    Name="Senior .Net",
                    ImageUrl="net.jpg",
                    Description="Yazilim Gelistirme"
                },
                new Course()
                {
                    Id =7,
                    CategoryId = 7,
                    InstructorId = 7,
                    Name="Java ",
                    ImageUrl="java.png",
                    Description="Yazilim Gelistirme"
                },
                new Course()
                {
                    Id=8,
                    CategoryId = 8,
                    InstructorId = 8,
                    Name="Programlamaya Giris",
                    ImageUrl="prog.jpg",
                    Description="Yazilim Gelistirme"
                }

            };
        }
        public void Add(Course entity)
        {
            courses.Add(entity);
            Console.WriteLine("Course Aded");
        }

        public List<Course> GetAll()
        {
            return courses;
            Console.WriteLine("All Courses");
        }

        public Course GetById(int id)
        {
            Course course = courses.FirstOrDefault(c => c.Id == id);
            return course;
        }

        public void Remove(Course entity)
        {
            var courseRemove=courses.Where(c=>c.Id == entity.Id).FirstOrDefault();
            if (courseRemove != null)
            {
                courses.Remove(courseRemove);
                Console.WriteLine("Course Remove");
            }
            Console.WriteLine("Check and try again");
        }

        public void Update(Course entity)
        {
           var courseUpdate=courses.FirstOrDefault(u=>u.Id == entity.Id);
            if (courseUpdate != null)
            {
                courseUpdate.Name = entity.Name;
                courseUpdate.Description = entity.Description;
                courseUpdate.CategoryId = entity.CategoryId;
                courseUpdate.Id = entity.Id;
                courseUpdate.ImageUrl = entity.ImageUrl;
                Console.WriteLine("Course Updated");
            }
        }
    }
}
